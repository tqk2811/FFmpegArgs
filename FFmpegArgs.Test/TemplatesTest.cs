using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using FFmpegArgs.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

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
              .MakeBlurredBackgroundTemplate(1366, 768);

            var output = new ImageFileOutput("BlurredBackground.mp4", blurred);
            filterGraph.AddOutput(output);

            string args = filterGraph.GetFullCommandline();
        }

        [TestMethod]
        public void FadeInTwoTemplate()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\temp\ffmpeg_encode_test\ImgsTest");
            var files = directoryInfo.GetFiles("*.jpg");

            FilterGraph filterGraph = new FilterGraph();
            filterGraph.OverWriteOutput();

            var images_inputmap = files.Select(x => filterGraph.AddImageInput(new ImageFileInput(x.Name).SetOption("-loop", 1))).ToList();
            var fix_sizesInputmap = images_inputmap.Select(x => x.ScaleFilter($"trunc(iw/2)*2", $"trunc(ih/2)*2").MapOut).ToList();
            var fadeMap = fix_sizesInputmap.MakeFadeInTwoTemplate("1366", "768", 3, 1);
            var output = new ImageFileOutput("FadeInTwoTemplate.mp4", fadeMap);
            filterGraph.AddOutput(output);

            string filter = filterGraph.GetFiltersArgs(true);
            string args = filterGraph.GetFullCommandlineWithFilterScript("filter_script.txt");
            //string args = filterGraph.GetFullCommandline();
        }

        [TestMethod]
        public void BlurredBackground_of_FadeInTwoTemplate()
        {
            FilterGraph filterGraph = new FilterGraph();
            filterGraph.OverWriteOutput();

            var video = new ImageFileInput(@"FadeInTwoTemplate.mp4");
            var video_map = filterGraph.AddImageInput(video);
            var blurred = video_map//.CropFilter("iw/2-iw/4", "0", "iw/2", "ih").MapOut
              .MakeBlurredBackgroundTemplate(1366,768);

            var output = new ImageFileOutput("BlurredBackground_of_FadeInTwoTemplate.mp4", blurred);
            filterGraph.AddOutput(output);

            string args = filterGraph.GetFullCommandline();
        }
    }
}
