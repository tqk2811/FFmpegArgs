namespace FFmpegArgs.Cores.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ImageInput : BaseInput, IImageInput
    {
        readonly List<ImageInputAVStream> _imageInputAVStreams = new List<ImageInputAVStream>();


        /// <summary>
        /// 
        /// </summary>
        protected ImageInput(int streamCount)
        {
            if (streamCount < 1) throw new InvalidRangeException($"{nameof(streamCount)} should large than 0");
            for (int i = 0; i < streamCount; i++)
            {
                _imageInputAVStreams.Add(new ImageInputAVStream(this, i));
            }
        }

        /// <summary>
        /// Streams Input
        /// </summary>
        public override IEnumerable<InputAVStream> Streams => _imageInputAVStreams;

        /// <summary>
        /// Images Stream Input
        /// </summary>
        public virtual IEnumerable<ImageInputAVStream> ImageStreams { get { return _imageInputAVStreams; } }

        /// <summary>
        /// Image Stream Input
        /// </summary>
        public virtual ImageInputAVStream ImageStream => ImageStreams.First();
    }
}
