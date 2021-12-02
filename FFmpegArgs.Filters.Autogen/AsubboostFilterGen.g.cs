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
public class AsubboostFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsubboostFilterGen(AudioMap input) : base("asubboost",input) { AddMapOut(); }
/// <summary>
///  set dry gain (from 0 to 1) (default 0.7)
/// </summary>
public AsubboostFilterGen dry(double dry) => this.SetOptionRange("dry", dry,0,1);
/// <summary>
///  set wet gain (from 0 to 1) (default 0.7)
/// </summary>
public AsubboostFilterGen wet(double wet) => this.SetOptionRange("wet", wet,0,1);
/// <summary>
///  set decay (from 0 to 1) (default 0.7)
/// </summary>
public AsubboostFilterGen decay(double decay) => this.SetOptionRange("decay", decay,0,1);
/// <summary>
///  set feedback (from 0 to 1) (default 0.9)
/// </summary>
public AsubboostFilterGen feedback(double feedback) => this.SetOptionRange("feedback", feedback,0,1);
/// <summary>
///  set cutoff (from 50 to 900) (default 100)
/// </summary>
public AsubboostFilterGen cutoff(double cutoff) => this.SetOptionRange("cutoff", cutoff,50,900);
/// <summary>
///  set slope (from 0.0001 to 1) (default 0.5)
/// </summary>
public AsubboostFilterGen slope(double slope) => this.SetOptionRange("slope", slope,0.0001,1);
/// <summary>
///  set delay (from 1 to 100) (default 20)
/// </summary>
public AsubboostFilterGen delay(double delay) => this.SetOptionRange("delay", delay,1,100);
}
public static class AsubboostFilterGenExtensions
{
/// <summary>
/// Boost subwoofer frequencies.
/// </summary>
public static AsubboostFilterGen AsubboostFilterGen(this AudioMap input0) => new AsubboostFilterGen(input0);
/// <summary>
/// Boost subwoofer frequencies.
/// </summary>
public static AsubboostFilterGen AsubboostFilterGen(this AudioMap input0,AsubboostFilterGenConfig config)
{
var result = new AsubboostFilterGen(input0);
if(config?.dry != null) result.dry(config.dry.Value);
if(config?.wet != null) result.wet(config.wet.Value);
if(config?.decay != null) result.decay(config.decay.Value);
if(config?.feedback != null) result.feedback(config.feedback.Value);
if(config?.cutoff != null) result.cutoff(config.cutoff.Value);
if(config?.slope != null) result.slope(config.slope.Value);
if(config?.delay != null) result.delay(config.delay.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AsubboostFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set dry gain (from 0 to 1) (default 0.7)
/// </summary>
public double? dry { get; set; }
/// <summary>
///  set wet gain (from 0 to 1) (default 0.7)
/// </summary>
public double? wet { get; set; }
/// <summary>
///  set decay (from 0 to 1) (default 0.7)
/// </summary>
public double? decay { get; set; }
/// <summary>
///  set feedback (from 0 to 1) (default 0.9)
/// </summary>
public double? feedback { get; set; }
/// <summary>
///  set cutoff (from 50 to 900) (default 100)
/// </summary>
public double? cutoff { get; set; }
/// <summary>
///  set slope (from 0.0001 to 1) (default 0.5)
/// </summary>
public double? slope { get; set; }
/// <summary>
///  set delay (from 1 to 100) (default 20)
/// </summary>
public double? delay { get; set; }
public string TimelineSupport { get; set; }
}
}
