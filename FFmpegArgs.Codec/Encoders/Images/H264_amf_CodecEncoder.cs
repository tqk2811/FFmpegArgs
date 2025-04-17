/*h264_amf AVOptions:
  -usage             <int>        E..V....... Encoder Usage (from 0 to 5) (default transcoding)
     transcoding     0            E..V....... Generic Transcoding
     ultralowlatency 1            E..V....... ultra low latency trancoding
     lowlatency      2            E..V....... low latency trancoding
     webcam          3            E..V....... Webcam
     high_quality    4            E..V....... high quality trancoding
     lowlatency_high_quality 5            E..V....... low latency yet high quality trancoding
  -profile           <int>        E..V....... Profile (from 66 to 257) (default main)
     main            77           E..V....... 
     high            100          E..V....... 
     constrained_baseline 256          E..V....... 
     constrained_high 257          E..V....... 
  -level             <int>        E..V....... Profile Level (from 0 to 62) (default auto)
     auto            0            E..V....... 
     1.0             10           E..V....... 
     1.1             11           E..V....... 
     1.2             12           E..V....... 
     1.3             13           E..V....... 
     2.0             20           E..V....... 
     2.1             21           E..V....... 
     2.2             22           E..V....... 
     3.0             30           E..V....... 
     3.1             31           E..V....... 
     3.2             32           E..V....... 
     4.0             40           E..V....... 
     4.1             41           E..V....... 
     4.2             42           E..V....... 
     5.0             50           E..V....... 
     5.1             51           E..V....... 
     5.2             52           E..V....... 
     6.0             60           E..V....... 
     6.1             61           E..V....... 
     6.2             62           E..V....... 
  -quality           <int>        E..V....... Quality Preference (from 0 to 2) (default speed)
     speed           1            E..V....... Prefer Speed
     balanced        0            E..V....... Balanced
     quality         2            E..V....... Prefer Quality
  -rc                <int>        E..V....... Rate Control Method (from -1 to 6) (default -1)
     cqp             0            E..V....... Constant Quantization Parameter
     cbr             1            E..V....... Constant Bitrate
     vbr_peak        2            E..V....... Peak Contrained Variable Bitrate
     vbr_latency     3            E..V....... Latency Constrained Variable Bitrate
     qvbr            4            E..V....... Quality Variable Bitrate
     hqvbr           5            E..V....... High Quality Variable Bitrate
     hqcbr           6            E..V....... High Quality Constant Bitrate
  -qvbr_quality_level <int>        E..V....... Sets the QVBR quality level (from -1 to 51) (default -1)
  -enforce_hrd       <boolean>    E..V....... Enforce HRD (default false)
  -filler_data       <boolean>    E..V....... Filler Data Enable (default false)
  -vbaq              <boolean>    E..V....... Enable VBAQ (default false)
  -frame_skipping    <boolean>    E..V....... Rate Control Based Frame Skip (default false)
  -qp_i              <int>        E..V....... Quantization Parameter for I-Frame (from -1 to 51) (default -1)
  -qp_p              <int>        E..V....... Quantization Parameter for P-Frame (from -1 to 51) (default -1)
  -qp_b              <int>        E..V....... Quantization Parameter for B-Frame (from -1 to 51) (default -1)
  -preencode         <boolean>    E..V....... Pre-encode assisted rate control (default false)
  -max_au_size       <int>        E..V....... Maximum Access Unit Size for rate control (in bits) (from 0 to INT_MAX) (default 0)
  -header_spacing    <int>        E..V....... Header Insertion Spacing (from -1 to 1000) (default -1)
  -bf_delta_qp       <int>        E..V....... B-Picture Delta QP (from -10 to 10) (default 4)
  -bf_ref            <boolean>    E..V....... Enable Reference to B-Frames (default true)
  -bf_ref_delta_qp   <int>        E..V....... Reference B-Picture Delta QP (from -10 to 10) (default 4)
  -max_b_frames      <int>        E..V....... Maximum number of consecutive B Pictures (from -1 to 3) (default -1)
  -bf                <int>        E..V....... B Picture Pattern (from -1 to 3) (default -1)
  -intra_refresh_mb  <int>        E..V....... Intra Refresh MBs Number Per Slot in Macroblocks (from 0 to INT_MAX) (default 0)
  -coder             <int>        E..V....... Coding Type (from 0 to 2) (default auto)
     auto            0            E..V....... Automatic
     cavlc           2            E..V....... Context Adaptive Variable-Length Coding
     cabac           1            E..V....... Context Adaptive Binary Arithmetic Coding
  -high_motion_quality_boost_enable <boolean>    E..V....... Enable High motion quality boost mode (default auto)
  -me_half_pel       <boolean>    E..V....... Enable ME Half Pixel (default true)
  -me_quarter_pel    <boolean>    E..V....... Enable ME Quarter Pixel (default true)
  -aud               <boolean>    E..V....... Inserts AU Delimiter NAL unit (default false)
  -log_to_dbg        <boolean>    E..V....... Enable AMF logging to debug output (default false)
  -preanalysis       <boolean>    E..V....... Enable preanalysis (default auto)
  -pa_activity_type  <int>        E..V....... Set the type of activity analysis (from -1 to 1) (default -1)
     y               0            E..V....... activity y
     yuv             1            E..V....... activity yuv
  -pa_scene_change_detection_enable <boolean>    E..V....... Enable scene change detection (default auto)
  -pa_scene_change_detection_sensitivity <int>        E..V....... Set the sensitivity of scene change detection (from -1 to 2) (default -1)
     low             0            E..V....... low scene change dectection sensitivity
     medium          1            E..V....... medium scene change dectection sensitivity
     high            2            E..V....... high scene change dectection sensitivity
  -pa_static_scene_detection_enable <boolean>    E..V....... Enable static scene detection (default auto)
  -pa_static_scene_detection_sensitivity <int>        E..V....... Set the sensitivity of static scene detection (from -1 to 2) (default -1)
     low             0            E..V....... low static scene dectection sensitivity
     medium          1            E..V....... medium static scene dectection sensitivity
     high            2            E..V....... high static scene dectection sensitivity
  -pa_initial_qp_after_scene_change <int>        E..V....... The QP value that is used immediately after a scene change (from -1 to 51) (default -1)
  -pa_max_qp_before_force_skip <int>        E..V....... The QP threshold to allow a skip frame (from -1 to 51) (default -1)
  -pa_caq_strength   <int>        E..V....... Content Adaptive Quantization strength (from -1 to 2) (default -1)
     low             0            E..V....... low Content Adaptive Quantization strength
     medium          1            E..V....... medium Content Adaptive Quantization strength
     high            2            E..V....... high Content Adaptive Quantization strength
  -pa_frame_sad_enable <boolean>    E..V....... Enable Frame SAD algorithm (default auto)
  -pa_ltr_enable     <boolean>    E..V....... Enable long term reference frame management (default auto)
  -pa_lookahead_buffer_depth <int>        E..V....... Sets the PA lookahead buffer size (from -1 to 41) (default -1)
  -pa_paq_mode       <int>        E..V....... Sets the perceptual adaptive quantization mode (from -1 to 1) (default -1)
     none            0            E..V....... no perceptual adaptive quantization
     caq             1            E..V....... caq perceptual adaptive quantization
  -pa_taq_mode       <int>        E..V....... Sets the temporal adaptive quantization mode (from -1 to 2) (default -1)
     none            0            E..V....... no temporal adaptive quantization
     1               1            E..V....... temporal adaptive quantization mode 1
     2               2            E..V....... temporal adaptive quantization mode 2
  -pa_high_motion_quality_boost_mode <int>        E..V....... Sets the PA high motion quality boost mode (from -1 to 1) (default -1)
     none            0            E..V....... no high motion quality boost
     auto            1            E..V....... auto high motion quality boost
  -pa_adaptive_mini_gop <boolean>    E..V....... Enable Adaptive MiniGOP (default auto)
*/
namespace FFmpegArgs.Codec.Encoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public class H264_amf_CodecEncoder : BaseImageCodecEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public H264_amf_CodecEncoder(ImageOutputAVStream stream) : base("h264_amf", stream)
        {
        }


        /// <summary>
        /// Encoder Usage (from 0 to 5) (default transcoding)
        /// </summary>
        /// <param name="usage"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder Usage(H264_amf_Usage usage)
            => this.SetOptionRange("-usage", (int)usage, 0, 5);

        /// <summary>
        /// Profile (from 66 to 257) (default main)
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder Profile(H264_amf_Profile profile)
            => this.SetOptionRange("-profile", (int)profile, 66, 257);

        /// <summary>
        /// Profile Level (from 0 to 62) (default auto)
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder Level(H264_amf_Level level)
            => this.SetOptionRange("-level", (int)level, 0, 62);

        /// <summary>
        /// Quality Preference (from 0 to 2) (default speed)
        /// </summary>
        /// <param name="quality"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder Quality(H264_amf_Quality quality)
            => this.SetOptionRange("-quality", (int)quality, 0, 2);

        /// <summary>
        /// Rate Control Method (from -1 to 6) (default -1)
        /// </summary>
        /// <param name="rateControl"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder RateControl(H264_amf_RateControl rateControl)
            => this.SetOptionRange("-rc", (int)rateControl, -1, 6);

        /// <summary>
        /// Sets the QVBR quality level (from -1 to 51) (default -1)
        /// </summary>
        /// <param name="quality"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder QVBRQualityLevel(int quality)
            => this.SetOptionRange("-qvbr_quality_level", quality, -1, 51);

        /// <summary>
        /// Enforce HRD (default false)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder EnforceHRD(bool flag)
            => this.SetOption("-enforce_hrd", flag.ToFFmpegFlag());

        /// <summary>
        /// Filler Data Enable (default false)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder FillerData(bool flag)
            => this.SetOption("-filler_data", flag.ToFFmpegFlag());

        /// <summary>
        /// Enable VBAQ (default false)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder VBAQ(bool flag)
            => this.SetOption("-vbaq", flag.ToFFmpegFlag());

        /// <summary>
        /// Rate Control Based Frame Skip (default false)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder FrameSkipping(bool flag)
            => this.SetOption("-frame_skipping", flag.ToFFmpegFlag());

        /// <summary>
        /// Quantization Parameter for I-Frame (from -1 to 51) (default -1)
        /// </summary>
        /// <param name="qp"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder QPI(int qp)
            => this.SetOptionRange("-qp_i", qp, -1, 51);

        /// <summary>
        /// Quantization Parameter for P-Frame (from -1 to 51) (default -1)
        /// </summary>
        /// <param name="qp"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder QPP(int qp)
            => this.SetOptionRange("-qp_p", qp, -1, 51);

        /// <summary>
        /// Quantization Parameter for B-Frame (from -1 to 51) (default -1)
        /// </summary>
        /// <param name="qp"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder QPB(int qp)
            => this.SetOptionRange("-qp_b", qp, -1, 51);

        /// <summary>
        /// Pre-encode assisted rate control (default false)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder Preencode(bool flag)
            => this.SetOption("-preencode", flag.ToFFmpegFlag());

        /// <summary>
        /// Maximum Access Unit Size for rate control (in bits) (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder MaxAUSize(int size)
            => this.SetOptionRange("-max_au_size", size, 0, INT_MAX);

        /// <summary>
        /// Header Insertion Spacing (from -1 to 1000) (default -1)
        /// </summary>
        /// <param name="spacing"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder HeaderSpacing(int spacing)
            => this.SetOptionRange("-header_spacing", spacing, -1, 1000);

        /// <summary>
        /// B-Picture Delta QP (from -10 to 10) (default 4)
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder BfDeltaQP(int delta)
            => this.SetOptionRange("-bf_delta_qp", delta, -10, 10);

        /// <summary>
        /// Enable Reference to B-Frames (default true)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder BfRef(bool flag)
            => this.SetOption("-bf_ref", flag.ToFFmpegFlag());

        /// <summary>
        /// Reference B-Picture Delta QP (from -10 to 10) (default 4)
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder BfRefDeltaQP(int delta)
            => this.SetOptionRange("-bf_ref_delta_qp", delta, -10, 10);

        /// <summary>
        /// Maximum number of consecutive B Pictures (from -1 to 3) (default -1)
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder MaxBFrames(int max)
            => this.SetOptionRange("-max_b_frames", max, -1, 3);

        /// <summary>
        /// B Picture Pattern (from -1 to 3) (default -1)
        /// </summary>
        /// <param name="bf"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder Bf(int bf)
            => this.SetOptionRange("-bf", bf, -1, 3);

        /// <summary>
        /// Intra Refresh MBs Number Per Slot in Macroblocks (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="mb"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder IntraRefreshMB(int mb)
            => this.SetOptionRange("-intra_refresh_mb", mb, 0, INT_MAX);

        /// <summary>
        /// Coding Type (from 0 to 2) (default auto)
        /// </summary>
        /// <param name="coder"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder Coder(H264_amf_Coder coder)
            => this.SetOptionRange("-coder", (int)coder, 0, 2);

        /// <summary>
        /// Enable High motion quality boost mode (default auto)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder HighMotionQualityBoostEnable(bool flag)
            => this.SetOption("-high_motion_quality_boost_enable", flag.ToFFmpegFlag());

        /// <summary>
        /// Enable ME Half Pixel (default true)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder MEHalfPel(bool flag)
            => this.SetOption("-me_half_pel", flag.ToFFmpegFlag());

        /// <summary>
        /// Enable ME Quarter Pixel (default true)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder MEQuarterPel(bool flag)
            => this.SetOption("-me_quarter_pel", flag.ToFFmpegFlag());

        /// <summary>
        /// Inserts AU Delimiter NAL unit (default false)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder AUD(bool flag)
            => this.SetOption("-aud", flag.ToFFmpegFlag());

        /// <summary>
        /// Enable AMF logging to debug output (default false)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder LogToDbg(bool flag)
            => this.SetOption("-log_to_dbg", flag.ToFFmpegFlag());

        /// <summary>
        /// Enable preanalysis (default auto)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder Preanalysis(bool flag)
            => this.SetOption("-preanalysis", flag.ToFFmpegFlag());

        /// <summary>
        /// Set the type of activity analysis (from -1 to 1) (default -1)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PAActivityType(H264_amf_PaActivityType type)
            => this.SetOptionRange("-pa_activity_type", (int)type, -1, 1);

        /// <summary>
        /// Enable scene change detection (default auto)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PASceneChangeDetectionEnable(bool flag)
            => this.SetOption("-pa_scene_change_detection_enable", flag.ToFFmpegFlag());

        /// <summary>
        /// Set the sensitivity of scene change detection (from -1 to 2) (default -1)
        /// </summary>
        /// <param name="sensitivity"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PASceneChangeDetectionSensitivity(H264_amf_Sensitivity sensitivity)
            => this.SetOptionRange("-pa_scene_change_detection_sensitivity", (int)sensitivity, -1, 2);

        /// <summary>
        ///  Enable static scene detection (default auto)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PAStaticSceneDetectionEnable(bool flag)
            => this.SetOption("-pa_static_scene_detection_enable", flag.ToFFmpegFlag());

        /// <summary>
        /// Set the sensitivity of static scene detection (from -1 to 2) (default -1)
        /// </summary>
        /// <param name="sensitivity"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PAStaticSceneDetectionSensitivity(H264_amf_Sensitivity sensitivity)
            => this.SetOptionRange("-pa_static_scene_detection_sensitivity", (int)sensitivity, -1, 2);

        /// <summary>
        /// The QP value that is used immediately after a scene change (from -1 to 51) (default -1)
        /// </summary>
        /// <param name="qp"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PAInitialQPAfterSceneChange(int qp)
            => this.SetOptionRange("-pa_initial_qp_after_scene_change", qp, -1, 51);

        /// <summary>
        /// The QP threshold to allow a skip frame (from -1 to 51) (default -1)
        /// </summary>
        /// <param name="qp"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PAMaxQPBeforeForceSkip(int qp)
            => this.SetOptionRange("-pa_max_qp_before_force_skip", qp, -1, 51);

        /// <summary>
        /// Content Adaptive Quantization strength (from -1 to 2) (default -1)
        /// </summary>
        /// <param name="strength"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PACaqStrength(H264_amf_Sensitivity strength)
            => this.SetOptionRange("-pa_caq_strength", (int)strength, -1, 2);

        /// <summary>
        /// Enable Frame SAD algorithm (default auto)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PAFrameSADEnable(bool flag)
            => this.SetOption("-pa_frame_sad_enable", flag.ToFFmpegFlag());

        /// <summary>
        /// Enable long term reference frame management (default auto)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PALTREnable(bool flag)
            => this.SetOption("-pa_ltr_enable", flag.ToFFmpegFlag());

        /// <summary>
        /// Sets the PA lookahead buffer size (from -1 to 41) (default -1)
        /// </summary>
        /// <param name="depth"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PALookaheadBufferDepth(int depth)
            => this.SetOptionRange("-pa_lookahead_buffer_depth", depth, -1, 41);

        /// <summary>
        /// Sets the perceptual adaptive quantization mode (from -1 to 1) (default -1)
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PAPaqMode(H264_amf_PaqMode mode)
            => this.SetOptionRange("-pa_paq_mode", (int)mode, -1, 1);

        /// <summary>
        /// Sets the temporal adaptive quantization mode (from -1 to 2) (default -1)
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PATaqMode(H264_amf_TaqMode mode)
            => this.SetOptionRange("-pa_taq_mode", (int)mode, -1, 2);

        /// <summary>
        /// Sets the PA high motion quality boost mode (from -1 to 1) (default -1)
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PAHighMotionQualityBoostMode(H264_amf_HighMotionQualityBoostMode mode)
            => this.SetOptionRange("-pa_high_motion_quality_boost_mode", (int)mode, -1, 1);

        /// <summary>
        /// Enable Adaptive MiniGOP (default auto)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_amf_CodecEncoder PAAdaptiveMiniGOP(bool flag)
            => this.SetOption("-pa_adaptive_mini_gop", flag.ToFFmpegFlag());

    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum H264_amf_Usage
    {
        /// <summary>
        /// Generic Transcoding
        /// </summary>
        transcoding = 0,
        /// <summary>
        /// ultra low latency trancoding
        /// </summary>
        ultralowlatency = 1,
        /// <summary>
        /// low latency trancoding
        /// </summary>
        lowlatency = 2,
        /// <summary>
        /// Webcam
        /// </summary>
        webcam = 3,
        /// <summary>
        /// high quality trancoding
        /// </summary>
        high_quality = 4,
        /// <summary>
        /// low latency yet high quality trancoding
        /// </summary>
        lowlatency_high_quality = 5,
    }
    public enum H264_amf_Profile
    {
        main = 77,
        high = 100,
        constrained_baseline = 256,
        constrained_high = 257,
    }
    public enum H264_amf_Level
    {
        auto = 0,

        level_1_0 = 10,
        level_1_1 = 11,
        level_1_2 = 12,
        level_1_3 = 13,

        level_2_0 = 20,
        level_2_1 = 21,
        level_2_2 = 22,

        level_3_0 = 30,
        level_3_1 = 31,
        level_3_2 = 32,

        level_4_0 = 40,
        level_4_1 = 41,
        level_4_2 = 42,

        level_5_0 = 50,
        level_5_1 = 51,
        level_5_2 = 52,

        level_6_0 = 60,
        level_6_1 = 61,
        level_6_2 = 62,
    }
    public enum H264_amf_Quality
    {
        speed = 1,
        balanced = 0,
        quality = 2,
    }
    public enum H264_amf_RateControl
    {
        /// <summary>
        /// Constant Quantization Parameter
        /// </summary>
        cqp = 0,
        /// <summary>
        /// Constant Bitrate
        /// </summary>
        cbr = 1,
        /// <summary>
        /// Peak Contrained Variable Bitrate
        /// </summary>
        vbr_peak = 2,
        /// <summary>
        /// Latency Constrained Variable Bitrate
        /// </summary>
        vbr_latency = 3,
        /// <summary>
        /// Quality Variable Bitrate
        /// </summary>
        qvbr = 4,
    }
    public enum H264_amf_Coder
    {
        /// <summary>
        /// Automatic
        /// </summary>
        auto = 0,
        /// <summary>
        /// Context Adaptive Binary Arithmetic Coding
        /// </summary>
        cabac = 1,
        /// <summary>
        /// Context Adaptive Variable-Length Coding
        /// </summary>
        cavlc = 2,
    }
    public enum H264_amf_PaActivityType
    {
        /// <summary>
        /// activity y
        /// </summary>
        y = 0,
        /// <summary>
        /// activity yuv
        /// </summary>
        yuv = 1,
    }
    public enum H264_amf_Sensitivity
    {
        low = 0,
        medium = 1,
        high = 2,
    }
    public enum H264_amf_PaqMode
    {
        /// <summary>
        /// no perceptual adaptive quantization
        /// </summary>
        none = 0,
        /// <summary>
        /// caq perceptual adaptive quantization
        /// </summary>
        caq = 1,
    }
    public enum H264_amf_TaqMode
    {
        /// <summary>
        /// no temporal adaptive quantization
        /// </summary>
        none = 0,
        /// <summary>
        /// temporal adaptive quantization mode 1
        /// </summary>
        mode_1 = 1,
        /// <summary>
        /// temporal adaptive quantization mode 2
        /// </summary>
        mode_2 = 2,
    }
    public enum H264_amf_HighMotionQualityBoostMode
    {
        /// <summary>
        /// no high motion quality boost
        /// </summary>
        none = 0,
        /// <summary>
        /// auto high motion quality boost
        /// </summary>
        auto = 1,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    public static partial class ImageEncoderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static H264_amf_CodecEncoder H264_amf_Codec(this ImageOutputAVStream stream)
            => new H264_amf_CodecEncoder(stream);
    }
}
