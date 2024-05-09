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
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotSupportedException"></exception>
        protected override void AddMapOut()
        {
            throw new NotSupportedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="NotSupportedException"></exception>
        protected override void AddMapOut(int index)
        {
            throw new NotSupportedException();
        }
    }
}
