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
    public class Av1Codec : BaseImageCodecDecoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public Av1Codec(ImageInputAVStream stream) : base("av1", stream)
        {
        }

        /// <summary>
        /// Select an operating point of a scalable AV1 bitstream (0 - 31). Default is 0.
        /// </summary>
        /// <returns></returns>
        public Av1Codec OperatingPoint(int operating_point)
            => this.SetOptionRange("operating_point", operating_point, 0, 31);
    }

    /// <summary>
    /// 
    /// </summary>
    public static class Av1CodecExtension
    {
        /// <summary>
        /// AOMedia Video 1 (AV1) decoder.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Av1Codec Av1Codec(this ImageInputAVStream stream)
            => new Av1Codec(stream);
    }
}
