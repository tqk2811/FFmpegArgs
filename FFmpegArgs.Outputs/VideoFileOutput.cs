namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoFileOutput : VideoOutput
    {
        readonly string _filePath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="imageMap"></param>
        /// <param name="audioMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public VideoFileOutput(string filePath, ImageMap imageMap, AudioMap audioMap) : base(imageMap, audioMap)
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
                ImageMap.IsInput ? ImageMap.MapName : $"[{ImageMap.MapName}]",
                "-map",
                AudioMap.IsInput ? AudioMap.MapName : $"[{AudioMap.MapName}]",
                _filePath.Contains(" ") ? $"\"{_filePath}\"" : _filePath
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
