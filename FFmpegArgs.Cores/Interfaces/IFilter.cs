namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFilter
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
        IEnumerable<KeyValuePair<string, string>> Options { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetFilterOptions();

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<BaseMap> MapsOut { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<BaseMap> MapsIn { get; }

        /// <summary>
        /// 
        /// </summary>
        BaseMap MapOut { get; }
    }



    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    public interface IFilter<out TIn, out TOut> : IFilter
    where TIn : BaseMap
    where TOut : BaseMap
    {
        
        /// <summary>
        /// 
        /// </summary>
        new IEnumerable<TOut> MapsOut { get; }

        /// <summary>
        /// 
        /// </summary>
        new IEnumerable<TIn> MapsIn { get; }

        /// <summary>
        /// 
        /// </summary>
        new TOut MapOut { get; }
    }
}
