using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;

public class OnnxSupport : IDisposable
{
    public InferenceSession Session { get; private set; }

    public List<float> pred_score = new List<float>();
    public List<bool> pred_label = new List<bool>();
    public List<float[,]> anomaly_map = null;
    public List<bool[,]> pred_mask = null;
    private bool disposed = false;

    public OnnxSupport(string onnxFilename)
    {
        var options = new SessionOptions();
        //options.AppendExecutionProvider_DML();
        options.AppendExecutionProvider_CPU();
        Session = new InferenceSession(onnxFilename, options);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;

        if (disposing)
        {
            Session?.Dispose();
        }
        disposed = true;
    }

    ~OnnxSupport()
    {
        Dispose(false);
    }

    public List<string> GetOnnxModelIOInfo()
    {
        var ioInfoList = new List<string>();
        foreach (var input in Session.InputMetadata)
        {
            string info = $"Input: {input.Key}, Type: {input.Value.ElementType}, Dimensions: [{string.Join(",", input.Value.Dimensions)}]";
            ioInfoList.Add(info);
        }

        foreach (var output in Session.OutputMetadata)
        {
            string info = $"Output: {output.Key}, Type: {output.Value.ElementType}, Dimensions: [{string.Join(",", output.Value.Dimensions)}]";
            ioInfoList.Add(info);
        }

        return ioInfoList;
    }

    public void RunModel(Bitmap image)
    {
        pred_score.Clear();
        pred_label.Clear();
        anomaly_map = null;
        pred_mask = null;

        var resized = new Bitmap(image, new Size(224, 224));
        var tensor = ImageToCHWTensor(resized);

        var inputs = new List<NamedOnnxValue>
        {
            NamedOnnxValue.CreateFromTensor("input", tensor)
        };

        using (var results = Session.Run(inputs))
        {
            foreach (var result in results)
            {
                switch (result.Name)
                {
                    case "pred_score":
                        var scoreTensor = result.AsTensor<float>();
                        pred_score.AddRange(scoreTensor.ToArray());
                        break;

                    case "pred_label":
                        var labelTensor = result.AsTensor<bool>();
                        pred_label.AddRange(labelTensor.ToArray());
                        break;

                    case "anomaly_map":
                        anomaly_map = ConvertToArrayList(result.AsTensor<float>());
                        break;

                    case "pred_mask":
                        pred_mask = ConvertToBoolArrayList(result.AsTensor<bool>());
                        break;
                }
            }
        }
    }

    public Bitmap GetMap(float[,] array, float min = float.NaN, float max = float.NaN)
    {
        int width = array.GetLength(1);
        int height = array.GetLength(0);

        if (float.IsNaN(min) || float.IsNaN(max))
        {
            min = array.Cast<float>().Min();
            max = array.Cast<float>().Max();
        }

        Bitmap bitmap = new Bitmap(width, height);
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                float value = array[y, x];
                float norm = (value - min) / (max - min);

                int r = (int)(norm * 255);
                int g = (int)((1 - Math.Abs(norm - 0.5) * 2) * 255);
                int b = (int)((1 - norm) * 255);

                bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
            }
        }

        return bitmap;
    }

    public List<Bitmap> AnomalyMapImages
    {
        get
        {
            List<Bitmap> bitmaps = new List<Bitmap>();

            foreach (var map in anomaly_map)
            {
                bitmaps.Add(GetMap(map));
            }
            return bitmaps;
        }
    }


    private DenseTensor<float> ImageToCHWTensor(Bitmap bmp)
    {
        int width = bmp.Width;
        int height = bmp.Height;
        var tensor = new DenseTensor<float>(new[] { 1, 3, height, width });

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Color pixel = bmp.GetPixel(x, y);
                tensor[0, 0, y, x] = pixel.R / 255f;
                tensor[0, 1, y, x] = pixel.G / 255f;
                tensor[0, 2, y, x] = pixel.B / 255f;
            }
        }

        return tensor;
    }

    public List<float[,]> ConvertToArrayList(Tensor<float> tensor)
    {
        var shape = tensor.Dimensions;
        var result = new List<float[,]>();

        int batch = shape[0];
        int channel = shape[1];
        int height = shape[2];
        int width = shape[3];

        for (int b = 0; b < batch; b++)
        {
            var map = new float[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    map[i, j] = tensor[b, 0, i, j];
                }
            }
            result.Add(map);
        }

        return result;
    }


    public List<bool[,]> ConvertToBoolArrayList(Tensor<bool> tensor)
    {
        var shape = tensor.Dimensions;
        var result = new List<bool[,]>();

        int batch = shape[0];
        int channel = shape[1];
        int height = shape[2];
        int width = shape[3];

        for (int b = 0; b < batch; b++)
        {
            var mask = new bool[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    mask[i, j] = tensor[b, 0, i, j];
                }
            }
            result.Add(mask);
        }

        return result;
    }

}
