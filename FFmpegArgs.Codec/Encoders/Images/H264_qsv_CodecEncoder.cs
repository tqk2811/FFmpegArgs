/*h264_qsv encoder AVOptions:
  -async_depth       <int>        E..V....... Maximum processing parallelism (from 1 to INT_MAX) (default 4)
  -preset            <int>        E..V....... (from 0 to 7) (default 0)
     veryfast        7            E..V.......
     faster          6            E..V.......
     fast            5            E..V.......
     medium          4            E..V.......
     slow            3            E..V.......
     slower          2            E..V.......
     veryslow        1            E..V.......
  -forced_idr        <boolean>    E..V....... Forcing I frames as IDR frames (default false)
  -low_power         <boolean>    E..V....... enable low power mode(experimental: many limitations by mfx version, BRC modes, etc.) (default auto)
  -rdo               <int>        E..V....... Enable rate distortion optimization (from -1 to 1) (default -1)
  -max_frame_size    <int>        E..V....... Maximum encoded frame size in bytes (from -1 to INT_MAX) (default -1)
  -max_frame_size_i  <int>        E..V....... Maximum encoded I frame size in bytes (from -1 to INT_MAX) (default -1)
  -max_frame_size_p  <int>        E..V....... Maximum encoded P frame size in bytes (from -1 to INT_MAX) (default -1)
  -max_slice_size    <int>        E..V....... Maximum encoded slice size in bytes (from -1 to INT_MAX) (default -1)
  -bitrate_limit     <int>        E..V....... Toggle bitrate limitations (from -1 to 1) (default -1)
  -mbbrc             <int>        E..V....... MB level bitrate control (from -1 to 1) (default -1)
  -extbrc            <int>        E..V....... Extended bitrate control (from -1 to 1) (default -1)
  -adaptive_i        <int>        E..V....... Adaptive I-frame placement (from -1 to 1) (default -1)
  -adaptive_b        <int>        E..V....... Adaptive B-frame placement (from -1 to 1) (default -1)
  -p_strategy        <int>        E..V....... Enable P-pyramid: 0-default 1-simple 2-pyramid(bf need to be set to 0). (from 0 to 2) (default 0)
  -b_strategy        <int>        E..V....... Strategy to choose between I/P/B-frames (from -1 to 1) (default -1)
  -dblk_idc          <int>        E..V....... This option disable deblocking. It has value in range 0~2. (from 0 to 2) (default 0)
  -low_delay_brc     <boolean>    E..V....... Allow to strictly obey avg frame size (default auto)
  -max_qp_i          <int>        E..V....... Maximum video quantizer scale for I frame (from -1 to 51) (default -1)
  -min_qp_i          <int>        E..V....... Minimum video quantizer scale for I frame (from -1 to 51) (default -1)
  -max_qp_p          <int>        E..V....... Maximum video quantizer scale for P frame (from -1 to 51) (default -1)
  -min_qp_p          <int>        E..V....... Minimum video quantizer scale for P frame (from -1 to 51) (default -1)
  -max_qp_b          <int>        E..V....... Maximum video quantizer scale for B frame (from -1 to 51) (default -1)
  -min_qp_b          <int>        E..V....... Minimum video quantizer scale for B frame (from -1 to 51) (default -1)
  -scenario          <int>        E..V....... A hint to encoder about the scenario for the encoding session (from 0 to 8) (default unknown)
     unknown         0            E..V.......
     displayremoting 1            E..V.......
     videoconference 2            E..V.......
     archive         3            E..V.......
     livestreaming   4            E..V.......
     cameracapture   5            E..V.......
     videosurveillance 6            E..V.......
     gamestreaming   7            E..V.......
     remotegaming    8            E..V.......
  -avbr_accuracy     <int>        E..V....... Accuracy of the AVBR ratecontrol (unit of tenth of percent) (from 0 to 65535) (default 0)
  -avbr_convergence  <int>        E..V....... Convergence of the AVBR ratecontrol (unit of 100 frames) (from 0 to 65535) (default 0)
  -skip_frame        <int>        E..V....... Allow frame skipping (from 0 to 3) (default no_skip)
     no_skip         0            E..V....... Frame skipping is disabled
     insert_dummy    1            E..V....... Encoder inserts into bitstream frame where all macroblocks are encoded as skipped
     insert_nothing  2            E..V....... Encoder inserts nothing into bitstream
     brc_only        3            E..V....... skip_frame metadata indicates the number of missed frames before the current frame
  -dual_gfx          <int>        E..V....... Prefer processing on both iGfx and dGfx simultaneously (from 0 to 2) (default off)
     off             0            E..V....... Disable HyperEncode mode
     on              1            E..V....... Enable HyperEncode mode and return error if incompatible parameters during initialization
     adaptive        2            E..V....... Enable HyperEncode mode or fallback to single GPU if incompatible parameters during initialization
  -cavlc             <boolean>    E..V....... Enable CAVLC (default false)
  -vcm               <boolean>    E..V....... Use the video conferencing mode ratecontrol (default false)
  -idr_interval      <int>        E..V....... Distance (in I-frames) between IDR frames (from 0 to INT_MAX) (default 0)
  -pic_timing_sei    <boolean>    E..V....... Insert picture timing SEI with pic_struct_syntax element (default true)
  -single_sei_nal_unit <int>        E..V....... Put all the SEI messages into one NALU (from -1 to 1) (default -1)
  -max_dec_frame_buffering <int>        E..V....... Maximum number of frames buffered in the DPB (from 0 to 65535) (default 0)
  -look_ahead        <boolean>    E..V....... Use VBR algorithm with look ahead (default false)
  -look_ahead_depth  <int>        E..V....... Depth of look ahead in number frames (from 0 to 100) (default 0)
  -look_ahead_downsampling <int>        E..V....... Downscaling factor for the frames saved for the lookahead analysis (from 0 to 3) (default unknown)
     unknown         0            E..V.......
     auto            0            E..V.......
     off             1            E..V.......
     2x              2            E..V.......
     4x              3            E..V.......
  -int_ref_type      <int>        E..V....... Intra refresh type. B frames should be set to 0. (from -1 to 65535) (default -1)
     none            0            E..V.......
     vertical        1            E..V.......
     horizontal      2            E..V.......
     slice           3            E..V.......
  -int_ref_cycle_size <int>        E..V....... Number of frames in the intra refresh cycle (from -1 to 65535) (default -1)
  -int_ref_qp_delta  <int>        E..V....... QP difference for the refresh MBs (from -32768 to 32767) (default -32768)
  -recovery_point_sei <int>        E..V....... Insert recovery point SEI messages (from -1 to 1) (default -1)
  -int_ref_cycle_dist <int>        E..V....... Distance between the beginnings of the intra-refresh cycles in frames (from -1 to 32767) (default -1)
  -profile           <int>        E..V....... (from 0 to INT_MAX) (default unknown)
     unknown         0            E..V.......
     baseline        66           E..V.......
     main            77           E..V.......
     high            100          E..V.......
  -a53cc             <boolean>    E..V....... Use A53 Closed Captions (if available) (default true)
  -aud               <boolean>    E..V....... Insert the Access Unit Delimiter NAL (default false)
  -repeat_pps        <boolean>    E..V....... repeat pps for every frame (default false)
*/
namespace FFmpegArgs.Codec.Encoders.Images
{
    //chatgpt generated
    /// <summary>
    /// 
    /// </summary>
    public class H264_qsv_CodecEncoder : BaseImageCodecEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        public H264_qsv_CodecEncoder(ImageOutputAVStream stream) : base("h264_qsv", stream) { }

        /// <summary>Maximum processing parallelism (from 1 to INT_MAX) (default 4)</summary>
        public H264_qsv_CodecEncoder AsyncDepth(int depth) => this.SetOptionRange("-async_depth", depth, 1, int.MaxValue);

        /// <summary>Encoding preset (from 0 to 7) (default 0)</summary>
        public H264_qsv_CodecEncoder Preset(H264_qsv_Preset preset) => this.SetOptionRange("-preset", (int)preset, 0, 7);

        /// <summary>Forcing I frames as IDR frames (default false)</summary>
        public H264_qsv_CodecEncoder ForcedIdr(bool value) => this.SetOption("-forced_idr", value.ToFFmpegFlag());

        /// <summary>Enable low power mode(experimental: many limitations by mfx version, BRC modes, etc.) (default auto)</summary>
        public H264_qsv_CodecEncoder LowPower(bool value) => this.SetOption("-low_power", value.ToFFmpegFlag());

        /// <summary>Enable rate distortion optimization (from -1 to 1) (default -1)</summary>
        public H264_qsv_CodecEncoder Rdo(int value) => this.SetOptionRange("-rdo", value, -1, 1);

        /// <summary>Maximum encoded frame size in bytes (from -1 to INT_MAX) (default -1)</summary>
        public H264_qsv_CodecEncoder MaxFrameSize(int value) => this.SetOptionRange("-max_frame_size", value, -1, int.MaxValue);

        /// <summary>Maximum encoded I frame size in bytes (from -1 to INT_MAX) (default -1)</summary>
        public H264_qsv_CodecEncoder MaxFrameSizeI(int value) => this.SetOptionRange("-max_frame_size_i", value, -1, int.MaxValue);

        /// <summary>Maximum encoded P frame size in bytes (from -1 to INT_MAX) (default -1)</summary>
        public H264_qsv_CodecEncoder MaxFrameSizeP(int value) => this.SetOptionRange("-max_frame_size_p", value, -1, int.MaxValue);

        /// <summary>Maximum encoded slice size in bytes (from -1 to INT_MAX) (default -1)</summary>
        public H264_qsv_CodecEncoder MaxSliceSize(int value) => this.SetOptionRange("-max_slice_size", value, -1, int.MaxValue);

        /// <summary>Toggle bitrate limitations (from -1 to 1) (default -1)</summary>
        public H264_qsv_CodecEncoder BitrateLimit(int value) => this.SetOptionRange("-bitrate_limit", value, -1, 1);

        /// <summary>MB level bitrate control (from -1 to 1) (default -1)</summary>
        public H264_qsv_CodecEncoder Mbbrc(int value) => this.SetOptionRange("-mbbrc", value, -1, 1);

        /// <summary>Extended bitrate control (from -1 to 1) (default -1)</summary>
        public H264_qsv_CodecEncoder Extbrc(int value) => this.SetOptionRange("-extbrc", value, -1, 1);

        /// <summary>Adaptive I-frame placement (from -1 to 1) (default -1)</summary>
        public H264_qsv_CodecEncoder AdaptiveI(int value) => this.SetOptionRange("-adaptive_i", value, -1, 1);

        /// <summary>Adaptive B-frame placement (from -1 to 1) (default -1)</summary>
        public H264_qsv_CodecEncoder AdaptiveB(int value) => this.SetOptionRange("-adaptive_b", value, -1, 1);

        /// <summary>Enable P-pyramid: 0-default 1-simple 2-pyramid(bf need to be set to 0). (from 0 to 2) (default 0)</summary>
        public H264_qsv_CodecEncoder PStrategy(int value) => this.SetOptionRange("-p_strategy", value, 0, 2);

        /// <summary>Strategy to choose between I/P/B-frames (from -1 to 1) (default -1)</summary>
        public H264_qsv_CodecEncoder BStrategy(int value) => this.SetOptionRange("-b_strategy", value, -1, 1);

        /// <summary>This option disable deblocking. It has value in range 0~2. (from 0 to 2) (default 0)</summary>
        public H264_qsv_CodecEncoder DblkIdc(int value) => this.SetOptionRange("-dblk_idc", value, 0, 2);

        /// <summary>Allow to strictly obey avg frame size (default auto)</summary>
        public H264_qsv_CodecEncoder LowDelayBrc(bool value) => this.SetOption("-low_delay_brc", value.ToFFmpegFlag());

        /// <summary>Maximum video quantizer scale for I frame (from -1 to 51) (default -1)</summary>
        public H264_qsv_CodecEncoder MaxQpI(int value) => this.SetOptionRange("-max_qp_i", value, -1, 51);

        /// <summary>Minimum video quantizer scale for I frame (from -1 to 51) (default -1)</summary>
        public H264_qsv_CodecEncoder MinQpI(int value) => this.SetOptionRange("-min_qp_i", value, -1, 51);

        /// <summary>Maximum video quantizer scale for P frame (from -1 to 51) (default -1)</summary>
        public H264_qsv_CodecEncoder MaxQpP(int value) => this.SetOptionRange("-max_qp_p", value, -1, 51);

        /// <summary>Minimum video quantizer scale for P frame (from -1 to 51) (default -1)</summary>
        public H264_qsv_CodecEncoder MinQpP(int value) => this.SetOptionRange("-min_qp_p", value, -1, 51);

        /// <summary>Maximum video quantizer scale for B frame (from -1 to 51) (default -1)</summary>
        public H264_qsv_CodecEncoder MaxQpB(int value) => this.SetOptionRange("-max_qp_b", value, -1, 51);

        /// <summary>Minimum video quantizer scale for B frame (from -1 to 51) (default -1)</summary>
        public H264_qsv_CodecEncoder MinQpB(int value) => this.SetOptionRange("-min_qp_b", value, -1, 51);

        /// <summary>A hint to encoder about the scenario for the encoding session (from 0 to 8) (default unknown)</summary>
        public H264_qsv_CodecEncoder Scenario(H264_qsv_Scenario scenario) => this.SetOptionRange("-scenario", (int)scenario, 0, 8);

        /// <summary>Accuracy of the AVBR ratecontrol (unit of tenth of percent) (from 0 to 65535) (default 0)</summary>
        public H264_qsv_CodecEncoder AvbrAccuracy(int value) => this.SetOptionRange("-avbr_accuracy", value, 0, 65535);

        /// <summary>Convergence of the AVBR ratecontrol (unit of 100 frames) (from 0 to 65535) (default 0)</summary>
        public H264_qsv_CodecEncoder AvbrConvergence(int value) => this.SetOptionRange("-avbr_convergence", value, 0, 65535);

        /// <summary>Allow frame skipping (from 0 to 3) (default no_skip)</summary>
        public H264_qsv_CodecEncoder SkipFrame(H264_qsv_SkipFrame skipFrame) => this.SetOptionRange("-skip_frame", (int)skipFrame, 0, 3);

        /// <summary>Prefer processing on both iGfx and dGfx simultaneously (from 0 to 2) (default off)</summary>
        public H264_qsv_CodecEncoder DualGfx(H264_qsv_DualGfx mode) => this.SetOptionRange("-dual_gfx", (int)mode, 0, 2);

        /// <summary>Enable CAVLC (default false)</summary>
        public H264_qsv_CodecEncoder Cavlc(bool value) => this.SetOption("-cavlc", value.ToFFmpegFlag());

        /// <summary>Use the video conferencing mode ratecontrol (default false)</summary>
        public H264_qsv_CodecEncoder Vcm(bool value) => this.SetOption("-vcm", value.ToFFmpegFlag());

        /// <summary>Distance (in I-frames) between IDR frames (from 0 to INT_MAX) (default 0)</summary>
        public H264_qsv_CodecEncoder IdrInterval(int value) => this.SetOptionRange("-idr_interval", value, 0, int.MaxValue);

        /// <summary>Insert picture timing SEI with pic_struct_syntax element (default true)</summary>
        public H264_qsv_CodecEncoder PicTimingSei(bool value) => this.SetOption("-pic_timing_sei", value.ToFFmpegFlag());

        /// <summary>Put all the SEI messages into one NALU (from -1 to 1) (default -1)</summary>
        public H264_qsv_CodecEncoder SingleSeiNalUnit(int value) => this.SetOptionRange("-single_sei_nal_unit", value, -1, 1);

        /// <summary>Maximum number of frames buffered in the DPB (from 0 to 65535) (default 0)</summary>
        public H264_qsv_CodecEncoder MaxDecFrameBuffering(int value) => this.SetOptionRange("-max_dec_frame_buffering", value, 0, 65535);

        /// <summary>Use VBR algorithm with look ahead (default false)</summary>
        public H264_qsv_CodecEncoder LookAhead(bool value) => this.SetOption("-look_ahead", value.ToFFmpegFlag());

        /// <summary>Depth of look ahead in number frames (from 0 to 100) (default 0)</summary>
        public H264_qsv_CodecEncoder LookAheadDepth(int value) => this.SetOptionRange("-look_ahead_depth", value, 0, 100);

        /// <summary>Downscaling factor for the frames saved for the lookahead analysis (from 0 to 3) (default unknown)</summary>
        public H264_qsv_CodecEncoder LookAheadDownsampling(H264_qsv_LookAheadDownsampling value) => this.SetOptionRange("-look_ahead_downsampling", (int)value, 0, 3);

        /// <summary>Intra refresh type. B frames should be set to 0. (from -1 to 65535) (default -1)</summary>
        public H264_qsv_CodecEncoder IntRefType(H264_qsv_IntRefType type) => this.SetOptionRange("-int_ref_type", (int)type, -1, 65535);

        /// <summary>Number of frames in the intra refresh cycle (from -1 to 65535) (default -1)</summary>
        public H264_qsv_CodecEncoder IntRefCycleSize(int value) => this.SetOptionRange("-int_ref_cycle_size", value, -1, 65535);

        /// <summary>QP difference for the refresh MBs (from -32768 to 32767) (default -32768)</summary>
        public H264_qsv_CodecEncoder IntRefQpDelta(int value) => this.SetOptionRange("-int_ref_qp_delta", value, -32768, 32767);

        /// <summary>Insert recovery point SEI messages (from -1 to 1) (default -1)</summary>
        public H264_qsv_CodecEncoder RecoveryPointSei(int value) => this.SetOptionRange("-recovery_point_sei", value, -1, 1);

        /// <summary>Distance between the beginnings of the intra-refresh cycles in frames (from -1 to 32767) (default -1)</summary>
        public H264_qsv_CodecEncoder IntRefCycleDist(int value) => this.SetOptionRange("-int_ref_cycle_dist", value, -1, 32767);

        /// <summary>(from 0 to INT_MAX) (default unknown)</summary>
        public H264_qsv_CodecEncoder Profile(H264_qsv_Profile profile) => this.SetOptionRange("-profile", (int)profile, 0, int.MaxValue);

        /// <summary>Use A53 Closed Captions (if available) (default true)</summary>
        public H264_qsv_CodecEncoder A53CC(bool value) => this.SetOption("-a53cc", value.ToFFmpegFlag());

        /// <summary>Insert the Access Unit Delimiter NAL (default false)</summary>
        public H264_qsv_CodecEncoder Aud(bool value) => this.SetOption("-aud", value.ToFFmpegFlag());

        /// <summary>repeat pps for every frame (default false)</summary>
        public H264_qsv_CodecEncoder RepeatPps(bool value) => this.SetOption("-repeat_pps", value.ToFFmpegFlag());
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>Encoding preset (from 0 to 7)</summary>
    public enum H264_qsv_Preset
    {
        /// <summary>Very slow preset</summary>
        VerySlow = 1,
        /// <summary>Slower preset</summary>
        Slower = 2,
        /// <summary>Slow preset</summary>
        Slow = 3,
        /// <summary>Medium preset</summary>
        Medium = 4,
        /// <summary>Fast preset</summary>
        Fast = 5,
        /// <summary>Faster preset</summary>
        Faster = 6,
        /// <summary>Very fast preset</summary>
        VeryFast = 7
    }
    /// <summary>Encoding scenario hint</summary>
    public enum H264_qsv_Scenario
    {
        /// <summary>Unknown/default scenario</summary>
        Unknown = 0,
        /// <summary>Display remoting</summary>
        DisplayRemoting = 1,
        /// <summary>Video conferencing</summary>
        VideoConference = 2,
        /// <summary>Archiving</summary>
        Archive = 3,
        /// <summary>Live streaming</summary>
        LiveStreaming = 4,
        /// <summary>Camera capture</summary>
        CameraCapture = 5,
        /// <summary>Video surveillance</summary>
        VideoSurveillance = 6,
        /// <summary>Game streaming</summary>
        GameStreaming = 7,
        /// <summary>Remote gaming</summary>
        RemoteGaming = 8
    }
    /// <summary>Frame skipping mode</summary>
    public enum H264_qsv_SkipFrame
    {
        /// <summary>Frame skipping is disabled</summary>
        NoSkip = 0,
        /// <summary>Encoder inserts into bitstream frame where all macroblocks are encoded as skipped</summary>
        InsertDummy = 1,
        /// <summary>Encoder inserts nothing into bitstream</summary>
        InsertNothing = 2,
        /// <summary>skip_frame metadata indicates the number of missed frames before the current frame</summary>
        BrcOnly = 3
    }
    /// <summary>Dual graphics adapter usage mode</summary>
    public enum H264_qsv_DualGfx
    {
        /// <summary>Disable HyperEncode mode</summary>
        Off = 0,
        /// <summary>Enable HyperEncode mode and return error if incompatible parameters during initialization</summary>
        On = 1,
        /// <summary>Enable HyperEncode mode or fallback to single GPU if incompatible parameters during initialization</summary>
        Adaptive = 2
    }
    /// <summary>Lookahead downsampling factor</summary>
    public enum H264_qsv_LookAheadDownsampling
    {
        /// <summary>Unknown or default value</summary>
        Unknown = 0,
        /// <summary>Auto (same as unknown)</summary>
        Auto = 0,
        /// <summary>Disable downsampling</summary>
        Off = 1,
        /// <summary>Downscale by 2</summary>
        _2x = 2,
        /// <summary>Downscale by 4</summary>
        _4x = 3
    }
    /// <summary>Intra refresh type</summary>
    public enum H264_qsv_IntRefType
    {
        /// <summary>No intra refresh</summary>
        None = 0,
        /// <summary>Vertical refresh</summary>
        Vertical = 1,
        /// <summary>Horizontal refresh</summary>
        Horizontal = 2,
        /// <summary>Slice-based refresh</summary>
        Slice = 3
    }
    /// <summary>H.264 encoding profile</summary>
    public enum H264_qsv_Profile
    {
        /// <summary>Unknown/default profile</summary>
        Unknown = 0,
        /// <summary>Baseline profile</summary>
        Baseline = 66,
        /// <summary>Main profile</summary>
        Main = 77,
        /// <summary>High profile</summary>
        High = 100
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    public static partial class ImageEncoderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static H264_qsv_CodecEncoder H264_qsv_Codec(this ImageOutputAVStream stream)
            => new H264_qsv_CodecEncoder(stream);
        public static T H264_qsv_Codec<T>(this T stream, Action<H264_qsv_CodecEncoder> action) where T : ImageOutputAVStream
        {
            action.Invoke(stream.H264_qsv_Codec());
            return stream;
        }
    }
}
