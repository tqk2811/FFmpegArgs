namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public class UrlVideoInput : VideoInput
    {
        readonly Uri _url;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="format"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public UrlVideoInput(Uri url, DemuxingFileFormat format)
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
                GetArgs(),
                $"-i \"{_url}\""
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
