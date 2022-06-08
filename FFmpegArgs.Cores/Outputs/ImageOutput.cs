namespace FFmpegArgs.Cores.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ImageOutput : BaseOutput, IImage
    {
        readonly List<ImageOutputAVStream> _imageOutputAVStreams = new List<ImageOutputAVStream>();
        readonly List<ImageMap> _imageMaps = new List<ImageMap>();

        /// <summary>
        /// 
        /// </summary>
        public override IEnumerable<OutputAVStream> OutputAVStreams => _imageOutputAVStreams;

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ImageOutputAVStream> ImageOutputAVStreams => _imageOutputAVStreams;

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ImageMap> ImageMaps => _imageMaps;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        protected ImageOutput(params ImageMap[] imageMaps) : base(imageMaps)
        {
            _imageMaps.AddRange(imageMaps);
            for (int i = 0; i < imageMaps.Length; i++)
            {
                _imageOutputAVStreams.Add(new ImageOutputAVStream(imageMaps[i], i));
            }
        }
    }
}
