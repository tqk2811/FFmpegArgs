namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioUrlOutput : AudioOutput
    {
        readonly Uri _url;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="format"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioUrlOutput(Uri url, MuxingFileFormat format, AudioMap audioMap) : base(audioMap)
        {
            this._url = url ?? throw new ArgumentNullException(nameof(url));
            this.Format(format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="format"></param>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioUrlOutput(Uri url, MuxingFileFormat format, params AudioMap[] audioMaps) : base(audioMaps)
        {
            this._url = url ?? throw new ArgumentNullException(nameof(url));
            this.Format(format);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="format"></param>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioUrlOutput(Uri url, MuxingFileFormat format, IEnumerable<AudioMap> audioMaps) : base(audioMaps.ToArray())
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
