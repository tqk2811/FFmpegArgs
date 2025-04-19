namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC adynamicequalizer A-&gt;A       Apply Dynamic Equalization of input audio.
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
///  set detection attack duration (from 0.01 to 2000) (default 20)
/// </summary>
public AdynamicequalizerFilterGen attack(double attack) => this.SetOptionRange("attack", attack,0.01,2000);
/// <summary>
///  set detection release duration (from 0.01 to 2000) (default 200)
/// </summary>
public AdynamicequalizerFilterGen release(double release) => this.SetOptionRange("release", release,0.01,2000);
/// <summary>
///  set ratio factor (from 0 to 30) (default 1)
/// </summary>
public AdynamicequalizerFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,0,30);
/// <summary>
///  set makeup gain (from 0 to 1000) (default 0)
/// </summary>
public AdynamicequalizerFilterGen makeup(double makeup) => this.SetOptionRange("makeup", makeup,0,1000);
/// <summary>
///  set max gain (from 1 to 2000) (default 50)
/// </summary>
public AdynamicequalizerFilterGen range(double range) => this.SetOptionRange("range", range,1,2000);
/// <summary>
///  set mode (from -1 to 3) (default cutbelow)
/// </summary>
public AdynamicequalizerFilterGen mode(AdynamicequalizerFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set detection filter type (from 0 to 3) (default bandpass)
/// </summary>
public AdynamicequalizerFilterGen dftype(AdynamicequalizerFilterGenDftype dftype) => this.SetOption("dftype", dftype.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set target filter type (from 0 to 2) (default bell)
/// </summary>
public AdynamicequalizerFilterGen tftype(AdynamicequalizerFilterGenTftype tftype) => this.SetOption("tftype", tftype.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set auto threshold (from 1 to 4) (default off)
/// </summary>
public AdynamicequalizerFilterGen auto(AdynamicequalizerFilterGenAuto auto) => this.SetOption("auto", auto.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set processing precision (from 0 to 2) (default auto)
/// </summary>
public AdynamicequalizerFilterGen precision(AdynamicequalizerFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply Dynamic Equalization of input audio.
/// </summary>
public static AdynamicequalizerFilterGen AdynamicequalizerFilterGen(this AudioMap input0) => new AdynamicequalizerFilterGen(input0);
}
/// <summary>
///  set mode (from -1 to 3) (default cutbelow)
/// </summary>
public enum AdynamicequalizerFilterGenMode
{
/// <summary>
/// listen          -1           ..F.A....T.
/// </summary>
[Name("listen")] listen,
/// <summary>
/// cutbelow        0            ..F.A....T.
/// </summary>
[Name("cutbelow")] cutbelow,
/// <summary>
/// cutabove        1            ..F.A....T.
/// </summary>
[Name("cutabove")] cutabove,
/// <summary>
/// boostbelow      2            ..F.A....T.
/// </summary>
[Name("boostbelow")] boostbelow,
/// <summary>
/// boostabove      3            ..F.A....T.
/// </summary>
[Name("boostabove")] boostabove,
}

/// <summary>
///  set detection filter type (from 0 to 3) (default bandpass)
/// </summary>
public enum AdynamicequalizerFilterGenDftype
{
/// <summary>
/// bandpass        0            ..F.A....T.
/// </summary>
[Name("bandpass")] bandpass,
/// <summary>
/// lowpass         1            ..F.A....T.
/// </summary>
[Name("lowpass")] lowpass,
/// <summary>
/// highpass        2            ..F.A....T.
/// </summary>
[Name("highpass")] highpass,
/// <summary>
/// peak            3            ..F.A....T.
/// </summary>
[Name("peak")] peak,
}

/// <summary>
///  set target filter type (from 0 to 2) (default bell)
/// </summary>
public enum AdynamicequalizerFilterGenTftype
{
/// <summary>
/// bell            0            ..F.A....T.
/// </summary>
[Name("bell")] bell,
/// <summary>
/// lowshelf        1            ..F.A....T.
/// </summary>
[Name("lowshelf")] lowshelf,
/// <summary>
/// highshelf       2            ..F.A....T.
/// </summary>
[Name("highshelf")] highshelf,
}

/// <summary>
///  set auto threshold (from 1 to 4) (default off)
/// </summary>
public enum AdynamicequalizerFilterGenAuto
{
/// <summary>
/// disabled        1            ..F.A....T.
/// </summary>
[Name("disabled")] disabled,
/// <summary>
/// off             2            ..F.A....T.
/// </summary>
[Name("off")] off,
/// <summary>
/// on              3            ..F.A....T.
/// </summary>
[Name("on")] on,
/// <summary>
/// adaptive        4            ..F.A....T.
/// </summary>
[Name("adaptive")] adaptive,
}

/// <summary>
///  set processing precision (from 0 to 2) (default auto)
/// </summary>
public enum AdynamicequalizerFilterGenPrecision
{
/// <summary>
/// auto            0            ..F.A...... set auto processing precision
/// </summary>
[Name("auto")] auto,
/// <summary>
/// float           1            ..F.A...... set single-floating point processing precision
/// </summary>
[Name("float")] _float,
/// <summary>
/// double          2            ..F.A...... set double-floating point processing precision
/// </summary>
[Name("double")] _double,
}

}
