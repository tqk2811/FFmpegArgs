using FFmpegArgs.Cores.Interfaces;
using FFmpegArgs.Cores.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Codecs.Decoders.Audios
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseAudioCodecDecoder : BaseCodecDecoder, IAudioCodec
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseAudioCodecDecoder(string codecName, AudioInputAVStream stream) : base(codecName, stream)
        {
        }
    }
}
