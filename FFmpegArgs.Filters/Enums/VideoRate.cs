namespace FFmpegArgs.Filters.Enums
{
  /// <summary>
  /// https://ffmpeg.org/ffmpeg-utils.html#Video-rate
  /// </summary>
  public enum VideoRate
  {
    /// <summary>
    /// 30000/1001
    /// </summary>
    [Name("ntsc")] ntsc,

    /// <summary>
    /// 25/1
    /// </summary>
    [Name("pal")] pal,

    /// <summary>
    /// 30000/1001
    /// </summary>
    [Name("qntsc")] qntsc,

    /// <summary>
    /// 25/1
    /// </summary>
    [Name("qpal")] qpal,

    /// <summary>
    /// 30000/1001
    /// </summary>
    [Name("sntsc")] sntsc,

    /// <summary>
    /// 25/1
    /// </summary>
    [Name("spal")] spal,

    /// <summary>
    /// 24/1
    /// </summary>
    [Name("film")] film,

    /// <summary>
    /// 24000/1001
    /// </summary>
    [Name("ntsc-film")] NtscFilm
  }
}
