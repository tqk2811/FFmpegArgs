using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Test.FeatureTest
{
    [TestClass]
    public class PipeTest
    {
        [TestMethod]
        public void TestStdInOut()
        {
            using FileStream input = new FileStream(".\\Resources\\img0.jpg", FileMode.Open, FileAccess.Read, FileShare.Read);
            using FileStream output = new FileStream("img0_out.jpg", FileMode.Create, FileAccess.Write, FileShare.Read);
            FFmpegArg ffmpegArg = new FFmpegArg();
            var imageMap = ffmpegArg.AddImagesInput(new ImagePipeInput(input, DemuxingFileFormat.mjpeg, 1)).First();
            imageMap = imageMap.ScaleFilter().W("iw/2").H("ih/2").MapOut;
            ffmpegArg.AddOutput(new ImagePipeOutput(output, MuxingFileFormat.mjpeg, imageMap));
            var result = ffmpegArg.Render().Execute();
            Assert.AreEqual(0, result.ExitCode);
        }
    }
}
