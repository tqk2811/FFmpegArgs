using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using FFmpegArgs;
using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
namespace FFmpegArgs.Filters.Autogens
{
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
public RubberbandFilterGen transients(RubberbandFilterGenTransients transients) => this.SetOption("transients", transients.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set detector (from 0 to INT_MAX) (default compound)
/// </summary>
public RubberbandFilterGen detector(RubberbandFilterGenDetector detector) => this.SetOption("detector", detector.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set phase (from 0 to INT_MAX) (default laminar)
/// </summary>
public RubberbandFilterGen phase(RubberbandFilterGenPhase phase) => this.SetOption("phase", phase.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set window (from 0 to INT_MAX) (default standard)
/// </summary>
public RubberbandFilterGen window(RubberbandFilterGenWindow window) => this.SetOption("window", window.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set smoothing (from 0 to INT_MAX) (default off)
/// </summary>
public RubberbandFilterGen smoothing(RubberbandFilterGenSmoothing smoothing) => this.SetOption("smoothing", smoothing.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set formant (from 0 to INT_MAX) (default shifted)
/// </summary>
public RubberbandFilterGen formant(RubberbandFilterGenFormant formant) => this.SetOption("formant", formant.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set pitch quality (from 0 to INT_MAX) (default speed)
/// </summary>
public RubberbandFilterGen pitchq(RubberbandFilterGenPitchq pitchq) => this.SetOption("pitchq", pitchq.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set channels (from 0 to INT_MAX) (default apart)
/// </summary>
public RubberbandFilterGen channels(RubberbandFilterGenChannels channels) => this.SetOption("channels", channels.GetAttribute<NameAttribute>().Name);
}
public static class RubberbandFilterGenExtensions
{
/// <summary>
/// Apply time-stretching and pitch-shifting.
/// </summary>
public static RubberbandFilterGen RubberbandFilterGen(this AudioMap input0) => new RubberbandFilterGen(input0);
/// <summary>
/// Apply time-stretching and pitch-shifting.
/// </summary>
public static RubberbandFilterGen RubberbandFilterGen(this AudioMap input0,RubberbandFilterGenConfig config)
{
var result = new RubberbandFilterGen(input0);
if(config?.tempo != null) result.tempo(config.tempo);
if(config?.pitch != null) result.pitch(config.pitch);
if(config?.transients != null) result.transients(config.transients);
if(config?.detector != null) result.detector(config.detector);
if(config?.phase != null) result.phase(config.phase);
if(config?.window != null) result.window(config.window);
if(config?.smoothing != null) result.smoothing(config.smoothing);
if(config?.formant != null) result.formant(config.formant);
if(config?.pitchq != null) result.pitchq(config.pitchq);
if(config?.channels != null) result.channels(config.channels);
return result;
}
}
public class RubberbandFilterGenConfig
{
/// <summary>
///  set tempo scale factor (from 0.01 to 100) (default 1)
/// </summary>
public double tempo { get; set; }
/// <summary>
///  set pitch scale factor (from 0.01 to 100) (default 1)
/// </summary>
public double pitch { get; set; }
/// <summary>
///  set transients (from 0 to INT_MAX) (default crisp)
/// </summary>
public RubberbandFilterGenTransients transients { get; set; }
/// <summary>
///  set detector (from 0 to INT_MAX) (default compound)
/// </summary>
public RubberbandFilterGenDetector detector { get; set; }
/// <summary>
///  set phase (from 0 to INT_MAX) (default laminar)
/// </summary>
public RubberbandFilterGenPhase phase { get; set; }
/// <summary>
///  set window (from 0 to INT_MAX) (default standard)
/// </summary>
public RubberbandFilterGenWindow window { get; set; }
/// <summary>
///  set smoothing (from 0 to INT_MAX) (default off)
/// </summary>
public RubberbandFilterGenSmoothing smoothing { get; set; }
/// <summary>
///  set formant (from 0 to INT_MAX) (default shifted)
/// </summary>
public RubberbandFilterGenFormant formant { get; set; }
/// <summary>
///  set pitch quality (from 0 to INT_MAX) (default speed)
/// </summary>
public RubberbandFilterGenPitchq pitchq { get; set; }
/// <summary>
///  set channels (from 0 to INT_MAX) (default apart)
/// </summary>
public RubberbandFilterGenChannels channels { get; set; }
}
public enum RubberbandFilterGenTransients
{
[Name("crisp")] crisp,
[Name("mixed")] mixed,
[Name("smooth")] smooth,
}

public enum RubberbandFilterGenDetector
{
[Name("compound")] compound,
[Name("percussive")] percussive,
[Name("soft")] soft,
}

public enum RubberbandFilterGenPhase
{
[Name("laminar")] laminar,
[Name("independent")] independent,
}

public enum RubberbandFilterGenWindow
{
[Name("standard")] standard,
[Name("short")] _short,
[Name("long")] _long,
}

public enum RubberbandFilterGenSmoothing
{
[Name("off")] off,
[Name("on")] on,
}

public enum RubberbandFilterGenFormant
{
[Name("shifted")] shifted,
[Name("preserved")] preserved,
}

public enum RubberbandFilterGenPitchq
{
[Name("quality")] quality,
[Name("speed")] speed,
[Name("consistency")] consistency,
}

public enum RubberbandFilterGenChannels
{
[Name("apart")] apart,
[Name("together")] together,
}

}
