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
                _filePath.ContainsOrd(" ") ? $"-i \"{_filePath}\"" : $"-i {_filePath}"
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
