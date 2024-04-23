namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioOutputAVStream : OutputAVStream, IAudio, IAudioCodec
    {
        /// <summary>
        /// 
        /// </summary>
        public AudioMap AudioMap { get; }
        /// <summary>
        /// 
        /// </summary>
        internal AudioOutputAVStream(AudioMap audioMap, int streamIndex) : base(audioMap, streamIndex)
        {
            this.AudioMap = audioMap;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> options = base.Options.Select(x => $"{x.Key}:a:{StreamIndex} {x.Value}").ToList();
            options.AddRange(base.Flags.Select(x => x));
            if (this.AudioMap.IsInput) options.Add($"-map {this.AudioMap.MapName}");
            else options.Add($"-map [{this.AudioMap.MapName}]");
            return string.Join(" ", options);
        }
    }
}
