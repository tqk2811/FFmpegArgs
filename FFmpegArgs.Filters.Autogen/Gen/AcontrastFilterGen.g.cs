namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... acontrast         A->A       Simple audio dynamic range compression/expansion filter.
/// </summary>
public class AcontrastFilterGen : AudioToAudioFilter
{
internal AcontrastFilterGen(AudioMap input) : base("acontrast",input) { AddMapOut(); }
/// <summary>
///  set contrast (from 0 to 100) (default 33)
/// </summary>
public AcontrastFilterGen contrast(float contrast) => this.SetOptionRange("contrast", contrast,0,100);
}
/// <summary>
/// </summary>
public static class AcontrastFilterGenExtensions
{
/// <summary>
/// Simple audio dynamic range compression/expansion filter.
/// </summary>
public static AcontrastFilterGen AcontrastFilterGen(this AudioMap input0) => new AcontrastFilterGen(input0);
}
}
