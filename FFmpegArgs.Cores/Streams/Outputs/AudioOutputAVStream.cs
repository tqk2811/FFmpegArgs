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

        protected override string StreamSymbol => "a";
    }
}
