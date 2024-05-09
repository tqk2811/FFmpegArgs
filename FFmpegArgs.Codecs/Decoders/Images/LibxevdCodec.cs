using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Codecs.Decoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public class LibxevdCodec : BaseImageCodecDecoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public LibxevdCodec(ImageInputAVStream stream) : base("libxevd", stream)
        {
        }

        /// <summary>
        /// Force to use a specific number of threads
        /// </summary>
        /// <param name="threads"></param>
        /// <returns></returns>
        public LibxevdCodec Threads(int threads)
            => this.SetOptionRange("threads", threads, 0, int.MaxValue);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class LibxevdCodecExtension
    {
        /// <summary>
        /// eXtra-fast Essential Video Decoder (XEVD) MPEG-5 EVC decoder wrapper.<br>
        /// </br>This decoder requires the presence of the libxevd headers and library during configuration.You need to explicitly configure the build with --enable-libxevd.<br>
        /// </br>The xevd project website is at <see href="https://github.com/mpeg5/xevd"/>.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static LibxevdCodec LibxevdCodec(this ImageInputAVStream stream)
            => new LibxevdCodec(stream);
    }
}
