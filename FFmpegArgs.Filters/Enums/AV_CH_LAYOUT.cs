namespace FFmpegArgs.Filters.Enums
{
  /// <summary>
  /// https://github.com/FFmpeg/FFmpeg/blob/f6ab103bb5c2dd494620f7a28ae232efe497a4d1/libavutil/channel_layout.h#L90 <br></br>
  /// </summary>
  public enum AV_CH_LAYOUT
  {
    [Name("mono")]
    AV_CH_LAYOUT_MONO,

    [Name("stereo")]
    AV_CH_LAYOUT_STEREO,

    [Name("2.1")]
    AV_CH_LAYOUT_2POINT1,

    [Name("3.0(back)")]
    AV_CH_LAYOUT_2_1,

    [Name("3.0")]
    AV_CH_LAYOUT_SURROUND,

    [Name("3.1")]
    AV_CH_LAYOUT_3POINT1,

    [Name("4.0")]
    AV_CH_LAYOUT_4POINT0,

    [Name("4.1")]
    AV_CH_LAYOUT_4POINT1,

    [Name("quad(side)")]
    AV_CH_LAYOUT_2_2,

    [Name("quad")]
    AV_CH_LAYOUT_QUAD,

    [Name("5.0(side)")]
    AV_CH_LAYOUT_5POINT0,

    [Name("5.1(side)")]
    AV_CH_LAYOUT_5POINT1,

    [Name("5.0")]
    AV_CH_LAYOUT_5POINT0_BACK,

    [Name("5.1")]
    AV_CH_LAYOUT_5POINT1_BACK,

    [Name("6.0")]
    AV_CH_LAYOUT_6POINT0,

    [Name("6.0(front)")]
    AV_CH_LAYOUT_6POINT0_FRONT,

    [Name("hexagonal")]
    AV_CH_LAYOUT_HEXAGONAL,

    [Name("6.1")]
    AV_CH_LAYOUT_6POINT1,

    [Name("6.1(back)")]
    AV_CH_LAYOUT_6POINT1_BACK,

    [Name("6.1(front)")]
    AV_CH_LAYOUT_6POINT1_FRONT,

    [Name("7.0")]
    AV_CH_LAYOUT_7POINT0,

    [Name("7.0(front)")]
    AV_CH_LAYOUT_7POINT0_FRONT,

    [Name("7.1")]
    AV_CH_LAYOUT_7POINT1,

    [Name("7.1(wide-side)")]
    AV_CH_LAYOUT_7POINT1_WIDE,

    [Name("7.1(wide)")]
    AV_CH_LAYOUT_7POINT1_WIDE_BACK,

    [Name("octagonal")]
    AV_CH_LAYOUT_OCTAGONAL,

    [Name("hexadecagonal")]
    AV_CH_LAYOUT_HEXADECAGONAL,

    [Name("downmix")]
    AV_CH_LAYOUT_STEREO_DOWNMIX,

    [Name("22.2")]
    AV_CH_LAYOUT_22POINT2

  }
}