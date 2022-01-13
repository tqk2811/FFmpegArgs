namespace FFmpegArgs.Filters.Autogens
{
public class EqFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal EqFilterGen(ImageMap input) : base("eq",input) { AddMapOut(); }
/// <summary>
///  set the contrast adjustment, negative values give a negative image (default "1.0")
/// </summary>
public EqFilterGen contrast(string contrast) => this.SetOption("contrast",contrast);
/// <summary>
///  set the brightness adjustment (default "0.0")
/// </summary>
public EqFilterGen brightness(string brightness) => this.SetOption("brightness",brightness);
/// <summary>
///  set the saturation adjustment (default "1.0")
/// </summary>
public EqFilterGen saturation(string saturation) => this.SetOption("saturation",saturation);
/// <summary>
///  set the initial gamma value (default "1.0")
/// </summary>
public EqFilterGen gamma(string gamma) => this.SetOption("gamma",gamma);
/// <summary>
///  gamma value for red (default "1.0")
/// </summary>
public EqFilterGen gamma_r(string gamma_r) => this.SetOption("gamma_r",gamma_r);
/// <summary>
///  gamma value for green (default "1.0")
/// </summary>
public EqFilterGen gamma_g(string gamma_g) => this.SetOption("gamma_g",gamma_g);
/// <summary>
///  gamma value for blue (default "1.0")
/// </summary>
public EqFilterGen gamma_b(string gamma_b) => this.SetOption("gamma_b",gamma_b);
/// <summary>
///  set the gamma weight which reduces the effect of gamma on bright areas (default "1.0")
/// </summary>
public EqFilterGen gamma_weight(string gamma_weight) => this.SetOption("gamma_weight",gamma_weight);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public EqFilterGen eval(EqFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
}
public static class EqFilterGenExtensions
{
/// <summary>
/// Adjust brightness, contrast, gamma, and saturation.
/// </summary>
public static EqFilterGen EqFilterGen(this ImageMap input0) => new EqFilterGen(input0);
/// <summary>
/// Adjust brightness, contrast, gamma, and saturation.
/// </summary>
public static EqFilterGen EqFilterGen(this ImageMap input0,EqFilterGenConfig config)
{
var result = new EqFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.contrast)) result.contrast(config.contrast);
if(!string.IsNullOrWhiteSpace(config?.brightness)) result.brightness(config.brightness);
if(!string.IsNullOrWhiteSpace(config?.saturation)) result.saturation(config.saturation);
if(!string.IsNullOrWhiteSpace(config?.gamma)) result.gamma(config.gamma);
if(!string.IsNullOrWhiteSpace(config?.gamma_r)) result.gamma_r(config.gamma_r);
if(!string.IsNullOrWhiteSpace(config?.gamma_g)) result.gamma_g(config.gamma_g);
if(!string.IsNullOrWhiteSpace(config?.gamma_b)) result.gamma_b(config.gamma_b);
if(!string.IsNullOrWhiteSpace(config?.gamma_weight)) result.gamma_weight(config.gamma_weight);
if(config?.eval != null) result.eval(config.eval.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class EqFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set the contrast adjustment, negative values give a negative image (default "1.0")
/// </summary>
public string contrast { get; set; }
/// <summary>
///  set the brightness adjustment (default "0.0")
/// </summary>
public string brightness { get; set; }
/// <summary>
///  set the saturation adjustment (default "1.0")
/// </summary>
public string saturation { get; set; }
/// <summary>
///  set the initial gamma value (default "1.0")
/// </summary>
public string gamma { get; set; }
/// <summary>
///  gamma value for red (default "1.0")
/// </summary>
public string gamma_r { get; set; }
/// <summary>
///  gamma value for green (default "1.0")
/// </summary>
public string gamma_g { get; set; }
/// <summary>
///  gamma value for blue (default "1.0")
/// </summary>
public string gamma_b { get; set; }
/// <summary>
///  set the gamma weight which reduces the effect of gamma on bright areas (default "1.0")
/// </summary>
public string gamma_weight { get; set; }
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public EqFilterGenEval? eval { get; set; }
public string TimelineSupport { get; set; }
}
public enum EqFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

}
