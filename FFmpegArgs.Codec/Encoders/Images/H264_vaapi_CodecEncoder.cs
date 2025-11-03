/*h264_vaapi AVOptions:
  -low_power         <boolean>    E..V....... Use low-power encoding mode (only available on some platforms; may not support all encoding features) (default false)
  -idr_interval      <int>        E..V....... Distance (in I-frames) between IDR frames (from 0 to INT_MAX) (default 0)
  -b_depth           <int>        E..V....... Maximum B-frame reference depth (from 1 to INT_MAX) (default 1)
  -async_depth       <int>        E..V....... Maximum processing parallelism. Increase this to improve single channel performance. This option doesn't work if driver doesn't implement vaSyncBuffer function. (from 1 to 64) (default 2)
  -max_frame_size    <int>        E..V....... Maximum frame size (in bytes) (from 0 to INT_MAX) (default 0)
  -rc_mode           <int>        E..V....... Set rate control mode (from 0 to 6) (default auto)
     auto            0            E..V....... Choose mode automatically based on other parameters
     CQP             1            E..V....... Constant-quality
     CBR             2            E..V....... Constant-bitrate
     VBR             3            E..V....... Variable-bitrate
     ICQ             4            E..V....... Intelligent constant-quality
     QVBR            5            E..V....... Quality-defined variable-bitrate
     AVBR            6            E..V....... Average variable-bitrate
  -qp                <int>        E..V....... Constant QP (for P-frames; scaled by qfactor/qoffset for I/B) (from 0 to 52) (default 0)
  -quality           <int>        E..V....... Set encode quality (trades off against speed, higher is faster) (from -1 to INT_MAX) (default -1)
  -coder             <int>        E..V....... Entropy coder type (from 0 to 1) (default cabac)
     cavlc           0            E..V.......
     cabac           1            E..V.......
     vlc             0            E..V.......
     ac              1            E..V.......
  -aud               <boolean>    E..V....... Include AUD (default false)
  -sei               <flags>      E..V....... Set SEI to include (default identifier+timing+recovery_point+a53_cc)
     identifier                   E..V....... Include encoder version identifier
     timing                       E..V....... Include timing parameters (buffering_period and pic_timing)
     recovery_point               E..V....... Include recovery points where appropriate
     a53_cc                       E..V....... Include A/53 caption data
  -profile           <int>        E..V....... Set profile (profile_idc and constraint_set*_flag) (from -99 to 65535) (default -99)
     constrained_baseline 578          E..V.......
     main            77           E..V.......
     high            100          E..V.......
     high10          110          E..V.......
  -level             <int>        E..V....... Set level (level_idc) (from -99 to 255) (default -99)
     1               10           E..V.......
     1.1             11           E..V.......
     1.2             12           E..V.......
     1.3             13           E..V.......
     2               20           E..V.......
     2.1             21           E..V.......
     2.2             22           E..V.......
     3               30           E..V.......
     3.1             31           E..V.......
     3.2             32           E..V.......
     4               40           E..V.......
     4.1             41           E..V.......
     4.2             42           E..V.......
     5               50           E..V.......
     5.1             51           E..V.......
     5.2             52           E..V.......
     6               60           E..V.......
     6.1             61           E..V.......
     6.2             62           E..V.......
*/
using System.Xml.Linq;

namespace FFmpegArgs.Codec.Encoders.Images
{
    //chatgpt generated
    /// <summary>
    /// 
    /// </summary>
    public class H264_vaapi_CodecEncoder : BaseImageCodecEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        public H264_vaapi_CodecEncoder(ImageOutputAVStream stream) : base("h264_vaapi", stream) { }

        /// <summary>Use low-power encoding mode (only available on some platforms; may not support all encoding features) (default false)</summary>
        public H264_vaapi_CodecEncoder LowPower(bool value) => this.SetOption("-low_power", value.ToFFmpegFlag());

        /// <summary>Distance (in I-frames) between IDR frames (from 0 to INT_MAX) (default 0)</summary>
        public H264_vaapi_CodecEncoder IdrInterval(int value) => this.SetOptionRange("-idr_interval", value, 0, int.MaxValue);

        /// <summary>Maximum B-frame reference depth (from 1 to INT_MAX) (default 1)</summary>
        public H264_vaapi_CodecEncoder BDepth(int value) => this.SetOptionRange("-b_depth", value, 1, int.MaxValue);

        /// <summary>Maximum processing parallelism. Increase this to improve single channel performance. This option doesn't work if driver doesn't implement vaSyncBuffer function. (from 1 to 64) (default 2)</summary>
        public H264_vaapi_CodecEncoder AsyncDepth(int value) => this.SetOptionRange("-async_depth", value, 1, 64);

        /// <summary>Maximum frame size (in bytes) (from 0 to INT_MAX) (default 0)</summary>
        public H264_vaapi_CodecEncoder MaxFrameSize(int value) => this.SetOptionRange("-max_frame_size", value, 0, int.MaxValue);

        /// <summary>Set rate control mode (from 0 to 6) (default auto)</summary>
        public H264_vaapi_CodecEncoder RcMode(H264_vaapi_RcMode mode) => this.SetOptionRange("-rc_mode", (int)mode, 0, 6);

        /// <summary>Constant QP (for P-frames; scaled by qfactor/qoffset for I/B) (from 0 to 52) (default 0)</summary>
        public H264_vaapi_CodecEncoder Qp(int value) => this.SetOptionRange("-qp", value, 0, 52);

        /// <summary>Set encode quality (trades off against speed, higher is faster) (from -1 to INT_MAX) (default -1)</summary>
        public H264_vaapi_CodecEncoder Quality(int value) => this.SetOptionRange("-quality", value, -1, int.MaxValue);

        /// <summary>Entropy coder type (from 0 to 1) (default cabac)</summary>
        public H264_vaapi_CodecEncoder Coder(H264_vaapi_Coder coder) => this.SetOptionRange("-coder", (int)coder, 0, 1);

        /// <summary>Include AUD (default false)</summary>
        public H264_vaapi_CodecEncoder Aud(bool value) => this.SetOption("-aud", value.ToFFmpegFlag());

        /// <summary>Set SEI to include (default identifier+timing+recovery_point+a53_cc)</summary>
        public H264_vaapi_CodecEncoder Sei(params H264_vaapi_Sei[] seiFlags)
        {
            if (seiFlags == null || seiFlags.Length == 0)
                throw new ArgumentNullException(nameof(seiFlags), "At least one SEI flag must be specified.");
            List<H264_vaapi_Sei> flags = new();
            foreach (var item in Enum.GetValues(typeof(H264_vaapi_Sei)).Cast<H264_vaapi_Sei>())
            {
                foreach (var item1 in seiFlags)
                {
                    if (item1.HasFlag(item))
                    {
                        flags.Add(item);
                        break;
                    }
                }
            }
            string[] flags_str = flags.Select(x => x.GetEnumAttribute<NameAttribute>().Name).ToArray();
            return this.SetOption("-sei", string.Join("+", flags_str));
        }

        /// <summary>Set profile (profile_idc and constraint_set*_flag) (from -99 to 65535) (default -99)</summary>
        public H264_vaapi_CodecEncoder Profile(H264_vaapi_Profile profile) => this.SetOptionRange("-profile", (int)profile, -99, 65535);

        /// <summary>Set level (level_idc) (from -99 to 255) (default -99)</summary>
        public H264_vaapi_CodecEncoder Level(H264_vaapi_Level level) => this.SetOptionRange("-level", (int)level, -99, 255);
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary>Set rate control mode (from 0 to 6) (default auto)</summary>
    public enum H264_vaapi_RcMode
    {
        /// <summary>Choose mode automatically based on other parameters</summary>
        Auto = 0,
        /// <summary>Constant-quality</summary>
        CQP = 1,
        /// <summary>Constant-bitrate</summary>
        CBR = 2,
        /// <summary>Variable-bitrate</summary>
        VBR = 3,
        /// <summary>Intelligent constant-quality</summary>
        ICQ = 4,
        /// <summary>Quality-defined variable-bitrate</summary>
        QVBR = 5,
        /// <summary>Average variable-bitrate</summary>
        AVBR = 6
    }

    /// <summary>Entropy coder type (from 0 to 1) (default cabac)</summary>
    public enum H264_vaapi_Coder
    {
        CAVLC = 0,
        CABAC = 1,
        VLC = 0,
        AC = 1
    }
    [Flags]
    public enum H264_vaapi_Sei
    {
        /// <summary>
        /// Include encoder version identifier
        /// </summary>
        [Name("identifier")] Identifier = 1,
        /// <summary>
        /// Include timing parameters (buffering_period and pic_timing)
        /// </summary>
        [Name("timing")] Timing = 2,
        /// <summary>
        /// Include recovery points where appropriate
        /// </summary>
        [Name("recovery_point")] RecoveryPoint = 4,
        /// <summary>
        /// Include A/53 caption data
        /// </summary>
        [Name("a53_cc")] A53Cc = 8
    }

    /// <summary>Set profile (profile_idc and constraint_set*_flag) (from -99 to 65535) (default -99)</summary>
    public enum H264_vaapi_Profile
    {
        /// <summary>Constrained Baseline profile</summary>
        ConstrainedBaseline = 578,
        /// <summary>Main profile</summary>
        Main = 77,
        /// <summary>High profile</summary>
        High = 100,
        /// <summary>High 10 profile</summary>
        High10 = 110
    }

    /// <summary>Set level (level_idc) (from -99 to 255) (default -99)</summary>
    public enum H264_vaapi_Level
    {
        Level1 = 10,
        Level1_1 = 11,
        Level1_2 = 12,
        Level1_3 = 13,

        Level2 = 20,
        Level2_1 = 21,
        Level2_2 = 22,

        Level3 = 30,
        Level3_1 = 31,
        Level3_2 = 32,

        Level4 = 40,
        Level4_1 = 41,
        Level4_2 = 42,

        Level5 = 50,
        Level5_1 = 51,
        Level5_2 = 52,

        Level6 = 60,
        Level6_1 = 61,
        Level6_2 = 62
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    public static partial class ImageEncoderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static H264_vaapi_CodecEncoder H264_vaapi_Codec(this ImageOutputAVStream stream)
            => new H264_vaapi_CodecEncoder(stream);
        public static T H264_vaapi_Codec<T>(this T stream, Action<H264_vaapi_CodecEncoder> action) where T : ImageOutputAVStream
        {
            action.Invoke(stream.H264_vaapi_Codec());
            return stream;
        }
    }
}
