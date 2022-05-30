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
