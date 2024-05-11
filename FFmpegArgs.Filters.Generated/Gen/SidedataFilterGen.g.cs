namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. sidedata          V-&gt;V       Manipulate video frame side data.
/// </summary>
public class SidedataFilterGen : ImageToImageFilter,ITimelineSupport
{
internal SidedataFilterGen(ImageMap input) : base("sidedata",input) { AddMapOut(); }
/// <summary>
///  set a mode of operation (from 0 to 1) (default select)
/// </summary>
public SidedataFilterGen mode(SidedataFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set side data type (from -1 to INT_MAX) (default -1)
/// </summary>
public SidedataFilterGen type(SidedataFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Manipulate video frame side data.
/// </summary>
public static SidedataFilterGen SidedataFilterGen(this ImageMap input0) => new SidedataFilterGen(input0);
}
/// <summary>
///  set a mode of operation (from 0 to 1) (default select)
/// </summary>
public enum SidedataFilterGenMode
{
/// <summary>
/// select          0            ..FV....... select frame
/// </summary>
[Name("select")] select,
/// <summary>
/// delete          1            ..FV....... delete side data
/// </summary>
[Name("delete")] delete,
}

/// <summary>
///  set side data type (from -1 to INT_MAX) (default -1)
/// </summary>
public enum SidedataFilterGenType
{
/// <summary>
/// PANSCAN         0            ..FV.......
/// </summary>
[Name("PANSCAN")] PANSCAN,
/// <summary>
/// A53_CC          1            ..FV.......
/// </summary>
[Name("A53_CC")] A53_CC,
/// <summary>
/// STEREO3D        2            ..FV.......
/// </summary>
[Name("STEREO3D")] STEREO3D,
/// <summary>
/// MATRIXENCODING  3            ..FV.......
/// </summary>
[Name("MATRIXENCODING")] MATRIXENCODING,
/// <summary>
/// DOWNMIX_INFO    4            ..FV.......
/// </summary>
[Name("DOWNMIX_INFO")] DOWNMIX_INFO,
/// <summary>
/// REPLAYGAIN      5            ..FV.......
/// </summary>
[Name("REPLAYGAIN")] REPLAYGAIN,
/// <summary>
/// DISPLAYMATRIX   6            ..FV.......
/// </summary>
[Name("DISPLAYMATRIX")] DISPLAYMATRIX,
/// <summary>
/// AFD             7            ..FV.......
/// </summary>
[Name("AFD")] AFD,
/// <summary>
/// MOTION_VECTORS  8            ..FV.......
/// </summary>
[Name("MOTION_VECTORS")] MOTION_VECTORS,
/// <summary>
/// SKIP_SAMPLES    9            ..FV.......
/// </summary>
[Name("SKIP_SAMPLES")] SKIP_SAMPLES,
/// <summary>
/// AUDIO_SERVICE_TYPE 10           ..FV.......
/// </summary>
[Name("AUDIO_SERVICE_TYPE")] AUDIO_SERVICE_TYPE,
/// <summary>
/// MASTERING_DISPLAY_METADATA 11           ..FV.......
/// </summary>
[Name("MASTERING_DISPLAY_METADATA")] MASTERING_DISPLAY_METADATA,
/// <summary>
/// GOP_TIMECODE    12           ..FV.......
/// </summary>
[Name("GOP_TIMECODE")] GOP_TIMECODE,
/// <summary>
/// SPHERICAL       13           ..FV.......
/// </summary>
[Name("SPHERICAL")] SPHERICAL,
/// <summary>
/// CONTENT_LIGHT_LEVEL 14           ..FV.......
/// </summary>
[Name("CONTENT_LIGHT_LEVEL")] CONTENT_LIGHT_LEVEL,
/// <summary>
/// ICC_PROFILE     15           ..FV.......
/// </summary>
[Name("ICC_PROFILE")] ICC_PROFILE,
/// <summary>
/// S12M_TIMECOD    16           ..FV.......
/// </summary>
[Name("S12M_TIMECOD")] S12M_TIMECOD,
/// <summary>
/// DYNAMIC_HDR_PLUS 17           ..FV.......
/// </summary>
[Name("DYNAMIC_HDR_PLUS")] DYNAMIC_HDR_PLUS,
/// <summary>
/// REGIONS_OF_INTEREST 18           ..FV.......
/// </summary>
[Name("REGIONS_OF_INTEREST")] REGIONS_OF_INTEREST,
/// <summary>
/// DETECTION_BOUNDING_BOXES 22           ..FV.......
/// </summary>
[Name("DETECTION_BOUNDING_BOXES")] DETECTION_BOUNDING_BOXES,
/// <summary>
/// SEI_UNREGISTERED 20           ..FV.......
/// </summary>
[Name("SEI_UNREGISTERED")] SEI_UNREGISTERED,
}

}
