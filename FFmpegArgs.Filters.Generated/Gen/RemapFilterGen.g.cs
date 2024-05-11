namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. remap             VVV-&gt;V     Remap pixels.
/// </summary>
public class RemapFilterGen : ImageToImageFilter,ISliceThreading
{
internal RemapFilterGen(params ImageMap[] inputs) : base("remap",inputs) { AddMapOut(); }
/// <summary>
///  set output format (from 0 to 1) (default color)
/// </summary>
public RemapFilterGen format(RemapFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the color of the unmapped pixels (default &quot;black&quot;)
/// </summary>
public RemapFilterGen fill(Color fill) => this.SetOption("fill",fill.ToHexStringRGBA());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Remap pixels.
/// </summary>
public static RemapFilterGen RemapFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new RemapFilterGen(input0, input1, input2);
}
/// <summary>
///  set output format (from 0 to 1) (default color)
/// </summary>
public enum RemapFilterGenFormat
{
/// <summary>
/// color           0            ..FV.......
/// </summary>
[Name("color")] color,
/// <summary>
/// gray            1            ..FV.......
/// </summary>
[Name("gray")] gray,
}

}
