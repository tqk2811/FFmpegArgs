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

        public override IEnumerable<string> GetAllArgs()
        {
            List<string> args =
            [
                .. GetFlagArgs(),
                .. GetOptionArgs(),
                .. GetAVStreamArgs(),
                "-i",
                _url.ToString()
            ];
            return args;
        }
    }
}
