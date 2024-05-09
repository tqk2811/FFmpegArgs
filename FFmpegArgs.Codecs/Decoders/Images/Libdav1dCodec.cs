using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Codecs.Decoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public class Libdav1dCodec : BaseImageCodecDecoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public Libdav1dCodec(ImageInputAVStream stream) : base("libdav1d", stream)
        {
        }

        /// <summary>
        /// Set max amount of frames the decoder may buffer internally. The default value is 0 (autodetect).
        /// </summary>
        /// <returns></returns>
        public Libdav1dCodec MaxFrameDelay(int max_frame_delay)
            => this.SetOptionRange("max_frame_delay", max_frame_delay, 0, int.MaxValue);

        /// <summary>
        /// Select an operating point of a scalable AV1 bitstream (0 - 31). Defaults to the internal default of the library.
        /// </summary>
        /// <param name="opPoint"></param>
        /// <returns></returns>
        public Libdav1dCodec OpPoint(int opPoint)
            => this.SetOptionRange("opPoint", opPoint, 0, 31);

        /// <summary>
        /// Output all spatial layers of a scalable AV1 bitstream. The default value is false.
        /// </summary>
        /// <param name="alllayers"></param>
        /// <returns></returns>
        public Libdav1dCodec AllLayers(bool alllayers)
            => this.SetOption("alllayers", alllayers.ToFFmpegFlag());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Libdav1dCodecExtension
    {
        /// <summary>
        /// dav1d AV1 decoder.<br>
        /// </br>libdav1d allows libavcodec to decode the AOMedia Video 1 (AV1) codec.Requires the presence of the libdav1d headers and library during configuration. You need to explicitly configure the build with --enable-libdav1d.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Libdav1dCodec Libdav1dCodec(this ImageInputAVStream stream)
            => new Libdav1dCodec(stream);
    }
}
