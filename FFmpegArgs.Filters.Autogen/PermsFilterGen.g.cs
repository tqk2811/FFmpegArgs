namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. perms             V->V       Set permissions for the output video frame.
/// </summary>
public class PermsFilterGen : ImageToImageFilter,ITimelineSupport
{
internal PermsFilterGen(ImageMap input) : base("perms",input) { AddMapOut(); }
/// <summary>
///  select permissions mode (from 0 to 4) (default none)
/// </summary>
public PermsFilterGen mode(PermsFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the seed for the random mode (from -1 to UINT32_MAX) (default -1)
/// </summary>
public PermsFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
}
/// <summary>
/// </summary>
public static class PermsFilterGenExtensions
{
/// <summary>
/// Set permissions for the output video frame.
/// </summary>
public static PermsFilterGen PermsFilterGen(this ImageMap input0) => new PermsFilterGen(input0);
}
/// <summary>
///  select permissions mode (from 0 to 4) (default none)
/// </summary>
public enum PermsFilterGenMode
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
