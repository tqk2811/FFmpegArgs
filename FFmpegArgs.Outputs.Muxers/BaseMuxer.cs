namespace FFmpegArgs.Inputs.Demuxers
{
    public abstract class BaseMuxer : BaseOption, IMux
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="format"></param>
        /// <param name="baseInput"></param>
        protected BaseMuxer(MuxingFileFormat format, BaseOutput baseInput) : base(baseInput)
        {
            this.Format(format);
        }
    }
}
