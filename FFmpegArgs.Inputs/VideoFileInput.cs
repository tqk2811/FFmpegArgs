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

        public override IEnumerable<string> GetAllArgs()
        {
            List<string> args =
            [
                .. GetFlagArgs(),
                .. GetOptionArgs(),
                .. GetAVStreamArgs(),
                "-i",
                _filePath
            ];
            return args;
        }
    }
}
