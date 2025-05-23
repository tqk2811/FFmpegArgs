namespace FFmpegArgs.Cores.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AudioInput : BaseInput, IAudioInput
    {
        readonly List<AudioInputAVStream> _inputAudioFFStreams = new List<AudioInputAVStream>();

        /// <summary>
        /// 
        /// </summary>
        protected AudioInput(int streamCount)
        {
            if (streamCount < 1) throw new InvalidRangeException($"{nameof(streamCount)} should large than 0");
            for (int i = 0; i < streamCount; i++)
            {
                _inputAudioFFStreams.Add(new AudioInputAVStream(this, i));
            }
        }

        /// <summary>
        /// Streams Input
        /// </summary>
        public override IEnumerable<InputAVStream> InputAVStreams => _inputAudioFFStreams;


        /// <summary>
        /// Audios Stream Input
        /// </summary>
        public virtual IEnumerable<AudioInputAVStream> AudioInputAVStreams { get { return _inputAudioFFStreams; } }

        /// <summary>
        /// 
        /// </summary>
        public virtual AudioInputAVStream? AudioInputAVStream => AudioInputAVStreams.First();
    }
}
