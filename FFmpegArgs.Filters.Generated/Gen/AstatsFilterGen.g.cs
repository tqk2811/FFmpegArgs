namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. astats            A-&gt;A       Show time domain statistics about audio frames.
/// </summary>
public class AstatsFilterGen : AudioToAudioFilter,ISliceThreading
{
internal AstatsFilterGen(AudioMap input) : base("astats",input) { AddMapOut(); }
/// <summary>
///  set the window length (from 0 to 10) (default 0.05)
/// </summary>
public AstatsFilterGen length(double length) => this.SetOptionRange("length", length,0,10);
/// <summary>
///  inject metadata in the filtergraph (default false)
/// </summary>
public AstatsFilterGen metadata(bool metadata) => this.SetOption("metadata",metadata.ToFFmpegFlag());
/// <summary>
///  Set the number of frames over which cumulative stats are calculated before being reset (from 0 to INT_MAX) (default 0)
/// </summary>
public AstatsFilterGen reset(int reset) => this.SetOptionRange("reset", reset,0,INT_MAX);
/// <summary>
///  Select the parameters which are measured per channel (default all+Bit_depth+Crest_factor+DC_offset+Dynamic_range+Entropy+Flat_factor+Max_difference+Max_level+Mean_difference+Min_difference+Min_level+Noise_floor+Noise_floor_count+Number_of_Infs+Number_of_NaNs+Number_of_denormals+Number_of_samples+Peak_count+Peak_level+RMS_difference+RMS_level+RMS_peak+RMS_trough+Zero_crossings+Zero_crossings_rate+Abs_Peak_count)
/// </summary>
public AstatsFilterGen measure_perchannel(AstatsFilterGenMeasure_perchannel measure_perchannel) => this.SetOption("measure_perchannel", measure_perchannel.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Select the parameters which are measured overall (default all+Bit_depth+Crest_factor+DC_offset+Dynamic_range+Entropy+Flat_factor+Max_difference+Max_level+Mean_difference+Min_difference+Min_level+Noise_floor+Noise_floor_count+Number_of_Infs+Number_of_NaNs+Number_of_denormals+Number_of_samples+Peak_count+Peak_level+RMS_difference+RMS_level+RMS_peak+RMS_trough+Zero_crossings+Zero_crossings_rate+Abs_Peak_count)
/// </summary>
public AstatsFilterGen measure_overall(AstatsFilterGenMeasure_overall measure_overall) => this.SetOption("measure_overall", measure_overall.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Show time domain statistics about audio frames.
/// </summary>
public static AstatsFilterGen AstatsFilterGen(this AudioMap input0) => new AstatsFilterGen(input0);
}
/// <summary>
///  Select the parameters which are measured per channel (default all+Bit_depth+Crest_factor+DC_offset+Dynamic_range+Entropy+Flat_factor+Max_difference+Max_level+Mean_difference+Min_difference+Min_level+Noise_floor+Noise_floor_count+Number_of_Infs+Number_of_NaNs+Number_of_denormals+Number_of_samples+Peak_count+Peak_level+RMS_difference+RMS_level+RMS_peak+RMS_trough+Zero_crossings+Zero_crossings_rate+Abs_Peak_count)
/// </summary>
public enum AstatsFilterGenMeasure_perchannel
{
/// <summary>
/// none                         ..F.A......
/// </summary>
[Name("none")] none,
/// <summary>
/// all                          ..F.A......
/// </summary>
[Name("all")] all,
/// <summary>
/// Bit_depth                    ..F.A......
/// </summary>
[Name("Bit_depth")] Bit_depth,
/// <summary>
/// Crest_factor                 ..F.A......
/// </summary>
[Name("Crest_factor")] Crest_factor,
/// <summary>
/// DC_offset                    ..F.A......
/// </summary>
[Name("DC_offset")] DC_offset,
/// <summary>
/// Dynamic_range                ..F.A......
/// </summary>
[Name("Dynamic_range")] Dynamic_range,
/// <summary>
/// Entropy                      ..F.A......
/// </summary>
[Name("Entropy")] Entropy,
/// <summary>
/// Flat_factor                  ..F.A......
/// </summary>
[Name("Flat_factor")] Flat_factor,
/// <summary>
/// Max_difference               ..F.A......
/// </summary>
[Name("Max_difference")] Max_difference,
/// <summary>
/// Max_level                    ..F.A......
/// </summary>
[Name("Max_level")] Max_level,
/// <summary>
/// Mean_difference              ..F.A......
/// </summary>
[Name("Mean_difference")] Mean_difference,
/// <summary>
/// Min_difference               ..F.A......
/// </summary>
[Name("Min_difference")] Min_difference,
/// <summary>
/// Min_level                    ..F.A......
/// </summary>
[Name("Min_level")] Min_level,
/// <summary>
/// Noise_floor                  ..F.A......
/// </summary>
[Name("Noise_floor")] Noise_floor,
/// <summary>
/// Noise_floor_count              ..F.A......
/// </summary>
[Name("Noise_floor_count")] Noise_floor_count,
/// <summary>
/// Number_of_Infs               ..F.A......
/// </summary>
[Name("Number_of_Infs")] Number_of_Infs,
/// <summary>
/// Number_of_NaNs               ..F.A......
/// </summary>
[Name("Number_of_NaNs")] Number_of_NaNs,
/// <summary>
/// Number_of_denormals              ..F.A......
/// </summary>
[Name("Number_of_denormals")] Number_of_denormals,
/// <summary>
/// Number_of_samples              ..F.A......
/// </summary>
[Name("Number_of_samples")] Number_of_samples,
/// <summary>
/// Peak_count                   ..F.A......
/// </summary>
[Name("Peak_count")] Peak_count,
/// <summary>
/// Peak_level                   ..F.A......
/// </summary>
[Name("Peak_level")] Peak_level,
/// <summary>
/// RMS_difference               ..F.A......
/// </summary>
[Name("RMS_difference")] RMS_difference,
/// <summary>
/// RMS_level                    ..F.A......
/// </summary>
[Name("RMS_level")] RMS_level,
/// <summary>
/// RMS_peak                     ..F.A......
/// </summary>
[Name("RMS_peak")] RMS_peak,
/// <summary>
/// RMS_trough                   ..F.A......
/// </summary>
[Name("RMS_trough")] RMS_trough,
/// <summary>
/// Zero_crossings               ..F.A......
/// </summary>
[Name("Zero_crossings")] Zero_crossings,
/// <summary>
/// Zero_crossings_rate              ..F.A......
/// </summary>
[Name("Zero_crossings_rate")] Zero_crossings_rate,
/// <summary>
/// Abs_Peak_count               ..F.A......
/// </summary>
[Name("Abs_Peak_count")] Abs_Peak_count,
}

/// <summary>
///  Select the parameters which are measured overall (default all+Bit_depth+Crest_factor+DC_offset+Dynamic_range+Entropy+Flat_factor+Max_difference+Max_level+Mean_difference+Min_difference+Min_level+Noise_floor+Noise_floor_count+Number_of_Infs+Number_of_NaNs+Number_of_denormals+Number_of_samples+Peak_count+Peak_level+RMS_difference+RMS_level+RMS_peak+RMS_trough+Zero_crossings+Zero_crossings_rate+Abs_Peak_count)
/// </summary>
public enum AstatsFilterGenMeasure_overall
{
/// <summary>
/// none                         ..F.A......
/// </summary>
[Name("none")] none,
/// <summary>
/// all                          ..F.A......
/// </summary>
[Name("all")] all,
/// <summary>
/// Bit_depth                    ..F.A......
/// </summary>
[Name("Bit_depth")] Bit_depth,
/// <summary>
/// Crest_factor                 ..F.A......
/// </summary>
[Name("Crest_factor")] Crest_factor,
/// <summary>
/// DC_offset                    ..F.A......
/// </summary>
[Name("DC_offset")] DC_offset,
/// <summary>
/// Dynamic_range                ..F.A......
/// </summary>
[Name("Dynamic_range")] Dynamic_range,
/// <summary>
/// Entropy                      ..F.A......
/// </summary>
[Name("Entropy")] Entropy,
/// <summary>
/// Flat_factor                  ..F.A......
/// </summary>
[Name("Flat_factor")] Flat_factor,
/// <summary>
/// Max_difference               ..F.A......
/// </summary>
[Name("Max_difference")] Max_difference,
/// <summary>
/// Max_level                    ..F.A......
/// </summary>
[Name("Max_level")] Max_level,
/// <summary>
/// Mean_difference              ..F.A......
/// </summary>
[Name("Mean_difference")] Mean_difference,
/// <summary>
/// Min_difference               ..F.A......
/// </summary>
[Name("Min_difference")] Min_difference,
/// <summary>
/// Min_level                    ..F.A......
/// </summary>
[Name("Min_level")] Min_level,
/// <summary>
/// Noise_floor                  ..F.A......
/// </summary>
[Name("Noise_floor")] Noise_floor,
/// <summary>
/// Noise_floor_count              ..F.A......
/// </summary>
[Name("Noise_floor_count")] Noise_floor_count,
/// <summary>
/// Number_of_Infs               ..F.A......
/// </summary>
[Name("Number_of_Infs")] Number_of_Infs,
/// <summary>
/// Number_of_NaNs               ..F.A......
/// </summary>
[Name("Number_of_NaNs")] Number_of_NaNs,
/// <summary>
/// Number_of_denormals              ..F.A......
/// </summary>
[Name("Number_of_denormals")] Number_of_denormals,
/// <summary>
/// Number_of_samples              ..F.A......
/// </summary>
[Name("Number_of_samples")] Number_of_samples,
/// <summary>
/// Peak_count                   ..F.A......
/// </summary>
[Name("Peak_count")] Peak_count,
/// <summary>
/// Peak_level                   ..F.A......
/// </summary>
[Name("Peak_level")] Peak_level,
/// <summary>
/// RMS_difference               ..F.A......
/// </summary>
[Name("RMS_difference")] RMS_difference,
/// <summary>
/// RMS_level                    ..F.A......
/// </summary>
[Name("RMS_level")] RMS_level,
/// <summary>
/// RMS_peak                     ..F.A......
/// </summary>
[Name("RMS_peak")] RMS_peak,
/// <summary>
/// RMS_trough                   ..F.A......
/// </summary>
[Name("RMS_trough")] RMS_trough,
/// <summary>
/// Zero_crossings               ..F.A......
/// </summary>
[Name("Zero_crossings")] Zero_crossings,
/// <summary>
/// Zero_crossings_rate              ..F.A......
/// </summary>
[Name("Zero_crossings_rate")] Zero_crossings_rate,
/// <summary>
/// Abs_Peak_count               ..F.A......
/// </summary>
[Name("Abs_Peak_count")] Abs_Peak_count,
}

}
