namespace FFmpegArgs
{
  public static class Extensions
  {
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-filters.html#Notes-on-filtergraph-escaping <br></br>
    /// Text Level
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string FiltergraphEscapingLv1(this string input)
    {
      return input.Replace(@"'", @"\'").Replace(@":", @"\:");
    }

    /// <summary>
    /// Filter level
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string FiltergraphEscapingLv2(this string input)
    {
      return input
        .Replace(@"\", @"\\")
        .Replace(@"'", @"\'")
        .Replace(@"[", @"\[")
        .Replace(@"]", @"\]")
        .Replace(@";", @"\;")
        .Replace(@",", @"\,");
    }

    /// <summary>
    /// OS shell level
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string FiltergraphEscapingLv3(this string input)
    {
      return input.Replace(@"\", @"\\");
    }



    public static string ToFFmpegFlag(this bool flag)
    {
      return flag ? "1" : "0";
    }
  }
}
