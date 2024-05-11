namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... decimate          N-&gt;V       Decimate frames (post field matching filter).
/// </summary>
public class DecimateFilterGen : ImageToImageFilter
{
internal DecimateFilterGen(params ImageMap[] inputs) : base("decimate",inputs) { AddMapOut(); }
/// <summary>
///  set the number of frame from which one will be dropped (from 2 to 25) (default 5)
/// </summary>
public DecimateFilterGen cycle(int cycle) => this.SetOptionRange("cycle", cycle,2,25);
/// <summary>
///  set duplicate threshold (from 0 to 100) (default 1.1)
/// </summary>
public DecimateFilterGen dupthresh(double dupthresh) => this.SetOptionRange("dupthresh", dupthresh,0,100);
/// <summary>
///  set scene change threshold (from 0 to 100) (default 15)
/// </summary>
public DecimateFilterGen scthresh(double scthresh) => this.SetOptionRange("scthresh", scthresh,0,100);
/// <summary>
///  set the size of the x-axis blocks used during metric calculations (from 4 to 512) (default 32)
/// </summary>
public DecimateFilterGen blockx(int blockx) => this.SetOptionRange("blockx", blockx,4,512);
/// <summary>
///  set the size of the y-axis blocks used during metric calculations (from 4 to 512) (default 32)
/// </summary>
public DecimateFilterGen blocky(int blocky) => this.SetOptionRange("blocky", blocky,4,512);
/// <summary>
///  mark main input as a pre-processed input and activate clean source input stream (default false)
/// </summary>
public DecimateFilterGen ppsrc(bool ppsrc) => this.SetOption("ppsrc",ppsrc.ToFFmpegFlag());
/// <summary>
///  set whether or not chroma is considered in the metric calculations (default true)
/// </summary>
public DecimateFilterGen chroma(bool chroma) => this.SetOption("chroma",chroma.ToFFmpegFlag());
/// <summary>
///  set whether or not the input only partially contains content to be decimated (default false)
/// </summary>
public DecimateFilterGen mixed(bool mixed) => this.SetOption("mixed",mixed.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Decimate frames (post field matching filter).
/// </summary>
public static DecimateFilterGen DecimateFilterGen(this IEnumerable<ImageMap> inputs) => new DecimateFilterGen(inputs.ToArray());
}
}
