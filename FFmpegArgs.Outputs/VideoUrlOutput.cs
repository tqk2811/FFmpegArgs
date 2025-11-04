namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoUrlOutput : VideoOutput
    {
        readonly Uri _url;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="format"></param>
        /// <param name="imageMap"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public VideoUrlOutput(Uri url, MuxingFileFormat format, ImageMap imageMap, AudioMap audioMap)
            : base(new List<ImageMap>() { imageMap }, new List<AudioMap>() { audioMap })
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
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public VideoUrlOutput(Uri url, MuxingFileFormat format, IEnumerable<ImageMap> imageMaps, IEnumerable<AudioMap> audioMaps)
            : base(imageMaps, audioMaps)
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
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public VideoUrlOutput(Uri url, MuxingFileFormat format, ImageMap[] imageMaps, AudioMap[] audioMaps)
            : base(imageMaps, audioMaps)
        {
            this._url = url ?? throw new ArgumentNullException(nameof(url));
            this.Format(format);
        }

        public override IEnumerable<string> GetAllArgs()
        {
            List<string> args =
            [
                .. GetFlagArgs(),
                .. GetOptionArgs(),
                .. GetAVStreamArgs(),
                _url.ToString()
            ];
            return args;
        }
    }
}
