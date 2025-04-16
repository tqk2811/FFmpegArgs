
using FFmpegArgs.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Codec.Encoders
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseCodecEncoder : BaseCodec, ICodec, ICodecEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseCodecEncoder(string codecName, OutputAVStream stream) : base(codecName, stream)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codec"></param>
        /// <param name="stream"></param>
        protected BaseCodecEncoder(Codecs codec, OutputAVStream stream) : base(codec, stream)
        {

        }
    }
}
