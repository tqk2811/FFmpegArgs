using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Enums;
using FFmpegArgs.Cores.Inputs;
using FFmpegArgs.Cores.Interfaces;

namespace FFmpegArgs.Inputs.Demuxers
{
    public abstract class BaseDemuxer : BaseOption, IDemux
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="baseInput"></param>
        protected BaseDemuxer(DemuxingFileFormat format, BaseInput baseInput) : base(baseInput)
        {
            this.Format(format);
        }
    }
}
