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
    public class RawVideoCodec : BaseImageCodecDecoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public RawVideoCodec(ImageInputAVStream stream) : base("rawvideo", stream)
        {

        }
        /// <summary>
        /// Specify the assumed field type of the input video.
        /// </summary>
        /// <param name="top_field_first"></param>
        /// <returns></returns>
        public RawVideoCodec Top(RawVideoCodecTop top_field_first)
            => this.SetOption("top", (int)top_field_first);
    }
    /// <summary>
    /// 
    /// </summary>
    public enum RawVideoCodecTop
    {
        /// <summary>
        /// the video is assumed to be progressive (default)
        /// </summary>
        TheVideoIsAssumedToBeProgressive = -1,
        /// <summary>
        /// bottom-field-first is assumed
        /// </summary>
        BottomFieldFirst = 0,
        /// <summary>
        /// top-field-first is assumed
        /// </summary>
        TopFieldFirst = 1,
    }
    /// <summary>
    /// 
    /// </summary>
    public static class RawVideoCodecExtension
    {
        /// <summary>
        /// Raw video decoder.<br>
        /// </br>This decoder decodes rawvideo streams.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static RawVideoCodec RawVideoCodec(this ImageInputAVStream stream)
            => new RawVideoCodec(stream);
    }
}
