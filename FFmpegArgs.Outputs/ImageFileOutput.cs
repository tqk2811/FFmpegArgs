namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageFileOutput : ImageOutput
    {
        readonly string _filePath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="imageMap"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ImageFileOutput(string filePath, ImageMap imageMap) : base(imageMap)
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
                $"[{ImageMap.MapName}]",
                _filePath.Contains(" ") ? $"\"{_filePath}\"" : _filePath
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
