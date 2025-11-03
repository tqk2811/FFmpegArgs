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
        /// <exception cref="ArgumentNullException"></exception>
        public ImageMap(IFilterGraph filterGraph, string name) : base(filterGraph, name)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public ImageMap(IBaseFFArg baseFFArg, IFilterGraph filterGraph, ImageInputAVStream imageInputAVStream) 
            : base(baseFFArg, filterGraph, imageInputAVStream)
        {

        }

        /// <summary>
        /// Unique name of map
        /// </summary>
        public override string MapName
        {
            get { return IsInput ? Inv($"{IndexOfInput}:v:{InputAVStream.StreamIndex}") : _name; }
        }
    }
}
