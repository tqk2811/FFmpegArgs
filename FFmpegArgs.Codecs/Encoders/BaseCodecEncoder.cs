using FFmpegArgs.Cores.Codecs;
using FFmpegArgs.Cores.Interfaces;
using FFmpegArgs.Cores.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Codecs.Encoders
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseCodecEncoder : BaseCodec, ICodecEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseCodecEncoder(string codecName, OutputAVStream stream) : base(codecName, stream)
        {

        }
    }
}
