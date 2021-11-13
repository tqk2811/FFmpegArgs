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
public class ApadFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal ApadFilterGen(AudioMap input) : base("apad",input) { AddMapOut(); }
/// <summary>
///  set silence packet size (from 0 to INT_MAX) (default 4096)
/// </summary>
public ApadFilterGen packet_size(int packet_size) => this.SetOptionRange("packet_size", packet_size,0,INT_MAX);
/// <summary>
///  set number of samples of silence to add (from -1 to I64_MAX) (default -1)
/// </summary>
public ApadFilterGen pad_len(long pad_len) => this.SetOptionRange("pad_len", pad_len,-1,I64_MAX);
/// <summary>
///  set minimum target number of samples in the audio stream (from -1 to I64_MAX) (default -1)
/// </summary>
public ApadFilterGen whole_len(long whole_len) => this.SetOptionRange("whole_len", whole_len,-1,I64_MAX);
/// <summary>
///  set duration of silence to add (default 0)
/// </summary>
public ApadFilterGen pad_dur(TimeSpan pad_dur) => this.SetOptionRange("pad_dur",pad_dur,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set minimum target duration in the audio stream (default 0)
/// </summary>
public ApadFilterGen whole_dur(TimeSpan whole_dur) => this.SetOptionRange("whole_dur",whole_dur,TimeSpan.Zero,TimeSpan.MaxValue);
}
public static class ApadFilterGenExtensions
{
/// <summary>
/// Pad audio with silence.
/// </summary>
public static ApadFilterGen ApadFilterGen(this AudioMap input0) => new ApadFilterGen(input0);
}
}
