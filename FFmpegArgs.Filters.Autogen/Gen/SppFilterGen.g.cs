namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C spp               V->V       Apply a simple post processing filter.
/// </summary>
public class SppFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal SppFilterGen(ImageMap input) : base("spp",input) { AddMapOut(); }
/// <summary>
///  set quality (from 0 to 6) (default 3)
/// </summary>
public SppFilterGen quality(int quality) => this.SetOptionRange("quality", quality,0,6);
/// <summary>
///  force a constant quantizer parameter (from 0 to 63) (default 0)
/// </summary>
public SppFilterGen qp(int qp) => this.SetOptionRange("qp", qp,0,63);
/// <summary>
///  set thresholding mode (from 0 to 1) (default hard)
/// </summary>
public SppFilterGen mode(SppFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  use B-frames' QP (default false)
/// </summary>
public SppFilterGen use_bframe_qp(bool use_bframe_qp) => this.SetOption("use_bframe_qp",use_bframe_qp.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class SppFilterGenExtensions
{
/// <summary>
/// Apply a simple post processing filter.
/// </summary>
public static SppFilterGen SppFilterGen(this ImageMap input0) => new SppFilterGen(input0);
}
/// <summary>
///  set thresholding mode (from 0 to 1) (default hard)
/// </summary>
public enum SppFilterGenMode
{
/// <summary>
/// hard            0            ..FV....... hard thresholding
/// </summary>
[Name("hard")] hard,
/// <summary>
/// soft            1            ..FV....... soft thresholding
/// </summary>
[Name("soft")] soft,
}

}
