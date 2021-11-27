using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.MultimediaFilters;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Filters.VideoSources;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using FFmpegArgs.Filters;
using FFmpegArgs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class PhotoCollection
    {
        /// <summary>
        /// https://github.com/tanersener/ffmpeg-video-slideshow-scripts/blob/master/advanced_scripts/photo_collection.sh
        /// </summary>
        [TestMethod]
        public void PhotoCollectionCustomTest()
        {
            int WIDTH = 1280;
            int HEIGHT = 720;
            int FPS = 24;
            int TRANSITION_DURATION = 1;
            int IMAGE_DURATION = 2;
            int MAX_IMAGE_ANGLE = 25;
            Color BACKGROUND_COLOR = Color.FromArgb(0, 0, 0, 0);

            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\temp\ffmpeg_encode_test\ImgsTest");
            var files = directoryInfo.GetFiles("*.jpg");

            int IMAGE_COUNT = files.Length;
            int TRANSITION_FRAME_COUNT = TRANSITION_DURATION * FPS;
            int IMAGE_FRAME_COUNT = IMAGE_DURATION * FPS;
            int TOTAL_DURATION = (IMAGE_DURATION + TRANSITION_DURATION) * IMAGE_COUNT - TRANSITION_DURATION;

            Random random = new Random();

            FilterGraph filterGraph = new FilterGraph().OverWriteOutput();
            var images_inputmap = files.Select(x => filterGraph.AddImageInput(new ImageFileInput(x.Name).SetOption("-loop", 1))).ToList();
            var background = filterGraph.ColorFilter()
                    .Size(new Size(WIDTH, HEIGHT))
                    .Color(BACKGROUND_COLOR)
                    .Duration(TimeSpan.FromSeconds(TOTAL_DURATION)).MapOut
                .FpsFilter($"{FPS}").MapOut;

            var lastOverLay = background;

            for(int c = 0; c < images_inputmap.Count; c++)
            {
                var start = (TRANSITION_DURATION + IMAGE_DURATION) * c;
                var end = start + TRANSITION_DURATION;
                var ANGLE_RANDOMNESS = random.Next() % MAX_IMAGE_ANGLE + 1;

                lastOverLay = images_inputmap[c]
                    .SetPtsFilter("PTS-STARTPTS").MapOut
                    .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)", $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
                    .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                    .SetSarFilter("1/1").MapOut
                    .FpsFilter($"{FPS}").MapOut
                    .FormatFilter(PixFmt.rgba).MapOut
                    .PadFilter($"{WIDTH * 4}", $"{HEIGHT}").Position($"({WIDTH * 4}-iw)/2", $"({HEIGHT}-ih)/2").Color(BACKGROUND_COLOR).MapOut
                    .TrimFilter().Duration(TimeSpan.FromSeconds((c + 1) * (TRANSITION_DURATION + IMAGE_DURATION))).MapOut
                    .SetPtsFilter("PTS-STARTPTS").MapOut
                    .RotateFilter($"if(between(t,{start},{end})," +
                                        $"2*PI*t+if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*PI/180," +
                                        $"if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*PI/180)")
                        .OW($"{WIDTH * 4}").FillColor(BACKGROUND_COLOR).MapOut
                    .OverlayFilterOn(lastOverLay,
                        $"if(gt(t,{start})," +
                            $"if(lt(t,{end})," +
                                $"{(double)WIDTH * 3 / 2}-w+(t-{start})/{TRANSITION_DURATION}*{WIDTH}," +
                                "(main_w-overlay_w)/2)," +
                            "-w)",
                        "(main_h-overlay_h)/2").MapOut;
            }

            var output = lastOverLay.FormatFilter(PixFmt.yuv420p).MapOut;

            var videoOut = new ImageFileOutput("PhotoCollection.mp4", output);
            videoOut.VSync(VSyncMethod.vfr).SetOption("-rc-lookahead", 0).SetOption("-g", 0).SetOption("-c:v", "libx264").Fps(FPS);

            filterGraph.AddOutput(videoOut);

            //string full_args = filterGraph.GetFullCommandline();
            //int len = full_args.Length;
            string filter = filterGraph.GetFiltersArgs(true);
            string args = filterGraph.GetFullCommandlineWithFilterScript("filter_script.txt");
            
        }


        [TestMethod]
        public void PhotoCollectionTest()
        {
            int WIDTH = 1280;
            int HEIGHT = 720;
            int FPS = 24;
            int TRANSITION_DURATION = 1;
            int IMAGE_DURATION = 2;
            int MAX_IMAGE_ANGLE = 25;
            Color BACKGROUND_COLOR = Color.FromArgb(0, 0, 0, 0);

            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\temp\ffmpeg_encode_test\ImgsTest");
            var files = directoryInfo.GetFiles("*.jpg");

            int IMAGE_COUNT = files.Length;
            int TRANSITION_FRAME_COUNT = TRANSITION_DURATION * FPS;
            int IMAGE_FRAME_COUNT = IMAGE_DURATION * FPS;
            int TOTAL_DURATION = (IMAGE_DURATION + TRANSITION_DURATION) * IMAGE_COUNT - TRANSITION_DURATION;

            Random random = new Random();

            FilterGraph filterGraph = new FilterGraph().OverWriteOutput();

            var images_inputmap = files.Select(x => filterGraph.AddImageInput(new ImageFileInput(x.Name).SetOption("-loop", 1))).ToList();

            var background = filterGraph.AddImageInput(
                new ImageFilterInput($"color={BACKGROUND_COLOR.ToHexStringRGBA()}:s={WIDTH}x{HEIGHT},fps={FPS}"))
                .TrimFilter().Duration(TimeSpan.FromSeconds(TOTAL_DURATION)).MapOut;

            var lastOverLay = background;

            for(int c = 0; c < images_inputmap.Count; c++)
            {
                var ANGLE_RANDOMNESS = random.Next() % MAX_IMAGE_ANGLE + 1;
                lastOverLay = images_inputmap[c]
                    .SetPtsFilter("PTS-STARTPTS").MapOut
                    .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)", $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
                    .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                    .SetSarFilter("1/1").MapOut
                    .FpsFilter($"{FPS}").MapOut
                    .FormatFilter(PixFmt.rgba).MapOut
                    .PadFilter($"{WIDTH * 4}", $"{HEIGHT}").Position($"({WIDTH * 4}-iw)/2", $"({HEIGHT}-ih)/2").Color(BACKGROUND_COLOR).MapOut
                    .TrimFilter().Duration(TimeSpan.FromSeconds((c + 1) * (TRANSITION_DURATION + IMAGE_DURATION))).MapOut
                    .SetPtsFilter("PTS-STARTPTS").MapOut


                    .RotateFilter($"if(between(t,{(TRANSITION_DURATION +IMAGE_DURATION)*c},{(TRANSITION_DURATION+IMAGE_DURATION)*c+TRANSITION_DURATION})," +
                                        $"2*PI*t+if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*PI/180," +
                                        $"if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*PI/180)")
                        .OW($"{WIDTH * 4}").FillColor(BACKGROUND_COLOR).MapOut
                    .OverlayFilterOn(lastOverLay,
                        $"if(gt(t,{(TRANSITION_DURATION+IMAGE_DURATION)*c})," +
                            $"if(lt(t,{(TRANSITION_DURATION+IMAGE_DURATION)*c+TRANSITION_DURATION })," +
                                $"{(double)WIDTH * 3 / 2}-w+(t-{c*(TRANSITION_DURATION+IMAGE_DURATION)})/{TRANSITION_DURATION}*{WIDTH}," +
                                "(main_w-overlay_w)/2)," +
                            "-w)",
                        "(main_h-overlay_h)/2").MapOut;
            }

            var output = lastOverLay.FormatFilter(PixFmt.yuv420p).MapOut;

            var videoOut = new ImageFileOutput("PhotoCollection.mp4", output);
            videoOut.VSync(VSyncMethod.vfr).SetOption("-rc-lookahead", 0).SetOption("-g", 0).SetOption("-c:v", "libx264").Fps(FPS);

            filterGraph.AddOutput(videoOut);

            //string full_args = filterGraph.GetFullCommandline();
            //int len = full_args.Length;
            string filter = filterGraph.GetFiltersArgs(true);
            string args = filterGraph.GetFullCommandlineWithFilterScript("filter_script.txt");

        }

    }
}
