namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageFileInput : ImageInput
    {
        readonly string _filePath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ImageFileInput(string filePath)
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
                _filePath.Contains(" ") ? $"-i \"{_filePath}\"" : $"-i {_filePath}"
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
