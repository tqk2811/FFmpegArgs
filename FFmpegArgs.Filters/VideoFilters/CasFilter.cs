﻿namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC cas               V->V       Contrast Adaptive Sharpen.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#cas
    /// </summary>
    public class CasFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal CasFilter(ImageMap imageMap) : base("cas", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the sharpening strength. Default value is 0.
        /// </summary>
        /// <param name="strength"></param>
        /// <returns></returns>
        public CasFilter Strength(double strength)
          => this.SetOptionRange("strength", strength, 0, double.MaxValue);
        /// <summary>
        /// Set planes to filter. Default value is to filter all planes except alpha plane.<br>
        /// </br>flags ..FV.....T. set what planes to filter (default 7)
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public CasFilter Planes(string planes)
          => this.SetOption("planes", planes);
    }
    public static class CasFilterExtensions
    {
        /// <summary>
        /// Apply Contrast Adaptive Sharpen filter to video stream.
        /// </summary>
        public static CasFilter CasFilter(this ImageMap imageMap)
          => new CasFilter(imageMap);
    }
}
