namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... buffer            |-&gt;V       Buffer video frames, and make them accessible to the filterchain.
/// </summary>
public class BufferFilterGen : SourceToImageFilter
{
internal BufferFilterGen(IImageFilterGraph input) : base("buffer",input) { AddMapOut(); }
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public BufferFilterGen width(int width) => this.SetOptionRange("width", width,0,INT_MAX);
/// <summary>
/// 
/// </summary>
public BufferFilterGen video_size(Size video_size) => this.SetOption("video_size",$"{video_size.Width}x{video_size.Height}");
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public BufferFilterGen height(int height) => this.SetOptionRange("height", height,0,INT_MAX);
/// <summary>
///  (default none)
/// </summary>
public BufferFilterGen pix_fmt(PixFmt pix_fmt) => this.SetOption("pix_fmt",pix_fmt.ToString());
/// <summary>
///  sample aspect ratio (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public BufferFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,DBL_MAX));
/// <summary>
///  sample aspect ratio (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public BufferFilterGen pixel_aspect(Rational pixel_aspect) => this.SetOption("pixel_aspect",pixel_aspect.Check(0,DBL_MAX));
/// <summary>
///  (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public BufferFilterGen time_base(Rational time_base) => this.SetOption("time_base",time_base.Check(0,DBL_MAX));
/// <summary>
///  (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public BufferFilterGen frame_rate(Rational frame_rate) => this.SetOption("frame_rate",frame_rate.Check(0,DBL_MAX));
/// <summary>
///  select colorspace (from 0 to 14) (default unknown)
/// </summary>
public BufferFilterGen colorspace(BufferFilterGenColorspace colorspace) => this.SetOption("colorspace", colorspace.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select color range (from 0 to 2) (default unspecified)
/// </summary>
public BufferFilterGen range(BufferFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Buffer video frames, and make them accessible to the filterchain.
/// </summary>
public static BufferFilterGen BufferFilterGen(this IImageFilterGraph input0) => new BufferFilterGen(input0);
}
/// <summary>
///  select colorspace (from 0 to 14) (default unknown)
/// </summary>
public enum BufferFilterGenColorspace
{
/// <summary>
/// gbr             0            ..FV.......
/// </summary>
[Name("gbr")] gbr,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// fcc             4            ..FV.......
/// </summary>
[Name("fcc")] fcc,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// ycgco           8            ..FV.......
/// </summary>
[Name("ycgco")] ycgco,
/// <summary>
/// bt2020nc        9            ..FV.......
/// </summary>
[Name("bt2020nc")] bt2020nc,
/// <summary>
/// bt2020c         10           ..FV.......
/// </summary>
[Name("bt2020c")] bt2020c,
/// <summary>
/// smpte2085       11           ..FV.......
/// </summary>
[Name("smpte2085")] smpte2085,
/// <summary>
/// chroma-derived-nc 12           ..FV.......
/// </summary>
[Name("chroma-derived-nc")] chroma_derived_nc,
/// <summary>
/// chroma-derived-c 13           ..FV.......
/// </summary>
[Name("chroma-derived-c")] chroma_derived_c,
/// <summary>
/// ictcp           14           ..FV.......
/// </summary>
[Name("ictcp")] ictcp,
}

/// <summary>
///  select color range (from 0 to 2) (default unspecified)
/// </summary>
public enum BufferFilterGenRange
{
/// <summary>
/// unspecified     0            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// unknown         0            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// limited         1            ..FV.......
/// </summary>
[Name("limited")] limited,
/// <summary>
/// tv              1            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// mpeg            1            ..FV.......
/// </summary>
[Name("mpeg")] mpeg,
/// <summary>
/// full            2            ..FV.......
/// </summary>
[Name("full")] full,
/// <summary>
/// pc              2            ..FV.......
/// </summary>
[Name("pc")] pc,
/// <summary>
/// jpeg            2            ..FV.......
/// </summary>
[Name("jpeg")] jpeg,
}

}
