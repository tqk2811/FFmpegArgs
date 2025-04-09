namespace FFmpegArgs
{
    /// <summary>
    /// 
    /// </summary>
    public static class UtilsExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static string ToFFmpegFlag(this bool flag)
            => flag ? "1" : "0";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ToHexStringRGB(this Color color)
            => $"0x{color.R:X2}{color.G:X2}{color.B:X2}";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ToHexStringRGBA(this Color color)
            => $"0x{color.R:X2}{color.G:X2}{color.B:X2}{color.A:X2}";

        /// <summary>
        /// <see href="https://ffmpeg.org/ffmpeg-utils.html#date-syntax"/>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string ToFFmpegDate(this DateTime dateTime)
            => dateTime.ToString("yyyy-MM-dd HH:mm:ss");
    }
}
