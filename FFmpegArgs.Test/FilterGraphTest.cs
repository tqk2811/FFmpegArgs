using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Filters.VideoSources;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Linq;

namespace FFmpegArgs.Test
{
    [TestClass]
    public class FilterGraphTest
    {
        [TestMethod]
        public void Test1()
        {
            FilterGraph filterGraph = new FilterGraph();
            filterGraph.OverWriteOutput();

            var video_filter_green = filterGraph.AddVideoInput(new VideoFileInput(@"D:\temp\ffmpeg_encode_test\chromakey.mp4"));
            var video_filter_base = filterGraph.AddVideoInput(new VideoFileInput(@"D:\temp\ffmpeg_encode_test\in_out_tro.mp4"));

            var video_filter_green_colorKey = video_filter_green.ImageMaps.First().ColorKeyFilter(Color.FromArgb(101, 220, 8)).Similarity(0.25f);
            video_filter_green_colorKey.Enable("between(t,0,10)");

            var video_green_scale = video_filter_green_colorKey.MapOut.ScaleFilter("iw/3", "ih/3");

            var overlay = video_green_scale.MapOut.OverlayFilterOn(video_filter_base.ImageMaps.First(), "0", "0");

            var videoOutput = new VideoFileOutput(@"D:\temp\ffmpeg_encode_test\out.mp4", overlay.MapOut, video_filter_base.AudioMaps.First());
            filterGraph.AddOutput(videoOutput);

            var args = filterGraph.GetFullCommandline();
        }

        [TestMethod]
        public void Test2()
        {
            //var files = Directory.GetFiles(@"D:\temp\ffmpeg_encode_test\ImgsTest\*.jpg");
            int out_w = 1366;
            int out_h = 768;
            //total time per image = 3 sec
            double imageDuration = 2;
            double animationDuration = 1;
            double rotateSpeed = 2;//2 * 2PI radian/sec

            FilterGraph filterGraph = new FilterGraph();
            filterGraph.OverWriteOutput();

            var background = filterGraph.Color()
              .Color(Color.FromArgb(00, 100, 00))
              .Size(new Size(out_w, out_h));

            var images = ImageFilesConcatInput.FromFilesSearch(@"D:\temp\ffmpeg_encode_test\ImgsTest\img%d.jpg");
            images.SetOption("-r", 1 / (imageDuration + animationDuration));
            var images_map = filterGraph.AddImageInput(images);
            var pad = images_map.PadFilter("ceil(iw/2)*2", "ceil(ih/2)*2");//fix image size not % 2 = 0
            var format = pad.MapOut.FormatFilter(PixFmt.rgba);
            var scale = format.MapOut.ScaleFilter($"if(gte(iw/ih,{out_w}/{out_h}),min(iw,{out_w}),-1)", $"if(gte(iw/ih,{out_w}/{out_h}),-1,min(ih,{out_h}))");

            //rotate {animationDuration} sec and stop rotate {imageDuration} sec
            string _whenRotate = $"between(t,n*({imageDuration} + {animationDuration}),n *({imageDuration} + {animationDuration})+{animationDuration})";
            string _rotate = $"2*PI*t*{rotateSpeed}";
            string _nonRotate = $"2*PI*{rotateSpeed}*(n+{animationDuration})";
            var rotate = scale.MapOut.RotateFilter($"if({_whenRotate},{_rotate},{_nonRotate})");


            string _whenMove = $"between(t,n*({imageDuration} + {animationDuration}),n *({imageDuration} + {animationDuration})+{animationDuration})";
            string _move = $"-main_w/2 + main_w * (t - n*({imageDuration} + {animationDuration}))/({imageDuration} + {animationDuration})";
            string _stopMove = $"main_w/2";
            var overlay = rotate.MapOut.OverlayFilterOn(background.MapOut, $"if({_whenMove},{_move},{_stopMove})", $"main_h/2");
            overlay.EofAction(EofAction.EndAll);
            var videout = new ImageFileOutput(@"D:\temp\ffmpeg_encode_test\ImgsTest\test.mp4", overlay.MapOut);
            videout.FrameRate(24);
            filterGraph.AddOutput(videout);

            var args = filterGraph.GetFullCommandline();


        }

    }
}
