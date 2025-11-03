namespace FFmpegArgs.Filters.BaseFilters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class SourceToImageFilter : BaseFilter<BaseMap, ImageMap>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterGraph"></param>
        protected SourceToImageFilter(string filterName, IImageFilterGraph filterGraph)
          : base(filterName, new ImageMap(filterGraph, string.Empty))
        {
        }
        /// <summary>
        /// 
        /// </summary>
        protected override void AddMapOut()
          => _mapsOut.Add(new ImageMap(FilterGraph, Inv($"f_{FilterIndex}")));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        protected override void AddMapOut(int index)
          => _mapsOut.Add(new ImageMap(FilterGraph, Inv($"f_{FilterIndex}_{index}")));
    }
}
