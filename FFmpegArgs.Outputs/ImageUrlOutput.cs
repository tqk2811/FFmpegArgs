namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// Image/Video non audio
    /// </summary>
    public class ImageUrlOutput : ImageOutput
    {
        readonly Uri _url;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="format"></param>
        /// <param name="imageMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ImageUrlOutput(Uri url, MuxingFileFormat format, ImageMap imageMap) : base(imageMap)
        {
            this._url = url ?? throw new ArgumentNullException(nameof(url));
            this.Format(format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="format"></param>
        /// <param name="imageMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ImageUrlOutput(Uri url, MuxingFileFormat format, params ImageMap[] imageMaps) : base(imageMaps)
        {
            this._url = url ?? throw new ArgumentNullException(nameof(url));
            this.Format(format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="format"></param>
        /// <param name="imageMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ImageUrlOutput(Uri url, MuxingFileFormat format, IEnumerable<ImageMap> imageMaps) : base(imageMaps.ToArray())
        {
            this._url = url ?? throw new ArgumentNullException(nameof(url));
            this.Format(format);
        }

        /// <summary>
        /// Get FirstOrDefault of <see cref="ImageOutput.ImageOutputAVStreams"/>
        /// </summary>
        public ImageOutputAVStream ImageOutputAVStream { get { return this.ImageOutputAVStreams.FirstOrDefault(); } }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> args = new List<string>()
            {
                GetAVStreamArg(),
                GetFlagArgs(),
                GetOptionArgs(),
                _url.ToString()
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
