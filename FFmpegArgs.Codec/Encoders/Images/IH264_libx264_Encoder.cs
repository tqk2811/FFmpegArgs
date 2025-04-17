/*libx264 AVOptions:
  -preset            <string>     E..V....... Set the encoding preset (cf. x264 --fullhelp) (default "medium")
  -tune              <string>     E..V....... Tune the encoding params (cf. x264 --fullhelp)
  -profile           <string>     E..V....... Set profile restrictions (cf. x264 --fullhelp)
  -fastfirstpass     <boolean>    E..V....... Use fast settings when encoding first pass (default true)
  -level             <string>     E..V....... Specify level (as defined by Annex A)
  -passlogfile       <string>     E..V....... Filename for 2 pass stats
  -wpredp            <string>     E..V....... Weighted prediction for P-frames
  -a53cc             <boolean>    E..V....... Use A53 Closed Captions (if available) (default true)
  -x264opts          <string>     E..V....... x264 options
  -crf               <float>      E..V....... Select the quality for constant quality mode (from -1 to FLT_MAX) (default -1)
  -crf_max           <float>      E..V....... In CRF mode, prevents VBV from lowering quality beyond this point. (from -1 to FLT_MAX) (default -1)
  -qp                <int>        E..V....... Constant quantization parameter rate control method (from -1 to INT_MAX) (default -1)
  -aq-mode           <int>        E..V....... AQ method (from -1 to INT_MAX) (default -1)
     none            0            E..V.......
     variance        1            E..V....... Variance AQ (complexity mask)
     autovariance    2            E..V....... Auto-variance AQ
     autovariance-biased 3            E..V....... Auto-variance AQ with bias to dark scenes
  -aq-strength       <float>      E..V....... AQ strength. Reduces blocking and blurring in flat and textured areas. (from -1 to FLT_MAX) (default -1)
  -psy               <boolean>    E..V....... Use psychovisual optimizations. (default auto)
  -psy-rd            <string>     E..V....... Strength of psychovisual optimization, in <psy-rd>:<psy-trellis> format.
  -rc-lookahead      <int>        E..V....... Number of frames to look ahead for frametype and ratecontrol (from -1 to INT_MAX) (default -1)
  -weightb           <boolean>    E..V....... Weighted prediction for B-frames. (default auto)
  -weightp           <int>        E..V....... Weighted prediction analysis method. (from -1 to INT_MAX) (default -1)
     none            0            E..V.......
     simple          1            E..V.......
     smart           2            E..V.......
  -ssim              <boolean>    E..V....... Calculate and print SSIM stats. (default auto)
  -intra-refresh     <boolean>    E..V....... Use Periodic Intra Refresh instead of IDR frames. (default auto)
  -bluray-compat     <boolean>    E..V....... Bluray compatibility workarounds. (default auto)
  -b-bias            <int>        E..V....... Influences how often B-frames are used (from INT_MIN to INT_MAX) (default INT_MIN)
  -b-pyramid         <int>        E..V....... Keep some B-frames as references. (from -1 to INT_MAX) (default -1)
     none            0            E..V.......
     strict          1            E..V....... Strictly hierarchical pyramid
     normal          2            E..V....... Non-strict (not Blu-ray compatible)
  -mixed-refs        <boolean>    E..V....... One reference per partition, as opposed to one reference per macroblock (default auto)
  -8x8dct            <boolean>    E..V....... High profile 8x8 transform. (default auto)
  -fast-pskip        <boolean>    E..V....... (default auto)
  -aud               <boolean>    E..V....... Use access unit delimiters. (default auto)
  -mbtree            <boolean>    E..V....... Use macroblock tree ratecontrol. (default auto)
  -deblock           <string>     E..V....... Loop filter parameters, in <alpha:beta> form.
  -cplxblur          <float>      E..V....... Reduce fluctuations in QP (before curve compression) (from -1 to FLT_MAX) (default -1)
  -partitions        <string>     E..V....... A comma-separated list of partitions to consider. Possible values: p8x8, p4x4, b8x8, i8x8, i4x4, none, all
  -direct-pred       <int>        E..V....... Direct MV prediction mode (from -1 to INT_MAX) (default -1)
     none            0            E..V.......
     spatial         1            E..V.......
     temporal        2            E..V.......
     auto            3            E..V.......
  -slice-max-size    <int>        E..V....... Limit the size of each slice in bytes (from -1 to INT_MAX) (default -1)
  -stats             <string>     E..V....... Filename for 2 pass stats
  -nal-hrd           <int>        E..V....... Signal HRD information (requires vbv-bufsize; cbr not allowed in .mp4) (from -1 to INT_MAX) (default -1)
     none            0            E..V.......
     vbr             1            E..V.......
     cbr             2            E..V.......
  -avcintra-class    <int>        E..V....... AVC-Intra class 50/100/200/300/480 (from -1 to 480) (default -1)
  -me_method         <int>        E..V....... Set motion estimation method (from -1 to 4) (default -1)
     dia             0            E..V.......
     hex             1            E..V.......
     umh             2            E..V.......
     esa             3            E..V.......
     tesa            4            E..V.......
  -motion-est        <int>        E..V....... Set motion estimation method (from -1 to 4) (default -1)
     dia             0            E..V.......
     hex             1            E..V.......
     umh             2            E..V.......
     esa             3            E..V.......
     tesa            4            E..V.......
  -forced-idr        <boolean>    E..V....... If forcing keyframes, force them as IDR frames. (default false)
  -coder             <int>        E..V....... Coder type (from -1 to 1) (default default)
     default         -1           E..V.......
     cavlc           0            E..V.......
     cabac           1            E..V.......
     vlc             0            E..V.......
     ac              1            E..V.......
  -b_strategy        <int>        E..V....... Strategy to choose between I/P/B-frames (from -1 to 2) (default -1)
  -chromaoffset      <int>        E..V....... QP difference between chroma and luma (from INT_MIN to INT_MAX) (default 0)
  -sc_threshold      <int>        E..V....... Scene change threshold (from INT_MIN to INT_MAX) (default -1)
  -noise_reduction   <int>        E..V....... Noise reduction (from INT_MIN to INT_MAX) (default -1)
  -udu_sei           <boolean>    E..V....... Use user data unregistered SEI if available (default false)
  -x264-params       <dictionary> E..V....... Override the x264 configuration using a :-separated list of key=value parameters
  -mb_info           <boolean>    E..V....... Set mb_info data through AVSideData, only useful when used from the API (default false)
*/
/*libx264rgb AVOptions:
  -preset            <string>     E..V....... Set the encoding preset (cf. x264 --fullhelp) (default "medium")
  -tune              <string>     E..V....... Tune the encoding params (cf. x264 --fullhelp)
  -profile           <string>     E..V....... Set profile restrictions (cf. x264 --fullhelp)
  -fastfirstpass     <boolean>    E..V....... Use fast settings when encoding first pass (default true)
  -level             <string>     E..V....... Specify level (as defined by Annex A)
  -passlogfile       <string>     E..V....... Filename for 2 pass stats
  -wpredp            <string>     E..V....... Weighted prediction for P-frames
  -a53cc             <boolean>    E..V....... Use A53 Closed Captions (if available) (default true)
  -x264opts          <string>     E..V....... x264 options
  -crf               <float>      E..V....... Select the quality for constant quality mode (from -1 to FLT_MAX) (default -1)
  -crf_max           <float>      E..V....... In CRF mode, prevents VBV from lowering quality beyond this point. (from -1 to FLT_MAX) (default -1)
  -qp                <int>        E..V....... Constant quantization parameter rate control method (from -1 to INT_MAX) (default -1)
  -aq-mode           <int>        E..V....... AQ method (from -1 to INT_MAX) (default -1)
     none            0            E..V.......
     variance        1            E..V....... Variance AQ (complexity mask)
     autovariance    2            E..V....... Auto-variance AQ
     autovariance-biased 3            E..V....... Auto-variance AQ with bias to dark scenes
  -aq-strength       <float>      E..V....... AQ strength. Reduces blocking and blurring in flat and textured areas. (from -1 to FLT_MAX) (default -1)
  -psy               <boolean>    E..V....... Use psychovisual optimizations. (default auto)
  -psy-rd            <string>     E..V....... Strength of psychovisual optimization, in <psy-rd>:<psy-trellis> format.
  -rc-lookahead      <int>        E..V....... Number of frames to look ahead for frametype and ratecontrol (from -1 to INT_MAX) (default -1)
  -weightb           <boolean>    E..V....... Weighted prediction for B-frames. (default auto)
  -weightp           <int>        E..V....... Weighted prediction analysis method. (from -1 to INT_MAX) (default -1)
     none            0            E..V.......
     simple          1            E..V.......
     smart           2            E..V.......
  -ssim              <boolean>    E..V....... Calculate and print SSIM stats. (default auto)
  -intra-refresh     <boolean>    E..V....... Use Periodic Intra Refresh instead of IDR frames. (default auto)
  -bluray-compat     <boolean>    E..V....... Bluray compatibility workarounds. (default auto)
  -b-bias            <int>        E..V....... Influences how often B-frames are used (from INT_MIN to INT_MAX) (default INT_MIN)
  -b-pyramid         <int>        E..V....... Keep some B-frames as references. (from -1 to INT_MAX) (default -1)
     none            0            E..V.......
     strict          1            E..V....... Strictly hierarchical pyramid
     normal          2            E..V....... Non-strict (not Blu-ray compatible)
  -mixed-refs        <boolean>    E..V....... One reference per partition, as opposed to one reference per macroblock (default auto)
  -8x8dct            <boolean>    E..V....... High profile 8x8 transform. (default auto)
  -fast-pskip        <boolean>    E..V....... (default auto)
  -aud               <boolean>    E..V....... Use access unit delimiters. (default auto)
  -mbtree            <boolean>    E..V....... Use macroblock tree ratecontrol. (default auto)
  -deblock           <string>     E..V....... Loop filter parameters, in <alpha:beta> form.
  -cplxblur          <float>      E..V....... Reduce fluctuations in QP (before curve compression) (from -1 to FLT_MAX) (default -1)
  -partitions        <string>     E..V....... A comma-separated list of partitions to consider. Possible values: p8x8, p4x4, b8x8, i8x8, i4x4, none, all
  -direct-pred       <int>        E..V....... Direct MV prediction mode (from -1 to INT_MAX) (default -1)
     none            0            E..V.......
     spatial         1            E..V.......
     temporal        2            E..V.......
     auto            3            E..V.......
  -slice-max-size    <int>        E..V....... Limit the size of each slice in bytes (from -1 to INT_MAX) (default -1)
  -stats             <string>     E..V....... Filename for 2 pass stats
  -nal-hrd           <int>        E..V....... Signal HRD information (requires vbv-bufsize; cbr not allowed in .mp4) (from -1 to INT_MAX) (default -1)
     none            0            E..V.......
     vbr             1            E..V.......
     cbr             2            E..V.......
  -avcintra-class    <int>        E..V....... AVC-Intra class 50/100/200/300/480 (from -1 to 480) (default -1)
  -me_method         <int>        E..V....... Set motion estimation method (from -1 to 4) (default -1)
     dia             0            E..V.......
     hex             1            E..V.......
     umh             2            E..V.......
     esa             3            E..V.......
     tesa            4            E..V.......
  -motion-est        <int>        E..V....... Set motion estimation method (from -1 to 4) (default -1)
     dia             0            E..V.......
     hex             1            E..V.......
     umh             2            E..V.......
     esa             3            E..V.......
     tesa            4            E..V.......
  -forced-idr        <boolean>    E..V....... If forcing keyframes, force them as IDR frames. (default false)
  -coder             <int>        E..V....... Coder type (from -1 to 1) (default default)
     default         -1           E..V.......
     cavlc           0            E..V.......
     cabac           1            E..V.......
     vlc             0            E..V.......
     ac              1            E..V.......
  -b_strategy        <int>        E..V....... Strategy to choose between I/P/B-frames (from -1 to 2) (default -1)
  -chromaoffset      <int>        E..V....... QP difference between chroma and luma (from INT_MIN to INT_MAX) (default 0)
  -sc_threshold      <int>        E..V....... Scene change threshold (from INT_MIN to INT_MAX) (default -1)
  -noise_reduction   <int>        E..V....... Noise reduction (from INT_MIN to INT_MAX) (default -1)
  -udu_sei           <boolean>    E..V....... Use user data unregistered SEI if available (default false)
  -x264-params       <dictionary> E..V....... Override the x264 configuration using a :-separated list of key=value parameters
  -mb_info           <boolean>    E..V....... Set mb_info data through AVSideData, only useful when used from the API (default false)
*/
namespace FFmpegArgs.Codec.Encoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public interface IH264_libx264_Encoder : ICodec, ICodecEncoder, IImage, IImageCodec, IImageCodecEncoder
    {
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum Libx264_Preset
    {
        ultrafast,
        superfast,
        veryfast,
        faster,
        fast,
        medium,
        slow,
        slower,
        veryslow,
        placebo
    }
    public enum Libx264_Tune
    {
        film,
        animation,
        grain,
        stillimage,
        psnr,
        ssim,
        fastdecode,
        zerolatency
    }
    public enum Libx264_Profile
    {
        baseline,
        main,
        high,
        /// <summary>
        /// first 10 bit compatible profile
        /// </summary>
        high10,
        /// <summary>
        /// supports yuv420p, yuv422p, yuv420p10le and yuv422p10le
        /// </summary>
        high422,
        /// <summary>
        /// supports as above as well as yuv444p and yuv444p10le
        /// </summary>
        high444,
    }
    public enum Libx264_AqMode
    {
        none = 0,
        /// <summary>
        /// Variance AQ (complexity mask)
        /// </summary>
        variance = 1,
        /// <summary>
        /// Auto-variance AQ
        /// </summary>
        autovariance = 2,
        /// <summary>
        /// Auto-variance AQ with bias to dark scenes
        /// </summary>
        autovariance_biased = 3
    }
    public enum Libx264_WeightP
    {
        none = 0,
        simple = 1,
        smart = 2
    }
    public enum Libx264_BPyramid
    {
        none = 0,
        /// <summary>
        /// Strictly hierarchical pyramid
        /// </summary>
        strict = 1,
        /// <summary>
        /// Non-strict (not Blu-ray compatible)
        /// </summary>
        normal = 2
    }
    public enum Libx264_Partitions
    {
        p8x8, p4x4, b8x8, i8x8, i4x4, none, all
    }
    public enum Libx264_DirectPred
    {
        none = 0,
        spatial = 1,
        temporal = 2,
        auto = 3
    }
    public enum Libx264_NALHRD
    {
        none = 0,
        vbr = 1,
        cbr = 2
    }
    public enum Libx264_MotionEstimationMethod
    {
        dia = 0,
        hex = 1,
        umh = 2,
        esa = 3,
        tesa = 4
    }
    public enum Libx264_Coder
    {
        @default = -1,
        cavlc = 0,
        cabac = 1,
        vlc = 0,
        ac = 1
    }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    public static partial class ImageEncoderExtensions
    {
        /// <summary>
        /// Set the encoding preset (default "medium")
        /// </summary>
        /// <param name="t"></param>
        /// <param name="preset"></param>
        /// <returns></returns>
        public static T Preset<T>(this T t, Libx264_Preset preset) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-preset", preset);
        /// <summary>
        /// Tune the encoding params
        /// </summary>
        /// <param name="t"></param>
        /// <param name="tune"></param>
        /// <returns></returns>
        public static T Tune<T>(this T t, Libx264_Tune tune) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-tune", tune);
        /// <summary>
        /// Set profile restrictions
        /// </summary>
        /// <param name="t"></param>
        /// <param name="profile"></param>
        /// <returns></returns>
        public static T Profile<T>(this T t, Libx264_Profile profile) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-profile", profile);
        /// <summary>
        /// Use fast settings when encoding first pass (default true)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T FastFirstPass<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-fastfirstpass", flag.ToFFmpegFlag());
        /// <summary>
        /// Specify level (as defined by Annex A)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public static T Level<T>(this T t, string level) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-level", level);
        /// <summary>
        /// Filename for 2 pass stats
        /// </summary>
        /// <param name="t"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static T PassLogFile<T>(this T t, string filename) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-passlogfile", filename);
        /// <summary>
        /// Weighted prediction for P-frames
        /// </summary>
        /// <param name="t"></param>
        /// <param name="wpredp"></param>
        /// <returns></returns>
        public static T WPredP<T>(this T t, string wpredp) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-wpredp", wpredp);
        /// <summary>
        /// Use A53 Closed Captions (if available) (default true)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T A53CC<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-a53cc", flag.ToFFmpegFlag());
        /// <summary>
        /// x264 options
        /// </summary>
        /// <param name="t"></param>
        /// <param name="x264opts"></param>
        /// <returns></returns>
        public static T X264Opts<T>(this T t, string x264opts) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-x264opts", x264opts);
        /// <summary>
        /// x264 options
        /// </summary>
        /// <param name="t"></param>
        /// <param name="x264opts"></param>
        /// <returns></returns>
        public static T X264Opts<T>(this T t, IReadOnlyDictionary<string, string> x264opts) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-x264opts", string.Join(":", x264opts.Select(pair => $"{pair.Key}={pair.Value}")));
        /// <summary>
        /// Select the quality for constant quality mode (from -1 to FLT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="crf"></param>
        /// <returns></returns>
        public static T Crf<T>(this T t, float crf) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-crf", crf, -1, float.MaxValue);
        /// <summary>
        /// In CRF mode, prevents VBV from lowering quality beyond this point. (from -1 to FLT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="crfMax"></param>
        /// <returns></returns>
        public static T CrfMax<T>(this T t, float crfMax) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-crf_max", crfMax, -1, float.MaxValue);
        /// <summary>
        /// Constant quantization parameter rate control method (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="qp"></param>
        /// <returns></returns>
        public static T QP<T>(this T t, int qp) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-qp", qp, -1, int.MaxValue);
        /// <summary>
        /// AQ method (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="aqMode"></param>
        /// <returns></returns>
        public static T AQMode<T>(this T t, Libx264_AqMode aqMode) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-aq-mode", (int)aqMode, -1, int.MaxValue);
        /// <summary>
        /// AQ strength. Reduces blocking and blurring in flat and textured areas. (from -1 to FLT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="aqStrength"></param>
        /// <returns></returns>
        public static T AQStrength<T>(this T t, float aqStrength) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-aq-strength", aqStrength, -1, float.MaxValue);
        /// <summary>
        /// Use psychovisual optimizations. (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T Psy<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-psy", flag.ToFFmpegFlag());
        /// <summary>
        /// Strength of psychovisual optimization, in &lt;psy-rd&gt;:&lt;psy-trellis&gt; format.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="psyRD"></param>
        /// <returns></returns>
        public static T PsyRD<T>(this T t, string psyRD) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-psy-rd", psyRD);
        /// <summary>
        /// Number of frames to look ahead for frametype and ratecontrol (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="rcLookahead"></param>
        /// <returns></returns>
        public static T RCLookahead<T>(this T t, int rcLookahead) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-rc-lookahead", rcLookahead, -1, int.MaxValue);
        /// <summary>
        /// Weighted prediction for B-frames. (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T WeightB<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-weightb", flag.ToFFmpegFlag());
        /// <summary>
        /// Weighted prediction analysis method. (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="weightP"></param>
        /// <returns></returns>
        public static T WeightP<T>(this T t, Libx264_WeightP weightP) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-weightp", (int)weightP, -1, int.MaxValue);
        /// <summary>
        /// Calculate and print SSIM stats. (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T SSIM<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-ssim", flag.ToFFmpegFlag());
        /// <summary>
        /// Use Periodic Intra Refresh instead of IDR frames. (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T IntraRefresh<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-intra-refresh", flag.ToFFmpegFlag());
        /// <summary>
        /// Bluray compatibility workarounds. (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T BlurayCompat<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-bluray-compat", flag.ToFFmpegFlag());
        /// <summary>
        /// Influences how often B-frames are used (from INT_MIN to INT_MAX) (default INT_MIN)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="bBias"></param>
        /// <returns></returns>
        public static T BBias<T>(this T t, int bBias) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-b-bias", bBias, int.MinValue, int.MaxValue);
        /// <summary>
        /// Keep some B-frames as references. (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="bPyramid"></param>
        /// <returns></returns>
        public static T BPyramid<T>(this T t, Libx264_BPyramid bPyramid) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-b-pyramid", (int)bPyramid, -1, int.MaxValue);
        /// <summary>
        /// One reference per partition, as opposed to one reference per macroblock (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T MixedRefs<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-mixed-refs", flag.ToFFmpegFlag());
        /// <summary>
        /// High profile 8x8 transform. (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T EightByEightDCT<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-8x8dct", flag.ToFFmpegFlag());
        /// <summary>
        /// (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T FastPSkip<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-fast-pskip", flag.ToFFmpegFlag());
        /// <summary>
        /// Use access unit delimiters. (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T AUD<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-aud", flag.ToFFmpegFlag());
        /// <summary>
        /// Use macroblock tree ratecontrol. (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T MBTree<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-mbtree", flag.ToFFmpegFlag());
        /// <summary>
        /// Loop filter parameters, in &lt;alpha:beta&gt; form.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="deblock"></param>
        /// <returns></returns>
        public static T Deblock<T>(this T t, string deblock) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-deblock", deblock);
        /// <summary>
        /// Reduce fluctuations in QP (before curve compression) (from -1 to FLT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="cplxBlur"></param>
        /// <returns></returns>
        public static T CPLXBlur<T>(this T t, float cplxBlur) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-cplxblur", cplxBlur, -1, float.MaxValue);
        /// <summary>
        /// A comma-separated list of partitions to consider. Possible values: p8x8, p4x4, b8x8, i8x8, i4x4, none, all
        /// </summary>
        /// <param name="t"></param>
        /// <param name="partitions"></param>
        /// <returns></returns>
        public static T Partitions<T>(this T t, params Libx264_Partitions[] partitions) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-partitions", string.Join(",", partitions.Select(x => x.ToString())));
        /// <summary>
        /// Direct MV prediction mode (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="directPred"></param>
        /// <returns></returns>
        public static T DirectPred<T>(this T t, Libx264_DirectPred directPred) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-direct-pred", (int)directPred, -1, int.MaxValue);
        /// <summary>
        /// Limit the size of each slice in bytes (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="sliceMaxSize"></param>
        /// <returns></returns>
        public static T SliceMaxSize<T>(this T t, int sliceMaxSize) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-slice-max-size", sliceMaxSize, -1, int.MaxValue);
        /// <summary>
        /// Filename for 2 pass stats
        /// </summary>
        /// <param name="t"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static T Stats<T>(this T t, string filename) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-stats", filename);
        /// <summary>
        /// Signal HRD information (requires vbv-bufsize; cbr not allowed in .mp4) (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="nalHrd"></param>
        /// <returns></returns>
        public static T NALHRD<T>(this T t, Libx264_NALHRD nalHrd) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-nal-hrd", (int)nalHrd, -1, int.MaxValue);
        /// <summary>
        /// AVC-Intra class 50/100/200/300/480 (from -1 to 480) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="avcIntraClass"></param>
        /// <returns></returns>
        public static T AVCIntraClass<T>(this T t, int avcIntraClass) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-avcintra-class", avcIntraClass, -1, 480);
        /// <summary>
        /// Set motion estimation method (from -1 to 4) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="meMethod"></param>
        /// <returns></returns>
        public static T ME_Method<T>(this T t, Libx264_MotionEstimationMethod meMethod) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-me_method", (int)meMethod, -1, 4);
        /// <summary>
        /// Set motion estimation method (from -1 to 4) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="motionEst"></param>
        /// <returns></returns>
        public static T MotionEst<T>(this T t, Libx264_MotionEstimationMethod motionEst) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-motion-est", (int)motionEst, -1, 4);
        /// <summary>
        /// If forcing keyframes, force them as IDR frames. (default false)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T ForcedIDR<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-forced-idr", flag.ToFFmpegFlag());
        /// <summary>
        /// Coder type (from -1 to 1) (default default)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="coder"></param>
        /// <returns></returns>
        public static T Coder<T>(this T t, Libx264_Coder coder) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-coder", (int)coder, -1, 1);
        /// <summary>
        /// Strategy to choose between I/P/B-frames (from -1 to 2) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="bStrategy"></param>
        /// <returns></returns>
        public static T BStrategy<T>(this T t, int bStrategy) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-b_strategy", bStrategy, -1, 2);
        /// <summary>
        /// QP difference between chroma and luma (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="chromaOffset"></param>
        /// <returns></returns>
        public static T ChromaOffset<T>(this T t, int chromaOffset) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-chromaoffset", chromaOffset, int.MinValue, int.MaxValue);
        /// <summary>
        /// Scene change threshold (from INT_MIN to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="scThreshold"></param>
        /// <returns></returns>
        public static T SCThreshold<T>(this T t, int scThreshold) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-sc_threshold", scThreshold, int.MinValue, int.MaxValue);
        /// <summary>
        /// Noise reduction (from INT_MIN to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="noiseReduction"></param>
        /// <returns></returns>
        public static T NoiseReduction<T>(this T t, int noiseReduction) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOptionRange("-noise_reduction", noiseReduction, int.MinValue, int.MaxValue);
        /// <summary>
        /// Use user data unregistered SEI if available (default false)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T UDU_SEI<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-udu_sei", flag.ToFFmpegFlag());
        /// <summary>
        /// Override the x264 configuration using a :-separated list of key=value parameters
        /// </summary>
        /// <param name="t"></param>
        /// <param name="x264Params"></param>
        /// <returns></returns>
        public static T X264Params<T>(this T t, string x264Params) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-x264-params", x264Params);
        /// <summary>
        /// Override the x264 configuration using a :-separated list of key=value parameters
        /// </summary>
        /// <param name="t"></param>
        /// <param name="x264Params"></param>
        /// <returns></returns>
        public static T X264Params<T>(this T t, IReadOnlyDictionary<string, string> x264Params) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-x264-params", string.Join(":", x264Params.Select(pair => $"{pair.Key}={pair.Value}")));
        /// <summary>
        /// Set mb_info data through AVSideData, only useful when used from the API (default false)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T MBInfo<T>(this T t, bool flag) where T : BaseImageCodecEncoder, IH264_libx264_Encoder
            => t.SetOption("-mb_info", flag.ToFFmpegFlag());
    }
}
