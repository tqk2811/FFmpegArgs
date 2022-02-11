namespace FFmpegArgs.Cores.Enums
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-scaler.html#sws_005fflags
    /// </summary>
    public enum SwsFlags
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        fast_bilinear,
        bilinear,
        bicubic,
        experimental,
        neighbor,
        area,
        bicublin,
        gauss,
        sinc,
        lanczos,
        spline,
        print_info,
        accurate_rnd,
        full_chroma_int,
        full_chroma_inp,
        bitexact
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
