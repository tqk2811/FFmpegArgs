namespace FFmpegArgs.Filters.BaseFilters
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioToImageFilter : BaseFilter<AudioMap, ImageMap>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="mapsIn"></param>
        protected AudioToImageFilter(string filterName, params AudioMap[] mapsIn) : base(filterName, mapsIn)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        protected override void AddMapOut()
            => _mapsOut.Add(new ImageMap(FilterGraph, $"f_{FilterIndex}"));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        protected override void AddMapOut(int index)
            => _mapsOut.Add(new ImageMap(FilterGraph, $"f_{FilterIndex}_{index}"));
    }
}
