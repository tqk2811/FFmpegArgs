namespace FFmpegArgs.Filters.Autogens
{
public class WeaveFilterGen : ImageToImageFilter,ISliceThreading
{
internal WeaveFilterGen(ImageMap input) : base("weave",input) { AddMapOut(); }
/// <summary>
///  set first field (from 0 to 1) (default top)
/// </summary>
public WeaveFilterGen first_field(WeaveFilterGenFirst_field first_field) => this.SetOption("first_field", first_field.GetEnumAttribute<NameAttribute>().Name);
}
public static class WeaveFilterGenExtensions
{
/// <summary>
/// Weave input video fields into frames.
/// </summary>
public static WeaveFilterGen WeaveFilterGen(this ImageMap input0) => new WeaveFilterGen(input0);
/// <summary>
/// Weave input video fields into frames.
/// </summary>
public static WeaveFilterGen WeaveFilterGen(this ImageMap input0,WeaveFilterGenConfig config)
{
var result = new WeaveFilterGen(input0);
if(config?.first_field != null) result.first_field(config.first_field.Value);
return result;
}
}
public class WeaveFilterGenConfig
{
/// <summary>
///  set first field (from 0 to 1) (default top)
/// </summary>
public WeaveFilterGenFirst_field? first_field { get; set; }
}
public enum WeaveFilterGenFirst_field
{
[Name("top")] top,
[Name("t")] t,
[Name("bottom")] bottom,
[Name("b")] b,
}

}
