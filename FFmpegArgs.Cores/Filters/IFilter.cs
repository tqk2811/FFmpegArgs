namespace FFmpegArgs.Cores.Filters
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    public interface IFilter<out TIn, out TOut>
    where TIn : BaseMap
    where TOut : BaseMap
    {
        /// <summary>
        /// 
        /// </summary>
        IFilterGraph FilterGraph { get; }

        /// <summary>
        /// 
        /// </summary>
        int FilterIndex { get; }

        /// <summary>
        /// 
        /// </summary>
        string FilterName { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<TOut> MapsOut { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<TIn> MapsIn { get; }

        /// <summary>
        /// 
        /// </summary>
        TOut MapOut { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<KeyValuePair<string, string>> Options { get; }
    }
}
