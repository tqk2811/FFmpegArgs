namespace FFmpegArgs.Filters.Enums
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-scaler.html#sws_005fflags
    /// </summary>
    public enum SwsFlags
    {
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
    }
}
