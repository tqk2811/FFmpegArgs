using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC colortemperature  V->V       Adjust color temperature of video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#colortemperature
    /// </summary>
    public class ColortemperatureFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ColortemperatureFilter(ImageMap imageMap) : base("colortemperature", imageMap)
        {
            AddMapOut();
            IsAllowEmptyOption = true;
        }

        /// <summary>
        /// Set the temperature in Kelvin. Allowed range is from 1000 to 40000. Default value is 6500 K.
        /// </summary>
        /// <param name="temperature"></param>
        /// <returns></returns>
        public ColortemperatureFilter Temperature(int temperature)
            => this.SetOptionRange("temperature", temperature, 1000, 40000);

        /// <summary>
        /// Set mixing with filtered output. Allowed range is from 0 to 1. Default value is 1.
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public ColortemperatureFilter Mix(int mix)
          => this.SetOptionRange("mix", mix, 0, 1);

        /// <summary>
        /// Set the amount of preserving lightness. Allowed range is from 0 to 1. Default value is 0.
        /// </summary>
        /// <param name="pl"></param>
        /// <returns></returns>
        public ColortemperatureFilter Pl(float pl)
          => this.SetOptionRange("pl", pl, 0, 1);

    }

    public static class ColortemperatureFilterExtensions
    {
        /// <summary>
        /// Adjust color temperature in video to simulate variations in ambient color temperature.
        /// </summary>
        public static ColortemperatureFilter ColortemperatureFilter(this ImageMap imageMap)
          => new ColortemperatureFilter(imageMap);
    }
}
