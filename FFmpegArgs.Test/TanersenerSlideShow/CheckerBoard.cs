﻿using FFmpegArgs.Filters.Enums;
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

            Config config = new Config();
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;
            ScreenMode screenMode = ScreenMode.Blur;
            int CELL_SIZE = 64;

            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenModes(screenMode, config);

            var overlaids = prepareInputs.Select(x => x.First()).Overlaids(config);

            var startEnd = prepareInputs.Select(x => x.Last()).ToList().StartEnd(config);

            var blendeds = startEnd.Blendeds(config, blend => blend
                .Shortest(true)
                .All_Expr(
                    $"if(" +
                        $"(" +
                            $"lte(mod(X,{CELL_SIZE}),{CELL_SIZE}/2-({CELL_SIZE}/2)*T/{config.TransitionDuration.TotalSeconds})" +
                            $"+lte(mod(Y,{CELL_SIZE}),{CELL_SIZE}/2-({CELL_SIZE}/2)*T/{config.TransitionDuration.TotalSeconds})" +
                        $")+" +
                        $"(" +
                            $"gte(mod(X,{CELL_SIZE}),({CELL_SIZE}/2)+({CELL_SIZE}/2)*T/{config.TransitionDuration.TotalSeconds})" +
                            $"+gte(mod(Y,{CELL_SIZE}),({CELL_SIZE}/2)+({CELL_SIZE}/2)*T/{config.TransitionDuration.TotalSeconds})" +
                        $")" +
                        $",B" +
                        $",A)"));

            var out_map = overlaids.ConcatOverlaidsAndBlendeds(blendeds);

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
