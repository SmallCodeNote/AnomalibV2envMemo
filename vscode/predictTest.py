from anomalib.models import Patchcore
from anomalib.engine import Engine
from anomalib.data.utils import TestSplitMode, ValSplitMode
from anomalib.data import Folder
import anomalib
from torchvision.transforms.v2 import Compose, CenterCrop

if __name__ == "__main__":
    transform_size = 224
    datamodule = Folder(
      name="Stlipe",
      root=R"R:",
      normal_dir=R"train1\good",
      abnormal_dir=R"train1\ng",
      mask_dir=R"train1\mask",
      test_split_mode=TestSplitMode.SYNTHETIC,
      val_split_mode=ValSplitMode.SYNTHETIC,
      val_split_ratio=0.5,
      train_augmentations=Compose(
        [
            CenterCrop( transform_size ),
       ],
      )
    )
    datamodule.setup()
    model = Patchcore()
    engine = Engine(default_root_dir=R"R:\train1")
    engine.fit(datamodule=datamodule, model=model)
    predictions = engine.predict(
        data_path=R"R:\test\ng",
        model=model,
    )
    engine.export(model=model,export_type="onnx",export_root=R"R:\train1",model_file_name=R"model1")
