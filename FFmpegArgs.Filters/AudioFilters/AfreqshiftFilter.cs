using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;

namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC afreqshift        A->A       Apply frequency shifting to input audio.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#afreqshift
    /// </summary>
    public class AfreqshiftFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        readonly Expression expression = new Expression();
        internal AfreqshiftFilter(AudioMap audioMap) : base("afreqshift", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Specify frequency shift. Allowed range is -INT_MAX to INT_MAX. Default value is 0.0.
        /// </summary>
        /// <param name="shift"></param>
        /// <returns></returns>
        public AfreqshiftFilter Shift(string shift)
          => this.SetOption("shift", shift.Expression().Run(expression));

        /// <summary>
        /// Specify frequency shift. Allowed range is -INT_MAX to INT_MAX. Default value is 0.0.
        /// </summary>
        /// <param name="shift"></param>
        /// <returns></returns>
        public AfreqshiftFilter Shift(Action<Expression> shift)
          => this.SetOption("shift", shift.Run(expression));

        /// <summary>
        /// Set output gain applied to final output. Allowed range is from 0.0 to 1.0. Default value is 1.0.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public AfreqshiftFilter Level(float level)
          => this.SetOptionRange("level", level, 0.0f, 1.0f);

        /// <summary>
        /// Set filter order used for filtering. Allowed range is from 1 to 16. Default value is 8.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public AfreqshiftFilter Order(int order)
          => this.SetOptionRange("order", order, 1, 16);
    }

    public static class AfreqshiftFilterExtensions
    {
        /// <summary>
        /// Apply frequency shift to input audio samples.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AfreqshiftFilter AfreqshiftFilter(this AudioMap audioMap)
          => new AfreqshiftFilter(audioMap);
    }
}
