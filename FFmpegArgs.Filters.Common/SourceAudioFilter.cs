namespace FFmpegArgs.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class SourceAudioFilter : BaseFilter<BaseMap, AudioMap>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterGraph"></param>
        protected SourceAudioFilter(string filterName, FilterGraph filterGraph)
          : base(filterName, new AudioMap(filterGraph, string.Empty))
        {
        }
        /// <summary>
        /// 
        /// </summary>
        protected void AddMapOut()
          => _mapsOut.Add(new AudioMap(FilterGraph, $"f_{FilterIndex}"));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        protected void AddMapOut(int index)
          => _mapsOut.Add(new AudioMap(FilterGraph, $"f_{FilterIndex}_{index}"));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        protected void AddMultiMapOut(int count)
        {
            for (int i = 0; i < count; i++) AddMapOut(i);
        }
    }
}
