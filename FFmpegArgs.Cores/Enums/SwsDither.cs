namespace FFmpegArgs.Cores.Enums
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-scaler.html#Scaler-Options
    /// </summary>
    public enum SwsDither
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        auto,
        none,
        bayer,
        ed,
        a_dither,
        x_dither
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
