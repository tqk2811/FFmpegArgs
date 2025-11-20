namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAudioInput : IAudio, IInput
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<AudioInputAVStream> AudioStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        AudioInputAVStream AudioStream { get; }
    }
}
