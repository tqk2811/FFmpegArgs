namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC aemphasis         A-&gt;A       Audio emphasis.
/// </summary>
public class AemphasisFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AemphasisFilterGen(AudioMap input) : base("aemphasis",input) { AddMapOut(); }
/// <summary>
///  set input gain (from 0 to 64) (default 1)
/// </summary>
public AemphasisFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0,64);
/// <summary>
///  set output gain (from 0 to 64) (default 1)
/// </summary>
public AemphasisFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0,64);
/// <summary>
///  set filter mode (from 0 to 1) (default reproduction)
/// </summary>
public AemphasisFilterGen mode(AemphasisFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filter type (from 0 to 8) (default cd)
/// </summary>
public AemphasisFilterGen type(AemphasisFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Audio emphasis.
/// </summary>
public static AemphasisFilterGen AemphasisFilterGen(this AudioMap input0) => new AemphasisFilterGen(input0);
}
/// <summary>
///  set filter mode (from 0 to 1) (default reproduction)
/// </summary>
public enum AemphasisFilterGenMode
{
/// <summary>
/// reproduction    0            ..F.A....T.
/// </summary>
[Name("reproduction")] reproduction,
/// <summary>
/// production      1            ..F.A....T.
/// </summary>
[Name("production")] production,
}

/// <summary>
///  set filter type (from 0 to 8) (default cd)
/// </summary>
public enum AemphasisFilterGenType
{
/// <summary>
/// col             0            ..F.A....T. Columbia
/// </summary>
[Name("col")] col,
/// <summary>
/// emi             1            ..F.A....T. EMI
/// </summary>
[Name("emi")] emi,
/// <summary>
/// bsi             2            ..F.A....T. BSI (78RPM)
/// </summary>
[Name("bsi")] bsi,
/// <summary>
/// riaa            3            ..F.A....T. RIAA
/// </summary>
[Name("riaa")] riaa,
/// <summary>
/// cd              4            ..F.A....T. Compact Disc (CD)
/// </summary>
[Name("cd")] cd,
/// <summary>
/// 50fm            5            ..F.A....T. 50┬╡s (FM)
/// </summary>
[Name("50fm")] _50fm,
/// <summary>
/// 75fm            6            ..F.A....T. 75┬╡s (FM)
/// </summary>
[Name("75fm")] _75fm,
/// <summary>
/// 50kf            7            ..F.A....T. 50┬╡s (FM-KF)
/// </summary>
[Name("50kf")] _50kf,
/// <summary>
/// 75kf            8            ..F.A....T. 75┬╡s (FM-KF)
/// </summary>
[Name("75kf")] _75kf,
}

}
