namespace FFmpegArgs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg.html#Video-Options<br>
    /// </br>https://ffmpeg.org/ffmpeg.html#Advanced-Video-options
    /// </summary>
    public static class VideoOptionsExtension
    {
        
        #region Video Options
        
        /// <summary>
        /// Set the number of video frames to output. This is an obsolete alias for <b>-frames:v</b>, which you should use instead.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="vframes"></param>
        /// <returns></returns>
        public static T Vframes<T>(this T t, int vframes) where T : BaseOutput, IImage // (output)
            => t.SetOption("-vframes", vframes.ToString());

        /// <summary>
        /// As an input option, ignore any timestamps stored in the file and instead generate timestamps assuming constant frame rate fps. This is not the same as the -framerate option used for some input formats like image2 or v4l2 (it used to be the same in older versions of FFmpeg). If in doubt use -framerate instead of the input option -r.<br>
        /// </br>As an output option, duplicate or drop input frames to achieve constant output frame rate fps.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fps"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T R<T>(this T t, int fps) where T : BaseAVStream, IImage // (input/output,per-stream)
            => t.SetOption($"-r", fps);

        /// <summary>
        /// As an input option, ignore any timestamps stored in the file and instead generate timestamps assuming constant frame rate fps. This is not the same as the -framerate option used for some input formats like image2 or v4l2 (it used to be the same in older versions of FFmpeg). If in doubt use -framerate instead of the input option -r.<br>
        /// </br>As an output option, duplicate or drop input frames to achieve constant output frame rate fps.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fps"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T Fps<T>(this T t, int fps) where T : BaseAVStream, IImage // (input/output,per-stream)
            => t.SetOption($"-r", fps);
        
        /// <summary>
        /// Set maximum frame rate (Hz value, fraction or abbreviation).<br>
        /// </br>Clamps output frame rate when output framerate is auto-set and is higher than this value.Useful in batch processing or when input framerate is wrongly detected as very high.It cannot be set together with -r.It is ignored during streamcopy.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fps"></param>
        /// <returns></returns>
        public static T FpsMax<T>(this T t, int fps) where T : ImageOutputAVStream, IImage // (output,per-stream)
            => t.SetOption($"-fpsmax", fps);

        /// <summary>
        /// As an input option, this is a shortcut for the video_size private option, recognized by some demuxers for which the frame size is either not stored in the file or is configurable – e.g. raw video or video grabbers.<br>
        /// </br>As an output option, this inserts the scale video filter to the end of the corresponding filtergraph.Please use the scale filter directly to insert it at the beginning or some other place.<br>
        /// </br>The format is ‘wxh’ (default - same as source).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static T S<T>(this T t, Size size) where T : BaseAVStream, IImage // (input/output,per-stream)
            => t.SetOption($"-s", $"{size.Width}x{size.Height}");

        /// <summary>
        /// Set the video display aspect ratio specified by aspect.<br>
        /// </br>aspect can be a floating point number string, or a string of the form num:den, where num and den are the numerator and denominator of the aspect ratio.For example "4:3", "16:9", "1.3333", and "1.7777" are valid argument values.<br>
        /// </br>If used together with -vcodec copy, it will affect the aspect ratio stored at container level, but not the aspect ratio stored in encoded frames, if it exists.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="rational"></param>
        /// <returns></returns>
        public static T Aspect<T>(this T t, Rational rational) where T : BaseAVStream, IImage // (output,per-stream)
            => t.SetOption($"-aspect", rational.ToStringColon());

        /// <summary>
        /// As an input option, blocks all video streams of a file from being filtered or being automatically selected or mapped for any output. See -discard option to disable streams individually.<br>
        /// </br>As an output option, disables video recording i.e.automatic selection or mapping of any video stream.For full manual control see the -map option.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T Vn<T>(this T t) where T : BaseInputOutput, IImage // (input/output)
            => t.SetFlag("-vn");

        /// <summary>
        /// Set the video codec. This is an alias for <b>-codec:v</b>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="codec"></param>
        /// <returns></returns>
        public static T Vcodec<T>(this T t, string codec) where T : BaseOutput, IImage // (output)
            => t.SetOption("-vcodec", codec);

        /// <summary>
        /// Select the pass number (1 or 2). It is used to do two-pass video encoding. The statistics of the video are recorded in the first pass into a log file (see also the option -passlogfile), and in the second pass that log file is used to generate the video at the exact requested bitrate. On pass 1, you may just deactivate audio and set output to null, examples for Windows and Unix:<br>
        /// </br>ffmpeg -i foo.mov -c:v libxvid -pass 1 -an -f rawvideo -y NUL<br>
        /// </br>ffmpeg -i foo.mov -c:v libxvid -pass 1 -an -f rawvideo -y /dev/null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static T Pass<T>(this T t, int pass) where T : ImageOutputAVStream, IImage // (output,per-stream)
            => t.SetOptionRange($"-pass", pass, 1, 2);

        /// <summary>
        /// Set two-pass log file name prefix to prefix, the default file name prefix is “ffmpeg2pass”. The complete file name will be PREFIX-N.log, where N is a number specific to the output stream
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static T PassLogFile<T>(this T t, string prefix) where T : ImageOutputAVStream, IImage // (output,per-stream)
            => t.SetOption($"-passlogfile", prefix);

        // -vf filtergraph (output)

        // -autorotate

        // -autoscale
        #endregion


        #region Advanced Video Options
        /// <summary>
        /// Set pixel format. Use -pix_fmts to show all the supported pixel formats. If the selected pixel format can not be selected, ffmpeg will print a warning and select the best pixel format supported by the encoder. If pix_fmt is prefixed by a +, ffmpeg will exit with an error if the requested pixel format can not be selected, and automatic conversions inside filtergraphs are disabled. If pix_fmt is a single +, ffmpeg selects the same pixel format as the input (or graph output) and automatic conversions are disabled.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="pixFmt"></param>
        /// <returns></returns>
        public static T PixFmt<T>(this T t, PixFmt pixFmt) where T : BaseAVStream, IImage // (input/output,per-stream)
            => t.SetOption("-pix_fmt", pixFmt);

        /// <summary>
        /// Set SwScaler flags.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="swsFlags"></param>
        /// <returns></returns>
        public static T SwsFlags<T>(this T t, SwsFlags swsFlags) where T : BaseInputOutput, IImage // (input/output)
            => t.SetOption("-sws_flags", swsFlags);

        /// <summary>
        /// Rate control override for specific intervals, formatted as "int,int,int" list separated with slashes. Two first values are the beginning and end frame numbers, last one is quantizer to use if positive, or quality factor if negative.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="override"></param>
        /// <returns></returns>
        public static T RcOverride<T>(this T t, string @override) where T : ImageOutputAVStream // (output,per-stream)
            => t.SetOption("-rc_override", @override);

        // -ilme

        // -psnr

        // -vstats

        // -vstats_file file

        // -vstats_version file

        /// <summary>
        /// top=1/bottom=0/auto=-1 field first
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="top"></param>
        /// <returns></returns>
        public static T Top<T>(this T t, OutputVStreamTop top) where T : ImageOutputAVStream // (output,per-stream)
            => t.SetOption("-top", (int)top);

        // -dc precision

        // -vtag fourcc/tag (output)

        // -qphist (global)

        // -vbsf bitstream_filter

        // -force_key_frames[:stream_specifier] time[, time...] (output, per-stream)
        // -force_key_frames[:stream_specifier] expr:expr(output, per-stream)
        // -force_key_frames[:stream_specifier] source(output, per-stream)
        // -force_key_frames[:stream_specifier] source_no_drop(output, per-stream)

        // -copyinkf[:stream_specifier] (output,per-stream)

        // -init_hw_device type[=name][:device[,key=value...]]

        // -init_hw_device type[=name]@source

        // -init_hw_device list

        // -filter_hw_device name

        // -hwaccel[:stream_specifier] hwaccel (input,per-stream)

        // -hwaccel_device[:stream_specifier] hwaccel_device (input,per-stream)

        // -hwaccels
        #endregion
        
    }
    
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum OutputVStreamTop
    {
        Top = 1,
        Bottom = 0,
        Auto = -1
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
