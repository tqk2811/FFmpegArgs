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
        /// <param name="streamIndexOfInput"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioMap(IFilterGraph filterGraph, string name, int? streamIndexOfInput = null) : base(filterGraph, name, streamIndexOfInput)
        {

        }

        /// <summary>
        /// Unique name of map
        /// </summary>
        public override string MapName
        {
            get { return IsInput ? $"{_name}:a:{StreamIndexOfInput}" : _name; }
        }
    }
}
