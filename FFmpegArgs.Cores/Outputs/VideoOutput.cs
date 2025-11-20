namespace FFmpegArgs.Cores.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class VideoOutput : BaseOutput, IAudioOutput, IImageOutput
    {
        readonly List<ImageOutputAVStream> _imageOutputAVStreams = new List<ImageOutputAVStream>();
        readonly List<AudioOutputAVStream> _audioOutputAVStreams = new List<AudioOutputAVStream>();
        readonly List<ImageMap> _imageMaps = new List<ImageMap>();
        readonly List<AudioMap> _audioMaps = new List<AudioMap>();

        /// <summary>
        /// 
        /// </summary>
        public override IEnumerable<OutputAVStream> Streams
            => _imageOutputAVStreams.Cast<OutputAVStream>().Concat(_audioOutputAVStreams);



        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ImageOutputAVStream> ImageStreams => _imageOutputAVStreams;

        /// <summary>
        /// 
        /// </summary>
        public virtual ImageOutputAVStream ImageStream => ImageStreams.First();

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<AudioOutputAVStream> AudioStreams => _audioOutputAVStreams;

        /// <summary>
        /// 
        /// </summary>
        public virtual AudioOutputAVStream AudioStream => AudioStreams.First();




        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ImageMap> ImageMaps => _imageMaps;

        /// <summary>
        /// 
        /// </summary>
        public virtual ImageMap ImageMap => ImageMaps.First();

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
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected VideoOutput(IEnumerable<ImageMap> imageMaps, IEnumerable<AudioMap> audioMaps)
            : base(imageMaps.Cast<BaseMap>().Concat(audioMaps).ToArray())
        {
            _imageMaps.AddRange(imageMaps);
            _audioMaps.AddRange(audioMaps);

            for (int i = 0; i < _imageMaps.Count; i++)
            {
                _imageOutputAVStreams.Add(new ImageOutputAVStream(_imageMaps[i], i));
            }
            for (int i = 0; i < _audioMaps.Count; i++)
            {
                _audioOutputAVStreams.Add(new AudioOutputAVStream(_audioMaps[i], i));
            }
        }
    }
}
