namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITransform
    {
        
    }
    /// <summary>
    /// 
    /// </summary>
    public static class ITransformExtension
    {
        /// <summary>
        /// Set transform type of IIR filter. (default di)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="transform"></param>
        /// <returns></returns>
        public static T Transform<T>(this T t, Transform transform) where T : BaseOption, ITransform
            => t.SetOption("a", transform);
    }
}
