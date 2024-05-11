namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. sierpinski        |-&gt;V       Render a Sierpinski fractal.
/// </summary>
public class SierpinskiFilterGen : SourceToImageFilter,ISliceThreading
{
internal SierpinskiFilterGen(IImageFilterGraph input) : base("sierpinski",input) { AddMapOut(); }
/// <summary>
///  set frame size (default &quot;640x480&quot;)
/// </summary>
public SierpinskiFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set frame rate (default &quot;25&quot;)
/// </summary>
public SierpinskiFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set the seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public SierpinskiFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  set the jump (from 1 to 10000) (default 100)
/// </summary>
public SierpinskiFilterGen jump(int jump) => this.SetOptionRange("jump", jump,1,10000);
/// <summary>
///  set fractal type (from 0 to 1) (default carpet)
/// </summary>
public SierpinskiFilterGen type(SierpinskiFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Render a Sierpinski fractal.
/// </summary>
public static SierpinskiFilterGen SierpinskiFilterGen(this IImageFilterGraph input0) => new SierpinskiFilterGen(input0);
}
/// <summary>
///  set fractal type (from 0 to 1) (default carpet)
/// </summary>
public enum SierpinskiFilterGenType
{
/// <summary>
/// carpet          0            ..FV....... sierpinski carpet
/// </summary>
[Name("carpet")] carpet,
/// <summary>
/// triangle        1            ..FV....... sierpinski triangle
/// </summary>
[Name("triangle")] triangle,
}

}
