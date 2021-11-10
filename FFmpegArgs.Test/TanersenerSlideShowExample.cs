using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.MultimediaFilters;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Filters.VideoSources;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace FFmpegArgs.Test
{
    /// <summary>
    /// https://github.com/tanersener/ffmpeg-video-slideshow-scripts
    /// </summary>
    [TestClass]
    public class TanersenerSlideShowExample
    {
        /// <summary>
        /// https://github.com/tanersener/ffmpeg-video-slideshow-scripts/blob/master/advanced_scripts/blurred_background.sh
        /// </summary>
        [TestMethod]
        public void BlurredBackground()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\temp\ffmpeg_encode_test\ImgsTest");
            var files = directoryInfo.GetFiles("*.jpg");

            int IMAGE_COUNT = files.Length;
            int WIDTH = 1366;
            int HEIGHT = 768;
            int FPS = 24;
            double IMAGE_DURATION = 1;
            double TRANSITION_DURATION = 1;

            double TRANSITION_FRAME_COUNT = TRANSITION_DURATION * FPS;
            double IMAGE_FRAME_COUNT = FPS * IMAGE_DURATION;
            double TOTAL_DURATION = (IMAGE_DURATION + TRANSITION_DURATION) * IMAGE_COUNT - TRANSITION_DURATION;
            double TOTAL_FRAME_COUNT = TOTAL_DURATION * FPS;

            FilterGraph filterGraph = new FilterGraph().OverWriteOutput();

            var images_inputmap = files.Select(x => filterGraph.AddImageInput(new ImageFileInput(x.Name).SetOption("-loop", 1))).ToList();

            //PREPARE BLURRED INPUTS
            List<ImageMap> blureds = new List<ImageMap>();
            foreach (var image in images_inputmap)
            {
                blureds.Add(image
                  .ScaleFilter($"{WIDTH}", $"{HEIGHT}").MapOut
                  .SetSarFilter("1/1").MapOut
                  .FormatFilter(FormatPixFmt.rgba).MapOut.BoxBlurFilter().LumaRadius($"{100}").MapOut
                  .SetSarFilter("1/1").MapOut
                  .FpsFilter($"{FPS}").MapOut);
            }

            //PREPARE INPUTS
            List<ImageMap> inputs = new List<ImageMap>();
            foreach (var image in images_inputmap)
            {
                inputs.Add(image
                  .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)", $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
                  .ScaleFilter($"trunc(iw/2)*2", $"trunc(ih/2)*2").MapOut
                  .SetSarFilter("1/1").MapOut
                  .FormatFilter(FormatPixFmt.rgba).MapOut);
            }

            //OVERLAY BLURRED AND SCALED INPUTS
            List<IEnumerable<ImageMap>> overlays = new List<IEnumerable<ImageMap>>();
            for (int i = 0; i < blureds.Count; i++)
            {
                overlays.Add(inputs[i]
                  .OverlayFilterOn(blureds[i], "(main_w - overlay_w)/2", "(main_h-overlay_h)/2").MapOut
                  .FormatFilter(FormatPixFmt.rgba).MapOut
                  .SetPtsFilter("PTS-STARTPTS").MapOut
                  .SplitFilter(2).MapsOut);
            }

            //APPLY PADDING
            List<ImageMap> overlaids = new List<ImageMap>();
            for (int i = 0; i < overlays.Count; i++)
            {
                overlaids.Add(overlays[i].First()
                  .PadFilter($"{WIDTH}", $"{HEIGHT}").Position($"({WIDTH} - iw)/2", $"({HEIGHT} - ih)/2").MapOut
                  .TrimFilter().Duration(TimeSpan.FromSeconds(IMAGE_DURATION)).MapOut
                  .SelectFilter($"lte(n,{IMAGE_FRAME_COUNT})").MapOut);
            }

            List<ImageMap> startings = new List<ImageMap>();
            List<ImageMap> endings = new List<ImageMap>();
            for (int i = 0; i < overlays.Count; i++)
            {
                //first create ed only (if only 1 image -> create ed)
                //mid: split to ed and op
                //last create op

                var res = overlays[i].Last()
                  .PadFilter($"{WIDTH}", $"{HEIGHT}").Position($"({WIDTH}-iw)/2", $"({HEIGHT}-ih)/2").MapOut
                  .TrimFilter().Duration(TimeSpan.FromSeconds(TRANSITION_DURATION)).MapOut
                  .SelectFilter($"lte(n,{TRANSITION_FRAME_COUNT})").MapOut;

                if (i == 0)//first
                {
                    if (overlays.Count > 1)
                    {
                        endings.Add(res);
                    }
                }
                else if (i == overlays.Count - 1)//last
                {
                    startings.Add(res);
                }
                else//mid
                {
                    var splits = res.SplitFilter(2).MapsOut;
                    startings.Add(splits.First());
                    endings.Add(splits.Last());
                }
            }


            //CREATE TRANSITION FRAMES
            List<ImageMap> blendeds = new List<ImageMap>();

            for (int i = 0; i < startings.Count; i++)
            {
                blendeds.Add(startings[i]
                  .BlendFilterOn(endings[i]).All_Expr(
                    $"A*(if( gte(T,{TRANSITION_DURATION}),{TRANSITION_DURATION},T/{TRANSITION_DURATION})) + " +
                    $"B*(1-(if(gte(T,{TRANSITION_DURATION}),{TRANSITION_DURATION},T/{TRANSITION_DURATION})))").MapOut
                  .SelectFilter($"lte(n,{TRANSITION_FRAME_COUNT})").MapOut);
            }

            //CONCAT
            List<ConcatGroup> concatGroups = new List<ConcatGroup>();
            for (int i = 0; i < overlaids.Count; i++)
            {
                concatGroups.Add(new ConcatGroup(overlaids[i]));
                if (i < overlaids.Count - 1) concatGroups.Add(new ConcatGroup(blendeds[i]));
            }
            ConcatFilter concatFilter = new ConcatFilter(concatGroups);
            var out_map = concatFilter.ImageMapsOut.First()
              .FormatFilter(FormatPixFmt.yuv420p).MapOut;

            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(@"out.mp4", out_map);
            imageFileOutput
              .VSync(2)
              .SetOption("-c:v", "libx264")
              .FrameRate(FPS)
              .SetOption("-g", "0")
              .SetOption("-rc-lookahead", "0");

            filterGraph.AddOutput(imageFileOutput);

            string filter = filterGraph.GetFiltersArgs(true);
            string args = filterGraph.GetFullCommandlineWithFilterScript("filter_script.txt");
            int len = args.Length;
        }


        /// <summary>
        /// https://github.com/tanersener/ffmpeg-video-slideshow-scripts/blob/master/advanced_scripts/photo_collection.sh
        /// </summary>
        [TestMethod]
        public void PhotoCollection()
        {
            int WIDTH = 1280;
            int HEIGHT = 720;
            int FPS = 24;
            int TRANSITION_DURATION = 1;
            int IMAGE_DURATION = 2;
            int MAX_IMAGE_ANGLE = 25;
            Color BACKGROUND_COLOR = Color.FromArgb(0,0,0,0);

            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\temp\ffmpeg_encode_test\ImgsTest");
            var files = directoryInfo.GetFiles("*.jpg");

            int IMAGE_COUNT = files.Length;
            int TRANSITION_FRAME_COUNT = TRANSITION_DURATION * FPS;
            int IMAGE_FRAME_COUNT = IMAGE_DURATION * FPS;
            int TOTAL_DURATION = (IMAGE_DURATION + TRANSITION_DURATION) * IMAGE_COUNT - TRANSITION_DURATION;

            Random random = new Random();

            FilterGraph filterGraph = new FilterGraph().OverWriteOutput();
            var images_inputmap = files.Select(x => filterGraph.AddImageInput(new ImageFileInput(x.Name).SetOption("-loop", 1))).ToList();
            var background = filterGraph.Color()
                    .Size(new Size(WIDTH, HEIGHT))
                    .Color(BACKGROUND_COLOR)
                    .Duration(TimeSpan.FromSeconds(TOTAL_DURATION)).MapOut
                .FpsFilter($"{FPS}").MapOut;

            var lastOverLay = background;

            images_inputmap.ForEach(x => 
            {
                var c = images_inputmap.IndexOf(x);
                var start = (TRANSITION_DURATION + IMAGE_DURATION) * c;
                var end = start + TRANSITION_DURATION;
                var ANGLE_RANDOMNESS = random.Next() % MAX_IMAGE_ANGLE + 1;

                lastOverLay = x
                    .SetPtsFilter("PTS-STARTPTS").MapOut
                    .ScaleFilter($"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)", $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
                    .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                    .SetSarFilter("1/1").MapOut
                    .FpsFilter($"{FPS}").MapOut
                    .FormatFilter(FormatPixFmt.rgba).MapOut
                    .PadFilter($"{WIDTH * 4}", $"{HEIGHT}").Position($"({WIDTH * 4}-iw)/2", $"({HEIGHT}-ih)/2").Color(BACKGROUND_COLOR).MapOut
                    .TrimFilter().Duration(TimeSpan.FromSeconds((c + 1) * (TRANSITION_DURATION + IMAGE_DURATION))).MapOut
                    .SetPtsFilter("PTS-STARTPTS").MapOut
                    .RotateFilter($"if(between(t,{start},{end}),"+
                                        $"2*PI*t+if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*PI/180,"+
                                        $"if(eq(mod({c},2),0),1,-1)*{ANGLE_RANDOMNESS}*PI/180)")
                        .OW($"{WIDTH*4}").FillColor(BACKGROUND_COLOR).MapOut
                    .OverlayFilterOn(lastOverLay,
                        $"if(gt(t,{start})," +
                            $"if(lt(t,{end})," +
                                $"{(double)WIDTH * 3 / 2}-w+(t-{start})/{TRANSITION_DURATION}*{WIDTH}," +
                                "(main_w-overlay_w)/2)," +
                            "-w)",
                        "(main_h-overlay_h)/2").MapOut;
            });

            var output = lastOverLay.FormatFilter(FormatPixFmt.yuv420p).MapOut;

            var videoOut = new ImageFileOutput("PhotoCollection.mp4", output);
            videoOut.VSync(2).SetOption("-rc-lookahead",0).SetOption("-g",0).SetOption("-c:v","libx264").FrameRate(FPS);

            filterGraph.AddOutput(videoOut);

            string filter = filterGraph.GetFiltersArgs(true);
            string args = filterGraph.GetFullCommandlineWithFilterScript("filter_script.txt");
            int len = args.Length;
        }
    }
}
