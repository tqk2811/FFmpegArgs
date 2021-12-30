using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Executes;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.MultimediaFilters;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Inputs;
using FFmpegArgs.Outputs;
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
    public class FadeInTwo
    {
        [TestMethod]
        public void FadeInTwoTest()
        {
            string outputFileName = $"{nameof(FadeInTwoTest)}.mp4";
            string filterFileName = $"{nameof(FadeInTwoTest)}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();

            Config config = new Config();
            TimeSpan TOTAL_DURATION = (config.ImageDuration + config.TransitionDuration) * images_inputmap.Count - config.TransitionDuration;

            List<IEnumerable<ImageMap>> splitInputs = new List<IEnumerable<ImageMap>>();
            splitInputs.AddRange(images_inputmap.Select(x => x
              .SetSarFilter("1/1").MapOut
              .ScaleFilter($"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),min(iw,{config.Size.Width}),-1)",
                            $"if(gte(iw/ih,{config.Size.Width}/{config.Size.Height}),-1,min(ih,{config.Size.Height}))").MapOut
              .PadFilter($"{config.Size.Width}", $"{config.Size.Height}").Position($"({config.Size.Height} - ow)/2", $"({config.Size.Height} - oh)/2").Color(config.BackgroundColor).MapOut
              .FpsFilter($"{config.Fps}").MapOut
              .SetPtsFilter("PTS-STARTPTS").MapOut
              .SplitFilter(2).MapsOut));

            var overlaids = splitInputs.Select(x => x.First()).Overlaids(config);

            var startEnd = splitInputs.Select(x => x.Last()).ToList().StartEnd(config);

            var blendeds = startEnd.Blendeds(config, blend => blend
               .Shortest(true)
               .All_Expr(
                    $"A*(if(gte(T,{config.TransitionDuration.TotalSeconds}),{config.TransitionDuration.TotalSeconds},T/{config.TransitionDuration.TotalSeconds})) + " +
                    $"B*(1-(if(gte(T,{config.TransitionDuration.TotalSeconds}),{config.TransitionDuration.TotalSeconds},T/{config.TransitionDuration.TotalSeconds})))"));

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
