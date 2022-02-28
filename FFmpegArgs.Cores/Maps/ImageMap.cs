namespace FFmpegArgs.Cores.Maps
{
    /// <summary>
    /// Image map
    /// </summary>
    public class ImageMap : BaseMap, IImage
    {
        /// <summary>
        /// Create image map
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <param name="name"></param>
        /// <param name="streamIndexOfInput"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ImageMap(BaseFilterGraph filterGraph, string name, int? streamIndexOfInput = null) : base(filterGraph, name, streamIndexOfInput)
        {

        }

        /// <summary>
        /// Unique name of map
        /// </summary>
        public override string MapName
        {
            get { return IsInput ? $"{_name}:v:{StreamIndexOfInput}" : _name; }
        }
    }
}
