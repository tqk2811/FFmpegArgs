namespace FFmpegArgs.Cores.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AudioOutput : BaseOutput, IAudioOutput
    {
        readonly List<AudioOutputAVStream> _audioOutputAVStreams = new List<AudioOutputAVStream>();
        readonly List<AudioMap> _audioMaps = new List<AudioMap>();


        /// <summary>
        /// 
        /// </summary>
        public override IEnumerable<OutputAVStream> OutputAVStreams => _audioOutputAVStreams;


        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<AudioOutputAVStream> AudioOutputAVStreams => _audioOutputAVStreams;

        /// <summary>
        /// 
        /// </summary>
        public virtual AudioOutputAVStream AudioOutputAVStream => AudioOutputAVStreams.First();

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<AudioMap> AudioMaps => _audioMaps;

        /// <summary>
        /// 
        /// </summary>
        public virtual AudioMap AudioMap => AudioMaps.First();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected AudioOutput(params AudioMap[] audioMaps) : base(audioMaps)
        {
            _audioMaps.AddRange(audioMaps);
            for (int i = 0; i < audioMaps.Length; i++)
            {
                _audioOutputAVStreams.Add(new AudioOutputAVStream(audioMaps[i], i));
            }
        }
    }
}
