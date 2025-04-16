/*libopenh264enc AVOptions:
  -loopfilter        <int>        E..V....... enable loop filter (from 0 to 1) (default 1)
  -profile           <int>        E..V....... set profile restrictions (from -99 to 65535) (default -99)
     constrained_baseline 578          E..V.......
     main            77           E..V.......
     high            100          E..V.......
  -max_nal_size      <int>        E..V....... set maximum NAL size in bytes (from 0 to INT_MAX) (default 0)
  -allow_skip_frames <boolean>    E..V....... allow skipping frames to hit the target bitrate (default false)
  -coder             <int>        E..V....... Coder type (from -1 to 1) (default default)
     default         -1           E..V.......
     cavlc           0            E..V.......
     cabac           1            E..V.......
     vlc             0            E..V.......
     ac              1            E..V.......
  -rc_mode           <int>        E..V....... Select rate control mode (from -1 to 3) (default quality)
     off             -1           E..V....... bit rate control off
     quality         0            E..V....... quality mode
     bitrate         1            E..V....... bitrate mode
     buffer          2            E..V....... using buffer status to adjust the video quality (no bitrate control)
     timestamp       3            E..V....... bit rate control based on timestamp
*/
namespace FFmpegArgs.Codec.Encoders.Images
{

    /// <summary>
    /// 
    /// </summary>
    public class H264_libopenh264_CodecEncoder : H264CodecEncoder, ILibx264Encoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public H264_libopenh264_CodecEncoder(ImageOutputAVStream stream) : base("libopenh264", stream)
        {
        }


        /// <summary>
        /// enable/disable loop filter, default true
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_libopenh264_CodecEncoder LoopFilter(bool flag)
            => this.SetOption("-loopfilter", flag.ToFFmpegFlag());

        /// <summary>
        /// set profile restrictions (from -99 to 65535) (default -99)
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        public H264_libopenh264_CodecEncoder Profile(LibOpenH264_Profile profile)
            => this.SetOption("-profile", (int)profile);

        /// <summary>
        /// set maximum NAL size in bytes (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="max_nal_size"></param>
        /// <returns></returns>
        public H264_libopenh264_CodecEncoder MaxNalSize(int max_nal_size)
            => this.SetOptionRange("-max_nal_size", max_nal_size, 0, INT_MAX);

        /// <summary>
        /// allow skipping frames to hit the target bitrate (default false)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264_libopenh264_CodecEncoder AllowSkipFrames(bool flag)
            => this.SetOption("-allow_skip_frames", flag.ToFFmpegFlag());

        /// <summary>
        /// Coder type (from -1 to 1) (default default)
        /// </summary>
        /// <param name="coder"></param>
        /// <returns></returns>
        public H264_libopenh264_CodecEncoder Coder(LibOpenH264_Coder coder)
            => this.SetOptionRange("-coder", (int)coder, -1, 1);

        /// <summary>
        /// Select rate control mode (from -1 to 3) (default quality)
        /// </summary>
        /// <param name="rcMode"></param>
        /// <returns></returns>
        public H264_libopenh264_CodecEncoder RcMode(LibOpenH264_RcMode rcMode)
            => this.SetOptionRange("-rc_mode", (int)rcMode, -1, 1);
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum LibOpenH264_Profile
    {
        constrained_baseline = 578,
        main = 77,
        high = 100,
    }
    public enum LibOpenH264_Coder
    {
        @default = -1,
        cavlc = 0,
        cabac = 1,
        vlc = 0,
        ac = 1,
    }
    public enum LibOpenH264_RcMode
    {
        /// <summary>
        /// bit rate control off
        /// </summary>
        off = -1,
        /// <summary>
        /// quality mode
        /// </summary>
        quality = 0,
        /// <summary>
        /// bitrate mode
        /// </summary>
        bitrate = 1,
        /// <summary>
        /// using buffer status to adjust the video quality (no bitrate control)
        /// </summary>
        buffer = 2,
        /// <summary>
        /// bit rate control based on timestamp
        /// </summary>
        timestamp = 3,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    public static partial class ImageEncoderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static H264_libopenh264_CodecEncoder H264_libopenh264_Codec(this ImageOutputAVStream stream)
            => new H264_libopenh264_CodecEncoder(stream);
    }
}
