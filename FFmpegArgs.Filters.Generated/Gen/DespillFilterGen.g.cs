namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC despill           V->V       Despill video.
/// </summary>
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
/// <summary>
/// </summary>
public static class DespillFilterGenExtensions
{
/// <summary>
/// Despill video.
/// </summary>
public static DespillFilterGen DespillFilterGen(this ImageMap input0) => new DespillFilterGen(input0);
}
/// <summary>
///  set the screen type (from 0 to 1) (default green)
/// </summary>
public enum DespillFilterGenType
{
/// <summary>
/// green           0            ..FV.....T. greenscreen
/// </summary>
[Name("green")] green,
/// <summary>
/// blue            1            ..FV.....T. bluescreen
/// </summary>
[Name("blue")] blue,
}

}
