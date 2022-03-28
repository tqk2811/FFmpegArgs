namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC adynamicequalizer A->A       Apply Dynamic Equalization of input audio.
/// </summary>
public class AdynamicequalizerFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AdynamicequalizerFilterGen(AudioMap input) : base("adynamicequalizer",input) { AddMapOut(); }
/// <summary>
///  set detection threshold (from 0 to 100) (default 0)
/// </summary>
public AdynamicequalizerFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,100);
/// <summary>
///  set detection frequency (from 2 to 1e+06) (default 1000)
/// </summary>
public AdynamicequalizerFilterGen dfrequency(double dfrequency) => this.SetOptionRange("dfrequency", dfrequency,2,1e+06);
/// <summary>
///  set detection Q factor (from 0.001 to 1000) (default 1)
/// </summary>
public AdynamicequalizerFilterGen dqfactor(double dqfactor) => this.SetOptionRange("dqfactor", dqfactor,0.001,1000);
/// <summary>
///  set target frequency (from 2 to 1e+06) (default 1000)
/// </summary>
public AdynamicequalizerFilterGen tfrequency(double tfrequency) => this.SetOptionRange("tfrequency", tfrequency,2,1e+06);
/// <summary>
///  set target Q factor (from 0.001 to 1000) (default 1)
/// </summary>
public AdynamicequalizerFilterGen tqfactor(double tqfactor) => this.SetOptionRange("tqfactor", tqfactor,0.001,1000);
/// <summary>
///  set attack duration (from 1 to 2000) (default 20)
/// </summary>
public AdynamicequalizerFilterGen attack(double attack) => this.SetOptionRange("attack", attack,1,2000);
/// <summary>
///  set release duration (from 1 to 2000) (default 200)
/// </summary>
public AdynamicequalizerFilterGen release(double release) => this.SetOptionRange("release", release,1,2000);
/// <summary>
///  set knee factor (from 0 to 8) (default 1)
/// </summary>
public AdynamicequalizerFilterGen knee(double knee) => this.SetOptionRange("knee", knee,0,8);
/// <summary>
///  set ratio factor (from 1 to 20) (default 1)
/// </summary>
public AdynamicequalizerFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,1,20);
/// <summary>
///  set makeup gain (from 0 to 30) (default 0)
/// </summary>
public AdynamicequalizerFilterGen makeup(double makeup) => this.SetOptionRange("makeup", makeup,0,30);
/// <summary>
///  set max gain (from 0 to 200) (default 0)
/// </summary>
public AdynamicequalizerFilterGen range(double range) => this.SetOptionRange("range", range,0,200);
/// <summary>
///  set slew factor (from 1 to 200) (default 1)
/// </summary>
public AdynamicequalizerFilterGen slew(double slew) => this.SetOptionRange("slew", slew,1,200);
/// <summary>
///  set mode (from -1 to 1) (default cut)
/// </summary>
public AdynamicequalizerFilterGen mode(AdynamicequalizerFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class AdynamicequalizerFilterGenExtensions
{
/// <summary>
/// Apply Dynamic Equalization of input audio.
/// </summary>
public static AdynamicequalizerFilterGen AdynamicequalizerFilterGen(this AudioMap input0) => new AdynamicequalizerFilterGen(input0);
}
/// <summary>
///  set mode (from -1 to 1) (default cut)
/// </summary>
public enum AdynamicequalizerFilterGenMode
{
/// <summary>
/// listen          -1           ..F.A....T.
/// </summary>
[Name("listen")] listen,
/// <summary>
/// cut             0            ..F.A....T.
/// </summary>
[Name("cut")] cut,
/// <summary>
/// boost           1            ..F.A....T.
/// </summary>
[Name("boost")] boost,
}

}
