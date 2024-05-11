namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... apulsator         A-&gt;A       Audio pulsator.
/// </summary>
public class ApulsatorFilterGen : AudioToAudioFilter
{
internal ApulsatorFilterGen(AudioMap input) : base("apulsator",input) { AddMapOut(); }
/// <summary>
///  set input gain (from 0.015625 to 64) (default 1)
/// </summary>
public ApulsatorFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set output gain (from 0.015625 to 64) (default 1)
/// </summary>
public ApulsatorFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0.015625,64);
/// <summary>
///  set mode (from 0 to 4) (default sine)
/// </summary>
public ApulsatorFilterGen mode(ApulsatorFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set modulation (from 0 to 1) (default 1)
/// </summary>
public ApulsatorFilterGen amount(double amount) => this.SetOptionRange("amount", amount,0,1);
/// <summary>
///  set offset L (from 0 to 1) (default 0)
/// </summary>
public ApulsatorFilterGen offset_l(double offset_l) => this.SetOptionRange("offset_l", offset_l,0,1);
/// <summary>
///  set offset R (from 0 to 1) (default 0.5)
/// </summary>
public ApulsatorFilterGen offset_r(double offset_r) => this.SetOptionRange("offset_r", offset_r,0,1);
/// <summary>
///  set pulse width (from 0 to 2) (default 1)
/// </summary>
public ApulsatorFilterGen width(double width) => this.SetOptionRange("width", width,0,2);
/// <summary>
///  set timing (from 0 to 2) (default hz)
/// </summary>
public ApulsatorFilterGen timing(ApulsatorFilterGenTiming timing) => this.SetOption("timing", timing.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set BPM (from 30 to 300) (default 120)
/// </summary>
public ApulsatorFilterGen bpm(double bpm) => this.SetOptionRange("bpm", bpm,30,300);
/// <summary>
///  set ms (from 10 to 2000) (default 500)
/// </summary>
public ApulsatorFilterGen ms(int ms) => this.SetOptionRange("ms", ms,10,2000);
/// <summary>
///  set frequency (from 0.01 to 100) (default 2)
/// </summary>
public ApulsatorFilterGen hz(double hz) => this.SetOptionRange("hz", hz,0.01,100);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Audio pulsator.
/// </summary>
public static ApulsatorFilterGen ApulsatorFilterGen(this AudioMap input0) => new ApulsatorFilterGen(input0);
}
/// <summary>
///  set mode (from 0 to 4) (default sine)
/// </summary>
public enum ApulsatorFilterGenMode
{
/// <summary>
/// sine            0            ..F.A......
/// </summary>
[Name("sine")] sine,
/// <summary>
/// triangle        1            ..F.A......
/// </summary>
[Name("triangle")] triangle,
/// <summary>
/// square          2            ..F.A......
/// </summary>
[Name("square")] square,
/// <summary>
/// sawup           3            ..F.A......
/// </summary>
[Name("sawup")] sawup,
/// <summary>
/// sawdown         4            ..F.A......
/// </summary>
[Name("sawdown")] sawdown,
}

/// <summary>
///  set timing (from 0 to 2) (default hz)
/// </summary>
public enum ApulsatorFilterGenTiming
{
/// <summary>
/// bpm             0            ..F.A......
/// </summary>
[Name("bpm")] bpm,
/// <summary>
/// ms              1            ..F.A......
/// </summary>
[Name("ms")] ms,
/// <summary>
/// hz              2            ..F.A......
/// </summary>
[Name("hz")] hz,
}

}
