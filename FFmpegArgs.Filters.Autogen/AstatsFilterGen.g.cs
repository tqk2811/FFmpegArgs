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
public class AstatsFilterGen : AudioToAudioFilter,ISliceThreading
{
internal AstatsFilterGen(AudioMap input) : base("astats",input) { AddMapOut(); }
/// <summary>
///  set the window length (from 0.01 to 10) (default 0.05)
/// </summary>
public AstatsFilterGen length(double length) => this.SetOptionRange("length", length,0.01,10);
/// <summary>
///  inject metadata in the filtergraph (default false)
/// </summary>
public AstatsFilterGen metadata(bool flag) => this.SetOption("metadata",flag.ToFFmpegFlag());
/// <summary>
///  recalculate stats after this many frames (from 0 to INT_MAX) (default 0)
/// </summary>
public AstatsFilterGen reset(int reset) => this.SetOptionRange("reset", reset,0,INT_MAX);
/// <summary>
///  only measure_perchannel these per-channel statistics (default all+DC_offset+Min_level+Max_level+Min_difference+Max_difference+Mean_difference+RMS_difference+Peak_level+RMS_level+RMS_peak+RMS_trough+Crest_factor+Flat_factor+Peak_count+Bit_depth+Dynamic_range+Zero_crossings+Zero_crossings_rate+Noise_floor+Noise_floor_count+Number_of_samples+Number_of_NaNs+Number_of_Infs+Number_of_denormals)
/// </summary>
public AstatsFilterGen measure_perchannel(AstatsFilterGenMeasure_perchannel measure_perchannel) => this.SetOption("measure_perchannel", measure_perchannel.GetAttribute<NameAttribute>().Name);
/// <summary>
///  only measure_perchannel these overall statistics (default all+DC_offset+Min_level+Max_level+Min_difference+Max_difference+Mean_difference+RMS_difference+Peak_level+RMS_level+RMS_peak+RMS_trough+Crest_factor+Flat_factor+Peak_count+Bit_depth+Dynamic_range+Zero_crossings+Zero_crossings_rate+Noise_floor+Noise_floor_count+Number_of_samples+Number_of_NaNs+Number_of_Infs+Number_of_denormals)
/// </summary>
public AstatsFilterGen measure_overall(AstatsFilterGenMeasure_overall measure_overall) => this.SetOption("measure_overall", measure_overall.GetAttribute<NameAttribute>().Name);
}
public static class AstatsFilterGenExtensions
{
/// <summary>
/// Show time domain statistics about audio frames.
/// </summary>
public static AstatsFilterGen AstatsFilterGen(this AudioMap input) => new AstatsFilterGen(input);
}
public enum AstatsFilterGenMeasure_perchannel
{
[Name("none")] none,
[Name("all")] all,
[Name("DC_offset")] DC_offset,
[Name("Min_level")] Min_level,
[Name("Max_level")] Max_level,
[Name("Min_difference")] Min_difference,
[Name("Max_difference")] Max_difference,
[Name("Mean_difference")] Mean_difference,
[Name("RMS_difference")] RMS_difference,
[Name("Peak_level")] Peak_level,
[Name("RMS_level")] RMS_level,
[Name("RMS_peak")] RMS_peak,
[Name("RMS_trough")] RMS_trough,
[Name("Crest_factor")] Crest_factor,
[Name("Flat_factor")] Flat_factor,
[Name("Peak_count")] Peak_count,
[Name("Bit_depth")] Bit_depth,
[Name("Dynamic_range")] Dynamic_range,
[Name("Zero_crossings")] Zero_crossings,
[Name("Zero_crossings_rate")] Zero_crossings_rate,
[Name("Noise_floor")] Noise_floor,
[Name("Noise_floor_count")] Noise_floor_count,
[Name("Number_of_samples")] Number_of_samples,
[Name("Number_of_NaNs")] Number_of_NaNs,
[Name("Number_of_Infs")] Number_of_Infs,
[Name("Number_of_denormals")] Number_of_denormals,
}

public enum AstatsFilterGenMeasure_overall
{
[Name("none")] none,
[Name("all")] all,
[Name("DC_offset")] DC_offset,
[Name("Min_level")] Min_level,
[Name("Max_level")] Max_level,
[Name("Min_difference")] Min_difference,
[Name("Max_difference")] Max_difference,
[Name("Mean_difference")] Mean_difference,
[Name("RMS_difference")] RMS_difference,
[Name("Peak_level")] Peak_level,
[Name("RMS_level")] RMS_level,
[Name("RMS_peak")] RMS_peak,
[Name("RMS_trough")] RMS_trough,
[Name("Crest_factor")] Crest_factor,
[Name("Flat_factor")] Flat_factor,
[Name("Peak_count")] Peak_count,
[Name("Bit_depth")] Bit_depth,
[Name("Dynamic_range")] Dynamic_range,
[Name("Zero_crossings")] Zero_crossings,
[Name("Zero_crossings_rate")] Zero_crossings_rate,
[Name("Noise_floor")] Noise_floor,
[Name("Noise_floor_count")] Noise_floor_count,
[Name("Number_of_samples")] Number_of_samples,
[Name("Number_of_NaNs")] Number_of_NaNs,
[Name("Number_of_Infs")] Number_of_Infs,
[Name("Number_of_denormals")] Number_of_denormals,
}

}
