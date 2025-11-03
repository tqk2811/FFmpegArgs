namespace FFmpegArgs.Cores.Maps
{
    /// <summary>
    /// Audio map
    /// </summary>
    public class AudioMap : BaseMap, IAudio
    {
        /// <summary>
        /// Create audio map
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioMap(IFilterGraph filterGraph, string name) : base(filterGraph, name)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public AudioMap(IBaseFFArg baseFFArg, IFilterGraph filterGraph, AudioInputAVStream audioInputAVStream)
            : base(baseFFArg, filterGraph, audioInputAVStream)
        {

        }
        /// <summary>
        /// Unique name of map
        /// </summary>
        public override string MapName
        {
            get { return IsInput ? Inv($"{IndexOfInput}:a:{InputAVStream.StreamIndex}") : _name; }
        }
    }
}
