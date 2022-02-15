namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. aperms            A->A       Set permissions for the output audio frame.
/// </summary>
public class ApermsFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal ApermsFilterGen(AudioMap input) : base("aperms",input) { AddMapOut(); }
/// <summary>
///  select permissions mode (from 0 to 4) (default none)
/// </summary>
public ApermsFilterGen mode(ApermsFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the seed for the random mode (from -1 to UINT32_MAX) (default -1)
/// </summary>
public ApermsFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
}
/// <summary>
/// </summary>
public static class ApermsFilterGenExtensions
{
/// <summary>
/// Set permissions for the output audio frame.
/// </summary>
public static ApermsFilterGen ApermsFilterGen(this AudioMap input0) => new ApermsFilterGen(input0);
}
/// <summary>
///  select permissions mode (from 0 to 4) (default none)
/// </summary>
public enum ApermsFilterGenMode
{
/// <summary>
/// none            0            ..FVA...... do nothing
/// </summary>
[Name("none")] none,
/// <summary>
/// ro              1            ..FVA...... set all output frames read-only
/// </summary>
[Name("ro")] ro,
/// <summary>
/// rw              2            ..FVA...... set all output frames writable
/// </summary>
[Name("rw")] rw,
/// <summary>
/// toggle          3            ..FVA...... switch permissions
/// </summary>
[Name("toggle")] toggle,
/// <summary>
/// random          4            ..FVA...... set permissions randomly
/// </summary>
[Name("random")] random,
}

}
