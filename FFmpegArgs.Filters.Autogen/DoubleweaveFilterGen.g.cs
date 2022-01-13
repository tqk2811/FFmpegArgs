namespace FFmpegArgs.Filters.Autogens
{
public class DoubleweaveFilterGen : ImageToImageFilter,ISliceThreading
{
internal DoubleweaveFilterGen(ImageMap input) : base("doubleweave",input) { AddMapOut(); }
/// <summary>
///  set first field (from 0 to 1) (default top)
/// </summary>
public DoubleweaveFilterGen first_field(DoubleweaveFilterGenFirst_field first_field) => this.SetOption("first_field", first_field.GetEnumAttribute<NameAttribute>().Name);
}
public static class DoubleweaveFilterGenExtensions
{
/// <summary>
/// Weave input video fields into double number of frames.
/// </summary>
public static DoubleweaveFilterGen DoubleweaveFilterGen(this ImageMap input0) => new DoubleweaveFilterGen(input0);
/// <summary>
/// Weave input video fields into double number of frames.
/// </summary>
public static DoubleweaveFilterGen DoubleweaveFilterGen(this ImageMap input0,DoubleweaveFilterGenConfig config)
{
var result = new DoubleweaveFilterGen(input0);
if(config?.first_field != null) result.first_field(config.first_field.Value);
return result;
}
}
public class DoubleweaveFilterGenConfig
{
/// <summary>
///  set first field (from 0 to 1) (default top)
/// </summary>
public DoubleweaveFilterGenFirst_field? first_field { get; set; }
}
public enum DoubleweaveFilterGenFirst_field
{
[Name("top")] top,
[Name("t")] t,
[Name("bottom")] bottom,
[Name("b")] b,
}

}
