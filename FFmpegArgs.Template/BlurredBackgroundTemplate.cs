using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.VideoFilters;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Template
{
    public static class BlurredBackgroundTemplate
    {
        public static ImageMap MakeBlurredBackgroundTemplate(this ImageMap image,
          string width, string height, string lumaRadius = "100")
        {
            List<ImageMap> inputs = new List<ImageMap>();
            if (image.IsInput)
            {
                inputs.Add(image);
                inputs.Add(image);
            }
            else
            {
                inputs.AddRange(image.SplitFilter(2).MapsOut);
            }

            var blurred = inputs.First()
              .ScaleFilter(width, height).MapOut
              .SetSarFilter("1/1").MapOut
              .FormatFilter(FormatPixFmt.rgba).MapOut
              .BoxBlurFilter().LumaRadius($"{lumaRadius}").MapOut
              .SetSarFilter("1/1").MapOut;

            return inputs.Last()
              .OverlayFilterOn(blurred, "(main_w - overlay_w)/2", "(main_h-overlay_h)/2").MapOut//center
              .FormatFilter(FormatPixFmt.rgba).MapOut;
        }
    }
}
