/*h264_mf AVOptions:
  -rate_control      <int>        E..V....... Select rate control mode (from -1 to INT_MAX) (default default)
     default         -1           E..V....... Default mode
     cbr             0            E..V....... CBR mode
     pc_vbr          1            E..V....... Peak constrained VBR mode
     u_vbr           2            E..V....... Unconstrained VBR mode
     quality         3            E..V....... Quality mode
     ld_vbr          4            E..V....... Low delay VBR mode
     g_vbr           5            E..V....... Global VBR mode
     gld_vbr         6            E..V....... Global low delay VBR mode
  -scenario          <int>        E..V....... Select usage scenario (from -1 to INT_MAX) (default default)
     default         -1           E..V....... Default scenario
     display_remoting 1            E..V....... Display remoting
     video_conference 2            E..V....... Video conference
     archive         3            E..V....... Archive
     live_streaming  4            E..V....... Live streaming
     camera_record   5            E..V....... Camera record
     display_remoting_with_feature_map 6            E..V....... Display remoting with feature map
  -quality           <int>        E..V....... Quality (from -1 to 100) (default -1)
  -hw_encoding       <boolean>    E..V....... Force hardware encoding (default false)
*/
namespace FFmpegArgs.Codec.Encoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public class H264_mf_CodecEncoder : H264CodecEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public H264_mf_CodecEncoder(ImageOutputAVStream stream) : base("h264_mf", stream)
        {
        }


        /// <summary>
        /// Select rate control mode (from -1 to INT_MAX) (default default)
        /// </summary>
        /// <param name="rateControl"></param>
        /// <returns></returns>
        public H264_mf_CodecEncoder RateControl(H264_mf_RateControl rateControl)
            => this.SetOptionRange("-rate_control", (int)rateControl, -1, INT_MAX);

        /// <summary>
        /// Select usage scenario (from -1 to INT_MAX) (default default)
        /// </summary>
        /// <param name="scenario"></param>
        /// <returns></returns>
        public H264_mf_CodecEncoder Scenario(H264_mf_Scenario scenario)
            => this.SetOptionRange("-scenario", (int)scenario, -1, INT_MAX);

        /// <summary>
        /// Quality (from -1 to 100) (default -1)
        /// </summary>
        /// <param name="quality"></param>
        /// <returns></returns>
        public H264_mf_CodecEncoder Quality(int quality)
            => this.SetOptionRange("-quality", quality, -1, 100);

        /// <summary>
        /// Force hardware encoding (default false)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_mf_CodecEncoder HWEncoding(bool flag)
            => this.SetOption("-hw_encoding", flag.ToFFmpegFlag());
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum H264_mf_RateControl
    {
        /// <summary>
        /// Default mode
        /// </summary>
        Default = -1,
        /// <summary>
        /// CBR mode
        /// </summary>
        CBR = 0,
        /// <summary>
        /// Peak constrained VBR mode
        /// </summary>
        PC_VBR = 1,
        /// <summary>
        /// Unconstrained VBR mode
        /// </summary>
        U_VBR = 2,
        /// <summary>
        /// Quality mode
        /// </summary>
        Quality = 3,
        /// <summary>
        /// Low delay VBR mode
        /// </summary>
        LD_VBR = 4,
        /// <summary>
        /// Global VBR mode
        /// </summary>
        G_VBR = 5,
        /// <summary>
        /// Global low delay VBR mode
        /// </summary>
        GLD_VBR = 6
    }
    public enum H264_mf_Scenario
    {
        /// <summary>
        /// Default scenario
        /// </summary>
        Default = -1,
        /// <summary>
        /// Display remoting
        /// </summary>
        DisplayRemoting = 1,
        /// <summary>
        /// Video Conference
        /// </summary>
        VideoConference = 2,
        /// <summary>
        /// Archive
        /// </summary>
        Archive = 3,
        /// <summary>
        /// Live Streaming
        /// </summary>
        LiveStreaming = 4,
        /// <summary>
        /// Camera record
        /// </summary>
        CameraRecord = 5,
        /// <summary>
        /// Display remoting with feature map
        /// </summary>
        DisplayRemotingWithFeatureMap = 6
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    public static partial class ImageEncoderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static H264_mf_CodecEncoder H264_mf_Codec(this ImageOutputAVStream stream)
            => new H264_mf_CodecEncoder(stream);
    }
}
