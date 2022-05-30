namespace FFmpegArgs.Cores.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class VideoOutput : BaseOutput, IImage, IAudio
    {
        readonly List<ImageOutputAVStream> _imageOutputAVStreams = new List<ImageOutputAVStream>();
        readonly List<AudioOutputAVStream> _audioOutputAVStreams = new List<AudioOutputAVStream>();
        readonly List<ImageMap> _imageMaps = new List<ImageMap>();
        readonly List<AudioMap> _audioMaps = new List<AudioMap>();

        /// <summary>
        /// 
        /// </summary>
        public override IEnumerable<OutputAVStream> OutputAVStreams
            => _imageOutputAVStreams.Cast<OutputAVStream>().Concat(_audioOutputAVStreams);

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ImageOutputAVStream> ImageOutputAVStreams => _imageOutputAVStreams;

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AudioOutputAVStream> AudioOutputAVStreams => _audioOutputAVStreams;

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ImageMap> ImageMaps => _imageMaps;

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<AudioMap> AudioMaps => _audioMaps;


        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected VideoOutput(IEnumerable<ImageMap> imageMaps, IEnumerable<AudioMap> audioMaps)
            : base(imageMaps.Cast<BaseMap>().Concat(audioMaps).ToArray())
        {
            _imageMaps.AddRange(imageMaps);
            _audioMaps.AddRange(audioMaps);

            for (int i = 0; i < _imageMaps.Count; i++)
            {
                _imageOutputAVStreams.Add(new ImageOutputAVStream(_imageMaps[i]));
            }
            for (int i = 0; i < _audioMaps.Count; i++)
            {
                _audioOutputAVStreams.Add(new AudioOutputAVStream(_audioMaps[i]));
            }
        }
    }
}
