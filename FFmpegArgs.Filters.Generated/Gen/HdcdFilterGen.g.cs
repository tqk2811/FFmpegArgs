namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... hdcd              A->A       Apply High Definition Compatible Digital (HDCD) decoding.
/// </summary>
public class HdcdFilterGen : AudioToAudioFilter
{
internal HdcdFilterGen(AudioMap input) : base("hdcd",input) { AddMapOut(); }
/// <summary>
///  Disable any format conversion or resampling in the filter graph. (default true)
/// </summary>
public HdcdFilterGen disable_autoconvert(bool disable_autoconvert) => this.SetOption("disable_autoconvert",disable_autoconvert.ToFFmpegFlag());
/// <summary>
///  Process stereo channels together. Only apply target_gain when both channels match. (default true)
/// </summary>
public HdcdFilterGen process_stereo(bool process_stereo) => this.SetOption("process_stereo",process_stereo.ToFFmpegFlag());
/// <summary>
///  Code detect timer period in ms. (from 100 to 60000) (default 2000)
/// </summary>
public HdcdFilterGen cdt_ms(int cdt_ms) => this.SetOptionRange("cdt_ms", cdt_ms,100,60000);
/// <summary>
///  Always extend peaks above -3dBFS even when PE is not signaled. (default false)
/// </summary>
public HdcdFilterGen force_pe(bool force_pe) => this.SetOption("force_pe",force_pe.ToFFmpegFlag());
/// <summary>
///  Replace audio with solid tone and signal some processing aspect in the amplitude. (from 0 to 4) (default off)
/// </summary>
public HdcdFilterGen analyze_mode(HdcdFilterGenAnalyze_mode analyze_mode) => this.SetOption("analyze_mode", analyze_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Valid bits per sample (location of the true LSB). (from 16 to 24) (default 16)
/// </summary>
public HdcdFilterGen bits_per_sample(HdcdFilterGenBits_per_sample bits_per_sample) => this.SetOption("bits_per_sample", bits_per_sample.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply High Definition Compatible Digital (HDCD) decoding.
/// </summary>
public static HdcdFilterGen HdcdFilterGen(this AudioMap input0) => new HdcdFilterGen(input0);
}
/// <summary>
///  Replace audio with solid tone and signal some processing aspect in the amplitude. (from 0 to 4) (default off)
/// </summary>
public enum HdcdFilterGenAnalyze_mode
{
/// <summary>
/// off             0            ..F.A...... disabled
/// </summary>
[Name("off")] off,
/// <summary>
/// lle             1            ..F.A...... gain adjustment level at each sample
/// </summary>
[Name("lle")] lle,
/// <summary>
/// pe              2            ..F.A...... samples where peak extend occurs
/// </summary>
[Name("pe")] pe,
/// <summary>
/// cdt             3            ..F.A...... samples where the code detect timer is active
/// </summary>
[Name("cdt")] cdt,
/// <summary>
/// tgm             4            ..F.A...... samples where the target gain does not match between channels
/// </summary>
[Name("tgm")] tgm,
}

/// <summary>
///  Valid bits per sample (location of the true LSB). (from 16 to 24) (default 16)
/// </summary>
public enum HdcdFilterGenBits_per_sample
{
/// <summary>
/// 16              16           ..F.A...... 16-bit (in s32 or s16)
/// </summary>
[Name("16")] _16,
/// <summary>
/// 20              20           ..F.A...... 20-bit (in s32)
/// </summary>
[Name("20")] _20,
/// <summary>
/// 24              24           ..F.A...... 24-bit (in s32)
/// </summary>
[Name("24")] _24,
}

}
