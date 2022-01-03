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
using FFmpegArgs.Executes;
using System.Diagnostics;

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
            string outputFileName = $"{nameof(PhotoCollectionCustomTest)}.mp4";
            string filterFileName = $"{nameof(PhotoCollectionCustomTest)}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();

            Config config = new Config();
            int MAX_IMAGE_ANGLE = 25;
            double RPS = 1;//Revolutions per sec
            int WIDTH = config.Size.Width;
            int HEIGHT = config.Size.Height;
            int FPS = config.Fps;
            Color BACKGROUND_COLOR = config.BackgroundColor;
            double TRANSITION_DURATION = config.TransitionDuration.TotalSeconds;

            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count;

            Random random = new Random();


            var background = ffmpegArg.FilterGraph.ColorFilter()
                    .Size(config.Size)
                    .Color(config.BackgroundColor)
                    .Duration(TOTAL_DURATION).MapOut
                .FpsFilter().Fps($"{config.Fps}").MapOut;

            var lastOverLay = background;
            images_inputmap = images_inputmap.InputScreenMode(ScreenMode.Center, config);
            for (int c = 0; c < images_inputmap.Count; c++)
            {
                var start = (config.TransitionDuration + config.ImageDuration) * c;
                var end = start + config.TransitionDuration;
                var ANGLE_RANDOMNESS = random.Next() % MAX_IMAGE_ANGLE + 1;

                lastOverLay = images_inputmap[c]
                    .PadFilter()
                        .W($"{WIDTH * 4}")
                        .H($"{HEIGHT}")
                        .X($"({WIDTH * 4}-iw)/2")
                        .Y($"({HEIGHT}-ih)/2")
                        .Color(BACKGROUND_COLOR).MapOut
                    .TrimFilter().Duration((c + 1) * (config.TransitionDuration + config.ImageDuration)).MapOut
                    .SetPtsFilter("PTS-STARTPTS").MapOut


                    .RotateFilter()
                        .Angle(  $"if(" +
                                        $"between(t,{start.TotalSeconds},{end.TotalSeconds})," +
                                        $"{RPS}*2*PI*(t-{end.TotalSeconds})," +
                                        $"0)" +
                                    $"+if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*2*PI/360")
                        .OW($"{WIDTH * 4}")
                        .FillColor(BACKGROUND_COLOR).MapOut
                    .OverlayFilterOn(lastOverLay)
                        .X($"if(gt(t,{start.TotalSeconds})," +
                                $"if(lt(t,{end.TotalSeconds})," +
                                    $"{WIDTH}*3/2 -w+(t-{start.TotalSeconds})/{TRANSITION_DURATION}*{WIDTH}," +
                                    "(main_w-overlay_w)/2)," +
                                "-w)")
                        .Y("(main_h-overlay_h)/2").MapOut;
            }

            var out_map = lastOverLay.FormatFilter(PixFmt.yuv420p).MapOut;

            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
              .VSync(VSyncMethod.vfr)
              .SetOption("-c:v", "libx264")
              .Fps(config.Fps)
              .SetOption("-g", "0")
              .SetOption("-rc-lookahead", "0");

            ffmpegArg.AddOutput(imageFileOutput);

            ffmpegArg.TestRender(filterFileName, outputFileName);
        }


        [TestMethod]
        public void PhotoCollectionTest()
        {
            string outputFileName = $"{nameof(PhotoCollectionTest)}.mp4";
            string filterFileName = $"{nameof(PhotoCollectionTest)}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();

            Config config = new Config();
            int MAX_IMAGE_ANGLE = 25;
            double RPS = 1.2;
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count;
            
            Random random = new Random();


            var background = ffmpegArg.AddVideoInput(
                new FilterInput($"color={config.BackgroundColor.ToHexStringRGBA()}:s={config.Size.Width}x{config.Size.Height},fps={config.Fps}"),1,0)
                .ImageMaps.First().TrimFilter().Duration(TOTAL_DURATION).MapOut;

            var lastOverLay = background;
            images_inputmap = images_inputmap.InputScreenMode(ScreenMode.Center, config);

            for (int c = 0; c < images_inputmap.Count; c++)
            {
                var ANGLE_RANDOMNESS = random.Next() % MAX_IMAGE_ANGLE + 1;
                var start = (config.TransitionDuration + config.ImageDuration) * c;
                var end = start + config.TransitionDuration;
                lastOverLay = images_inputmap[c]
                    .PadFilter()
                        .W($"{config.Size.Width * 4}")
                        .H($"{config.Size.Height}")
                        .X($"({config.Size.Width * 4}-iw)/2")
                        .Y($"({config.Size.Height}-ih)/2")
                        .Color(config.BackgroundColor).MapOut
                    .TrimFilter()
                        .Duration((c + 1) * (config.TransitionDuration + config.ImageDuration)).MapOut
                    .SetPtsFilter("PTS-STARTPTS").MapOut


                    .RotateFilter()
                        .Angle($"if(" +
                                        $"between(t,{start.TotalSeconds},{end.TotalSeconds})," +
                                        $"{RPS}*2*PI*(t-{end.TotalSeconds})," +
                                        $"0)" +
                                    $"+if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*2*PI/360")
                        .OW($"{config.Size.Width * 4}")
                        .FillColor(config.BackgroundColor).MapOut
                    .OverlayFilterOn(lastOverLay)
                        .X($"if(gt(t,{start.TotalSeconds})," +
                            $"if(lt(t,{end.TotalSeconds})," +
                                $"{config.Size.Width}*3/2 -w+(t-{start.TotalSeconds})/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}," +
                                "(main_w-overlay_w)/2)," +
                            "-w)")
                        .Y("(main_h-overlay_h)/2").MapOut;
            }

            var out_map = lastOverLay.FormatFilter(PixFmt.yuv420p).MapOut;

            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
              .VSync(VSyncMethod.vfr)
              .SetOption("-c:v", "libx264")
              .Fps(config.Fps)
              .SetOption("-g", "0")
              .SetOption("-rc-lookahead", "0");

            ffmpegArg.AddOutput(imageFileOutput);

            ffmpegArg.TestRender(filterFileName, outputFileName);
        }

    }
}
