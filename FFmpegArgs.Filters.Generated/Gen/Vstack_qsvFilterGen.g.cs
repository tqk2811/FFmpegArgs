namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... vstack_qsv        N->V       "Quick Sync Video" vstack
/// </summary>
public class Vstack_qsvFilterGen : ImageToImageFilter
{
internal Vstack_qsvFilterGen(params ImageMap[] inputs) : base("vstack_qsv",inputs) { AddMapOut(); }
/// <summary>
///  Set number of inputs (from 2 to 65535) (default 2)
/// </summary>
public Vstack_qsvFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs,2,65535);
/// <summary>
///  Force termination when the shortest input terminates (default false)
/// </summary>
public Vstack_qsvFilterGen shortest(bool shortest) => this.SetOption("shortest",shortest.ToFFmpegFlag());
/// <summary>
///  Set output width (0 to use the width of input 0) (from 0 to 65535) (default 0)
/// </summary>
public Vstack_qsvFilterGen width(int width) => this.SetOptionRange("width", width,0,65535);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// "Quick Sync Video" vstack
/// </summary>
public static Vstack_qsvFilterGen Vstack_qsvFilterGen(this IEnumerable<ImageMap> inputs) => new Vstack_qsvFilterGen(inputs.ToArray());
}
}
