namespace FFmpegArgs.Filters.Autogens
{
public class ShowinfoFilterGen : ImageToImageFilter
{
internal ShowinfoFilterGen(ImageMap input) : base("showinfo",input) { AddMapOut(); }
/// <summary>
///  calculate checksums (default true)
/// </summary>
public ShowinfoFilterGen checksum(bool checksum) => this.SetOption("checksum",checksum.ToFFmpegFlag());
}
public static class ShowinfoFilterGenExtensions
{
/// <summary>
/// Show textual information for each video frame.
/// </summary>
public static ShowinfoFilterGen ShowinfoFilterGen(this ImageMap input0) => new ShowinfoFilterGen(input0);
/// <summary>
/// Show textual information for each video frame.
/// </summary>
public static ShowinfoFilterGen ShowinfoFilterGen(this ImageMap input0,ShowinfoFilterGenConfig config)
{
var result = new ShowinfoFilterGen(input0);
if(config?.checksum != null) result.checksum(config.checksum.Value);
return result;
}
}
public class ShowinfoFilterGenConfig
{
/// <summary>
///  calculate checksums (default true)
/// </summary>
public bool? checksum { get; set; }
}
}
