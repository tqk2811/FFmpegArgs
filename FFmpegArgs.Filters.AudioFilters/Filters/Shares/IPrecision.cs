namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPrecision
    {
        
    }
    /// <summary>
    /// 
    /// </summary>
    public static class IPrecisionExtension
    {
        /// <summary>
        /// set filtering precision (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static T Precision<T>(this T t, Precision precision) where T : BaseOption, IPrecision
            => t.SetOption("r", precision);
    }
}
