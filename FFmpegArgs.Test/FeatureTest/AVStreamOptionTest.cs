using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Test.FeatureTest
{
    [TestClass]
    public class AVStreamOptionTest
    {
        [TestMethod]
        public void Test1()
        {
            string fileName = $"AVStreamOptionTest_{nameof(Test1)}.mp4";
            string filterName = $"AVStreamOptionTest_{nameof(Test1)}_fs.txt";
            
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();

            var videoMap = ffmpegArg.AddVideoInput(new VideoFileInput("Resources\\2.mp4"));
            
            var imageMap = videoMap.ImageMaps.First().ScaleFilter().W("iw/2").H("ih/2").MapOut;


            List<ImageMap> imageMaps = new List<ImageMap>()
            {
                imageMap,
                videoMap.ImageMaps.First()
            }; 
            List<AudioMap> audioMaps = new List<AudioMap>()
            {
                videoMap.AudioMaps.First(),
                videoMap.AudioMaps.First()
            };

            ffmpegArg.AddOutput(
                new VideoFileOutput(fileName, imageMaps, audioMaps)
                .AndSet(x => x.AudioOutputAVStreams.First().B(64000).Codec("aac"))
                .AndSet(x => x.AudioOutputAVStreams.Last().B(256000).Codec("libmp3lame"))
                .AndSet(x => x.ImageOutputAVStreams.First().B(3000000).Codec("libx264"))
                .AndSet(x => x.ImageOutputAVStreams.Last().B(1000000).Codec("libx265")));

            ffmpegArg.TestRender(filterName, fileName);
            //ffprobe -print_format json -show_format -show_streams AVStreamOptionTest_Test1.mp4
        }
    }
}
