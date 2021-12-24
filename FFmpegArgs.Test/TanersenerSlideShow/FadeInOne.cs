using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Executes;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.MultimediaFilters;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
using FFmpegArgs.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class FadeInOne
    {
        /// <summary>
        /// Same as BlurredBackground
        /// </summary>
        [TestMethod]
        public void FadeInOneTest()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\temp\ffmpeg_encode_test\ImgsTest");
            var files = directoryInfo.GetFiles("*.jpg");
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var inputs = files.Select(x => ffmpegArg.AddImageInput(new ImageFileInput(x.Name).SetOption("-loop", 1))).ToList();

            int WIDTH = 1280;
            int HEIGHT = 720;
            int FPS = 30;
            double TRANSITION_DURATION = 1;
            double IMAGE_DURATION = 2;
            ScreenMode SCREEN_MODE = ScreenMode.Blur;
            Color BACKGROUND_COLOR = Color.Black;

            int IMAGE_COUNT = inputs.Count;
            double TRANSITION_FRAME_COUNT = TRANSITION_DURATION * FPS;
            double IMAGE_FRAME_COUNT = IMAGE_DURATION * FPS;
            double TOTAL_DURATION = (IMAGE_DURATION + TRANSITION_DURATION) * IMAGE_COUNT - TRANSITION_DURATION;
            double TOTAL_FRAME_COUNT = TOTAL_DURATION * FPS;

            List<IEnumerable<ImageMap>> prepareInputs = new List<IEnumerable<ImageMap>>();
            switch (SCREEN_MODE)
            {
                case ScreenMode.Center:
                    prepareInputs.AddRange(inputs.Select(x => x
                        .SetPtsFilter("PTS-STARTPTS").MapOut
                        .ScaleFilter(
                            $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),min(iw,{WIDTH}),-1)",
                            $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,min(ih,{HEIGHT}))").MapOut
                        .ScaleFilter("trunc(iw/2)*2", "trunc(ih/2)*2").MapOut
                        .SetSarFilter("1/1").MapOut
                        .FpsFilter($"{FPS}").MapOut
                        .FormatFilter(PixFmt.rgba).MapOut
                        .SplitFilter(2).MapsOut));
                    break;

                case ScreenMode.Crop:
                    prepareInputs.AddRange(inputs.Select(x => x
                         .SetPtsFilter("PTS-STARTPTS").MapOut
                         .ScaleFilter(
                             $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),-1,{WIDTH})",
                             $"if(gte(iw/ih,{WIDTH}/{HEIGHT}),{HEIGHT},-1)").MapOut
                         .CropFilter().WH($"{WIDTH}",$"{HEIGHT}").MapOut
                         .SetSarFilter("1/1").MapOut
                         .FpsFilter($"{FPS}").MapOut
                         .FormatFilter(PixFmt.rgba).MapOut
                         .SplitFilter(2).MapsOut));
                    break;

                case ScreenMode.Scale:
                    prepareInputs.AddRange(inputs.Select(x => x
                        .ScaleFilter($"{WIDTH}", $"{HEIGHT}").MapOut
                        .SetSarFilter("1/1").MapOut
                        .FpsFilter($"{FPS}").MapOut
                        .FormatFilter(PixFmt.rgba).MapOut
                        .SplitFilter(2).MapsOut));
                    break;

                case ScreenMode.Blur:
                    prepareInputs.AddRange(inputs.Select(x => x
                        .MakeBlurredBackgroundTemplate(WIDTH, HEIGHT, FPS, "100")
                        .SplitFilter(2).MapsOut));
                    break;
            }

            List<ImageMap> overlaids = new List<ImageMap>();
            for (int i = 0; i < prepareInputs.Count; i++)
            {
                overlaids.Add(prepareInputs[i].First()
                  .PadFilter($"{WIDTH}", $"{HEIGHT}").Position($"({WIDTH} - iw)/2", $"({HEIGHT} - ih)/2").MapOut
                  .TrimFilter().Duration(TimeSpan.FromSeconds(IMAGE_DURATION)).MapOut
                  .SelectFilter($"lte(n,{IMAGE_FRAME_COUNT})").MapOut);
            }


            List<ImageMap> startings = new List<ImageMap>();
            List<ImageMap> endings = new List<ImageMap>();
            for (int i = 0; i < prepareInputs.Count; i++)
            {
                //first create ed only (if only 1 image -> create ed)
                //mid: split to ed and op
                //last create op

                var res = prepareInputs[i].Last()
                  .PadFilter($"{WIDTH}", $"{HEIGHT}").Position($"({WIDTH}-iw)/2", $"({HEIGHT}-ih)/2").MapOut
                  .TrimFilter().Duration(TimeSpan.FromSeconds(TRANSITION_DURATION)).MapOut
                  .SelectFilter($"lte(n,{TRANSITION_FRAME_COUNT})").MapOut;

                if (i == 0)//first
                {
                    if (overlaids.Count > 1)
                    {
                        endings.Add(res);
                    }
                }
                else if (i == overlaids.Count - 1)//last
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
            var mapout = concatFilter.ImageMapsOut.First()
              .FormatFilter(PixFmt.yuv420p).MapOut;



            var output = new ImageFileOutput($"{nameof(FadeInOneTest)}.mp4", mapout);
            ffmpegArg.AddOutput(output);

            FFmpegRender fFmpegRender = ffmpegArg.Render(new FFmpegRenderConfig()
            {
                WorkingDirectory = directoryInfo.FullName
            });
            FFmpegRenderResult result = fFmpegRender.Execute();
            Assert.IsTrue(result.ExitCode == 0);
            Process.Start("ffplay", Path.Combine(directoryInfo.FullName, $"{nameof(FadeInOneTest)}.mp4"));

        }
    }
}
