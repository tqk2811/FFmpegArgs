namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAudioOutput : IAudio, IOutput
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<AudioOutputAVStream> AudioStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        AudioOutputAVStream AudioStream { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<AudioMap> AudioMaps { get; }

        /// <summary>
        /// 
        /// </summary>
        AudioMap AudioMap { get; }
    }
}
