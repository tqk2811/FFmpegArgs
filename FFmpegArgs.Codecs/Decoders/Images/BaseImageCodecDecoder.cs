using FFmpegArgs.Cores.Interfaces;
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
    public abstract class BaseImageCodecDecoder : BaseCodecDecoder, IImageCodec
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseImageCodecDecoder(string codecName, ImageInputAVStream stream) : base(codecName, stream)
        {
        }
    }
}
