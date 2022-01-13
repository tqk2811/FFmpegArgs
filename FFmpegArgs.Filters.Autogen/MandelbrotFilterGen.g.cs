namespace FFmpegArgs.Filters.Autogens
{
public class MandelbrotFilterGen : SourceImageFilter
{
internal MandelbrotFilterGen(FilterGraph input) : base("mandelbrot",input) { AddMapOut(); }
/// <summary>
///  set frame size (default "640x480")
/// </summary>
public MandelbrotFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set frame rate (default "25")
/// </summary>
public MandelbrotFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set max iterations number (from 1 to INT_MAX) (default 7189)
/// </summary>
public MandelbrotFilterGen maxiter(int maxiter) => this.SetOptionRange("maxiter", maxiter,1,INT_MAX);
/// <summary>
///  set the initial x position (from -100 to 100) (default -0.743644)
/// </summary>
public MandelbrotFilterGen start_x(double start_x) => this.SetOptionRange("start_x", start_x,-100,100);
/// <summary>
///  set the initial y position (from -100 to 100) (default -0.131826)
/// </summary>
public MandelbrotFilterGen start_y(double start_y) => this.SetOptionRange("start_y", start_y,-100,100);
/// <summary>
///  set the initial scale value (from 0 to FLT_MAX) (default 3)
/// </summary>
public MandelbrotFilterGen start_scale(double start_scale) => this.SetOptionRange("start_scale", start_scale,0,FLT_MAX);
/// <summary>
///  set the terminal scale value (from 0 to FLT_MAX) (default 0.3)
/// </summary>
public MandelbrotFilterGen end_scale(double end_scale) => this.SetOptionRange("end_scale", end_scale,0,FLT_MAX);
/// <summary>
///  set the terminal pts value (from 0 to I64_MAX) (default 400)
/// </summary>
public MandelbrotFilterGen end_pts(double end_pts) => this.SetOptionRange("end_pts", end_pts,0,I64_MAX);
/// <summary>
///  set the bailout value (from 0 to FLT_MAX) (default 10)
/// </summary>
public MandelbrotFilterGen bailout(double bailout) => this.SetOptionRange("bailout", bailout,0,FLT_MAX);
/// <summary>
///  set morph x frequency (from -FLT_MAX to FLT_MAX) (default 0.01)
/// </summary>
public MandelbrotFilterGen morphxf(double morphxf) => this.SetOptionRange("morphxf", morphxf,-FLT_MAX,FLT_MAX);
/// <summary>
///  set morph y frequency (from -FLT_MAX to FLT_MAX) (default 0.0123)
/// </summary>
public MandelbrotFilterGen morphyf(double morphyf) => this.SetOptionRange("morphyf", morphyf,-FLT_MAX,FLT_MAX);
/// <summary>
///  set morph amplitude (from -FLT_MAX to FLT_MAX) (default 0)
/// </summary>
public MandelbrotFilterGen morphamp(double morphamp) => this.SetOptionRange("morphamp", morphamp,-FLT_MAX,FLT_MAX);
/// <summary>
///  set outer coloring mode (from 0 to INT_MAX) (default normalized_iteration_count)
/// </summary>
public MandelbrotFilterGen outer(MandelbrotFilterGenOuter outer) => this.SetOption("outer", outer.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set inner coloring mode (from 0 to INT_MAX) (default mincol)
/// </summary>
public MandelbrotFilterGen inner(MandelbrotFilterGenInner inner) => this.SetOption("inner", inner.GetEnumAttribute<NameAttribute>().Name);
}
public static class MandelbrotFilterGenExtensions
{
/// <summary>
/// Render a Mandelbrot fractal.
/// </summary>
public static MandelbrotFilterGen MandelbrotFilterGen(this FilterGraph input0) => new MandelbrotFilterGen(input0);
/// <summary>
/// Render a Mandelbrot fractal.
/// </summary>
public static MandelbrotFilterGen MandelbrotFilterGen(this FilterGraph input0,MandelbrotFilterGenConfig config)
{
var result = new MandelbrotFilterGen(input0);
if(config?.size != null) result.size(config.size.Value);
if(config?.rate != null) result.rate(config.rate);
if(config?.maxiter != null) result.maxiter(config.maxiter.Value);
if(config?.start_x != null) result.start_x(config.start_x.Value);
if(config?.start_y != null) result.start_y(config.start_y.Value);
if(config?.start_scale != null) result.start_scale(config.start_scale.Value);
if(config?.end_scale != null) result.end_scale(config.end_scale.Value);
if(config?.end_pts != null) result.end_pts(config.end_pts.Value);
if(config?.bailout != null) result.bailout(config.bailout.Value);
if(config?.morphxf != null) result.morphxf(config.morphxf.Value);
if(config?.morphyf != null) result.morphyf(config.morphyf.Value);
if(config?.morphamp != null) result.morphamp(config.morphamp.Value);
if(config?.outer != null) result.outer(config.outer.Value);
if(config?.inner != null) result.inner(config.inner.Value);
return result;
}
}
public class MandelbrotFilterGenConfig
{
/// <summary>
///  set frame size (default "640x480")
/// </summary>
public Size? size { get; set; }
/// <summary>
///  set frame rate (default "25")
/// </summary>
public Rational rate { get; set; }
/// <summary>
///  set max iterations number (from 1 to INT_MAX) (default 7189)
/// </summary>
public int? maxiter { get; set; }
/// <summary>
///  set the initial x position (from -100 to 100) (default -0.743644)
/// </summary>
public double? start_x { get; set; }
/// <summary>
///  set the initial y position (from -100 to 100) (default -0.131826)
/// </summary>
public double? start_y { get; set; }
/// <summary>
///  set the initial scale value (from 0 to FLT_MAX) (default 3)
/// </summary>
public double? start_scale { get; set; }
/// <summary>
///  set the terminal scale value (from 0 to FLT_MAX) (default 0.3)
/// </summary>
public double? end_scale { get; set; }
/// <summary>
///  set the terminal pts value (from 0 to I64_MAX) (default 400)
/// </summary>
public double? end_pts { get; set; }
/// <summary>
///  set the bailout value (from 0 to FLT_MAX) (default 10)
/// </summary>
public double? bailout { get; set; }
/// <summary>
///  set morph x frequency (from -FLT_MAX to FLT_MAX) (default 0.01)
/// </summary>
public double? morphxf { get; set; }
/// <summary>
///  set morph y frequency (from -FLT_MAX to FLT_MAX) (default 0.0123)
/// </summary>
public double? morphyf { get; set; }
/// <summary>
///  set morph amplitude (from -FLT_MAX to FLT_MAX) (default 0)
/// </summary>
public double? morphamp { get; set; }
/// <summary>
///  set outer coloring mode (from 0 to INT_MAX) (default normalized_iteration_count)
/// </summary>
public MandelbrotFilterGenOuter? outer { get; set; }
/// <summary>
///  set inner coloring mode (from 0 to INT_MAX) (default mincol)
/// </summary>
public MandelbrotFilterGenInner? inner { get; set; }
}
public enum MandelbrotFilterGenOuter
{
[Name("iteration_count")] iteration_count,
[Name("normalized_iteration_count")] normalized_iteration_count,
[Name("white")] white,
[Name("outz")] outz,
}

public enum MandelbrotFilterGenInner
{
[Name("black")] black,
[Name("period")] period,
[Name("convergence")] convergence,
[Name("mincol")] mincol,
}

}
