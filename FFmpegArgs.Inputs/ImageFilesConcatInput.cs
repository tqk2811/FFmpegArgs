﻿namespace FFmpegArgs.Inputs
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
        /// <param name="imageStreamCount"></param>
        /// <returns></returns>
        public static ImageFilesConcatInput ConcatProtocol(IEnumerable<string> files, int imageStreamCount = 1)
        {
            return new ImageFilesConcatInput($"concat:{string.Join("|", files)}", imageStreamCount);//filter
        }
        /// <summary>
        /// Use this method when you want to avoid a re-encode and your format does not support file-level concatenation <br></br>
        /// (most files used by general users do not support file-level concatenation).
        /// </summary>
        /// <param name="textFile"></param>
        /// <param name="safe"></param>
        /// <param name="imageStreamCount"></param>
        /// <returns></returns>
        public static ImageFilesConcatInput ConcatDemuxer(string textFile, bool safe = true, int imageStreamCount = 1)
        {
            var result = new ImageFilesConcatInput(textFile, imageStreamCount);
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
        /// <param name="imageStreamCount"></param>
        /// <returns></returns>
        public static ImageFilesConcatInput FromFilesSearch(string search, int imageStreamCount = 1)
        {
            var result = new ImageFilesConcatInput(search, imageStreamCount);
            //result.SetOption("-pattern_type", "glob");
            return result;
        }



        readonly string _filePath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="imageStreamCount"></param>
        private ImageFilesConcatInput(string input, int imageStreamCount = 1) : base(imageStreamCount)
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
                GetFlagArgs(),
                GetOptionArgs(),
                GetAVStreamArg(),
                _filePath.Contains(" ") ? $"-i \"{_filePath}\"" : $"-i {_filePath}"
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
