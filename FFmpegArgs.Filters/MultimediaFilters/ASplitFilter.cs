﻿namespace FFmpegArgs.Filters.MultimediaFilters
{
    /// <summary>
    /// ... asplit            A->N       Pass on the audio input to N audio outputs.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#split_002c-asplit"/>
    /// </summary>
    public class ASplitFilter : AudioToAudioFilter
    {
        internal ASplitFilter(int number, AudioMap audioMap) : base("asplit", audioMap)
        {
            if (number <= 0) throw new InvalidRangeException($"{nameof(number)} <= 0");
            AddMultiMapOut(number);
            this.SetOption("outputs", number);//libavfilter/split.c
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class ASplitFilterExtension
    {
        /// <summary>
        /// Split input into several identical outputs.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#split_002c-asplit"/>
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="number">The filter accepts a single parameter which specifies the number of outputs. If unspecified, it defaults to 2.</param>
        /// <returns></returns>
        public static ASplitFilter ASplit(this AudioMap audioMap, int number)
                => new ASplitFilter(number, audioMap ?? throw new ArgumentNullException(nameof(audioMap)));
    }
}
