namespace FFmpegArgs.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class SourceImageFilter : BaseFilter<BaseMap, ImageMap>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterGraph"></param>
        protected SourceImageFilter(string filterName, IFilterGraph filterGraph)
          : base(filterName, new ImageMap(filterGraph, string.Empty))
        {
        }
        /// <summary>
        /// 
        /// </summary>
        protected void AddMapOut()
          => _mapsOut.Add(new ImageMap(FilterGraph, $"f_{FilterIndex}"));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        protected void AddMapOut(int index)
          => _mapsOut.Add(new ImageMap(FilterGraph, $"f_{FilterIndex}_{index}"));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        protected void AddMultBaseMapOut(int count)
        {
            for (int i = 0; i < count; i++) AddMapOut(i);
        }
    }
}
