using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... setdar            V->V       Set the frame display aspect ratio.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#setdar_002c-setsar
    /// </summary>
    public class SetDarFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "w", "h",
            "a", "sar",
            "dar",
            "hsub", "vsub"
        };
        readonly Expression expression = new Expression();
        internal SetDarFilter(Action<Expression> r, ImageMap imageMap) : base("setdar", imageMap)
        {
            AddMapOut();
            this.SetOption("r", r.Run(expression));
        }

        /// <summary>
        /// Set the maximum integer value to use for expressing numerator and denominator when reducing the expressed aspect ratio to a rational. <br>
        /// </br>(from 1 to INT_MAX) (default 100)
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public SetDarFilter Max(int max)
          => this.SetOptionRange("max", max, 1, INT_MAX);
    }

    public static class SetDarFilterExtension
    {
        /// <summary>
        /// This is done by changing the specified Sample (aka Pixel) Aspect Ratio, according to the following equation:<br></br>
        /// <b>DAR = HORIZONTAL_RESOLUTION / VERTICAL_RESOLUTION* SAR</b><br>
        /// </br>Keep in mind that the setdar filter does not modify the pixel dimensions of the video frame.Also, the display aspect ratio set by this filter may be changed by later filters in the filterchain, e.g. in case of scaling or if another "setdar" or a "setsar" filter is applied.<br>
        /// </br>The setsar filter sets the Sample(aka Pixel) Aspect Ratio for the filter output video.<br>
        /// </br>Note that as a consequence of the application of this filter, the output display aspect ratio will change according to the equation above.<br>
        /// </br>Keep in mind that the sample aspect ratio set by the setsar filter may be changed by later filters in the filterchain, e.g. if another "setsar" or a "setdar" filter is applied.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static SetDarFilter SetDarFilter(this ImageMap imageMap, Action<Expression> r)
        {
            return new SetDarFilter(r, imageMap);
        }

        /// <summary>
        /// This is done by changing the specified Sample (aka Pixel) Aspect Ratio, according to the following equation:<br></br>
        /// <b>DAR = HORIZONTAL_RESOLUTION / VERTICAL_RESOLUTION* SAR</b><br>
        /// </br>Keep in mind that the setdar filter does not modify the pixel dimensions of the video frame.Also, the display aspect ratio set by this filter may be changed by later filters in the filterchain, e.g. in case of scaling or if another "setdar" or a "setsar" filter is applied.<br>
        /// </br>The setsar filter sets the Sample(aka Pixel) Aspect Ratio for the filter output video.<br>
        /// </br>Note that as a consequence of the application of this filter, the output display aspect ratio will change according to the equation above.<br>
        /// </br>Keep in mind that the sample aspect ratio set by the setsar filter may be changed by later filters in the filterchain, e.g. if another "setsar" or a "setdar" filter is applied.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static SetDarFilter SetDarFilter(this ImageMap imageMap, string r)
        {
            return new SetDarFilter(r.Expression(), imageMap);
        }
    }
}
