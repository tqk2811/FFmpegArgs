namespace FFmpegArgs.Inputs.Demuxers
{
    /// <summary>
    /// Raw video demuxer.<br/>
    /// This demuxer allows one to read raw video data.Since there is no header specifying the assumed video parameters, the user must specify them in order to be able to decode the data correctly.<br/>
    /// <see href="https://ffmpeg.org/ffmpeg-formats.html#rawvideo"/>
    /// </summary>
    public class RawvideoDemuxer : BaseDemuxer, IImage
    {
        internal RawvideoDemuxer(BaseInput baseInput) : base(DemuxingFileFormat.rawvideo, baseInput)
        {
        }

        /// <summary>
        /// Set input video frame rate. Default value is 25.
        /// </summary>
        public RawvideoDemuxer Framerate(int frameRate)
            => this.SetOption("-framerate", frameRate);
        /// <summary>
        /// Set the input video pixel format. Default value is <see cref="PixFmt.yuv420p"/>.
        /// </summary>
        public RawvideoDemuxer PixelFormat(PixFmt pixel_format)
            => this.SetOption("-pixel_format", pixel_format.ToString());
        /// <summary>
        /// Set the input video size. This value must be specified explicitly.
        /// </summary>
        public RawvideoDemuxer VideoSize(Size video_size)
            => this.SetOption("-video_size", video_size);
    }
    public static partial class DemuxerExtensions
    {
        public static RawvideoDemuxer RawvideoDemuxer<TInput>(this TInput input) where TInput : BaseInput, IImageInput
          => new RawvideoDemuxer(input);

        public static TInput RawvideoDemuxer<TInput>(this TInput input, Action<RawvideoDemuxer> action) where TInput : BaseInput, IImageInput
        {
            if (action is null) throw new ArgumentNullException(nameof(action));
            RawvideoDemuxer rawvideoDemuxer = new RawvideoDemuxer(input);
            action.Invoke(rawvideoDemuxer);
            return input;
        }
    }
}
