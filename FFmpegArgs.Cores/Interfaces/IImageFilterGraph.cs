namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IImageFilterGraph : IFilterGraph
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        internal int AddFilter<TIn, TOut>(BaseFilter<TIn, TOut> filter)
            where TIn : BaseMap
            where TOut : ImageMap;
    }
}
