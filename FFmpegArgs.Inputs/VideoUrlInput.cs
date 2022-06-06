namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoUrlInput : VideoInput
    {
        readonly Uri _url;

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public VideoUrlInput(
            Uri url,
            DemuxingFileFormat format,
            int imageStreamCount = 1,
            int audioStreamCount = 1) : base(imageStreamCount, audioStreamCount)
        {
            this._url = url ?? throw new ArgumentNullException(nameof(url));
            this.Format(format);
        }

        /// <summary>
        /// Image Stream Input
        /// </summary>
        public ImageInputAVStream ImageInputAVStream { get { return base.ImageInputAVStreams.FirstOrDefault(); } }

        /// <summary>
        /// Audio Stream Input
        /// </summary>
        public AudioInputAVStream AudioInputAVStream { get { return base.AudioInputAVStreams.FirstOrDefault(); } }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> args = new List<string>()
            {
                GetFlagArgs(),
                GetOptionArgs(),
                GetAVStreamArg(),
                $"-i \"{_url}\""
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
