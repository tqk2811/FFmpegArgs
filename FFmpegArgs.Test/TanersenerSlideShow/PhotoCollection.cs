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
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count;

            Random random = new Random();


            var background = ffmpegArg.FilterGraph.ColorFilter()
                    .Size(config.Size)
                    .Color(config.BackgroundColor)
                    .Duration(TOTAL_DURATION).MapOut
                .FpsFilter($"{config.Fps}").MapOut;

            var lastOverLay = background;

            for(int c = 0; c < images_inputmap.Count; c++)
            {
                var start = (config.TransitionDuration + config.ImageDuration) * c;
                var end = start + config.TransitionDuration;
                var ANGLE_RANDOMNESS = random.Next() % MAX_IMAGE_ANGLE + 1;

                lastOverLay = images_inputmap[c]
                    .SetPtsFilter("PTS-STARTPTS").MapOut
                    .ScaleFilter($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)", $"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
                    .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                    .SetSarFilter("1/1").MapOut
                    .FpsFilter($"{config.Fps}").MapOut
                    .FormatFilter(PixFmt.rgba).MapOut
                    .PadFilter($"{config.Size.Width * 4}", $"{config.Size.Height}").Position($"({config.Size.Width * 4}-iw)/2", $"({config.Size.Height}-ih)/2").Color(config.BackgroundColor).MapOut
                    .TrimFilter().Duration((c + 1) * (config.TransitionDuration + config.ImageDuration)).MapOut
                    .SetPtsFilter("PTS-STARTPTS").MapOut
                    .RotateFilter($"if(between(t,{start.TotalSeconds},{end.TotalSeconds})," +
                                        $"2*PI*t+if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*PI/180," +
                                        $"if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*PI/180)")
                        .OW($"{config.Size.Width * 4}").FillColor(config.BackgroundColor).MapOut
                    .OverlayFilterOn(lastOverLay,
                        $"if(gt(t,{start.TotalSeconds})," +
                            $"if(lt(t,{end.TotalSeconds})," +
                                $"{config.Size.Width}*3/2 -w+(t-{start.TotalSeconds})/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}," +
                                "(main_w-overlay_w)/2)," +
                            "-w)",
                        "(main_h-overlay_h)/2").MapOut;
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
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count;
            
            Random random = new Random();


            var background = ffmpegArg.AddVideoInput(
                new FilterInput($"color={config.BackgroundColor.ToHexStringRGBA()}:s={config.Size.Width}x{config.Size.Height},fps={config.Fps}"),1,0)
                .ImageMaps.First().TrimFilter().Duration(TOTAL_DURATION).MapOut;

            var lastOverLay = background;

            for(int c = 0; c < images_inputmap.Count; c++)
            {
                var ANGLE_RANDOMNESS = random.Next() % MAX_IMAGE_ANGLE + 1;
                var start = (config.TransitionDuration + config.ImageDuration) * c;
                var end = start + config.TransitionDuration;
                lastOverLay = images_inputmap[c]
                    .SetPtsFilter("PTS-STARTPTS").MapOut
                    .ScaleFilter($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)", $"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
                    .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                    .SetSarFilter("1/1").MapOut
                    .FpsFilter($"{config.Fps}").MapOut
                    .FormatFilter(PixFmt.rgba).MapOut
                    .PadFilter($"{config.Size.Width * 4}", $"{config.Size.Height}").Position($"({config.Size.Width * 4}-iw)/2", $"({config.Size.Height}-ih)/2").Color(config.BackgroundColor).MapOut
                    .TrimFilter().Duration((c + 1) * (config.TransitionDuration + config.ImageDuration)).MapOut
                    .SetPtsFilter("PTS-STARTPTS").MapOut


                    .RotateFilter($"if(between(t,{start.TotalSeconds},{end.TotalSeconds})," +
                                        $"2*PI*t+if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*PI/180," +
                                        $"if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*PI/180)")
                        .OW($"{config.Size.Width * 4}").FillColor(config.BackgroundColor).MapOut
                    .OverlayFilterOn(lastOverLay,
                        $"if(gt(t,{start.TotalSeconds})," +
                            $"if(lt(t,{end.TotalSeconds})," +
                                $"{config.Size.Width}*3/2 -w+(t-{start.TotalSeconds})/{config.TransitionDuration.TotalSeconds}*{config.Size.Width}," +
                                "(main_w-overlay_w)/2)," +
                            "-w)",
                        "(main_h-overlay_h)/2").MapOut;
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
