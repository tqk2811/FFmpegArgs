using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Codecs.Decoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public class Libuavs3dCodec : BaseImageCodecDecoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public Libuavs3dCodec(ImageInputAVStream stream) : base("libuavs3d", stream)
        {
        }

        /// <summary>
        /// Set amount of frame threads to use during decoding. The default value is 0 (autodetect).
        /// </summary>
        /// <param name="frame_threads">Set amount of frame threads to use during decoding. The default value is 0 (autodetect).</param>
        /// <returns></returns>
        public Libuavs3dCodec FrameThreads(int frame_threads)
            => this.SetOptionRange("frame_threads", frame_threads, 0, int.MaxValue);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Libuavs3dCodecExtension
    {
        /// <summary>
        /// AVS3-P2/IEEE1857.10 video decoder.<br>
        /// </br>libuavs3d allows libavcodec to decode AVS3 streams.Requires the presence of the libuavs3d headers and library during configuration.You need to explicitly configure the build with
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Libuavs3dCodec Libuavs3dCodec(this ImageInputAVStream stream)
            => new Libuavs3dCodec(stream);
    }
}
