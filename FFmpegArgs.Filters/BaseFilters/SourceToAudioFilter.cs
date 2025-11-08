namespace FFmpegArgs.Filters.BaseFilters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class SourceToAudioFilter : BaseFilter<BaseMap, AudioMap>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterGraph"></param>
        protected SourceToAudioFilter(string filterName, IAudioFilterGraph filterGraph)
          : base(filterName, new AudioMap(filterGraph, string.Empty))
        {
        }
        /// <summary>
        /// 
        /// </summary>
        protected override void AddMapOut()
          => _mapsOut.Add(new AudioMap(FilterGraph, $"f_{FilterIndex}"));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        protected override void AddMapOut(int index)
          => _mapsOut.Add(new AudioMap(FilterGraph, $"f_{FilterIndex}_{index}"));
    }
}
