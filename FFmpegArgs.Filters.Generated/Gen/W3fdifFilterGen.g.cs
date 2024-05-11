namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC w3fdif            V-&gt;V       Apply Martin Weston three field deinterlace.
/// </summary>
public class W3fdifFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal W3fdifFilterGen(ImageMap input) : base("w3fdif",input) { AddMapOut(); }
/// <summary>
///  specify the filter (from 0 to 1) (default complex)
/// </summary>
public W3fdifFilterGen filter(W3fdifFilterGenFilter filter) => this.SetOption("filter", filter.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify the interlacing mode (from 0 to 1) (default field)
/// </summary>
public W3fdifFilterGen mode(W3fdifFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public W3fdifFilterGen parity(W3fdifFilterGenParity parity) => this.SetOption("parity", parity.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public W3fdifFilterGen deint(W3fdifFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply Martin Weston three field deinterlace.
/// </summary>
public static W3fdifFilterGen W3fdifFilterGen(this ImageMap input0) => new W3fdifFilterGen(input0);
}
/// <summary>
///  specify the filter (from 0 to 1) (default complex)
/// </summary>
public enum W3fdifFilterGenFilter
{
/// <summary>
/// simple          0            ..FV.....T.
/// </summary>
[Name("simple")] simple,
/// <summary>
/// complex         1            ..FV.....T.
/// </summary>
[Name("complex")] complex,
}

/// <summary>
///  specify the interlacing mode (from 0 to 1) (default field)
/// </summary>
public enum W3fdifFilterGenMode
{
/// <summary>
/// frame           0            ..FV.....T. send one frame for each frame
/// </summary>
[Name("frame")] frame,
/// <summary>
/// field           1            ..FV.....T. send one frame for each field
/// </summary>
[Name("field")] field,
}

/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public enum W3fdifFilterGenParity
{
/// <summary>
/// tff             0            ..FV.....T. assume top field first
/// </summary>
[Name("tff")] tff,
/// <summary>
/// bff             1            ..FV.....T. assume bottom field first
/// </summary>
[Name("bff")] bff,
/// <summary>
/// auto            -1           ..FV.....T. auto detect parity
/// </summary>
[Name("auto")] auto,
}

/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public enum W3fdifFilterGenDeint
{
/// <summary>
/// all             0            ..FV.....T. deinterlace all frames
/// </summary>
[Name("all")] all,
/// <summary>
/// interlaced      1            ..FV.....T. only deinterlace frames marked as interlaced
/// </summary>
[Name("interlaced")] interlaced,
}

}
