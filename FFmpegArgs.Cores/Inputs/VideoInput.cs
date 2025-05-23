namespace FFmpegArgs.Cores.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class VideoInput : BaseInput, IAudioInput, IImageInput
    {
        readonly List<AudioInputAVStream> _audioInputAVStreams = new List<AudioInputAVStream>();
        readonly List<ImageInputAVStream> _imageInputAVStreams = new List<ImageInputAVStream>();

        /// <summary>
        /// 
        /// </summary>
        protected VideoInput(int imageStreamCount, int audioStreamCount)
        {
            if (imageStreamCount < 1) throw new InvalidRangeException($"{nameof(imageStreamCount)} should large than 0");
            if (audioStreamCount < 1) throw new InvalidRangeException($"{nameof(audioStreamCount)} should large than 0");

            for (int i = 0; i < imageStreamCount; i++)
            {
                _imageInputAVStreams.Add(new ImageInputAVStream(this, i));
            }
            for (int i = 0; i < audioStreamCount; i++)
            {
                _audioInputAVStreams.Add(new AudioInputAVStream(this, i));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override IEnumerable<InputAVStream> InputAVStreams
            => _imageInputAVStreams.Cast<InputAVStream>().Concat(_audioInputAVStreams);


        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ImageInputAVStream> ImageInputAVStreams { get { return _imageInputAVStreams; } }
        /// <summary>
        /// 
        /// </summary>
        public virtual ImageInputAVStream ImageInputAVStream => ImageInputAVStreams.First();

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<AudioInputAVStream> AudioInputAVStreams { get { return _audioInputAVStreams; } }

        /// <summary>
        /// 
        /// </summary>
        public virtual AudioInputAVStream AudioInputAVStream => AudioInputAVStreams.FirstOrDefault();
    }
}
