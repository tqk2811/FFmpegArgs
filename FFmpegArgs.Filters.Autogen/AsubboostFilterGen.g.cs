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
}
}
