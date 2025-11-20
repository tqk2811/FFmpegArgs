namespace FFmpegArgs.Inputs.Demuxers
{
    /// <summary>
    /// Advanced Systems Format demuxer.<br/>
    /// This demuxer is used to demux ASF files and MMS network streams.<br/>
    /// <see href="https://ffmpeg.org/ffmpeg-formats.html#asf-1"/>
    /// </summary>
    public class AsfDemuxer : BaseDemuxer, IImage
    {
        internal AsfDemuxer(BaseInput baseInput) : base(DemuxingFileFormat.asf, baseInput)
        {
        }

        /// <summary>
        /// Do not try to resynchronize by looking for a certain optional start code.
        /// </summary>
        public AsfDemuxer NoResyncSearch(bool no_resync_search)
            => this.SetOption("-no_resync_search", no_resync_search.ToFFmpegFlag());

    }
    public static partial class DemuxerExtensions
    {
        public static AsfDemuxer AsfDemuxer<TInput>(this TInput input) where TInput : BaseInput, IImageInput
          => new AsfDemuxer(input);
        public static TInput AsfDemuxer<TInput>(this TInput input, Action<AsfDemuxer> action) where TInput : BaseInput, IImageInput
        {
            if (action is null) throw new ArgumentNullException(nameof(action));
            AsfDemuxer asfDemuxer = new AsfDemuxer(input);
            action.Invoke(asfDemuxer);
            return input;
        }
    }
}
