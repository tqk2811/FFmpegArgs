namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// .S. waveform          V->V       Video waveform monitor.
/// </summary>
public class WaveformFilterGen : ImageToImageFilter,ISliceThreading
{
internal WaveformFilterGen(ImageMap input) : base("waveform",input) { AddMapOut(); }
/// <summary>
///  set mode (from 0 to 1) (default column)
/// </summary>
public WaveformFilterGen mode(WaveformFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set intensity (from 0 to 1) (default 0.04)
/// </summary>
public WaveformFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity,0,1);
/// <summary>
///  set mirroring (default true)
/// </summary>
public WaveformFilterGen mirror(bool mirror) => this.SetOption("mirror",mirror.ToFFmpegFlag());
/// <summary>
///  set mirroring (default true)
/// </summary>
public WaveformFilterGen r(bool r) => this.SetOption("r",r.ToFFmpegFlag());
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public WaveformFilterGen display(WaveformFilterGenDisplay display) => this.SetOption("display", display.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set components to display (from 1 to 15) (default 1)
/// </summary>
public WaveformFilterGen components(int components) => this.SetOptionRange("components", components,1,15);
/// <summary>
///  set envelope to display (from 0 to 3) (default none)
/// </summary>
public WaveformFilterGen envelope(WaveformFilterGenEnvelope envelope) => this.SetOption("envelope", envelope.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filter (from 0 to 7) (default lowpass)
/// </summary>
public WaveformFilterGen filter(WaveformFilterGenFilter filter) => this.SetOption("filter", filter.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public WaveformFilterGen graticule(WaveformFilterGenGraticule graticule) => this.SetOption("graticule", graticule.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set graticule opacity (from 0 to 1) (default 0.75)
/// </summary>
public WaveformFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
/// <summary>
///  set graticule flags (default numbers)
/// </summary>
public WaveformFilterGen flags(WaveformFilterGenFlags flags) => this.SetOption("flags", flags.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set scale (from 0 to 2) (default digital)
/// </summary>
public WaveformFilterGen scale(WaveformFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.75)
/// </summary>
public WaveformFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity,0,1);
/// <summary>
///  set 1st tint (from -1 to 1) (default 0)
/// </summary>
public WaveformFilterGen tint0(float tint0) => this.SetOptionRange("tint0", tint0,-1,1);
/// <summary>
///  set 1st tint (from -1 to 1) (default 0)
/// </summary>
public WaveformFilterGen t0(float t0) => this.SetOptionRange("t0", t0,-1,1);
/// <summary>
///  set 2nd tint (from -1 to 1) (default 0)
/// </summary>
public WaveformFilterGen tint1(float tint1) => this.SetOptionRange("tint1", tint1,-1,1);
/// <summary>
///  set 2nd tint (from -1 to 1) (default 0)
/// </summary>
public WaveformFilterGen t1(float t1) => this.SetOptionRange("t1", t1,-1,1);
}
/// <summary>
/// </summary>
public static class WaveformFilterGenExtensions
{
/// <summary>
/// Video waveform monitor.
/// </summary>
public static WaveformFilterGen WaveformFilterGen(this ImageMap input0) => new WaveformFilterGen(input0);
}
/// <summary>
///  set mode (from 0 to 1) (default column)
/// </summary>
public enum WaveformFilterGenMode
{
/// <summary>
/// row             0            ..FV.......
/// </summary>
[Name("row")] row,
/// <summary>
/// column          1            ..FV.......
/// </summary>
[Name("column")] column,
}

/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public enum WaveformFilterGenDisplay
{
/// <summary>
/// overlay         0            ..FV.......
/// </summary>
[Name("overlay")] overlay,
/// <summary>
/// stack           1            ..FV.......
/// </summary>
[Name("stack")] stack,
/// <summary>
/// parade          2            ..FV.......
/// </summary>
[Name("parade")] parade,
}

/// <summary>
///  set envelope to display (from 0 to 3) (default none)
/// </summary>
public enum WaveformFilterGenEnvelope
{
/// <summary>
/// none            0            ..FV.......
/// </summary>
[Name("none")] none,
/// <summary>
/// instant         1            ..FV.......
/// </summary>
[Name("instant")] instant,
/// <summary>
/// peak            2            ..FV.......
/// </summary>
[Name("peak")] peak,
/// <summary>
/// peak+instant    3            ..FV.......
/// </summary>
[Name("peak+instant")] peakPlusinstant,
}

/// <summary>
///  set filter (from 0 to 7) (default lowpass)
/// </summary>
public enum WaveformFilterGenFilter
{
/// <summary>
/// lowpass         0            ..FV.......
/// </summary>
[Name("lowpass")] lowpass,
/// <summary>
/// flat            1            ..FV.......
/// </summary>
[Name("flat")] flat,
/// <summary>
/// aflat           2            ..FV.......
/// </summary>
[Name("aflat")] aflat,
/// <summary>
/// chroma          3            ..FV.......
/// </summary>
[Name("chroma")] chroma,
/// <summary>
/// color           4            ..FV.......
/// </summary>
[Name("color")] color,
/// <summary>
/// acolor          5            ..FV.......
/// </summary>
[Name("acolor")] acolor,
/// <summary>
/// xflat           6            ..FV.......
/// </summary>
[Name("xflat")] xflat,
/// <summary>
/// yflat           7            ..FV.......
/// </summary>
[Name("yflat")] yflat,
}

/// <summary>
///  set graticule (from 0 to 3) (default none)
/// </summary>
public enum WaveformFilterGenGraticule
{
/// <summary>
/// none            0            ..FV.......
/// </summary>
[Name("none")] none,
/// <summary>
/// green           1            ..FV.......
/// </summary>
[Name("green")] green,
/// <summary>
/// orange          2            ..FV.......
/// </summary>
[Name("orange")] orange,
/// <summary>
/// invert          3            ..FV.......
/// </summary>
[Name("invert")] invert,
}

/// <summary>
///  set graticule flags (default numbers)
/// </summary>
public enum WaveformFilterGenFlags
{
/// <summary>
/// numbers                      ..FV....... draw numbers
/// </summary>
[Name("numbers")] numbers,
/// <summary>
/// dots                         ..FV....... draw dots instead of lines
/// </summary>
[Name("dots")] dots,
}

/// <summary>
///  set scale (from 0 to 2) (default digital)
/// </summary>
public enum WaveformFilterGenScale
{
/// <summary>
/// digital         0            ..FV.......
/// </summary>
[Name("digital")] digital,
/// <summary>
/// millivolts      1            ..FV.......
/// </summary>
[Name("millivolts")] millivolts,
/// <summary>
/// ire             2            ..FV.......
/// </summary>
[Name("ire")] ire,
}

}
