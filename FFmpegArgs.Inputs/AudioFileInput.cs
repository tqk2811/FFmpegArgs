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
