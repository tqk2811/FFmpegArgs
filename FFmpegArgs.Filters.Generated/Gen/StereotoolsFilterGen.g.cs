namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C stereotools       A->A       Apply various stereo tools.
/// </summary>
public class StereotoolsFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal StereotoolsFilterGen(AudioMap input) : base("stereotools",input) { AddMapOut(); }
/// <summary>
///  set level in (from 0.015625 to 64) (default 1)
/// </summary>
public StereotoolsFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set level out (from 0.015625 to 64) (default 1)
/// </summary>
public StereotoolsFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0.015625,64);
/// <summary>
///  set balance in (from -1 to 1) (default 0)
/// </summary>
public StereotoolsFilterGen balance_in(double balance_in) => this.SetOptionRange("balance_in", balance_in,-1,1);
/// <summary>
///  set balance out (from -1 to 1) (default 0)
/// </summary>
public StereotoolsFilterGen balance_out(double balance_out) => this.SetOptionRange("balance_out", balance_out,-1,1);
/// <summary>
///  enable softclip (default false)
/// </summary>
public StereotoolsFilterGen softclip(bool softclip) => this.SetOption("softclip",softclip.ToFFmpegFlag());
/// <summary>
///  mute L (default false)
/// </summary>
public StereotoolsFilterGen mutel(bool mutel) => this.SetOption("mutel",mutel.ToFFmpegFlag());
/// <summary>
///  mute R (default false)
/// </summary>
public StereotoolsFilterGen muter(bool muter) => this.SetOption("muter",muter.ToFFmpegFlag());
/// <summary>
///  phase L (default false)
/// </summary>
public StereotoolsFilterGen phasel(bool phasel) => this.SetOption("phasel",phasel.ToFFmpegFlag());
/// <summary>
///  phase R (default false)
/// </summary>
public StereotoolsFilterGen phaser(bool phaser) => this.SetOption("phaser",phaser.ToFFmpegFlag());
/// <summary>
///  set stereo mode (from 0 to 10) (default lr>lr)
/// </summary>
public StereotoolsFilterGen mode(StereotoolsFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set side level (from 0.015625 to 64) (default 1)
/// </summary>
public StereotoolsFilterGen slev(double slev) => this.SetOptionRange("slev", slev,0.015625,64);
/// <summary>
///  set side balance (from -1 to 1) (default 0)
/// </summary>
public StereotoolsFilterGen sbal(double sbal) => this.SetOptionRange("sbal", sbal,-1,1);
/// <summary>
///  set middle level (from 0.015625 to 64) (default 1)
/// </summary>
public StereotoolsFilterGen mlev(double mlev) => this.SetOptionRange("mlev", mlev,0.015625,64);
/// <summary>
///  set middle pan (from -1 to 1) (default 0)
/// </summary>
public StereotoolsFilterGen mpan(double mpan) => this.SetOptionRange("mpan", mpan,-1,1);
/// <summary>
///  set stereo base (from -1 to 1) (default 0)
/// </summary>
public StereotoolsFilterGen _base(double _base) => this.SetOptionRange("base", _base,-1,1);
/// <summary>
///  set delay (from -20 to 20) (default 0)
/// </summary>
public StereotoolsFilterGen delay(double delay) => this.SetOptionRange("delay", delay,-20,20);
/// <summary>
///  set S/C level (from 1 to 100) (default 1)
/// </summary>
public StereotoolsFilterGen sclevel(double sclevel) => this.SetOptionRange("sclevel", sclevel,1,100);
/// <summary>
///  set stereo phase (from 0 to 360) (default 0)
/// </summary>
public StereotoolsFilterGen phase(double phase) => this.SetOptionRange("phase", phase,0,360);
/// <summary>
///  set balance in mode (from 0 to 2) (default balance)
/// </summary>
public StereotoolsFilterGen bmode_in(StereotoolsFilterGenBmode_in bmode_in) => this.SetOption("bmode_in", bmode_in.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set balance out mode (from 0 to 2) (default balance)
/// </summary>
public StereotoolsFilterGen bmode_out(StereotoolsFilterGenBmode_out bmode_out) => this.SetOption("bmode_out", bmode_out.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply various stereo tools.
/// </summary>
public static StereotoolsFilterGen StereotoolsFilterGen(this AudioMap input0) => new StereotoolsFilterGen(input0);
}
/// <summary>
///  set stereo mode (from 0 to 10) (default lr>lr)
/// </summary>
public enum StereotoolsFilterGenMode
{
/// <summary>
/// lr>lr           0            ..F.A....T.
/// </summary>
[Name("lr>lr")] lrGreaterThanlr,
/// <summary>
/// lr>ms           1            ..F.A....T.
/// </summary>
[Name("lr>ms")] lrGreaterThanms,
/// <summary>
/// ms>lr           2            ..F.A....T.
/// </summary>
[Name("ms>lr")] msGreaterThanlr,
/// <summary>
/// lr>ll           3            ..F.A....T.
/// </summary>
[Name("lr>ll")] lrGreaterThanll,
/// <summary>
/// lr>rr           4            ..F.A....T.
/// </summary>
[Name("lr>rr")] lrGreaterThanrr,
/// <summary>
/// lr>l+r          5            ..F.A....T.
/// </summary>
[Name("lr>l+r")] lrGreaterThanlPlusr,
/// <summary>
/// lr>rl           6            ..F.A....T.
/// </summary>
[Name("lr>rl")] lrGreaterThanrl,
/// <summary>
/// ms>ll           7            ..F.A....T.
/// </summary>
[Name("ms>ll")] msGreaterThanll,
/// <summary>
/// ms>rr           8            ..F.A....T.
/// </summary>
[Name("ms>rr")] msGreaterThanrr,
/// <summary>
/// ms>rl           9            ..F.A....T.
/// </summary>
[Name("ms>rl")] msGreaterThanrl,
/// <summary>
/// lr>l-r          10           ..F.A....T.
/// </summary>
[Name("lr>l-r")] lrGreaterThanl_r,
}

/// <summary>
///  set balance in mode (from 0 to 2) (default balance)
/// </summary>
public enum StereotoolsFilterGenBmode_in
{
/// <summary>
/// balance         0            ..F.A....T.
/// </summary>
[Name("balance")] balance,
/// <summary>
/// amplitude       1            ..F.A....T.
/// </summary>
[Name("amplitude")] amplitude,
/// <summary>
/// power           2            ..F.A....T.
/// </summary>
[Name("power")] power,
}

/// <summary>
///  set balance out mode (from 0 to 2) (default balance)
/// </summary>
public enum StereotoolsFilterGenBmode_out
{
/// <summary>
/// balance         0            ..F.A....T.
/// </summary>
[Name("balance")] balance,
/// <summary>
/// amplitude       1            ..F.A....T.
/// </summary>
[Name("amplitude")] amplitude,
/// <summary>
/// power           2            ..F.A....T.
/// </summary>
[Name("power")] power,
}

}
