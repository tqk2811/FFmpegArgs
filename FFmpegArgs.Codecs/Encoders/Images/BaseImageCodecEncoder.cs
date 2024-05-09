using FFmpegArgs.Cores.Interfaces;
using FFmpegArgs.Cores.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Codecs.Encoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseImageCodecEncoder : BaseCodecEncoder, IImageCodec
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseImageCodecEncoder(string codecName, ImageOutputAVStream stream) : base(codecName, stream)
        {
        }
    }
}
