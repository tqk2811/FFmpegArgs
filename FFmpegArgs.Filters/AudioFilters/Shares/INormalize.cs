namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// 
    /// </summary>
    public interface INormalize
    {
        
    }
    /// <summary>
    /// 
    /// </summary>
    public static class INormalizeExtension
    {
        /// <summary>
        /// Normalize biquad coefficients, by default is disabled. Enabling it will normalize magnitude response at DC to 0dB.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="normalize"></param>
        /// <returns></returns>
        public static T Normalize<T>(this T t, bool normalize) where T : BaseOption, INormalize
            => t.SetOption("n", normalize.ToFFmpegFlag());
    }
}
