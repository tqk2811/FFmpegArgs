namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... split             V->N       Pass on the input to N video outputs.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#split_002c-asplit"/>
    /// </summary>
    public class SplitFilter : ImageToImageFilter
    {
        internal SplitFilter(int number, ImageMap imageMap) : base("split", imageMap)
        {
            if (number <= 1) throw new InvalidRangeException($"{nameof(number)} > 1");
            AddMultiMapOut(number);
            this.SetOption("outputs", number);//libavfilter/split.c
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class SplitFilterExtension
    {
        /// <summary>
        /// Split input into several identical outputs.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#split_002c-asplit"/>
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="number">The filter accepts a single parameter which specifies the number of outputs. If unspecified, it defaults to 2.</param>
        /// <returns></returns>
        public static SplitFilter SplitFilter(this ImageMap imageMap, int number)
        {
            return new SplitFilter(number, imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
        }
    }
}
