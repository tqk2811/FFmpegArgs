using FFmpegArgs.Cores.Interfaces;
using FFmpegArgs.Cores.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Codecs.Encoders.Audios
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseAudioCodecEncoder : BaseCodecEncoder, IAudioCodec
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseAudioCodecEncoder(string codecName, AudioOutputAVStream stream) : base(codecName, stream)
        {
        }
    }
}
