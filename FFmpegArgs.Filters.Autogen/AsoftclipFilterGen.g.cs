namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC asoftclip         A->A       Audio Soft Clipper.
/// </summary>
public class AsoftclipFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsoftclipFilterGen(AudioMap input) : base("asoftclip",input) { AddMapOut(); }
/// <summary>
///  set softclip type (from -1 to 7) (default tanh)
/// </summary>
public AsoftclipFilterGen type(AsoftclipFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set softclip threshold (from 1e-06 to 1) (default 1)
/// </summary>
public AsoftclipFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,1e-06,1);
/// <summary>
///  set softclip output gain (from 1e-06 to 16) (default 1)
/// </summary>
public AsoftclipFilterGen output(double output) => this.SetOptionRange("output", output,1e-06,16);
/// <summary>
///  set softclip parameter (from 0.01 to 3) (default 1)
/// </summary>
public AsoftclipFilterGen param(double param) => this.SetOptionRange("param", param,0.01,3);
/// <summary>
///  set oversample factor (from 1 to 32) (default 1)
/// </summary>
public AsoftclipFilterGen oversample(int oversample) => this.SetOptionRange("oversample", oversample,1,32);
}
/// <summary>
/// </summary>
public static class AsoftclipFilterGenExtensions
{
/// <summary>
/// Audio Soft Clipper.
/// </summary>
public static AsoftclipFilterGen AsoftclipFilterGen(this AudioMap input0) => new AsoftclipFilterGen(input0);
}
/// <summary>
///  set softclip type (from -1 to 7) (default tanh)
/// </summary>
public enum AsoftclipFilterGenType
{
/// <summary>
/// hard            -1           ..F.A....T.
/// </summary>
[Name("hard")] hard,
/// <summary>
/// tanh            0            ..F.A....T.
/// </summary>
[Name("tanh")] tanh,
/// <summary>
/// atan            1            ..F.A....T.
/// </summary>
[Name("atan")] atan,
/// <summary>
/// cubic           2            ..F.A....T.
/// </summary>
[Name("cubic")] cubic,
/// <summary>
/// exp             3            ..F.A....T.
/// </summary>
[Name("exp")] exp,
/// <summary>
/// alg             4            ..F.A....T.
/// </summary>
[Name("alg")] alg,
/// <summary>
/// quintic         5            ..F.A....T.
/// </summary>
[Name("quintic")] quintic,
/// <summary>
/// sin             6            ..F.A....T.
/// </summary>
[Name("sin")] sin,
/// <summary>
/// erf             7            ..F.A....T.
/// </summary>
[Name("erf")] erf,
}

}
