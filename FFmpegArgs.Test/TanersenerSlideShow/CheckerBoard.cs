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
    public class CheckerBoard
    {
        [TestMethod]
        public void CheckerBoardTest()
        {
            string outputFileName = $"{nameof(CheckerBoardTest)}.mp4";
            string filterFileName = $"{nameof(CheckerBoardTest)}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();


            int IMAGE_COUNT = images_inputmap.Count;
            int WIDTH = 1366;
            int HEIGHT = 768;
            int FPS = 24;
            double IMAGE_DURATION = 1;
            double TRANSITION_DURATION = 1;
            ScreenMode screenMode = ScreenMode.Blur;
            int CELL_SIZE = 64;
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
                  .PadFilter($"{WIDTH}", $"{HEIGHT}").Position($"({WIDTH}-iw)/2", $"({HEIGHT}-ih)/2").MapOut
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
            for (int i = 0; i < startings.Count;i++)
            {
                blendeds.Add(startings[i].BlendFilterOn(endings[i])
                    .All_Expr(  $"if((lte(mod(X,{CELL_SIZE}),{CELL_SIZE}/2-({CELL_SIZE}/2)*T/{TRANSITION_DURATION})+lte(mod(Y,{CELL_SIZE}),{CELL_SIZE}/2-({CELL_SIZE}/2)*T/{TRANSITION_DURATION}))+"+
                                $"(gte(mod(X,{CELL_SIZE}),({CELL_SIZE}/2)+({CELL_SIZE}/2)*T/{TRANSITION_DURATION})+gte(mod(Y,{CELL_SIZE}),({CELL_SIZE}/2)+({CELL_SIZE}/2)*T/{TRANSITION_DURATION})),B,A)")
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
