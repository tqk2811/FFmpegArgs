namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... random            V->V       Return random frames.
/// </summary>
public class RandomFilterGen : ImageToImageFilter
{
internal RandomFilterGen(ImageMap input) : base("random",input) { AddMapOut(); }
/// <summary>
///  set number of frames in cache (from 2 to 512) (default 30)
/// </summary>
public RandomFilterGen frames(int frames) => this.SetOptionRange("frames", frames,2,512);
/// <summary>
///  set the seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public RandomFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Return random frames.
/// </summary>
public static RandomFilterGen RandomFilterGen(this ImageMap input0) => new RandomFilterGen(input0);
}
}
