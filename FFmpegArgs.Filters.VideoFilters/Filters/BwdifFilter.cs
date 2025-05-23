namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. bwdif             V->V       Deinterlace the input image.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#bwdif
    /// </summary>
    public class BwdifFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal BwdifFilter(ImageMap imageMap) : base("bwdif", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// The interlacing mode to adopt. The default value is send_field.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public BwdifFilter Mode(BwdifMode mode)
          => this.SetOption("mode", mode);
        /// <summary>
        /// The picture field parity assumed for the input interlaced video.<br>
        /// </br>The default value is auto. If the interlacing is unknown or the decoder does not export this information, top field first will be assumed.
        /// </summary>
        /// <param name="parity"></param>
        /// <returns></returns>
        public BwdifFilter Parity(BwdifParity parity)
          => this.SetOption("parity", parity);
        /// <summary>
        /// Specify which frames to deinterlace.<br>
        /// </br>The default value is all.
        /// </summary>
        /// <param name="deint"></param>
        /// <returns></returns>
        public BwdifFilter Deint(BwdifDeint deint)
          => this.SetOption("deint", deint);
    }
    public static class BwdifFilterExtensions
    {
        /// <summary>
        /// Deinterlace the input video ("bwdif" stands for "Bob Weaver Deinterlacing Filter").<br></br>
        /// Motion adaptive deinterlacing based on yadif with the use of w3fdif and cubic interpolation algorithms.
        /// </summary>
        public static BwdifFilter BwdifFilter(this ImageMap imageMap)
          => new BwdifFilter(imageMap);
    }
    public enum BwdifMode
    {
        /// <summary>
        /// Output one frame for each frame.
        /// </summary>
        send_frame = 0,
        /// <summary>
        /// Output one frame for each field.
        /// </summary>
        send_field = 1
    }
    public enum BwdifParity
    {
        /// <summary>
        /// Assume the top field is first.
        /// </summary>
        tff = 0,
        /// <summary>
        /// Assume the bottom field is first.
        /// </summary>
        bff = 1,
        /// <summary>
        /// Enable automatic detection of field parity.
        /// </summary>
        auto = -1
    }
    public enum BwdifDeint
    {
        /// <summary>
        /// Deinterlace all frames.
        /// </summary>
        all = 0,
        /// <summary>
        /// Only deinterlace frames marked as interlaced.
        /// </summary>
        interlaced = 1
    }
}
