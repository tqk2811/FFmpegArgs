namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC chromanr          V->V       Reduce chrominance noise.
/// </summary>
public class ChromanrFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ChromanrFilterGen(ImageMap input) : base("chromanr",input) { AddMapOut(); }
/// <summary>
///  set y+u+v threshold (from 1 to 200) (default 30)
/// </summary>
public ChromanrFilterGen thres(float thres) => this.SetOptionRange("thres", thres,1,200);
/// <summary>
///  set horizontal patch size (from 1 to 100) (default 5)
/// </summary>
public ChromanrFilterGen sizew(int sizew) => this.SetOptionRange("sizew", sizew,1,100);
/// <summary>
///  set vertical patch size (from 1 to 100) (default 5)
/// </summary>
public ChromanrFilterGen sizeh(int sizeh) => this.SetOptionRange("sizeh", sizeh,1,100);
/// <summary>
///  set horizontal step (from 1 to 50) (default 1)
/// </summary>
public ChromanrFilterGen stepw(int stepw) => this.SetOptionRange("stepw", stepw,1,50);
/// <summary>
///  set vertical step (from 1 to 50) (default 1)
/// </summary>
public ChromanrFilterGen steph(int steph) => this.SetOptionRange("steph", steph,1,50);
/// <summary>
///  set y threshold (from 1 to 200) (default 200)
/// </summary>
public ChromanrFilterGen threy(float threy) => this.SetOptionRange("threy", threy,1,200);
/// <summary>
///  set u threshold (from 1 to 200) (default 200)
/// </summary>
public ChromanrFilterGen threu(float threu) => this.SetOptionRange("threu", threu,1,200);
/// <summary>
///  set v threshold (from 1 to 200) (default 200)
/// </summary>
public ChromanrFilterGen threv(float threv) => this.SetOptionRange("threv", threv,1,200);
/// <summary>
///  set distance type (from 0 to 1) (default manhattan)
/// </summary>
public ChromanrFilterGen distance(ChromanrFilterGenDistance distance) => this.SetOption("distance", distance.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class ChromanrFilterGenExtensions
{
/// <summary>
/// Reduce chrominance noise.
/// </summary>
public static ChromanrFilterGen ChromanrFilterGen(this ImageMap input0) => new ChromanrFilterGen(input0);
}
/// <summary>
///  set distance type (from 0 to 1) (default manhattan)
/// </summary>
public enum ChromanrFilterGenDistance
{
/// <summary>
/// manhattan       0            ..FV.....T.
/// </summary>
[Name("manhattan")] manhattan,
/// <summary>
/// euclidean       1            ..FV.....T.
/// </summary>
[Name("euclidean")] euclidean,
}

}
