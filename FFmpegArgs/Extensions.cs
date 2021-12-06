namespace FFmpegArgs
{
    public static class Extensions
    {
        public static string ToFFmpegFlag(this bool flag)
        {
            return flag ? "1" : "0";
        }
    }
}
