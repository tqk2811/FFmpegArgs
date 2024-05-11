namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... mergeplanes       N-&gt;V       Merge planes.
/// </summary>
public class MergeplanesFilterGen : ImageToImageFilter
{
internal MergeplanesFilterGen(params ImageMap[] inputs) : base("mergeplanes",inputs) { AddMapOut(); }
/// <summary>
///  set input to output plane mapping (from -1 to 8.58993e+08) (default -1)
/// </summary>
[Obsolete]
public MergeplanesFilterGen mapping(int mapping) => this.SetOptionRange("mapping", mapping,-1,8.58993e+08);
/// <summary>
///  set output pixel format (default yuva444p)
/// </summary>
public MergeplanesFilterGen format(PixFmt format) => this.SetOption("format",format.ToString());
/// <summary>
///  set 1st input to output stream mapping (from 0 to 3) (default 0)
/// </summary>
public MergeplanesFilterGen map0s(int map0s) => this.SetOptionRange("map0s", map0s,0,3);
/// <summary>
///  set 1st input to output plane mapping (from 0 to 3) (default 0)
/// </summary>
public MergeplanesFilterGen map0p(int map0p) => this.SetOptionRange("map0p", map0p,0,3);
/// <summary>
///  set 2nd input to output stream mapping (from 0 to 3) (default 0)
/// </summary>
public MergeplanesFilterGen map1s(int map1s) => this.SetOptionRange("map1s", map1s,0,3);
/// <summary>
///  set 2nd input to output plane mapping (from 0 to 3) (default 0)
/// </summary>
public MergeplanesFilterGen map1p(int map1p) => this.SetOptionRange("map1p", map1p,0,3);
/// <summary>
///  set 3rd input to output stream mapping (from 0 to 3) (default 0)
/// </summary>
public MergeplanesFilterGen map2s(int map2s) => this.SetOptionRange("map2s", map2s,0,3);
/// <summary>
///  set 3rd input to output plane mapping (from 0 to 3) (default 0)
/// </summary>
public MergeplanesFilterGen map2p(int map2p) => this.SetOptionRange("map2p", map2p,0,3);
/// <summary>
///  set 4th input to output stream mapping (from 0 to 3) (default 0)
/// </summary>
public MergeplanesFilterGen map3s(int map3s) => this.SetOptionRange("map3s", map3s,0,3);
/// <summary>
///  set 4th input to output plane mapping (from 0 to 3) (default 0)
/// </summary>
public MergeplanesFilterGen map3p(int map3p) => this.SetOptionRange("map3p", map3p,0,3);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Merge planes.
/// </summary>
public static MergeplanesFilterGen MergeplanesFilterGen(this IEnumerable<ImageMap> inputs) => new MergeplanesFilterGen(inputs.ToArray());
}
}
