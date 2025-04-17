/*h264_nvenc AVOptions:
  -preset            <int>        E..V....... Set the encoding preset (from 0 to 18) (default p4)
     default         0            E..V....... 
     slow            1            E..V....... hq 2 passes
     medium          2            E..V....... hq 1 pass
     fast            3            E..V....... hp 1 pass
     hp              4            E..V....... 
     hq              5            E..V....... 
     bd              6            E..V....... 
     ll              7            E..V....... low latency
     llhq            8            E..V....... low latency hq
     llhp            9            E..V....... low latency hp
     lossless        10           E..V....... 
     losslesshp      11           E..V....... 
     p1              12           E..V....... fastest (lowest quality)
     p2              13           E..V....... faster (lower quality)
     p3              14           E..V....... fast (low quality)
     p4              15           E..V....... medium (default)
     p5              16           E..V....... slow (good quality)
     p6              17           E..V....... slower (better quality)
     p7              18           E..V....... slowest (best quality)
  -tune              <int>        E..V....... Set the encoding tuning info (from 1 to 4) (default hq)
     hq              1            E..V....... High quality
     ll              2            E..V....... Low latency
     ull             3            E..V....... Ultra low latency
     lossless        4            E..V....... Lossless
  -profile           <int>        E..V....... Set the encoding profile (from 0 to 3) (default main)
     baseline        0            E..V....... 
     main            1            E..V....... 
     high            2            E..V....... 
     high444p        3            E..V....... 
  -level             <int>        E..V....... Set the encoding level restriction (from 0 to 62) (default auto)
     auto            0            E..V....... 
     1               10           E..V....... 
     1.0             10           E..V....... 
     1b              9            E..V....... 
     1.0b            9            E..V....... 
     1.1             11           E..V....... 
     1.2             12           E..V....... 
     1.3             13           E..V....... 
     2               20           E..V....... 
     2.0             20           E..V....... 
     2.1             21           E..V....... 
     2.2             22           E..V....... 
     3               30           E..V....... 
     3.0             30           E..V....... 
     3.1             31           E..V....... 
     3.2             32           E..V....... 
     4               40           E..V....... 
     4.0             40           E..V....... 
     4.1             41           E..V....... 
     4.2             42           E..V....... 
     5               50           E..V....... 
     5.0             50           E..V....... 
     5.1             51           E..V....... 
     5.2             52           E..V....... 
     6.0             60           E..V....... 
     6.1             61           E..V....... 
     6.2             62           E..V....... 
  -rc                <int>        E..V....... Override the preset rate-control (from -1 to INT_MAX) (default -1)
     constqp         0            E..V....... Constant QP mode
     vbr             1            E..V....... Variable bitrate mode
     cbr             2            E..V....... Constant bitrate mode
     vbr_minqp       8388612      E..V....... Variable bitrate mode with MinQP (deprecated)
     ll_2pass_quality 8388616      E..V....... Multi-pass optimized for image quality (deprecated)
     ll_2pass_size   8388624      E..V....... Multi-pass optimized for constant frame size (deprecated)
     vbr_2pass       8388640      E..V....... Multi-pass variable bitrate mode (deprecated)
     cbr_ld_hq       8388616      E..V....... Constant bitrate low delay high quality mode
     cbr_hq          8388624      E..V....... Constant bitrate high quality mode
     vbr_hq          8388640      E..V....... Variable bitrate high quality mode
  -rc-lookahead      <int>        E..V....... Number of frames to look ahead for rate-control (from 0 to INT_MAX) (default 0)
  -surfaces          <int>        E..V....... Number of concurrent surfaces (from 0 to 64) (default 0)
  -cbr               <boolean>    E..V....... Use cbr encoding mode (default false)
  -2pass             <boolean>    E..V....... Use 2pass encoding mode (default auto)
  -gpu               <int>        E..V....... Selects which NVENC capable GPU to use. First GPU is 0, second is 1, and so on. (from -2 to INT_MAX) (default any)
     any             -1           E..V....... Pick the first device available
     list            -2           E..V....... List the available devices
  -rgb_mode          <int>        E..V....... Configure how nvenc handles packed RGB input. (from 0 to INT_MAX) (default yuv420)
     yuv420          1            E..V....... Convert to yuv420
     yuv444          2            E..V....... Convert to yuv444
     disabled        0            E..V....... Disables support, throws an error.
  -delay             <int>        E..V....... Delay frame output by the given amount of frames (from 0 to INT_MAX) (default INT_MAX)
  -no-scenecut       <boolean>    E..V....... When lookahead is enabled, set this to 1 to disable adaptive I-frame insertion at scene cuts (default false)
  -forced-idr        <boolean>    E..V....... If forcing keyframes, force them as IDR frames. (default false)
  -b_adapt           <boolean>    E..V....... When lookahead is enabled, set this to 0 to disable adaptive B-frame decision (default true)
  -spatial-aq        <boolean>    E..V....... set to 1 to enable Spatial AQ (default false)
  -spatial_aq        <boolean>    E..V....... set to 1 to enable Spatial AQ (default false)
  -temporal-aq       <boolean>    E..V....... set to 1 to enable Temporal AQ (default false)
  -temporal_aq       <boolean>    E..V....... set to 1 to enable Temporal AQ (default false)
  -zerolatency       <boolean>    E..V....... Set 1 to indicate zero latency operation (no reordering delay) (default false)
  -nonref_p          <boolean>    E..V....... Set this to 1 to enable automatic insertion of non-reference P-frames (default false)
  -strict_gop        <boolean>    E..V....... Set 1 to minimize GOP-to-GOP rate fluctuations (default false)
  -aq-strength       <int>        E..V....... When Spatial AQ is enabled, this field is used to specify AQ strength. AQ strength scale is from 1 (low) - 15 (aggressive) (from 1 to 15) (default 8)
  -cq                <float>      E..V....... Set target quality level (0 to 51, 0 means automatic) for constant quality mode in VBR rate control (from 0 to 51) (default 0)
  -aud               <boolean>    E..V....... Use access unit delimiters (default false)
  -bluray-compat     <boolean>    E..V....... Bluray compatibility workarounds (default false)
  -init_qpP          <int>        E..V....... Initial QP value for P frame (from -1 to 51) (default -1)
  -init_qpB          <int>        E..V....... Initial QP value for B frame (from -1 to 51) (default -1)
  -init_qpI          <int>        E..V....... Initial QP value for I frame (from -1 to 51) (default -1)
  -qp                <int>        E..V....... Constant quantization parameter rate control method (from -1 to 51) (default -1)
  -qp_cb_offset      <int>        E..V....... Quantization parameter offset for cb channel (from -12 to 12) (default 0)
  -qp_cr_offset      <int>        E..V....... Quantization parameter offset for cr channel (from -12 to 12) (default 0)
  -weighted_pred     <int>        E..V....... Set 1 to enable weighted prediction (from 0 to 1) (default 0)
  -coder             <int>        E..V....... Coder type (from -1 to 2) (default default)
     default         -1           E..V....... 
     auto            0            E..V....... 
     cabac           1            E..V....... 
     cavlc           2            E..V....... 
     ac              1            E..V....... 
     vlc             2            E..V....... 
  -b_ref_mode        <int>        E..V....... Use B frames as references (from -1 to 2) (default -1)
     disabled        0            E..V....... B frames will not be used for reference
     each            1            E..V....... Each B frame will be used for reference
     middle          2            E..V....... Only (number of B frames)/2 will be used for reference
  -a53cc             <boolean>    E..V....... Use A53 Closed Captions (if available) (default true)
  -dpb_size          <int>        E..V....... Specifies the DPB size used for encoding (0 means automatic) (from 0 to INT_MAX) (default 0)
  -multipass         <int>        E..V....... Set the multipass encoding (from 0 to 2) (default disabled)
     disabled        0            E..V....... Single Pass
     qres            1            E..V....... Two Pass encoding is enabled where first Pass is quarter resolution
     fullres         2            E..V....... Two Pass encoding is enabled where first Pass is full resolution
  -ldkfs             <int>        E..V....... Low delay key frame scale; Specifies the Scene Change frame size increase allowed in case of single frame VBV and CBR (from 0 to 255) (default 0)
  -extra_sei         <boolean>    E..V....... Pass on extra SEI data (e.g. a53 cc) to be included in the bitstream (default true)
  -udu_sei           <boolean>    E..V....... Pass on user data unregistered SEI if available (default false)
  -intra-refresh     <boolean>    E..V....... Use Periodic Intra Refresh instead of IDR frames (default false)
  -single-slice-intra-refresh <boolean>    E..V....... Use single slice intra refresh (default false)
  -max_slice_size    <int>        E..V....... Maximum encoded slice size in bytes (from 0 to INT_MAX) (default 0)
  -constrained-encoding <boolean>    E..V....... Enable constrainedFrame encoding where each slice in the constrained picture is independent of other slices (default false)
*/
namespace FFmpegArgs.Codec.Encoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public class H264_nvenc_CodecEncoder : H264CodecEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public H264_nvenc_CodecEncoder(ImageOutputAVStream stream) : base("h264_nvenc", stream)
        {
        }

        /// <summary>
        /// Set the encoding preset (from 0 to 18) (default p4)
        /// </summary>
        /// <param name="preset"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Preset(H264_nvenc_Preset preset)
            => this.SetOptionRange("-preset", (int)preset, 0, 18);

        /// <summary>
        /// Set the encoding tuning info (from 1 to 4) (default hq)
        /// </summary>
        /// <param name="tune"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Tune(H264_nvenc_Tune tune)
            => this.SetOptionRange("-tune", (int)tune, 1, 4);

        /// <summary>
        /// Set the encoding profile (from 0 to 3) (default main)
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Profile(H264_nvenc_Profile profile)
            => this.SetOptionRange("-profile", (int)profile, 0, 3);

        /// <summary>
        /// Set the encoding level restriction (from 0 to 62) (default auto)
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Level(H264_nvenc_Level level)
            => this.SetOptionRange("-level", (int)level, 0, 62);

        /// <summary>
        /// Override the preset rate-control (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="rateControl"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder RateControl(H264_nvenc_RateControl rateControl)
            => this.SetOptionRange("-rc", (int)rateControl, -1, int.MaxValue);

        /// <summary>
        /// umber of frames to look ahead for rate-control (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="rc_lookahead"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder RateControlLookahead(int rc_lookahead)
            => this.SetOptionRange("-rc-lookahead", rc_lookahead, 0, INT_MAX);

        /// <summary>
        /// Number of concurrent surfaces (from 0 to 64) (default 0)
        /// </summary>
        /// <param name="surfaces"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Surfaces(int surfaces)
            => this.SetOptionRange("-surfaces", surfaces, 0, 64);

        /// <summary>
        /// Use cbr encoding mode (default false)
        /// </summary>
        /// <param name="cbr"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Cbr(bool cbr)
            => this.SetOption("-cbr", cbr.ToFFmpegFlag());

        /// <summary>
        /// Use 2pass encoding mode (default auto)
        /// </summary>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder TwoPass()
            => this.SetOption("-2pass", true.ToFFmpegFlag());

        /// <summary>
        /// Selects which NVENC capable GPU to use. First GPU is 0, second is 1, and so on. (from 0 to INT_MAX) (default any)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Gpu(int index)
            => this.SetOptionRange("-gpu", index, 0, INT_MAX);

        /// <summary>
        /// Configure how nvenc handles packed RGB input. (from 0 to INT_MAX) (default yuv420)
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder RgbMode(H264_nvenc_RgbMode mode)
            => this.SetOptionRange("-rgb_mode", (int)mode, 0, INT_MAX);

        /// <summary>
        /// Delay frame output by the given amount of frames (from 0 to INT_MAX) (default INT_MAX)
        /// </summary>
        /// <param name="delay"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Delay(int delay)
            => this.SetOptionRange("-delay", delay, 0, INT_MAX);

        /// <summary>
        /// When lookahead is enabled, set this to 1 to disable adaptive I-frame insertion at scene cuts (default false)
        /// </summary>
        /// <param name="noScenecut"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder NoScenecut(bool noScenecut)
            => this.SetOption("-no-scenecut", noScenecut.ToFFmpegFlag());

        /// <summary>
        /// If forcing keyframes, force them as IDR frames. (default false)
        /// </summary>
        /// <param name="forcedIdr"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder ForcedIdr(bool forcedIdr)
            => this.SetOption("-forced-idr", forcedIdr.ToFFmpegFlag());

        /// <summary>
        /// When lookahead is enabled, set this to 0 to disable adaptive B-frame decision (default true)
        /// </summary>
        /// <param name="bAdapt"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder BAdapt(bool bAdapt)
            => this.SetOption("-b_adapt", bAdapt.ToFFmpegFlag());

        /// <summary>
        /// set to 1 to enable Spatial AQ (default false)
        /// </summary>
        /// <param name="spatialAQ"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder SpatialAQ(bool spatialAQ)
            => this.SetOption("-spatial_aq", spatialAQ.ToFFmpegFlag());

        /// <summary>
        /// set to 1 to enable Temporal AQ (default false)
        /// </summary>
        /// <param name="temporalAQ"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder TemporalAQ(bool temporalAQ)
            => this.SetOption("-temporal_aq", temporalAQ.ToFFmpegFlag());

        /// <summary>
        /// Set 1 to indicate zero latency operation (no reordering delay) (default false)
        /// </summary>
        /// <param name="zeroLatency"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder ZeroLatency(bool zeroLatency)
            => this.SetOption("-zerolatency", zeroLatency.ToFFmpegFlag());

        /// <summary>
        /// Set this to 1 to enable automatic insertion of non-reference P-frames (default false)
        /// </summary>
        /// <param name="nonRefP"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder NonRefP(bool nonRefP)
            => this.SetOption("-nonref_p", nonRefP.ToFFmpegFlag());

        /// <summary>
        /// Set 1 to minimize GOP-to-GOP rate fluctuations (default false)
        /// </summary>
        /// <param name="strictGop"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder StrictGop(bool strictGop)
            => this.SetOption("-strict_gop", strictGop.ToFFmpegFlag());

        /// <summary>
        /// When Spatial AQ is enabled, this field is used to specify AQ strength. AQ strength scale is from 1 (low) - 15 (aggressive) (from 1 to 15) (default 8)
        /// </summary>
        /// <param name="aqStrength"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder AQStrength(int aqStrength)
            => this.SetOptionRange("-aq-strength", aqStrength, 1, 15);

        /// <summary>
        /// Set target quality level (0 to 51, 0 means automatic) for constant quality mode in VBR rate control (from 0 to 51) (default 0)
        /// </summary>
        /// <param name="cq"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder CQ(float cq)
            => this.SetOptionRange("-cq", cq, 0, 51);

        /// <summary>
        /// Use access unit delimiters (default false)
        /// </summary>
        /// <param name="aud"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Aud(bool aud)
            => this.SetOption("-aud", aud.ToFFmpegFlag());

        /// <summary>
        /// Bluray compatibility workarounds (default false)
        /// </summary>
        /// <param name="blurayCompat"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder BlurayCompat(bool blurayCompat)
            => this.SetOption("-bluray-compat", blurayCompat.ToFFmpegFlag());

        /// <summary>
        /// Initial QP value for P frame (from -1 to 51) (default -1)
        /// </summary>
        /// <param name="init_qpP"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder InitQP_P(int init_qpP)
            => this.SetOptionRange("-init_qpP", init_qpP, -1, 51);

        /// <summary>
        /// Initial QP value for B frame (from -1 to 51) (default -1)
        /// </summary>
        /// <param name="init_qpB"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder InitQP_B(int init_qpB)
            => this.SetOptionRange("-init_qpB", init_qpB, -1, 51);

        /// <summary>
        /// Initial QP value for I frame (from -1 to 51) (default -1)
        /// </summary>
        /// <param name="init_qpI"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder InitQP_I(int init_qpI)
            => this.SetOptionRange("-init_qpI", init_qpI, -1, 51);

        /// <summary>
        /// Constant quantization parameter rate control method (from -1 to 51) (default -1)
        /// </summary>
        /// <param name="qp"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder QP(int qp)
            => this.SetOptionRange("-qp", qp, -1, 51);

        /// <summary>
        /// Quantization parameter offset for cb channel (from -12 to 12) (default 0)
        /// </summary>
        /// <param name="qp_cb_offset"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder QP_Cb_Offset(int qp_cb_offset)
            => this.SetOptionRange("-qp_cb_offset", qp_cb_offset, -12, 12);

        /// <summary>
        /// Quantization parameter offset for cr channel (from -12 to 12) (default 0)
        /// </summary>
        /// <param name="qp_cr_offset"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder QP_Cr_Offset(int qp_cr_offset)
            => this.SetOptionRange("-qp_cr_offset", qp_cr_offset, -12, 12);

        /// <summary>
        /// Set 1 to enable weighted prediction (from 0 to 1) (default 0)
        /// </summary>
        /// <param name="weighted_pred"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder WeightedPred(int weighted_pred)
            => this.SetOptionRange("-weighted_pred", weighted_pred, 0, 1);

        /// <summary>
        /// Coder type (from -1 to 2) (default default)
        /// </summary>
        /// <param name="coder"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Coder(H264_nvenc_Coder coder)
            => this.SetOptionRange("-coder", (int)coder, -1, 2);

        /// <summary>
        /// Use B frames as references (from -1 to 2) (default -1)
        /// </summary>
        /// <param name="b_ref_mode"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder BRefMode(H264_nvenc_BRefMode b_ref_mode)
            => this.SetOptionRange("-b_ref_mode", (int)b_ref_mode, -1, 2);

        /// <summary>
        /// Use A53 Closed Captions (if available) (default true)
        /// </summary>
        /// <param name="a53cc"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder A53CC(bool a53cc)
            => this.SetOption("-a53cc", a53cc.ToFFmpegFlag());

        /// <summary>
        /// Specifies the DPB size used for encoding (0 means automatic) (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="dpb_size"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder DpbSize(int dpb_size)
            => this.SetOptionRange("-dpb_size", dpb_size, 0, INT_MAX);

        /// <summary>
        /// Set the multipass encoding (from 0 to 2) (default disabled)
        /// </summary>
        /// <param name="multiPass"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder MultiPass(H264_nvenc_MultiPass multiPass)
            => this.SetOptionRange("-multipass", (int)multiPass, 0, 2);

        /// <summary>
        /// Low delay key frame scale; Specifies the Scene Change frame size increase allowed in case of single frame VBV and CBR (from 0 to 255) (default 0)
        /// </summary>
        /// <param name="ldkfs"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder Ldkfs(int ldkfs)
            => this.SetOptionRange("-ldkfs", ldkfs, 0, 255);

        /// <summary>
        /// Pass on extra SEI data (e.g. a53 cc) to be included in the bitstream (default true)
        /// </summary>
        /// <param name="extraSEI"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder ExtraSEI(bool extraSEI)
            => this.SetOption("-extra_sei", extraSEI.ToFFmpegFlag());

        /// <summary>
        /// Pass on user data unregistered SEI if available (default false)
        /// </summary>
        /// <param name="udu_sei"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder UDU_SEI(bool udu_sei)
            => this.SetOption("-udu_sei", udu_sei.ToFFmpegFlag());

        /// <summary>
        /// Use Periodic Intra Refresh instead of IDR frames (default false)
        /// </summary>
        /// <param name="intraRefresh"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder IntraRefresh(bool intraRefresh)
            => this.SetOption("-intra-refresh", intraRefresh.ToFFmpegFlag());

        /// <summary>
        /// Use single slice intra refresh (default false)
        /// </summary>
        /// <param name="singleSliceIntraRefresh"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder SingleSliceIntraRefresh(bool singleSliceIntraRefresh)
            => this.SetOption("-single-slice-intra-refresh", singleSliceIntraRefresh.ToFFmpegFlag());

        /// <summary>
        /// Maximum encoded slice size in bytes (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="max_slice_size"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder MaxSliceSize(int max_slice_size)
            => this.SetOptionRange("-max_slice_size", max_slice_size, 0, INT_MAX);

        /// <summary>
        /// Enable constrainedFrame encoding where each slice in the constrained picture is independent of other slices (default false)
        /// </summary>
        /// <param name="constrainedEncoding"></param>
        /// <returns></returns>
        public H264_nvenc_CodecEncoder ConstrainedEncoding(bool constrainedEncoding)
            => this.SetOption("-constrained-encoding", constrainedEncoding.ToFFmpegFlag());
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum H264_nvenc_Preset
    {
        @default = 0,
        /// <summary>
        /// hq 2 passes
        /// </summary>
        slow = 1,
        /// <summary>
        /// hq 1 pass
        /// </summary>
        medium = 2,
        /// <summary>
        /// hp 1 pass
        /// </summary>
        fast = 3,
        hp = 4,
        hq = 5,
        bd = 6,
        /// <summary>
        /// low latency
        /// </summary>
        ll = 7,
        /// <summary>
        /// low latency hq
        /// </summary>
        llhq = 8,
        /// <summary>
        /// low latency hp
        /// </summary>
        llhp = 9,
        lossless = 10,
        losslesshp = 11,
        /// <summary>
        /// fastest (lowest quality)
        /// </summary>
        p1 = 12,
        /// <summary>
        /// faster (lower quality)
        /// </summary>
        p2 = 13,
        /// <summary>
        /// fast (low quality)
        /// </summary>
        p3 = 14,
        /// <summary>
        /// medium (default)
        /// </summary>
        p4 = 15,
        /// <summary>
        /// slow (good quality)
        /// </summary>
        p5 = 16,
        /// <summary>
        /// slower (better quality)
        /// </summary>
        p6 = 17,
        /// <summary>
        /// slowest (best quality)
        /// </summary>
        p7 = 18,
    }
    public enum H264_nvenc_Tune
    {
        /// <summary>
        /// High quality
        /// </summary>
        hq = 1,
        /// <summary>
        /// Low latency
        /// </summary>
        ll = 2,
        /// <summary>
        /// Ultra low latency
        /// </summary>
        ull = 3,
        /// <summary>
        /// Lossless
        /// </summary>
        lossless = 4,
    }
    public enum H264_nvenc_Profile
    {
        baseline = 0,
        main = 1,
        high = 2,
        high444p = 3,
    }
    public enum H264_nvenc_Level
    {
        auto = 0,

        Level_1b = 9,
        Level_1_0b = 9,

        Level_1 = 10,
        Level_1_0 = 10,
        Level_1_1 = 11,
        Level_1_2 = 12,
        Level_1_3 = 13,

        Level_2 = 20,
        Level_2_0 = 20,
        Level_2_1 = 21,
        Level_2_2 = 22,

        Level_3 = 30,
        Level_3_0 = 30,
        Level_3_1 = 31,
        Level_3_2 = 32,

        Level_4 = 40,
        Level_4_0 = 40,
        Level_4_1 = 41,
        Level_4_2 = 42,

        Level_5 = 50,
        Level_5_0 = 50,
        Level_5_1 = 51,
        Level_5_2 = 52,

        Level_6_0 = 60,
        Level_6_1 = 61,
        Level_6_2 = 62,

    }
    public enum H264_nvenc_RateControl
    {
        /// <summary>
        /// Constant QP mode
        /// </summary>
        constqp = 0,
        /// <summary>
        /// Variable bitrate mode
        /// </summary>
        vbr = 1,
        /// <summary>
        /// Constant bitrate mode
        /// </summary>
        cbr = 2,
        /// <summary>
        /// Variable bitrate mode with MinQP (deprecated)
        /// </summary>
        [Obsolete] vbr_minqp = 8388612,
        /// <summary>
        /// Multi-pass optimized for image quality (deprecated)
        /// </summary>
        [Obsolete] ll_2pass_quality = 8388616,
        /// <summary>
        /// Multi-pass optimized for constant frame size (deprecated)
        /// </summary>
        [Obsolete] ll_2pass_size = 8388624,
        /// <summary>
        /// Multi-pass variable bitrate mode (deprecated)
        /// </summary>
        vbr_2pass = 8388640,
        /// <summary>
        /// Constant bitrate low delay high quality mode
        /// </summary>
        cbr_ld_hq = 8388616,
        /// <summary>
        /// Constant bitrate high quality mode
        /// </summary>
        cbr_hq = 8388624,
        /// <summary>
        /// Variable bitrate high quality mode
        /// </summary>
        vbr_hq = 8388640,
    }
    public enum H264_nvenc_RgbMode
    {
        /// <summary>
        /// Disables support, throws an error.
        /// </summary>
        disabled = 0,
        /// <summary>
        /// Convert to yuv420
        /// </summary>
        yuv420 = 1,
        /// <summary>
        /// Convert to yuv444
        /// </summary>
        yuv444 = 2,
    }
    public enum H264_nvenc_Coder
    {
        @default = -1,
        auto = 0,
        cabac = 1,
        cavlc = 2,
        ac = 1,
        vlc = 2
    }
    public enum H264_nvenc_BRefMode
    {
        /// <summary>
        /// B frames will not be used for reference
        /// </summary>
        disabled = 0,
        /// <summary>
        /// Each B frame will be used for reference
        /// </summary>
        each = 1,
        /// <summary>
        /// Only (number of B frames)/2 will be used for reference
        /// </summary>
        middle = 2,
    }
    public enum H264_nvenc_MultiPass
    {
        /// <summary>
        /// Single Pass
        /// </summary>
        disabled = 0,
        /// <summary>
        /// Two Pass encoding is enabled where first Pass is quarter resolution
        /// </summary>
        qres = 1,
        /// <summary>
        /// Two Pass encoding is enabled where first Pass is full resolution
        /// </summary>
        fullres = 2,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    public static partial class ImageEncoderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static H264_nvenc_CodecEncoder H264_nvenc_Codec(this ImageOutputAVStream stream)
            => new H264_nvenc_CodecEncoder(stream);
    }
}
