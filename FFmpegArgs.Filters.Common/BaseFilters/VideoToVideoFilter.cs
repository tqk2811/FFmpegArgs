namespace FFmpegArgs.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class VideoToVideoFilter : BaseFilter<BaseMap, BaseMap>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="baseMaps"></param>
        protected VideoToVideoFilter(string filterName, params BaseMap[] baseMaps) : base(filterName, baseMaps)
        {
        }
    }
}
