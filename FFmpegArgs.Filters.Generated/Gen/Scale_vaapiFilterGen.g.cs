namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... scale_vaapi       V-&gt;V       Scale to/from VAAPI surfaces.
/// </summary>
public class Scale_vaapiFilterGen : ImageToImageFilter
{
internal Scale_vaapiFilterGen(ImageMap input) : base("scale_vaapi",input) { AddMapOut(); }
/// <summary>
///  Output video width (default &quot;iw&quot;)
/// </summary>
public Scale_vaapiFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Output video height (default &quot;ih&quot;)
/// </summary>
public Scale_vaapiFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Output video format (software format of hardware frames)
/// </summary>
public Scale_vaapiFilterGen format(string format) => this.SetOption("format",format);
/// <summary>
///  Scaling mode (from 0 to 768) (default hq)
/// </summary>
public Scale_vaapiFilterGen mode(Scale_vaapiFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Output colour matrix coefficient set
/// </summary>
public Scale_vaapiFilterGen out_color_matrix(string out_color_matrix) => this.SetOption("out_color_matrix",out_color_matrix);
/// <summary>
///  Output colour range (from 0 to 2) (default 0)
/// </summary>
public Scale_vaapiFilterGen out_range(Scale_vaapiFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Output colour primaries
/// </summary>
public Scale_vaapiFilterGen out_color_primaries(string out_color_primaries) => this.SetOption("out_color_primaries",out_color_primaries);
/// <summary>
///  Output colour transfer characteristics
/// </summary>
public Scale_vaapiFilterGen out_color_transfer(string out_color_transfer) => this.SetOption("out_color_transfer",out_color_transfer);
/// <summary>
///  Output chroma sample location
/// </summary>
public Scale_vaapiFilterGen out_chroma_location(string out_chroma_location) => this.SetOption("out_chroma_location",out_chroma_location);
/// <summary>
///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
/// </summary>
public Scale_vaapiFilterGen force_original_aspect_ratio(Scale_vaapiFilterGenForce_original_aspect_ratio force_original_aspect_ratio) => this.SetOption("force_original_aspect_ratio", force_original_aspect_ratio.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  enforce that the output resolution is divisible by a defined integer when force_original_aspect_ratio is used (from 1 to 256) (default 1)
/// </summary>
public Scale_vaapiFilterGen force_divisible_by(int force_divisible_by) => this.SetOptionRange("force_divisible_by", force_divisible_by,1,256);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Scale to/from VAAPI surfaces.
/// </summary>
public static Scale_vaapiFilterGen Scale_vaapiFilterGen(this ImageMap input0) => new Scale_vaapiFilterGen(input0);
}
/// <summary>
///  Scaling mode (from 0 to 768) (default hq)
/// </summary>
public enum Scale_vaapiFilterGenMode
{
/// <summary>
/// default         0            ..FV....... Use the default (depend on the driver) scaling algorithm
/// </summary>
[Name("default")] _default,
/// <summary>
/// fast            256          ..FV....... Use fast scaling algorithm
/// </summary>
[Name("fast")] fast,
/// <summary>
/// hq              512          ..FV....... Use high quality scaling algorithm
/// </summary>
[Name("hq")] hq,
/// <summary>
/// nl_anamorphic   768          ..FV....... Use nolinear anamorphic scaling algorithm
/// </summary>
[Name("nl_anamorphic")] nl_anamorphic,
}

/// <summary>
///  Output colour range (from 0 to 2) (default 0)
/// </summary>
public enum Scale_vaapiFilterGenOut_range
{
/// <summary>
/// full            2            ..FV....... Full range
/// </summary>
[Name("full")] full,
/// <summary>
/// limited         1            ..FV....... Limited range
/// </summary>
[Name("limited")] limited,
/// <summary>
/// jpeg            2            ..FV....... Full range
/// </summary>
[Name("jpeg")] jpeg,
/// <summary>
/// mpeg            1            ..FV....... Limited range
/// </summary>
[Name("mpeg")] mpeg,
/// <summary>
/// tv              1            ..FV....... Limited range
/// </summary>
[Name("tv")] tv,
/// <summary>
/// pc              2            ..FV....... Full range
/// </summary>
[Name("pc")] pc,
}

/// <summary>
///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
/// </summary>
public enum Scale_vaapiFilterGenForce_original_aspect_ratio
{
/// <summary>
/// disable         0            ..FV.......
/// </summary>
[Name("disable")] disable,
/// <summary>
/// decrease        1            ..FV.......
/// </summary>
[Name("decrease")] decrease,
/// <summary>
/// increase        2            ..FV.......
/// </summary>
[Name("increase")] increase,
}

}
