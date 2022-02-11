namespace FFmpegArgs.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ImageToImageFilter : BaseFilter<ImageMap, ImageMap>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="mapsIn"></param>
        protected ImageToImageFilter(string filterName, params ImageMap[] mapsIn) : base(filterName, mapsIn)
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
        protected void AddMultiMapOut(int count)
        {
            for (int i = 0; i < count; i++) AddMapOut(i);
        }
    }
}
