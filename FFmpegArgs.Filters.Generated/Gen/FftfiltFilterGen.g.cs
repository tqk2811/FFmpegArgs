namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. fftfilt           V->V       Apply arbitrary expressions to pixels in frequency domain.
/// </summary>
public class FftfiltFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal FftfiltFilterGen(ImageMap input) : base("fftfilt",input) { AddMapOut(); }
/// <summary>
///  adjust gain in Y plane (from 0 to 1000) (default 0)
/// </summary>
public FftfiltFilterGen dc_Y(int dc_Y) => this.SetOptionRange("dc_Y", dc_Y,0,1000);
/// <summary>
///  adjust gain in U plane (from 0 to 1000) (default 0)
/// </summary>
public FftfiltFilterGen dc_U(int dc_U) => this.SetOptionRange("dc_U", dc_U,0,1000);
/// <summary>
///  adjust gain in V plane (from 0 to 1000) (default 0)
/// </summary>
public FftfiltFilterGen dc_V(int dc_V) => this.SetOptionRange("dc_V", dc_V,0,1000);
/// <summary>
///  set luminance expression in Y plane (default "1")
/// </summary>
public FftfiltFilterGen weight_Y(ExpressionValue weight_Y) => this.SetOption("weight_Y",(string)weight_Y);
/// <summary>
///  set chrominance expression in U plane
/// </summary>
public FftfiltFilterGen weight_U(ExpressionValue weight_U) => this.SetOption("weight_U",(string)weight_U);
/// <summary>
///  set chrominance expression in V plane
/// </summary>
public FftfiltFilterGen weight_V(ExpressionValue weight_V) => this.SetOption("weight_V",(string)weight_V);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public FftfiltFilterGen eval(FftfiltFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply arbitrary expressions to pixels in frequency domain.
/// </summary>
public static FftfiltFilterGen FftfiltFilterGen(this ImageMap input0) => new FftfiltFilterGen(input0);
}
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public enum FftfiltFilterGenEval
{
/// <summary>
/// init            0            ..FV....... eval expressions once during initialization
/// </summary>
[Name("init")] init,
/// <summary>
/// frame           1            ..FV....... eval expressions per-frame
/// </summary>
[Name("frame")] frame,
}

}
