namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWidthType
    {
        
    }
    /// <summary>
    /// 
    /// </summary>
    public static class IWidthTypeExtension
    {
        /// <summary>
        /// set filter-width type (from 1 to 5) (default q)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="widthType"></param>
        /// <returns></returns>
        public static T WidthType<T>(this T t, WidthType widthType) where T : BaseOption, IWidthType
            => t.SetOption("t", widthType);
    }
}
