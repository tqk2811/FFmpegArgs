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
    ntsc,

    /// <summary>
    /// 25/1
    /// </summary>
    pal,

    /// <summary>
    /// 30000/1001
    /// </summary>
    qntsc,

    /// <summary>
    /// 25/1
    /// </summary>
    qpal,

    /// <summary>
    /// 30000/1001
    /// </summary>
    sntsc,

    /// <summary>
    /// 25/1
    /// </summary>
    spal,

    /// <summary>
    /// 24/1
    /// </summary>
    film,
    //ntsc-film
  }
}
