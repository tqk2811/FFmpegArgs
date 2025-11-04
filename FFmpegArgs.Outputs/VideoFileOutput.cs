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
        public VideoFileOutput(string filePath, ImageMap imageMap, AudioMap audioMap)
            : base(new List<ImageMap>() { imageMap }, new List<AudioMap>() { audioMap })
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            this._filePath = filePath;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="imageMaps"></param>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public VideoFileOutput(string filePath, IEnumerable<ImageMap> imageMaps, IEnumerable<AudioMap> audioMaps)
            : base(imageMaps, audioMaps)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            this._filePath = filePath;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="imageMaps"></param>
        /// <param name="audioMaps"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public VideoFileOutput(string filePath, ImageMap[] imageMaps, AudioMap[] audioMaps)
            : base(imageMaps, audioMaps)
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
                _filePath
            ];
            return args;
        }
    }
}
