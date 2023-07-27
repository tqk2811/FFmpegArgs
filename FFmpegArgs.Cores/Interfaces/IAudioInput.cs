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
        IEnumerable<AudioInputAVStream> AudioInputAVStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        AudioInputAVStream AudioInputAVStream { get; }
    }
}
