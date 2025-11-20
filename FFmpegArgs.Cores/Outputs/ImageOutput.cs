namespace FFmpegArgs.Cores.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ImageOutput : BaseOutput, IImageOutput
    {
        readonly List<ImageOutputAVStream> _imageOutputAVStreams = new List<ImageOutputAVStream>();
        readonly List<ImageMap> _imageMaps = new List<ImageMap>();

        /// <summary>
        /// 
        /// </summary>
        public override IEnumerable<OutputAVStream> Streams => _imageOutputAVStreams;

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
        public virtual IEnumerable<ImageMap> ImageMaps => _imageMaps;

        /// <summary>
        /// 
        /// </summary>
        public virtual ImageMap ImageMap => ImageMaps.First();

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
