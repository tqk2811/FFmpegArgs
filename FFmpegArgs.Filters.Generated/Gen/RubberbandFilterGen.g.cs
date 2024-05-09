namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ..C rubberband        A->A       Apply time-stretching and pitch-shifting.
/// </summary>
public class RubberbandFilterGen : AudioToAudioFilter,ICommandSupport
{
internal RubberbandFilterGen(AudioMap input) : base("rubberband",input) { AddMapOut(); }
/// <summary>
///  set tempo scale factor (from 0.01 to 100) (default 1)
/// </summary>
public RubberbandFilterGen tempo(double tempo) => this.SetOptionRange("tempo", tempo,0.01,100);
/// <summary>
///  set pitch scale factor (from 0.01 to 100) (default 1)
/// </summary>
public RubberbandFilterGen pitch(double pitch) => this.SetOptionRange("pitch", pitch,0.01,100);
/// <summary>
///  set transients (from 0 to INT_MAX) (default crisp)
/// </summary>
public RubberbandFilterGen transients(RubberbandFilterGenTransients transients) => this.SetOption("transients", transients.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set detector (from 0 to INT_MAX) (default compound)
/// </summary>
public RubberbandFilterGen detector(RubberbandFilterGenDetector detector) => this.SetOption("detector", detector.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set phase (from 0 to INT_MAX) (default laminar)
/// </summary>
public RubberbandFilterGen phase(RubberbandFilterGenPhase phase) => this.SetOption("phase", phase.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set window (from 0 to INT_MAX) (default standard)
/// </summary>
public RubberbandFilterGen window(RubberbandFilterGenWindow window) => this.SetOption("window", window.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set smoothing (from 0 to INT_MAX) (default off)
/// </summary>
public RubberbandFilterGen smoothing(RubberbandFilterGenSmoothing smoothing) => this.SetOption("smoothing", smoothing.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set formant (from 0 to INT_MAX) (default shifted)
/// </summary>
public RubberbandFilterGen formant(RubberbandFilterGenFormant formant) => this.SetOption("formant", formant.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set pitch quality (from 0 to INT_MAX) (default speed)
/// </summary>
public RubberbandFilterGen pitchq(RubberbandFilterGenPitchq pitchq) => this.SetOption("pitchq", pitchq.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set channels (from 0 to INT_MAX) (default apart)
/// </summary>
public RubberbandFilterGen channels(RubberbandFilterGenChannels channels) => this.SetOption("channels", channels.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class RubberbandFilterGenExtensions
{
/// <summary>
/// Apply time-stretching and pitch-shifting.
/// </summary>
public static RubberbandFilterGen RubberbandFilterGen(this AudioMap input0) => new RubberbandFilterGen(input0);
}
/// <summary>
///  set transients (from 0 to INT_MAX) (default crisp)
/// </summary>
public enum RubberbandFilterGenTransients
{
/// <summary>
/// crisp           0            ..F.A......
/// </summary>
[Name("crisp")] crisp,
/// <summary>
/// mixed           256          ..F.A......
/// </summary>
[Name("mixed")] mixed,
/// <summary>
/// smooth          512          ..F.A......
/// </summary>
[Name("smooth")] smooth,
}

/// <summary>
///  set detector (from 0 to INT_MAX) (default compound)
/// </summary>
public enum RubberbandFilterGenDetector
{
/// <summary>
/// compound        0            ..F.A......
/// </summary>
[Name("compound")] compound,
/// <summary>
/// percussive      1024         ..F.A......
/// </summary>
[Name("percussive")] percussive,
/// <summary>
/// soft            2048         ..F.A......
/// </summary>
[Name("soft")] soft,
}

/// <summary>
///  set phase (from 0 to INT_MAX) (default laminar)
/// </summary>
public enum RubberbandFilterGenPhase
{
/// <summary>
/// laminar         0            ..F.A......
/// </summary>
[Name("laminar")] laminar,
/// <summary>
/// independent     8192         ..F.A......
/// </summary>
[Name("independent")] independent,
}

/// <summary>
///  set window (from 0 to INT_MAX) (default standard)
/// </summary>
public enum RubberbandFilterGenWindow
{
/// <summary>
/// standard        0            ..F.A......
/// </summary>
[Name("standard")] standard,
/// <summary>
/// short           1048576      ..F.A......
/// </summary>
[Name("short")] _short,
/// <summary>
/// long            2097152      ..F.A......
/// </summary>
[Name("long")] _long,
}

/// <summary>
///  set smoothing (from 0 to INT_MAX) (default off)
/// </summary>
public enum RubberbandFilterGenSmoothing
{
/// <summary>
/// off             0            ..F.A......
/// </summary>
[Name("off")] off,
/// <summary>
/// on              8388608      ..F.A......
/// </summary>
[Name("on")] on,
}

/// <summary>
///  set formant (from 0 to INT_MAX) (default shifted)
/// </summary>
public enum RubberbandFilterGenFormant
{
/// <summary>
/// shifted         0            ..F.A......
/// </summary>
[Name("shifted")] shifted,
/// <summary>
/// preserved       16777216     ..F.A......
/// </summary>
[Name("preserved")] preserved,
}

/// <summary>
///  set pitch quality (from 0 to INT_MAX) (default speed)
/// </summary>
public enum RubberbandFilterGenPitchq
{
/// <summary>
/// quality         33554432     ..F.A......
/// </summary>
[Name("quality")] quality,
/// <summary>
/// speed           0            ..F.A......
/// </summary>
[Name("speed")] speed,
/// <summary>
/// consistency     67108864     ..F.A......
/// </summary>
[Name("consistency")] consistency,
}

/// <summary>
///  set channels (from 0 to INT_MAX) (default apart)
/// </summary>
public enum RubberbandFilterGenChannels
{
/// <summary>
/// apart           0            ..F.A......
/// </summary>
[Name("apart")] apart,
/// <summary>
/// together        268435456    ..F.A......
/// </summary>
[Name("together")] together,
}

}
