namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C eq                V-&gt;V       Adjust brightness, contrast, gamma, and saturation.
/// </summary>
public class EqFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal EqFilterGen(ImageMap input) : base("eq",input) { AddMapOut(); }
/// <summary>
///  set the contrast adjustment, negative values give a negative image (default &quot;1.0&quot;)
/// </summary>
public EqFilterGen contrast(string contrast) => this.SetOption("contrast",contrast);
/// <summary>
///  set the brightness adjustment (default &quot;0.0&quot;)
/// </summary>
public EqFilterGen brightness(string brightness) => this.SetOption("brightness",brightness);
/// <summary>
///  set the saturation adjustment (default &quot;1.0&quot;)
/// </summary>
public EqFilterGen saturation(string saturation) => this.SetOption("saturation",saturation);
/// <summary>
///  set the initial gamma value (default &quot;1.0&quot;)
/// </summary>
public EqFilterGen gamma(string gamma) => this.SetOption("gamma",gamma);
/// <summary>
///  gamma value for red (default &quot;1.0&quot;)
/// </summary>
public EqFilterGen gamma_r(string gamma_r) => this.SetOption("gamma_r",gamma_r);
/// <summary>
///  gamma value for green (default &quot;1.0&quot;)
/// </summary>
public EqFilterGen gamma_g(string gamma_g) => this.SetOption("gamma_g",gamma_g);
/// <summary>
///  gamma value for blue (default &quot;1.0&quot;)
/// </summary>
public EqFilterGen gamma_b(string gamma_b) => this.SetOption("gamma_b",gamma_b);
/// <summary>
///  set the gamma weight which reduces the effect of gamma on bright areas (default &quot;1.0&quot;)
/// </summary>
public EqFilterGen gamma_weight(string gamma_weight) => this.SetOption("gamma_weight",gamma_weight);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public EqFilterGen eval(EqFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Adjust brightness, contrast, gamma, and saturation.
/// </summary>
public static EqFilterGen EqFilterGen(this ImageMap input0) => new EqFilterGen(input0);
}
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public enum EqFilterGenEval
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
