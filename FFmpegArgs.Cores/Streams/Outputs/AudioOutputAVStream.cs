namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioOutputAVStream : OutputAVStream,
        IAudio, IAudioCodec, IAudioStream,
        ICodec, ICodecEncoder, IAudioCodecEncoder,
        IStream, IOutputStream, IAudioOutputStream
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
            List<string> options = base.Options.Select(x => Inv($"{x.Key}:a:{StreamIndex} {x.Value}")).ToList();
            options.AddRange(base.Flags.Select(x => x));
            if (this.AudioMap.IsInput) options.Add(Inv($"-map {this.AudioMap.MapName}"));
            else options.Add(Inv($"-map [{this.AudioMap.MapName}]"));
            return string.Join(" ", options);
        }
    }
}
