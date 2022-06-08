namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioInputAVStream : InputAVStream, IAudio
    {
        /// <summary>
        /// 
        /// </summary>
        internal AudioInputAVStream(BaseInput baseInput, int streamIndex) : base(baseInput, streamIndex)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> options = base._options.Select(x => $"{x.Key}:a:{StreamIndex} {x.Value}").ToList();
            options.AddRange(base._flags.Select(x => x));
            return string.Join(" ", options);
        }
    }
}
