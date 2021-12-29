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
using System.Collections.Generic;
using System.Collections;
using FFmpegArgs.Executes;
using FFmpegArgs.Cores.Maps;
using System.Diagnostics;

namespace FFmpegArgs.Test.TanersenerSlideShow
{
    [TestClass]
    public class Clock
    {
        [TestMethod]
        public void ClockTest_Blur()
        {
            ClockTest(ScreenMode.Blur);
        }



        public void ClockTest(ScreenMode screenMode)
        {
            string outputFileName = $"{nameof(ClockTest)}-{screenMode}.mp4";
            string filterFileName = $"{nameof(ClockTest)}-{screenMode}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();

            int IMAGE_COUNT = images_inputmap.Count;
            int WIDTH = 1280;
            int HEIGHT = 720;
            int FPS = 30;
            double IMAGE_DURATION = 2;
            double TRANSITION_DURATION = 2;

            Color BACKGROUND_COLOR = Color.FromArgb(0, 0, 0, 0);
            int TRANSITION_FRAME_COUNT = (int)(TRANSITION_DURATION * FPS);
            int IMAGE_FRAME_COUNT = (int)(IMAGE_DURATION * FPS);
            double TOTAL_DURATION = (IMAGE_DURATION + TRANSITION_DURATION) * IMAGE_COUNT - TRANSITION_DURATION;
            int TOTAL_FRAME_COUNT = (int)(TOTAL_DURATION * FPS);

            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenMode(screenMode, WIDTH, HEIGHT, FPS);

            List<ImageMap> overlaids = new List<ImageMap>();
            for (int i = 0; i < prepareInputs.Count; i++)
            {
                overlaids.Add(prepareInputs[i].First()
                  .PadFilter($"{WIDTH}", $"{HEIGHT}")
                    .Position($"({WIDTH} - iw)/2", $"({HEIGHT} - ih)/2")
                    .Color(BACKGROUND_COLOR).MapOut
                  .TrimFilter()
                    .Duration(TimeSpan.FromSeconds(IMAGE_DURATION)).MapOut
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
                  .PadFilter($"{WIDTH}", $"{HEIGHT}").Position($"({WIDTH}-iw)/2", $"({HEIGHT}-ih)/2").Color(BACKGROUND_COLOR).MapOut
                  .TrimFilter().Duration(TimeSpan.FromSeconds(TRANSITION_DURATION)).MapOut
                  .SelectFilter($"lte(n,{TRANSITION_FRAME_COUNT})").MapOut;

                if (i == 0)//first
                {
                    if (prepareInputs.Count > 1)
                    {
                        endings.Add(res);
                    }
                }
                else if (i == prepareInputs.Count - 1)//last
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

            List<ImageMap> blendeds = new List<ImageMap>();
            for (int i = 0; i < startings.Count; i++)
            {
                blendeds.Add(startings[i].BlendFilterOn(endings[i])
                    .All_Expr(  $"if(" +
                                    $"lte(T,0.125)," +
                                    $"if(" +
                                        $"gt(X,W/2)*lte(Y,H/2)*lte(X-W/2+Y-H/2,0)," +
                                        $"A," +
                                        $"B)," +
                                    $"if(" +
                                        $"lte(T,0.25)," +
                                        $"if(" +
                                            $"gt(X,W/2)*lte(Y,H/2)," +
                                            $"A," +
                                            $"B)," +
                                        $"if(" +
                                            $"lte(T,0.375)," +
                                            $"if(" +
                                                $"(gt(X,W/2)*gt(Y,H/2)*gt(X-W/2-Y+H/2,0))+(gt(X,W/2)*lte(Y,H/2))," +
                                                $"A," +
                                                $"B)," +
                                            $"if(" +
                                                $"lte(T,0.5)," +
                                                $"if(" +
                                                    $"gt(X,W/2)," +
                                                    $"A," +
                                                    $"B)," +
                                                $"if(" +
                                                    $"lte(T,0.625)," +
                                                    $"if(" +
                                                        $"(lte(X,W/2)*gt(Y,H/2)*gt(X-W/2+Y-H/2,0))+gt(X,W/2)," +
                                                        $"A," +
                                                        $"B)," +
                                                    $"if(" +
                                                        $"lte(T,0.75)," +
                                                        $"if(" +
                                                            $"(lte(X,W/2)*gt(Y,H/2))+gt(X,W/2)," +
                                                            $"A," +
                                                            $"B)," +
                                                        $"if(" +
                                                            $"lte(T,0.875)," +
                                                            $"if(" +
                                                                $"(lte(X,W/2)*lte(Y,H/2)*lte(Y-H/2-X+W/2,0))," +
                                                                $"B," +
                                                                $"A)," +
                                                             $"A)))))))")
                    .Shortest(true)
                    .MapOut);
            }

            List<ConcatGroup> concatGroups = new List<ConcatGroup>();
            for (int i = 0; i < overlaids.Count; i++)
            {
                concatGroups.Add(new ConcatGroup(overlaids[i]));
                if (i < overlaids.Count - 1) concatGroups.Add(new ConcatGroup(blendeds[i]));
            }
            ConcatFilter concatFilter = new ConcatFilter(concatGroups);
            var out_map = concatFilter.ImageMapsOut.First()
              .FormatFilter(PixFmt.yuv420p).MapOut;


            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
              .VSync(VSyncMethod.vfr)
              .SetOption("-c:v", "libx264")
              .Fps(FPS)
              .SetOption("-g", "0")
              .SetOption("-rc-lookahead", "0");

            ffmpegArg.AddOutput(imageFileOutput);

            ffmpegArg.TestRender(filterFileName, outputFileName);
        }






        [TestMethod]
        public void ClockTestCustom_Blur()
        {
            ClockTestCustom(ScreenMode.Blur);
        }



        public void ClockTestCustom(ScreenMode screenMode)
        {
            string outputFileName = $"{nameof(ClockTestCustom)}-{screenMode}.mp4";
            string filterFileName = $"{nameof(ClockTestCustom)}-{screenMode}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();

            int IMAGE_COUNT = images_inputmap.Count;
            int WIDTH = 1280;
            int HEIGHT = 720;
            int FPS = 30;
            double IMAGE_DURATION = 2;
            double TRANSITION_DURATION = 2;

            Color BACKGROUND_COLOR = Color.FromArgb(0, 0, 0, 0);
            int TRANSITION_FRAME_COUNT = (int)(TRANSITION_DURATION * FPS);
            int IMAGE_FRAME_COUNT = (int)(IMAGE_DURATION * FPS);
            double TOTAL_DURATION = (IMAGE_DURATION + TRANSITION_DURATION) * IMAGE_COUNT - TRANSITION_DURATION;
            int TOTAL_FRAME_COUNT = (int)(TOTAL_DURATION * FPS);

            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenMode(screenMode, WIDTH, HEIGHT, FPS);

            List<ImageMap> overlaids = new List<ImageMap>();
            for (int i = 0; i < prepareInputs.Count; i++)
            {
                overlaids.Add(prepareInputs[i].First()
                  .PadFilter($"{WIDTH}", $"{HEIGHT}")
                    .Position($"({WIDTH} - iw)/2", $"({HEIGHT} - ih)/2")
                    .Color(BACKGROUND_COLOR).MapOut
                  .TrimFilter()
                    .Duration(TimeSpan.FromSeconds(IMAGE_DURATION)).MapOut
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
                  .PadFilter($"{WIDTH}", $"{HEIGHT}").Position($"({WIDTH}-iw)/2", $"({HEIGHT}-ih)/2").Color(BACKGROUND_COLOR).MapOut
                  .TrimFilter().Duration(TimeSpan.FromSeconds(TRANSITION_DURATION)).MapOut
                  .SelectFilter($"lte(n,{TRANSITION_FRAME_COUNT})").MapOut;

                if (i == 0)//first
                {
                    if (prepareInputs.Count > 1)
                    {
                        endings.Add(res);
                    }
                }
                else if (i == prepareInputs.Count - 1)//last
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

            List<ImageMap> blendeds = new List<ImageMap>();
            for (int i = 0; i < startings.Count; i++)
            {
                // (0.5W, 0.5H) -> (0.5W, 0) => vecto v1 = (0.5W-0.5W,0-0.5H)   = (0        ,    -0.5*H)
                // (0.5W, 0.5H) -> (X, Y) => vecto v2                           = (X - 0.5*W ,   Y - 0.5*H);
                // cos(v1,v2) = (a1*a2 + b1*b2)/[sqrt(a1*a1 + b1*b1) * sqrt(a2*a2 + b2*b2)]
                // = (-0.5*H * (Y - 0.5*H))/(sqrt(0.5*H*0.5*H) * sqrt((X - 0.5*W)*(X - 0.5*W) + (Y - 0.5*H)*(Y - 0.5*H)))

                //0 degrees => 1, 90 degrees => 0, 180 degrees => -1:   cos range 1 -> -1, acos 0 -> PI
                //                                                      cos range -1 -> 1, acos PI -> 0
                var exp = "((-0.5*H * (Y - 0.5*H))/(0.5*H * sqrt((X - 0.5*W)*(X - 0.5*W) + (Y - 0.5*H)*(Y - 0.5*H))))";
                blendeds.Add(startings[i].BlendFilterOn(endings[i])//if X >= 0.5*W => exp...
                    .All_Expr(  $"if(" +
                                    $"lt(T,{TRANSITION_DURATION})," +
                                    $"if(" +//0 -> 2 PI                                                            
                                        $"lte(" +
                                            $"if(" +
                                                $"gte(X,W/2)," +
                                                $"acos({exp})," +// 0 -> PI
                                                $"2*PI-acos({exp}))," +// PI -> 0 => 2PI -  (PI -> 0) = PI -> 2PI
                                             $"T*2*PI/{TRANSITION_DURATION})," +
                                        $"A," +
                                        $"B)," +
                                    $"B)")
                    .Shortest(true)
                    .MapOut);
            }

            List<ConcatGroup> concatGroups = new List<ConcatGroup>();
            for (int i = 0; i < overlaids.Count; i++)
            {
                concatGroups.Add(new ConcatGroup(overlaids[i]));
                if (i < overlaids.Count - 1) concatGroups.Add(new ConcatGroup(blendeds[i]));
            }
            ConcatFilter concatFilter = new ConcatFilter(concatGroups);
            var out_map = concatFilter.ImageMapsOut.First()
              .FormatFilter(PixFmt.yuv420p).MapOut;


            //Output
            ImageFileOutput imageFileOutput = new ImageFileOutput(outputFileName, out_map);
            imageFileOutput
              .VSync(VSyncMethod.vfr)
              .SetOption("-c:v", "libx264")
              .Fps(FPS)
              .SetOption("-g", "0")
              .SetOption("-rc-lookahead", "0");

            ffmpegArg.AddOutput(imageFileOutput);

            ffmpegArg.TestRender(filterFileName, outputFileName);
        }
    }
}
