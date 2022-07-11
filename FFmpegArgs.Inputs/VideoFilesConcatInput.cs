namespace FFmpegArgs.Inputs
{
    //https://stackoverflow.com/a/11175851/5034139
    /// <summary>
    /// 
    /// </summary>
    public class VideoFilesConcatInput : VideoInput
    {
        /// <summary>
        /// Use this method with formats that support file-level concatenation (MPEG-1, MPEG-2 PS, DV).<br></br>
        /// Do not use with MP4.
        /// </summary>
        /// <returns></returns>
        public static VideoFilesConcatInput ConcatProtocol(IEnumerable<string> files, int imageCount = 1, int audioCount = 1)
        {
            return new VideoFilesConcatInput($"concat:{string.Join("|", files)}", imageCount, audioCount);//filter
        }
        /// <summary>
        /// Use this method when you want to avoid a re-encode and your format does not support file-level concatenation <br></br>
        /// (most files used by general users do not support file-level concatenation).
        /// </summary>
        /// <returns></returns>
        public static VideoFilesConcatInput ConcatDemuxer(string textFile, bool safe = true, int imageCount = 1, int audioCount = 1)
        {
            var result = new VideoFilesConcatInput(textFile, imageCount, audioCount);
            if (safe) result.SetOption("-safe", "0");
            result.Format(DemuxingFileFormat.concat);
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="search">Example: *.png, imagename%04d.png<br>
        /// </br>Note: *.png Not a available on window <br>
        /// </br><see href="https://stackoverflow.com/a/31513542/5034139"/></param>
        /// <param name="audioCount"></param>
        /// <param name="imageCount"></param>
        /// <returns></returns>
        public static VideoFilesConcatInput FromFilesSearch(string search, int imageCount = 1, int audioCount = 1)
        {
            var result = new VideoFilesConcatInput(search, imageCount, audioCount);
            //result.SetOption("-pattern_type", "glob");
            return result;
        }



        readonly string _filesPath;
        /// <summary>
        /// 
        /// </summary>
        private VideoFilesConcatInput(string input, int imageCount = 1, int audioCount = 1) : base(imageCount, audioCount)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException(nameof(input));
            this._filesPath = input;
        }

        /// <summary>
        /// Image Stream Input
        /// </summary>
        public ImageInputAVStream ImageInputAVStream { get { return base.ImageInputAVStreams.FirstOrDefault(); } }

        /// <summary>
        /// Audio Stream Input
        /// </summary>
        public AudioInputAVStream AudioInputAVStream { get { return base.AudioInputAVStreams.FirstOrDefault(); } }

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
                _filesPath.Contains(" ") ? $"-i \"{_filesPath}\"" : $"-i {_filesPath}"
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
