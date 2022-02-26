namespace FFmpegArgs.Inputs
{
    //https://stackoverflow.com/a/11175851/5034139
    /// <summary>
    /// 
    /// </summary>
    public class ImageFilesConcatInput : ImageInput
    {
        /// <summary>
        /// Use this method with formats that support file-level concatenation (MPEG-1, MPEG-2 PS, DV).<br></br>
        /// Do not use with MP4.
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public static ImageFilesConcatInput ConcatProtocol(IEnumerable<string> files)
        {
            return new ImageFilesConcatInput($"concat:{string.Join("|", files)}");//filter
        }
        /// <summary>
        /// Use this method when you want to avoid a re-encode and your format does not support file-level concatenation <br></br>
        /// (most files used by general users do not support file-level concatenation).
        /// </summary>
        /// <param name="textFile"></param>
        /// <param name="safe"></param>
        /// <returns></returns>
        public static ImageFilesConcatInput ConcatDemuxer(string textFile, bool safe = true)
        {
            var result = new ImageFilesConcatInput(textFile);
            if (safe) result.SetOption("-safe", "0");
            result.Format(DemuxingFileFormat.concat);
            return result;
        }
        /// <summary>
        /// Note: *.png Not a available on window <br></br>
        /// https://stackoverflow.com/a/31513542/5034139
        /// </summary>
        /// <param name="search">Example: *.png, imagename%04d.png</param>
        /// <returns></returns>
        public static ImageFilesConcatInput FromFilesSearch(string search)
        {
            var result = new ImageFilesConcatInput(search);
            //result.SetOption("-pattern_type", "glob");
            return new ImageFilesConcatInput(search);
        }



        readonly string _filePath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        private ImageFilesConcatInput(string input)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException(nameof(input));
            this._filePath = input;
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
