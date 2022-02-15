namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. asidedata         A->A       Manipulate audio frame side data.
/// </summary>
public class AsidedataFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal AsidedataFilterGen(AudioMap input) : base("asidedata",input) { AddMapOut(); }
/// <summary>
///  set a mode of operation (from 0 to 1) (default select)
/// </summary>
public AsidedataFilterGen mode(AsidedataFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set side data type (from -1 to INT_MAX) (default -1)
/// </summary>
public AsidedataFilterGen type(AsidedataFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class AsidedataFilterGenExtensions
{
/// <summary>
/// Manipulate audio frame side data.
/// </summary>
public static AsidedataFilterGen AsidedataFilterGen(this AudioMap input0) => new AsidedataFilterGen(input0);
}
/// <summary>
///  set a mode of operation (from 0 to 1) (default select)
/// </summary>
public enum AsidedataFilterGenMode
{
/// <summary>
/// select          0            ..F.A...... select frame
/// </summary>
[Name("select")] select,
/// <summary>
/// delete          1            ..F.A...... delete side data
/// </summary>
[Name("delete")] delete,
}

/// <summary>
///  set side data type (from -1 to INT_MAX) (default -1)
/// </summary>
public enum AsidedataFilterGenType
{
/// <summary>
/// PANSCAN         0            ..F.A......
/// </summary>
[Name("PANSCAN")] PANSCAN,
/// <summary>
/// A53_CC          1            ..F.A......
/// </summary>
[Name("A53_CC")] A53_CC,
/// <summary>
/// STEREO3D        2            ..F.A......
/// </summary>
[Name("STEREO3D")] STEREO3D,
/// <summary>
/// MATRIXENCODING  3            ..F.A......
/// </summary>
[Name("MATRIXENCODING")] MATRIXENCODING,
/// <summary>
/// DOWNMIX_INFO    4            ..F.A......
/// </summary>
[Name("DOWNMIX_INFO")] DOWNMIX_INFO,
/// <summary>
/// REPLAYGAIN      5            ..F.A......
/// </summary>
[Name("REPLAYGAIN")] REPLAYGAIN,
/// <summary>
/// DISPLAYMATRIX   6            ..F.A......
/// </summary>
[Name("DISPLAYMATRIX")] DISPLAYMATRIX,
/// <summary>
/// AFD             7            ..F.A......
/// </summary>
[Name("AFD")] AFD,
/// <summary>
/// MOTION_VECTORS  8            ..F.A......
/// </summary>
[Name("MOTION_VECTORS")] MOTION_VECTORS,
/// <summary>
/// SKIP_SAMPLES    9            ..F.A......
/// </summary>
[Name("SKIP_SAMPLES")] SKIP_SAMPLES,
/// <summary>
/// AUDIO_SERVICE_TYPE 10           ..F.A......
/// </summary>
[Name("AUDIO_SERVICE_TYPE")] AUDIO_SERVICE_TYPE,
/// <summary>
/// MASTERING_DISPLAY_METADATA 11           ..F.A......
/// </summary>
[Name("MASTERING_DISPLAY_METADATA")] MASTERING_DISPLAY_METADATA,
/// <summary>
/// GOP_TIMECODE    12           ..F.A......
/// </summary>
[Name("GOP_TIMECODE")] GOP_TIMECODE,
/// <summary>
/// SPHERICAL       13           ..F.A......
/// </summary>
[Name("SPHERICAL")] SPHERICAL,
/// <summary>
/// CONTENT_LIGHT_LEVEL 14           ..F.A......
/// </summary>
[Name("CONTENT_LIGHT_LEVEL")] CONTENT_LIGHT_LEVEL,
/// <summary>
/// ICC_PROFILE     15           ..F.A......
/// </summary>
[Name("ICC_PROFILE")] ICC_PROFILE,
/// <summary>
/// QP_TABLE_PROPERTIES 16           ..F.A......
/// </summary>
[Name("QP_TABLE_PROPERTIES")] QP_TABLE_PROPERTIES,
/// <summary>
/// QP_TABLE_DATA   17           ..F.A......
/// </summary>
[Name("QP_TABLE_DATA")] QP_TABLE_DATA,
/// <summary>
/// S12M_TIMECOD    18           ..F.A......
/// </summary>
[Name("S12M_TIMECOD")] S12M_TIMECOD,
/// <summary>
/// DYNAMIC_HDR_PLUS 19           ..F.A......
/// </summary>
[Name("DYNAMIC_HDR_PLUS")] DYNAMIC_HDR_PLUS,
/// <summary>
/// REGIONS_OF_INTEREST 20           ..F.A......
/// </summary>
[Name("REGIONS_OF_INTEREST")] REGIONS_OF_INTEREST,
/// <summary>
/// SEI_UNREGISTERED 22           ..F.A......
/// </summary>
[Name("SEI_UNREGISTERED")] SEI_UNREGISTERED,
}

}
