namespace FFmpegArgs.Filters.Autogens
{
public class DeflickerFilterGen : ImageToImageFilter
{
internal DeflickerFilterGen(ImageMap input) : base("deflicker",input) { AddMapOut(); }
/// <summary>
///  set how many frames to use (from 2 to 129) (default 5)
/// </summary>
public DeflickerFilterGen size(int size) => this.SetOptionRange("size", size,2,129);
/// <summary>
///  set how to smooth luminance (from 0 to 6) (default am)
/// </summary>
public DeflickerFilterGen mode(DeflickerFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  leave frames unchanged (default false)
/// </summary>
public DeflickerFilterGen bypass(bool bypass) => this.SetOption("bypass",bypass.ToFFmpegFlag());
}
public static class DeflickerFilterGenExtensions
{
/// <summary>
/// Remove temporal frame luminance variations.
/// </summary>
public static DeflickerFilterGen DeflickerFilterGen(this ImageMap input0) => new DeflickerFilterGen(input0);
/// <summary>
/// Remove temporal frame luminance variations.
/// </summary>
public static DeflickerFilterGen DeflickerFilterGen(this ImageMap input0,DeflickerFilterGenConfig config)
{
var result = new DeflickerFilterGen(input0);
if(config?.size != null) result.size(config.size.Value);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.bypass != null) result.bypass(config.bypass.Value);
return result;
}
}
public class DeflickerFilterGenConfig
{
/// <summary>
///  set how many frames to use (from 2 to 129) (default 5)
/// </summary>
public int? size { get; set; }
/// <summary>
///  set how to smooth luminance (from 0 to 6) (default am)
/// </summary>
public DeflickerFilterGenMode? mode { get; set; }
/// <summary>
///  leave frames unchanged (default false)
/// </summary>
public bool? bypass { get; set; }
}
public enum DeflickerFilterGenMode
{
[Name("am")] am,
[Name("gm")] gm,
[Name("hm")] hm,
[Name("qm")] qm,
[Name("cm")] cm,
[Name("pm")] pm,
[Name("median")] median,
}

}
