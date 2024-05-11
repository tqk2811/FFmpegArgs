namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. adeclick          A-&gt;A       Remove impulsive noise from input audio.
/// </summary>
public class AdeclickFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading
{
internal AdeclickFilterGen(AudioMap input) : base("adeclick",input) { AddMapOut(); }
/// <summary>
///  set window size (from 10 to 100) (default 55)
/// </summary>
public AdeclickFilterGen window(double window) => this.SetOptionRange("window", window,10,100);
/// <summary>
///  set window overlap (from 50 to 95) (default 75)
/// </summary>
public AdeclickFilterGen overlap(double overlap) => this.SetOptionRange("overlap", overlap,50,95);
/// <summary>
///  set autoregression order (from 0 to 25) (default 2)
/// </summary>
public AdeclickFilterGen arorder(double arorder) => this.SetOptionRange("arorder", arorder,0,25);
/// <summary>
///  set threshold (from 1 to 100) (default 2)
/// </summary>
public AdeclickFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,1,100);
/// <summary>
///  set burst fusion (from 0 to 10) (default 2)
/// </summary>
public AdeclickFilterGen burst(double burst) => this.SetOptionRange("burst", burst,0,10);
/// <summary>
///  set overlap method (from 0 to 1) (default add)
/// </summary>
public AdeclickFilterGen method(AdeclickFilterGenMethod method) => this.SetOption("method", method.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Remove impulsive noise from input audio.
/// </summary>
public static AdeclickFilterGen AdeclickFilterGen(this AudioMap input0) => new AdeclickFilterGen(input0);
}
/// <summary>
///  set overlap method (from 0 to 1) (default add)
/// </summary>
public enum AdeclickFilterGenMethod
{
/// <summary>
/// add             0            ..F.A...... overlap-add
/// </summary>
[Name("add")] add,
/// <summary>
/// a               0            ..F.A...... overlap-add
/// </summary>
[Name("a")] a,
/// <summary>
/// save            1            ..F.A...... overlap-save
/// </summary>
[Name("save")] save,
/// <summary>
/// s               1            ..F.A...... overlap-save
/// </summary>
[Name("s")] s,
}

}
