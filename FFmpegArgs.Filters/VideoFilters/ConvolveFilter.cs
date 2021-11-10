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
    /// TS. convolve          VV->V      Convolve first video stream with second video stream.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#convolve
    /// </summary>
    public class ConvolveFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, IFramesync
    {
        internal ConvolveFilter(int plane, ImageMap imageMap) : base("convolve", imageMap)
        {
            AddMapOut();
            this.SetOptionRange("planes", plane, 0, int.MaxValue);
        }

        /// <summary>
        /// Set which impulse video frames will be processed, can be first or all. Default is all.
        /// </summary>
        /// <param name="impulse"></param>
        /// <returns></returns>
        public ConvolveFilter Impulse(ConvolveImpulse impulse)
            => this.SetOption("impulse", impulse);

    }

    public static class ConvolveFilterExtensions
    {
        /// <summary>
        /// Apply 2D convolution of video stream in frequency domain using second stream as impulse.
        /// </summary>
        /// <param name="plane">Set which planes to process.</param>
        public static ConvolveFilter ConvolveFilter(this ImageMap imageMap,int plane)
          => new ConvolveFilter(plane, imageMap);
    }

    public enum ConvolveImpulse
    {
        first,
        all
    }
}
