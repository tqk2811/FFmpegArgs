namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C volume            A->A       Change input volume.
/// </summary>
public class VolumeFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal VolumeFilterGen(AudioMap input) : base("volume",input) { AddMapOut(); }
/// <summary>
///  set volume adjustment expression (default "1.0")
/// </summary>
public VolumeFilterGen volume(ExpressionValue volume) => this.SetOption("volume",(string)volume);
/// <summary>
///  select mathematical precision (from 0 to 2) (default float)
/// </summary>
public VolumeFilterGen precision(VolumeFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default once)
/// </summary>
public VolumeFilterGen eval(VolumeFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Apply replaygain side data when present (from 0 to 3) (default drop)
/// </summary>
public VolumeFilterGen replaygain(VolumeFilterGenReplaygain replaygain) => this.SetOption("replaygain", replaygain.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Apply replaygain pre-amplification (from -15 to 15) (default 0)
/// </summary>
public VolumeFilterGen replaygain_preamp(double replaygain_preamp) => this.SetOptionRange("replaygain_preamp", replaygain_preamp,-15,15);
/// <summary>
///  Apply replaygain clipping prevention (default true)
/// </summary>
public VolumeFilterGen replaygain_noclip(bool replaygain_noclip) => this.SetOption("replaygain_noclip",replaygain_noclip.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Change input volume.
/// </summary>
public static VolumeFilterGen VolumeFilterGen(this AudioMap input0) => new VolumeFilterGen(input0);
}
/// <summary>
///  select mathematical precision (from 0 to 2) (default float)
/// </summary>
public enum VolumeFilterGenPrecision
{
/// <summary>
/// fixed           0            ..F.A...... select 8-bit fixed-point
/// </summary>
[Name("fixed")] _fixed,
/// <summary>
/// float           1            ..F.A...... select 32-bit floating-point
/// </summary>
[Name("float")] _float,
/// <summary>
/// double          2            ..F.A...... select 64-bit floating-point
/// </summary>
[Name("double")] _double,
}

/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default once)
/// </summary>
public enum VolumeFilterGenEval
{
/// <summary>
/// once            0            ..F.A...... eval volume expression once
/// </summary>
[Name("once")] once,
/// <summary>
/// frame           1            ..F.A...... eval volume expression per-frame
/// </summary>
[Name("frame")] frame,
}

/// <summary>
///  Apply replaygain side data when present (from 0 to 3) (default drop)
/// </summary>
public enum VolumeFilterGenReplaygain
{
/// <summary>
/// drop            0            ..F.A...... replaygain side data is dropped
/// </summary>
[Name("drop")] drop,
/// <summary>
/// ignore          1            ..F.A...... replaygain side data is ignored
/// </summary>
[Name("ignore")] ignore,
/// <summary>
/// track           2            ..F.A...... track gain is preferred
/// </summary>
[Name("track")] track,
/// <summary>
/// album           3            ..F.A...... album gain is preferred
/// </summary>
[Name("album")] album,
}

}
