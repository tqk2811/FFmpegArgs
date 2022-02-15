namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. shuffleframes     V->V       Shuffle video frames.
/// </summary>
public class ShuffleframesFilterGen : ImageToImageFilter,ITimelineSupport
{
internal ShuffleframesFilterGen(ImageMap input) : base("shuffleframes",input) { AddMapOut(); }
/// <summary>
///  set destination indexes of input frames (default "0")
/// </summary>
public ShuffleframesFilterGen mapping(string mapping) => this.SetOption("mapping",mapping);
}
/// <summary>
/// </summary>
public static class ShuffleframesFilterGenExtensions
{
/// <summary>
/// Shuffle video frames.
/// </summary>
public static ShuffleframesFilterGen ShuffleframesFilterGen(this ImageMap input0) => new ShuffleframesFilterGen(input0);
}
}
