namespace FFmpegArgs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg.html#Main-options
    /// </summary>
    public static class VideoOptionExtensions
    {
        /// <summary>
        /// As an input option, ignore any timestamps stored in the file and instead generate timestamps assuming constant frame rate fps. This is not the same as the -framerate option used for some input formats like image2 or v4l2 (it used to be the same in older versions of FFmpeg). If in doubt use -framerate instead of the input option -r.<br>
        /// </br>As an output option, duplicate or drop input frames to achieve constant output frame rate fps.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fps"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T Fps<T>(this T t, int fps, int? stream_specifier = null) where T : BaseInputOutput, IImage
        {
            if (stream_specifier == null)
            {
                t.SetOption($"-r", fps);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                t.SetOption($"-r:{stream_specifier.Value}", fps);
            }
            return t;
        }
        /// <summary>
        /// As an input option, this is a shortcut for the video_size private option, recognized by some demuxers for which the frame size is either not stored in the file or is configurable – e.g. raw video or video grabbers.<br>
        /// </br>As an output option, this inserts the scale video filter to the end of the corresponding filtergraph.Please use the scale filter directly to insert it at the beginning or some other place.<br>
        /// </br>The format is ‘wxh’ (default - same as source).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="size"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T Size<T>(this T t, Size size, int? stream_specifier = null) where T : BaseInputOutput, IImage
        {
            if (stream_specifier == null)
            {
                t.SetOption($"-s", $"{size.Width}x{size.Height}");
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                t.SetOption($"-s:{stream_specifier.Value}", $"{size.Width}x{size.Height}");
            }
            return t;
        }
        /// <summary>
        /// As an input option, blocks all video streams of a file from being filtered or being automatically selected or mapped for any output. See -discard option to disable streams individually.<br>
        /// </br>As an output option, disables video recording i.e.automatic selection or mapping of any video stream.For full manual control see the -map option.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T VN<T>(this T t) where T : BaseInputOutput, IImage
            => t.SetFlag("-vn");
        /// <summary>
        /// Set pixel format. Use -pix_fmts to show all the supported pixel formats. If the selected pixel format can not be selected, ffmpeg will print a warning and select the best pixel format supported by the encoder. If pix_fmt is prefixed by a +, ffmpeg will exit with an error if the requested pixel format can not be selected, and automatic conversions inside filtergraphs are disabled. If pix_fmt is a single +, ffmpeg selects the same pixel format as the input (or graph output) and automatic conversions are disabled.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="pixFmt"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        public static T Format<T>(this T t, PixFmt pixFmt, int? stream_specifier = null) where T : BaseInputOutput, IImage
        {
            if (stream_specifier == null)
            {
                t.SetOption("-pix_fmt", pixFmt);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                t.SetOption($"-pix_fmt:{stream_specifier.Value}", pixFmt);
            }
            return t;
        }
        public static T SwsFlags<T>(this T t, SwsFlags swsFlags) where T : BaseInputOutput, IImage
            => t.SetOption("-sws_flags", swsFlags);
    }
}
