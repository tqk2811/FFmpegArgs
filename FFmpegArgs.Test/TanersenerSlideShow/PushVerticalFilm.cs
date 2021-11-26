using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.MultimediaFilters;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Filters.VideoSources;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using FFmpegArgs.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class PushVerticalFilm
    {
        [TestMethod]
        public void PushVerticalFilmTest()
        {
            int WIDTH = 1280;
            int HEIGHT = 720;
            double FPS = 60;
            double TRANSITION_DURATION = 3;
            ScreenMode screenMode = ScreenMode.Blur;
            Color BACKGROUND_COLOR = Color.FromArgb(0, 0, 0, 0);
            VerticalDirection direction = VerticalDirection.BottomToTop;

            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\temp\ffmpeg_encode_test\ImgsTest");
            var files = directoryInfo.GetFiles("*.jpg");
            int IMAGE_COUNT = files.Length;

            double TRANSITION_FRAME_COUNT = TRANSITION_DURATION * FPS;
            double TOTAL_DURATION = TRANSITION_DURATION * (IMAGE_COUNT + 1);
            double TOTAL_FRAME_COUNT = TOTAL_DURATION * FPS;

            FilterGraph filterGraph = new FilterGraph().OverWriteOutput();
            var images_inputmap = files.Select(x => filterGraph.AddImageInput(new ImageFileInput(x.Name).SetOption("-loop", 1))).ToList();

            var film_strip_map = filterGraph.AddImageInput(new ImageFileInput("film_strip_vertical.png").SetOption("-loop", 1));

            var background = filterGraph
               .Color()
                   .Color(BACKGROUND_COLOR)
                   .Size(new Size(WIDTH, HEIGHT))
                   .Duration(TimeSpan.FromSeconds(TOTAL_DURATION)).MapOut
               .FpsFilter($"{FPS}").MapOut;

            List<ImageMap> images_Prepare = new List<ImageMap>();
            for (int i = 0; i < files.Length; i++)
            {
                switch (screenMode)
                {
                    case ScreenMode.Center:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)",
                                                $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
                                .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                                .PadFilter($"{WIDTH}", $"{HEIGHT}")
                                    .Position($"({WIDTH}-iw)/2", $"({HEIGHT}-ih)/2")
                                    .Color(BACKGROUND_COLOR).MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }

                    case ScreenMode.Crop:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,{WIDTH})",
                                                $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),{HEIGHT},-1)").MapOut
                                .OverlayFilterOn(film_strip_map, "0", "0").MapOut
                                .CropFilter().WH($"{WIDTH}", $"{HEIGHT}").MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }

                    case ScreenMode.Scale:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .ScaleFilter($"{WIDTH}", $"{HEIGHT}").MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }

                    case ScreenMode.Blur:
                        {
                            images_Prepare.Add(images_inputmap[i]
                                .MakeBlurredBackgroundTemplate(WIDTH, HEIGHT, "100")
                                .FormatFilter(PixFmt.rgba).MapOut
                                .SetSarFilter("1/1").MapOut);
                            break;
                        }
                }
            }


            var strip_images = film_strip_map
                .SetPtsFilter("PTS-STARTPTS").MapOut
                .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)",
                                $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
                .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                .SetSarFilter("1/1").MapOut
                .SplitFilter(IMAGE_COUNT).MapsOut.ToList();

            // OVERLAY FILM STRIP ON TOP OF INPUTS

            List<ImageMap> image_overlay_on_strips = new List<ImageMap>();
            for (int i = 0; i < images_Prepare.Count; i++)
            {
                image_overlay_on_strips.Add(strip_images[i]
                    .OverlayFilterOn(images_Prepare[i], "(main_w-overlay_w)/2", "(main_h-overlay_h)/2").Format(OverlayPixFmt.rgb).MapOut);
            }

            var lastOverLay = background;
            for (int i = 0; i < images_Prepare.Count; i++)
            {
                var start = i * TRANSITION_DURATION;
                var end = start + TRANSITION_DURATION * 2;
                switch (direction)
                {
                    case VerticalDirection.TopToBottom:
                        {
                            lastOverLay = image_overlay_on_strips[i].SetPtsFilter("PTS-STARTPTS").MapOut
                               .OverlayFilterOn(lastOverLay, "0", $"-{HEIGHT}+(t-{start})/{TRANSITION_DURATION}*{HEIGHT}")//from -HEIGHT to +HEIGHT
                                   .Enable($"between(t,{start},{end})").MapOut;
                            break;
                        }

                    case VerticalDirection.BottomToTop:
                        {
                            lastOverLay = image_overlay_on_strips[i].SetPtsFilter("PTS-STARTPTS").MapOut
                                .OverlayFilterOn(lastOverLay, "0", $"{HEIGHT}-(t-{start})/{TRANSITION_DURATION}*{HEIGHT}")//from +HEIGHT to -HEIGHT
                                    .Enable($"between(t,{start},{end})").MapOut;
                            break;
                        }
                }
            }

            var output = lastOverLay
                .TrimFilter().Duration(TimeSpan.FromSeconds(TOTAL_DURATION)).MapOut
                .FpsFilter($"{FPS}").MapOut
                .FormatFilter(PixFmt.yuv420p).MapOut;

            var videoOut = new ImageFileOutput($"PushVerticalFilm-{screenMode}-{direction}.mp4", output)
                .VSync(VSyncMethod.vfr)
                .SetOption("-rc-lookahead", 0)
                .SetOption("-g", 0)
                .VCodec("libx264")
                //.SetOption("-b:v", "3000")
                .Fps((int)FPS);

            filterGraph.AddOutput(videoOut);

            string filter = filterGraph.GetFiltersArgs(true);
            string args = filterGraph.GetFullCommandlineWithFilterScript("filter_script.txt");
        }
    }
}
