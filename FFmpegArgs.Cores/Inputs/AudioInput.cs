namespace FFmpegArgs.Cores.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AudioInput : BaseInput, IAudio
    {
        readonly List<AudioInputAVStream> _inputAudioFFStreams = new List<AudioInputAVStream>();

        /// <summary>
        /// 
        /// </summary>
        protected AudioInput(int streamCount)
        {
            if (streamCount < 1) throw new ArgumentOutOfRangeException(nameof(streamCount));
            for (int i = 0; i < streamCount; i++)
            {
                _inputAudioFFStreams.Add(new AudioInputAVStream(this, i));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override IEnumerable<InputAVStream> InputAVStreams => _inputAudioFFStreams;


        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AudioInputAVStream> AudioInputAVStreams { get { return _inputAudioFFStreams; } }
    }
}
