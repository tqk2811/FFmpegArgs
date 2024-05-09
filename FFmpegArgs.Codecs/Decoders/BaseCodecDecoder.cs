using FFmpegArgs.Cores.Codecs;
using FFmpegArgs.Cores.Interfaces;
using FFmpegArgs.Cores.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Codecs.Decoders
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseCodecDecoder : BaseCodec, ICodecDecoding
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseCodecDecoder(string codecName, InputAVStream stream) : base(codecName, stream)
        {
        }
    }
}
