namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioFileOutput : AudioOutput
    {
        readonly string _filePath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public AudioFileOutput(string filePath, AudioMap audioMap) : base(audioMap)
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
                GetArgs(),
                "-map",
                $"[{AudioMap.MapName}]",
                _filePath.Contains(" ") ? $"\"{_filePath}\"" : _filePath
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
