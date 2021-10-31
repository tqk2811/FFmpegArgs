using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using FFmpegArgs.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FFmpegArgs.Test
{
  [TestClass]
  public class TemplatesTest
  {
    [TestMethod]
    public void BlurredBackground()
    {
      FilterGraph filterGraph = new FilterGraph();
      filterGraph.OverWriteOutput();

      var video = new ImageFileInput(@"D:\temp\ffmpeg_encode_test\loop.mp4");
      var video_map = filterGraph.AddImageInput(video);
      var blurred = video_map.CropFilter("iw/2-iw/4", "0", "iw/2", "ih").MapOut
        .MakeBlurredBackgroundTemplate("iw*2", "ih");

      var output = new ImageFileOutput("BlurredBackground.mp4", blurred);
      filterGraph.AddOutput(output);

      string args = filterGraph.GetFullCommandline();
    }
  }
}
