namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... readvitc          V->V       Read vertical interval timecode and write it to frame metadata.
/// </summary>
public class ReadvitcFilterGen : ImageToImageFilter
{
internal ReadvitcFilterGen(ImageMap input) : base("readvitc",input) { AddMapOut(); }
/// <summary>
///  maximum line numbers to scan for VITC data (from -1 to INT_MAX) (default 45)
/// </summary>
public ReadvitcFilterGen scan_max(int scan_max) => this.SetOptionRange("scan_max", scan_max,-1,INT_MAX);
/// <summary>
///  black color threshold (from 0 to 1) (default 0.2)
/// </summary>
public ReadvitcFilterGen thr_b(double thr_b) => this.SetOptionRange("thr_b", thr_b,0,1);
/// <summary>
///  white color threshold (from 0 to 1) (default 0.6)
/// </summary>
public ReadvitcFilterGen thr_w(double thr_w) => this.SetOptionRange("thr_w", thr_w,0,1);
}
/// <summary>
/// </summary>
public static class ReadvitcFilterGenExtensions
{
/// <summary>
/// Read vertical interval timecode and write it to frame metadata.
/// </summary>
public static ReadvitcFilterGen ReadvitcFilterGen(this ImageMap input0) => new ReadvitcFilterGen(input0);
}
}
