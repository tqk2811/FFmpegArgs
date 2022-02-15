namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C bilateral         V->V       Apply Bilateral filter.
/// </summary>
public class BilateralFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal BilateralFilterGen(ImageMap input) : base("bilateral",input) { AddMapOut(); }
/// <summary>
///  set spatial sigma (from 0 to 512) (default 0.1)
/// </summary>
public BilateralFilterGen sigmaS(float sigmaS) => this.SetOptionRange("sigmaS", sigmaS,0,512);
/// <summary>
///  set range sigma (from 0 to 1) (default 0.1)
/// </summary>
public BilateralFilterGen sigmaR(float sigmaR) => this.SetOptionRange("sigmaR", sigmaR,0,1);
/// <summary>
///  set planes to filter (from 0 to 15) (default 1)
/// </summary>
public BilateralFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
/// <summary>
/// </summary>
public static class BilateralFilterGenExtensions
{
/// <summary>
/// Apply Bilateral filter.
/// </summary>
public static BilateralFilterGen BilateralFilterGen(this ImageMap input0) => new BilateralFilterGen(input0);
}
}
