using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Executes;
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
    public class FadeInOne
    {
        /// <summary>
        /// Same as BlurredBackground
        /// </summary>
        [TestMethod]
        public void FadeInOneTest()
        {
            string outputFileName = $"{nameof(FadeInOneTest)}.mp4";
            string filterFileName = $"{nameof(FadeInOneTest)}.txt";
            FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();
            var images_inputmap = ffmpegArg.GetImagesInput();

            int WIDTH = 1280;
            int HEIGHT = 720;
            int FPS = 30;
            double TRANSITION_DURATION = 1;
            double IMAGE_DURATION = 2;
            ScreenMode SCREEN_MODE = ScreenMode.Blur;
            Color BACKGROUND_COLOR = Color.Black;

            int IMAGE_COUNT = images_inputmap.Count;
            double TRANSITION_FRAME_COUNT = TRANSITION_DURATION * FPS;
            double IMAGE_FRAME_COUNT = IMAGE_DURATION * FPS;
            double TOTAL_DURATION = (IMAGE_DURATION + TRANSITION_DURATION) * IMAGE_COUNT - TRANSITION_DURATION;
            double TOTAL_FRAME_COUNT = TOTAL_DURATION * FPS;


            List<IEnumerable<ImageMap>> prepareInputs = images_inputmap.InputScreenMode(SCREEN_MODE, WIDTH, HEIGHT, FPS);


            List<ImageMap> overlaids = new List<ImageMap>();
            for (int i = 0; i < prepareInputs.Count; i++)
            {
                overlaids.Add(prepareInputs[i].First()
                  .PadFilter($"{WIDTH}", $"{HEIGHT}").Position($"({WIDTH} - iw)/2", $"({HEIGHT} - ih)/2").Color(BACKGROUND_COLOR).MapOut
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
