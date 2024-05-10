namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC colorchannelmixer V->V       Adjust colors by mixing color channels.
/// </summary>
public class ColorchannelmixerFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorchannelmixerFilterGen(ImageMap input) : base("colorchannelmixer",input) { AddMapOut(); }
/// <summary>
///  set the red gain for the red channel (from -2 to 2) (default 1)
/// </summary>
public ColorchannelmixerFilterGen rr(double rr) => this.SetOptionRange("rr", rr,-2,2);
/// <summary>
///  set the green gain for the red channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen rg(double rg) => this.SetOptionRange("rg", rg,-2,2);
/// <summary>
///  set the blue gain for the red channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen rb(double rb) => this.SetOptionRange("rb", rb,-2,2);
/// <summary>
///  set the alpha gain for the red channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ra(double ra) => this.SetOptionRange("ra", ra,-2,2);
/// <summary>
///  set the red gain for the green channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen gr(double gr) => this.SetOptionRange("gr", gr,-2,2);
/// <summary>
///  set the green gain for the green channel (from -2 to 2) (default 1)
/// </summary>
public ColorchannelmixerFilterGen gg(double gg) => this.SetOptionRange("gg", gg,-2,2);
/// <summary>
///  set the blue gain for the green channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen gb(double gb) => this.SetOptionRange("gb", gb,-2,2);
/// <summary>
///  set the alpha gain for the green channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ga(double ga) => this.SetOptionRange("ga", ga,-2,2);
/// <summary>
///  set the red gain for the blue channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen br(double br) => this.SetOptionRange("br", br,-2,2);
/// <summary>
///  set the green gain for the blue channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen bg(double bg) => this.SetOptionRange("bg", bg,-2,2);
/// <summary>
///  set the blue gain for the blue channel (from -2 to 2) (default 1)
/// </summary>
public ColorchannelmixerFilterGen bb(double bb) => this.SetOptionRange("bb", bb,-2,2);
/// <summary>
///  set the alpha gain for the blue channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ba(double ba) => this.SetOptionRange("ba", ba,-2,2);
/// <summary>
///  set the red gain for the alpha channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ar(double ar) => this.SetOptionRange("ar", ar,-2,2);
/// <summary>
///  set the green gain for the alpha channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ag(double ag) => this.SetOptionRange("ag", ag,-2,2);
/// <summary>
///  set the blue gain for the alpha channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ab(double ab) => this.SetOptionRange("ab", ab,-2,2);
/// <summary>
///  set the alpha gain for the alpha channel (from -2 to 2) (default 1)
/// </summary>
public ColorchannelmixerFilterGen aa(double aa) => this.SetOptionRange("aa", aa,-2,2);
/// <summary>
///  set the preserve color mode (from 0 to 6) (default none)
/// </summary>
public ColorchannelmixerFilterGen pc(ColorchannelmixerFilterGenPc pc) => this.SetOption("pc", pc.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the preserve color amount (from 0 to 1) (default 0)
/// </summary>
public ColorchannelmixerFilterGen pa(double pa) => this.SetOptionRange("pa", pa,0,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Adjust colors by mixing color channels.
/// </summary>
public static ColorchannelmixerFilterGen ColorchannelmixerFilterGen(this ImageMap input0) => new ColorchannelmixerFilterGen(input0);
}
/// <summary>
///  set the preserve color mode (from 0 to 6) (default none)
/// </summary>
public enum ColorchannelmixerFilterGenPc
{
/// <summary>
/// none            0            ..FV.....T. disabled
/// </summary>
[Name("none")] none,
/// <summary>
/// lum             1            ..FV.....T. luminance
/// </summary>
[Name("lum")] lum,
/// <summary>
/// max             2            ..FV.....T. max
/// </summary>
[Name("max")] max,
/// <summary>
/// avg             3            ..FV.....T. average
/// </summary>
[Name("avg")] avg,
/// <summary>
/// sum             4            ..FV.....T. sum
/// </summary>
[Name("sum")] sum,
/// <summary>
/// nrm             5            ..FV.....T. norm
/// </summary>
[Name("nrm")] nrm,
/// <summary>
/// pwr             6            ..FV.....T. power
/// </summary>
[Name("pwr")] pwr,
}

}
