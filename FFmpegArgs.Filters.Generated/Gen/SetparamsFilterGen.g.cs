namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... setparams         V-&gt;V       Force field, or color property for the output video frame.
/// </summary>
public class SetparamsFilterGen : ImageToImageFilter
{
internal SetparamsFilterGen(ImageMap input) : base("setparams",input) { AddMapOut(); }
/// <summary>
///  select interlace mode (from -1 to 2) (default auto)
/// </summary>
public SetparamsFilterGen field_mode(SetparamsFilterGenField_mode field_mode) => this.SetOption("field_mode", field_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select color range (from -1 to 2) (default auto)
/// </summary>
public SetparamsFilterGen range(SetparamsFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select color primaries (from -1 to 22) (default auto)
/// </summary>
public SetparamsFilterGen color_primaries(SetparamsFilterGenColor_primaries color_primaries) => this.SetOption("color_primaries", color_primaries.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select color transfer (from -1 to 18) (default auto)
/// </summary>
public SetparamsFilterGen color_trc(SetparamsFilterGenColor_trc color_trc) => this.SetOption("color_trc", color_trc.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select colorspace (from -1 to 14) (default auto)
/// </summary>
public SetparamsFilterGen colorspace(SetparamsFilterGenColorspace colorspace) => this.SetOption("colorspace", colorspace.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Force field, or color property for the output video frame.
/// </summary>
public static SetparamsFilterGen SetparamsFilterGen(this ImageMap input0) => new SetparamsFilterGen(input0);
}
/// <summary>
///  select interlace mode (from -1 to 2) (default auto)
/// </summary>
public enum SetparamsFilterGenField_mode
{
/// <summary>
/// auto            -1           ..FV....... keep the same input field
/// </summary>
[Name("auto")] auto,
/// <summary>
/// bff             0            ..FV....... mark as bottom-field-first
/// </summary>
[Name("bff")] bff,
/// <summary>
/// tff             1            ..FV....... mark as top-field-first
/// </summary>
[Name("tff")] tff,
/// <summary>
/// prog            2            ..FV....... mark as progressive
/// </summary>
[Name("prog")] prog,
}

/// <summary>
///  select color range (from -1 to 2) (default auto)
/// </summary>
public enum SetparamsFilterGenRange
{
/// <summary>
/// auto            -1           ..FV....... keep the same color range
/// </summary>
[Name("auto")] auto,
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

/// <summary>
///  select color primaries (from -1 to 22) (default auto)
/// </summary>
public enum SetparamsFilterGenColor_primaries
{
/// <summary>
/// auto            -1           ..FV....... keep the same color primaries
/// </summary>
[Name("auto")] auto,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
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
/// film            8            ..FV.......
/// </summary>
[Name("film")] film,
/// <summary>
/// bt2020          9            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
/// <summary>
/// smpte428        10           ..FV.......
/// </summary>
[Name("smpte428")] smpte428,
/// <summary>
/// smpte431        11           ..FV.......
/// </summary>
[Name("smpte431")] smpte431,
/// <summary>
/// smpte432        12           ..FV.......
/// </summary>
[Name("smpte432")] smpte432,
/// <summary>
/// jedec-p22       22           ..FV.......
/// </summary>
[Name("jedec-p22")] jedec_p22,
/// <summary>
/// ebu3213         22           ..FV.......
/// </summary>
[Name("ebu3213")] ebu3213,
}

/// <summary>
///  select color transfer (from -1 to 18) (default auto)
/// </summary>
public enum SetparamsFilterGenColor_trc
{
/// <summary>
/// auto            -1           ..FV....... keep the same color transfer
/// </summary>
[Name("auto")] auto,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
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
/// linear          8            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// log100          9            ..FV.......
/// </summary>
[Name("log100")] log100,
/// <summary>
/// log316          10           ..FV.......
/// </summary>
[Name("log316")] log316,
/// <summary>
/// iec61966-2-4    11           ..FV.......
/// </summary>
[Name("iec61966-2-4")] iec61966_2_4,
/// <summary>
/// bt1361e         12           ..FV.......
/// </summary>
[Name("bt1361e")] bt1361e,
/// <summary>
/// iec61966-2-1    13           ..FV.......
/// </summary>
[Name("iec61966-2-1")] iec61966_2_1,
/// <summary>
/// bt2020-10       14           ..FV.......
/// </summary>
[Name("bt2020-10")] bt2020_10,
/// <summary>
/// bt2020-12       15           ..FV.......
/// </summary>
[Name("bt2020-12")] bt2020_12,
/// <summary>
/// smpte2084       16           ..FV.......
/// </summary>
[Name("smpte2084")] smpte2084,
/// <summary>
/// smpte428        17           ..FV.......
/// </summary>
[Name("smpte428")] smpte428,
/// <summary>
/// arib-std-b67    18           ..FV.......
/// </summary>
[Name("arib-std-b67")] arib_std_b67,
}

/// <summary>
///  select colorspace (from -1 to 14) (default auto)
/// </summary>
public enum SetparamsFilterGenColorspace
{
/// <summary>
/// auto            -1           ..FV....... keep the same colorspace
/// </summary>
[Name("auto")] auto,
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

}
