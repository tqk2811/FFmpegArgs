namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... afireqsrc         |->A       Generate a FIR equalizer coefficients audio stream.
/// </summary>
public class AfireqsrcFilterGen : SourceAudioFilter
{
internal AfireqsrcFilterGen(IAudioFilterGraph input) : base("afireqsrc",input) { AddMapOut(); }
/// <summary>
///  set equalizer preset (from -1 to 17) (default flat)
/// </summary>
public AfireqsrcFilterGen preset(AfireqsrcFilterGenPreset preset) => this.SetOption("preset", preset.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set gain values per band (default "0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0")
/// </summary>
public AfireqsrcFilterGen gains(string gains) => this.SetOption("gains",gains);
/// <summary>
///  set central frequency values per band (default "25 40 63 100 160 250 400 630 1000 1600 2500 4000 6300 10000 16000 24000")
/// </summary>
public AfireqsrcFilterGen bands(string bands) => this.SetOption("bands",bands);
/// <summary>
///  set number of taps (from 16 to 65535) (default 4096)
/// </summary>
public AfireqsrcFilterGen taps(int taps) => this.SetOptionRange("taps", taps,16,65535);
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public AfireqsrcFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,1,INT_MAX);
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public AfireqsrcFilterGen r(int r) => this.SetOptionRange("r", r,1,INT_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public AfireqsrcFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,INT_MAX);
/// <summary>
///  set the interpolation (from 0 to 1) (default linear)
/// </summary>
public AfireqsrcFilterGen interp(AfireqsrcFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the phase (from 0 to 1) (default min)
/// </summary>
public AfireqsrcFilterGen phase(AfireqsrcFilterGenPhase phase) => this.SetOption("phase", phase.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the phase (from 0 to 1) (default min)
/// </summary>
public AfireqsrcFilterGen h(AfireqsrcFilterGenH h) => this.SetOption("h", h.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class AfireqsrcFilterGenExtensions
{
/// <summary>
/// Generate a FIR equalizer coefficients audio stream.
/// </summary>
public static AfireqsrcFilterGen AfireqsrcFilterGen(this IAudioFilterGraph input0) => new AfireqsrcFilterGen(input0);
}
/// <summary>
///  set equalizer preset (from -1 to 17) (default flat)
/// </summary>
public enum AfireqsrcFilterGenPreset
{
/// <summary>
/// custom          -1           ..F.A......
/// </summary>
[Name("custom")] custom,
/// <summary>
/// flat            0            ..F.A......
/// </summary>
[Name("flat")] flat,
/// <summary>
/// acoustic        1            ..F.A......
/// </summary>
[Name("acoustic")] acoustic,
/// <summary>
/// bass            2            ..F.A......
/// </summary>
[Name("bass")] bass,
/// <summary>
/// beats           3            ..F.A......
/// </summary>
[Name("beats")] beats,
/// <summary>
/// classic         4            ..F.A......
/// </summary>
[Name("classic")] classic,
/// <summary>
/// clear           5            ..F.A......
/// </summary>
[Name("clear")] clear,
/// <summary>
/// dubstep         7            ..F.A......
/// </summary>
[Name("dubstep")] dubstep,
/// <summary>
/// electronic      8            ..F.A......
/// </summary>
[Name("electronic")] electronic,
/// <summary>
/// hardstyle       9            ..F.A......
/// </summary>
[Name("hardstyle")] hardstyle,
/// <summary>
/// hip-hop         10           ..F.A......
/// </summary>
[Name("hip-hop")] hip_hop,
/// <summary>
/// jazz            11           ..F.A......
/// </summary>
[Name("jazz")] jazz,
/// <summary>
/// metal           12           ..F.A......
/// </summary>
[Name("metal")] metal,
/// <summary>
/// movie           13           ..F.A......
/// </summary>
[Name("movie")] movie,
/// <summary>
/// pop             14           ..F.A......
/// </summary>
[Name("pop")] pop,
/// <summary>
/// rock            16           ..F.A......
/// </summary>
[Name("rock")] rock,
}

/// <summary>
///  set the interpolation (from 0 to 1) (default linear)
/// </summary>
public enum AfireqsrcFilterGenInterp
{
/// <summary>
/// linear          0            ..F.A......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// cubic           1            ..F.A......
/// </summary>
[Name("cubic")] cubic,
}

/// <summary>
///  set the phase (from 0 to 1) (default min)
/// </summary>
public enum AfireqsrcFilterGenPhase
{
/// <summary>
/// linear          0            ..F.A...... linear phase
/// </summary>
[Name("linear")] linear,
/// <summary>
/// min             1            ..F.A...... minimum phase
/// </summary>
[Name("min")] min,
}

/// <summary>
///  set the phase (from 0 to 1) (default min)
/// </summary>
public enum AfireqsrcFilterGenH
{
/// <summary>
/// linear          0            ..F.A...... linear phase
/// </summary>
[Name("linear")] linear,
/// <summary>
/// min             1            ..F.A...... minimum phase
/// </summary>
[Name("min")] min,
}

}
