namespace FFmpegArgs.Filters.Autogens
{
public class DespillFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal DespillFilterGen(ImageMap input) : base("despill",input) { AddMapOut(); }
/// <summary>
///  set the screen type (from 0 to 1) (default green)
/// </summary>
public DespillFilterGen type(DespillFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the spillmap mix (from 0 to 1) (default 0.5)
/// </summary>
public DespillFilterGen mix(float mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set the spillmap expand (from 0 to 1) (default 0)
/// </summary>
public DespillFilterGen expand(float expand) => this.SetOptionRange("expand", expand,0,1);
/// <summary>
///  set red scale (from -100 to 100) (default 0)
/// </summary>
public DespillFilterGen red(float red) => this.SetOptionRange("red", red,-100,100);
/// <summary>
///  set green scale (from -100 to 100) (default -1)
/// </summary>
public DespillFilterGen green(float green) => this.SetOptionRange("green", green,-100,100);
/// <summary>
///  set blue scale (from -100 to 100) (default 0)
/// </summary>
public DespillFilterGen blue(float blue) => this.SetOptionRange("blue", blue,-100,100);
/// <summary>
///  set brightness (from -10 to 10) (default 0)
/// </summary>
public DespillFilterGen brightness(float brightness) => this.SetOptionRange("brightness", brightness,-10,10);
/// <summary>
///  change alpha component (default false)
/// </summary>
public DespillFilterGen alpha(bool alpha) => this.SetOption("alpha",alpha.ToFFmpegFlag());
}
public static class DespillFilterGenExtensions
{
/// <summary>
/// Despill video.
/// </summary>
public static DespillFilterGen DespillFilterGen(this ImageMap input0) => new DespillFilterGen(input0);
/// <summary>
/// Despill video.
/// </summary>
public static DespillFilterGen DespillFilterGen(this ImageMap input0,DespillFilterGenConfig config)
{
var result = new DespillFilterGen(input0);
if(config?.type != null) result.type(config.type.Value);
if(config?.mix != null) result.mix(config.mix.Value);
if(config?.expand != null) result.expand(config.expand.Value);
if(config?.red != null) result.red(config.red.Value);
if(config?.green != null) result.green(config.green.Value);
if(config?.blue != null) result.blue(config.blue.Value);
if(config?.brightness != null) result.brightness(config.brightness.Value);
if(config?.alpha != null) result.alpha(config.alpha.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class DespillFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set the screen type (from 0 to 1) (default green)
/// </summary>
public DespillFilterGenType? type { get; set; }
/// <summary>
///  set the spillmap mix (from 0 to 1) (default 0.5)
/// </summary>
public float? mix { get; set; }
/// <summary>
///  set the spillmap expand (from 0 to 1) (default 0)
/// </summary>
public float? expand { get; set; }
/// <summary>
///  set red scale (from -100 to 100) (default 0)
/// </summary>
public float? red { get; set; }
/// <summary>
///  set green scale (from -100 to 100) (default -1)
/// </summary>
public float? green { get; set; }
/// <summary>
///  set blue scale (from -100 to 100) (default 0)
/// </summary>
public float? blue { get; set; }
/// <summary>
///  set brightness (from -10 to 10) (default 0)
/// </summary>
public float? brightness { get; set; }
/// <summary>
///  change alpha component (default false)
/// </summary>
public bool? alpha { get; set; }
public string TimelineSupport { get; set; }
}
public enum DespillFilterGenType
{
[Name("green")] green,
[Name("blue")] blue,
}

}
