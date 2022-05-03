namespace FFmpegArgs.Cores.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ImageInput : BaseInput, IImage
    {
        readonly List<ImageInputAVStream> _imageInputAVStreams = new List<ImageInputAVStream>();


        /// <summary>
        /// 
        /// </summary>
        protected ImageInput(int streamCount)
        {
            if (streamCount < 1) throw new ArgumentOutOfRangeException(nameof(streamCount));
            for (int i = 0; i < streamCount; i++)
            {
                _imageInputAVStreams.Add(new ImageInputAVStream(this, i));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override IEnumerable<InputAVStream> InputAVStreams => _imageInputAVStreams;


        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ImageInputAVStream> ImageInputAVStreams { get { return _imageInputAVStreams; } }
    }
}
