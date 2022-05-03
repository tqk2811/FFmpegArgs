namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioFileInput : AudioInput
    {
        readonly string _filePath;
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioFileInput(string filePath, int streamCount = 1) : base(streamCount)
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
                _filePath.Contains(" ") ? $"-i \"{_filePath}\"" : $"-i {_filePath}"
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
