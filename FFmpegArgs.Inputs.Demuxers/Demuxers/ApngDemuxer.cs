namespace FFmpegArgs.Inputs.Demuxers
{
    /// <summary>
    /// Animated Portable Network Graphics demuxer.<br/>
    /// This demuxer is used to demux APNG files.All headers, but the PNG signature, up to(but not including) the first fcTL chunk are transmitted as extradata.Frames are then split as being all the chunks between two fcTL ones, or between the last fcTL and IEND chunks.<br/>
    /// <see href="https://ffmpeg.org/ffmpeg-formats.html#apng"/>
    /// </summary>
    public class ApngDemuxer : BaseDemuxer, IImage
    {
        internal ApngDemuxer(BaseInput baseInput) : base(DemuxingFileFormat.apng, baseInput)
        {
        }

        /// <summary>
        /// Ignore the loop variable in the file if set. Default is enabled.
        /// </summary>
        public ApngDemuxer IgnoreLoop(bool ignore_loop)
            => this.SetOption("-ignore_loop", ignore_loop.ToFFmpegFlag());
        /// <summary>
        /// Maximum framerate in frames per second. Default of 0 imposes no limit.
        /// </summary>
        public ApngDemuxer MaxFps(int max_fps)
            => this.SetOptionRange("-max_fps", max_fps, 0, INT_MAX);
        /// <summary>
        /// Default framerate in frames per second when none is specified in the file (0 meaning as fast as possible). Default is 15.
        /// </summary>
        public ApngDemuxer DefaultFps(int default_fps)
            => this.SetOptionRange("-default_fps", default_fps, 0, INT_MAX);
    }
    public static partial class DemuxerExtensions
    {
        public static ApngDemuxer ApngDemuxer<TInput>(this TInput input) where TInput : BaseInput, IImageInput
          => new ApngDemuxer(input);

        public static TInput ApngDemuxer<TInput>(this TInput input, Action<ApngDemuxer> action) where TInput : BaseInput, IImageInput
        {
            if (action is null) throw new ArgumentNullException(nameof(action));
            ApngDemuxer rawvideoDemuxer = new ApngDemuxer(input);
            action.Invoke(rawvideoDemuxer);
            return input;
        }
    }
}
