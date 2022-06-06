namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoFileInput : VideoInput
    {
        readonly string _filePath;
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public VideoFileInput(
            string filePath,
            int imageStreamCount = 1,
            int audioStreamCount = 1) : base(imageStreamCount, audioStreamCount)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            this._filePath = filePath;
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
                _filePath.Contains(" ") ? $"-i \"{_filePath}\"" : $"-i {_filePath}"
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
