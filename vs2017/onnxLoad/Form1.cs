using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormStringCnvClass;

namespace onnxLoad
{
    public partial class Form1 : Form
    {
        string thisExeDirPath;
        public Form1()
        {
            InitializeComponent(); thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT|*.txt";
            if (false && ofd.ShowDialog() == DialogResult.OK)
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(ofd.FileName));
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                if (File.Exists(paramFilename))
                {
                    WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TEXT|*.txt";

            if (false && sfd.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(sfd.FileName, FormContents);
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                File.WriteAllText(paramFilename, FormContents);
            }

        }

        OnnxSupport onnxSupport;

        private void button_OpenModel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ONNX|*.onnx";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            textBox_onnxFilePath.Text = ofd.FileName;
            onnxSupport = new OnnxSupport(ofd.FileName);
            textBox_onnxModelReport.Text = string.Join("\r\n", onnxSupport.GetOnnxModelIOInfo());

        }

        private void button_OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG|*.png";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            textBox_openImagePathes.Text = ofd.FileName;



            Bitmap bitmap = new Bitmap(ofd.FileName);


            if (onnxSupport == null) { onnxSupport = new OnnxSupport(textBox_onnxFilePath.Text); };

            onnxSupport.RunModel(bitmap);

            updatePictureBox(pictureBox_src, bitmap);
            updatePictureBox(pictureBox_dst, onnxSupport.AnomalyMapImages[0]);

        }
        void updatePictureBox(PictureBox p,Bitmap b)
        {
            if (p.Image != null) p.Image.Dispose();
            p.Image = b;

        }

    }
}
