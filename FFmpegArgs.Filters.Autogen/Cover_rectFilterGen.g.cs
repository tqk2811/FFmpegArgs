namespace FFmpegArgs.Filters.Autogens
{
public class Cover_rectFilterGen : ImageToImageFilter
{
internal Cover_rectFilterGen(ImageMap input) : base("cover_rect",input) { AddMapOut(); }
/// <summary>
///  cover bitmap filename
/// </summary>
public Cover_rectFilterGen cover(string cover) => this.SetOption("cover",cover);
/// <summary>
///  set removal mode (from 0 to 1) (default blur)
/// </summary>
public Cover_rectFilterGen mode(Cover_rectFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
}
public static class Cover_rectFilterGenExtensions
{
/// <summary>
/// Find and cover a user specified object.
/// </summary>
public static Cover_rectFilterGen Cover_rectFilterGen(this ImageMap input0) => new Cover_rectFilterGen(input0);
/// <summary>
/// Find and cover a user specified object.
/// </summary>
public static Cover_rectFilterGen Cover_rectFilterGen(this ImageMap input0,Cover_rectFilterGenConfig config)
{
var result = new Cover_rectFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.cover)) result.cover(config.cover);
if(config?.mode != null) result.mode(config.mode.Value);
return result;
}
}
public class Cover_rectFilterGenConfig
{
/// <summary>
///  cover bitmap filename
/// </summary>
public string cover { get; set; }
/// <summary>
///  set removal mode (from 0 to 1) (default blur)
/// </summary>
public Cover_rectFilterGenMode? mode { get; set; }
}
public enum Cover_rectFilterGenMode
{
[Name("cover")] cover,
[Name("blur")] blur,
}

}
