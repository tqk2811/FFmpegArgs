namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .SC gradients         |-&gt;V       Draw a gradients.
/// </summary>
public class GradientsFilterGen : SourceToImageFilter,ISliceThreading,ICommandSupport
{
internal GradientsFilterGen(IImageFilterGraph input) : base("gradients",input) { AddMapOut(); }
/// <summary>
///  set frame size (default &quot;640x480&quot;)
/// </summary>
public GradientsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set frame rate (default &quot;25&quot;)
/// </summary>
public GradientsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set 1st color (default &quot;random&quot;)
/// </summary>
public GradientsFilterGen c0(Color c0) => this.SetOption("c0",c0.ToHexStringRGBA());
/// <summary>
///  set 2nd color (default &quot;random&quot;)
/// </summary>
public GradientsFilterGen c1(Color c1) => this.SetOption("c1",c1.ToHexStringRGBA());
/// <summary>
///  set 3rd color (default &quot;random&quot;)
/// </summary>
public GradientsFilterGen c2(Color c2) => this.SetOption("c2",c2.ToHexStringRGBA());
/// <summary>
///  set 4th color (default &quot;random&quot;)
/// </summary>
public GradientsFilterGen c3(Color c3) => this.SetOption("c3",c3.ToHexStringRGBA());
/// <summary>
///  set 5th color (default &quot;random&quot;)
/// </summary>
public GradientsFilterGen c4(Color c4) => this.SetOption("c4",c4.ToHexStringRGBA());
/// <summary>
///  set 6th color (default &quot;random&quot;)
/// </summary>
public GradientsFilterGen c5(Color c5) => this.SetOption("c5",c5.ToHexStringRGBA());
/// <summary>
///  set 7th color (default &quot;random&quot;)
/// </summary>
public GradientsFilterGen c6(Color c6) => this.SetOption("c6",c6.ToHexStringRGBA());
/// <summary>
///  set 8th color (default &quot;random&quot;)
/// </summary>
public GradientsFilterGen c7(Color c7) => this.SetOption("c7",c7.ToHexStringRGBA());
/// <summary>
///  set gradient line source x0 (from -1 to INT_MAX) (default -1)
/// </summary>
public GradientsFilterGen x0(int x0) => this.SetOptionRange("x0", x0,-1,INT_MAX);
/// <summary>
///  set gradient line source y0 (from -1 to INT_MAX) (default -1)
/// </summary>
public GradientsFilterGen y0(int y0) => this.SetOptionRange("y0", y0,-1,INT_MAX);
/// <summary>
///  set gradient line destination x1 (from -1 to INT_MAX) (default -1)
/// </summary>
public GradientsFilterGen x1(int x1) => this.SetOptionRange("x1", x1,-1,INT_MAX);
/// <summary>
///  set gradient line destination y1 (from -1 to INT_MAX) (default -1)
/// </summary>
public GradientsFilterGen y1(int y1) => this.SetOptionRange("y1", y1,-1,INT_MAX);
/// <summary>
///  set the number of colors (from 2 to 8) (default 2)
/// </summary>
public GradientsFilterGen nb_colors(int nb_colors) => this.SetOptionRange("nb_colors", nb_colors,2,8);
/// <summary>
///  set the seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public GradientsFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public GradientsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set gradients rotation speed (from 0 to 1) (default 0.01)
/// </summary>
public GradientsFilterGen speed(float speed) => this.SetOptionRange("speed", speed,0,1);
/// <summary>
///  set gradient type (from 0 to 4) (default linear)
/// </summary>
public GradientsFilterGen type(GradientsFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Draw a gradients.
/// </summary>
public static GradientsFilterGen GradientsFilterGen(this IImageFilterGraph input0) => new GradientsFilterGen(input0);
}
/// <summary>
///  set gradient type (from 0 to 4) (default linear)
/// </summary>
public enum GradientsFilterGenType
{
/// <summary>
/// linear          0            ..FV.....T. set linear gradient
/// </summary>
[Name("linear")] linear,
/// <summary>
/// radial          1            ..FV.....T. set radial gradient
/// </summary>
[Name("radial")] radial,
/// <summary>
/// circular        2            ..FV.....T. set circular gradient
/// </summary>
[Name("circular")] circular,
/// <summary>
/// spiral          3            ..FV.....T. set spiral gradient
/// </summary>
[Name("spiral")] spiral,
/// <summary>
/// square          4            ..FV.....T. set square gradient
/// </summary>
[Name("square")] square,
}

}
