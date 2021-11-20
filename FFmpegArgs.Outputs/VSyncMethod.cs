namespace FFmpegArgs.Outputs
{
    public enum VSyncMethod
    {
        /// <summary>
        /// Each frame is passed with its timestamp from the demuxer to the muxer.
        /// </summary>
        passthrough,
        /// <summary>
        /// Frames will be duplicated and dropped to achieve exactly the requested constant frame rate.
        /// </summary>
        cfr,
        /// <summary>
        /// Frames are passed through with their timestamp or dropped so as to prevent 2 frames from having the same timestamp.
        /// </summary>
        vfr,
        /// <summary>
        /// As passthrough but destroys all timestamps, making the muxer generate fresh timestamps based on frame-rate.
        /// </summary>
        drop,
        /// <summary>
        /// Chooses between 1 and 2 depending on muxer capabilities. This is the default method.
        /// </summary>
        auto
    }
}
