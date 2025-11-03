namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// Image/Video non audio
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
        /// <param name="filePath"></param>
        /// <param name="imageMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ImageFileOutput(string filePath, params ImageMap[] imageMaps) : base(imageMaps)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            this._filePath = filePath;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="imageMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ImageFileOutput(string filePath, IEnumerable<ImageMap> imageMaps) : base(imageMaps.ToArray())
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
                GetAVStreamArg(),
                GetFlagArgs(),
                GetOptionArgs(),
                _filePath.ContainsOrd(" ") ? $"\"{_filePath}\"" : _filePath
            };
            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
