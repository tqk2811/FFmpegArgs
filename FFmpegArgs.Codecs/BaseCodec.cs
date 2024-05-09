using FFmpegArgs.Cores.Interfaces;
using FFmpegArgs.Cores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFmpegArgs.Cores.Streams;

namespace FFmpegArgs.Cores.Codecs
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseCodec : BaseOption, ICodec
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseCodec(string codecName, BaseAVStream stream) : base(stream)
        {
            this.Codec(codecName);
        }
    }
}
