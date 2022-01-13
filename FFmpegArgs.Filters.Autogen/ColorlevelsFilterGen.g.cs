namespace FFmpegArgs.Filters.Autogens
{
public class ColorlevelsFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorlevelsFilterGen(ImageMap input) : base("colorlevels",input) { AddMapOut(); }
/// <summary>
///  set input red black point (from -1 to 1) (default 0)
/// </summary>
public ColorlevelsFilterGen rimin(double rimin) => this.SetOptionRange("rimin", rimin,-1,1);
/// <summary>
///  set input green black point (from -1 to 1) (default 0)
/// </summary>
public ColorlevelsFilterGen gimin(double gimin) => this.SetOptionRange("gimin", gimin,-1,1);
/// <summary>
///  set input blue black point (from -1 to 1) (default 0)
/// </summary>
public ColorlevelsFilterGen bimin(double bimin) => this.SetOptionRange("bimin", bimin,-1,1);
/// <summary>
///  set input alpha black point (from -1 to 1) (default 0)
/// </summary>
public ColorlevelsFilterGen aimin(double aimin) => this.SetOptionRange("aimin", aimin,-1,1);
/// <summary>
///  set input red white point (from -1 to 1) (default 1)
/// </summary>
public ColorlevelsFilterGen rimax(double rimax) => this.SetOptionRange("rimax", rimax,-1,1);
/// <summary>
///  set input green white point (from -1 to 1) (default 1)
/// </summary>
public ColorlevelsFilterGen gimax(double gimax) => this.SetOptionRange("gimax", gimax,-1,1);
/// <summary>
///  set input blue white point (from -1 to 1) (default 1)
/// </summary>
public ColorlevelsFilterGen bimax(double bimax) => this.SetOptionRange("bimax", bimax,-1,1);
/// <summary>
///  set input alpha white point (from -1 to 1) (default 1)
/// </summary>
public ColorlevelsFilterGen aimax(double aimax) => this.SetOptionRange("aimax", aimax,-1,1);
/// <summary>
///  set output red black point (from 0 to 1) (default 0)
/// </summary>
public ColorlevelsFilterGen romin(double romin) => this.SetOptionRange("romin", romin,0,1);
/// <summary>
///  set output green black point (from 0 to 1) (default 0)
/// </summary>
public ColorlevelsFilterGen gomin(double gomin) => this.SetOptionRange("gomin", gomin,0,1);
/// <summary>
///  set output blue black point (from 0 to 1) (default 0)
/// </summary>
public ColorlevelsFilterGen bomin(double bomin) => this.SetOptionRange("bomin", bomin,0,1);
/// <summary>
///  set output alpha black point (from 0 to 1) (default 0)
/// </summary>
public ColorlevelsFilterGen aomin(double aomin) => this.SetOptionRange("aomin", aomin,0,1);
/// <summary>
///  set output red white point (from 0 to 1) (default 1)
/// </summary>
public ColorlevelsFilterGen romax(double romax) => this.SetOptionRange("romax", romax,0,1);
/// <summary>
///  set output green white point (from 0 to 1) (default 1)
/// </summary>
public ColorlevelsFilterGen gomax(double gomax) => this.SetOptionRange("gomax", gomax,0,1);
/// <summary>
///  set output blue white point (from 0 to 1) (default 1)
/// </summary>
public ColorlevelsFilterGen bomax(double bomax) => this.SetOptionRange("bomax", bomax,0,1);
/// <summary>
///  set output alpha white point (from 0 to 1) (default 1)
/// </summary>
public ColorlevelsFilterGen aomax(double aomax) => this.SetOptionRange("aomax", aomax,0,1);
}
public static class ColorlevelsFilterGenExtensions
{
/// <summary>
/// Adjust the color levels.
/// </summary>
public static ColorlevelsFilterGen ColorlevelsFilterGen(this ImageMap input0) => new ColorlevelsFilterGen(input0);
/// <summary>
/// Adjust the color levels.
/// </summary>
public static ColorlevelsFilterGen ColorlevelsFilterGen(this ImageMap input0,ColorlevelsFilterGenConfig config)
{
var result = new ColorlevelsFilterGen(input0);
if(config?.rimin != null) result.rimin(config.rimin.Value);
if(config?.gimin != null) result.gimin(config.gimin.Value);
if(config?.bimin != null) result.bimin(config.bimin.Value);
if(config?.aimin != null) result.aimin(config.aimin.Value);
if(config?.rimax != null) result.rimax(config.rimax.Value);
if(config?.gimax != null) result.gimax(config.gimax.Value);
if(config?.bimax != null) result.bimax(config.bimax.Value);
if(config?.aimax != null) result.aimax(config.aimax.Value);
if(config?.romin != null) result.romin(config.romin.Value);
if(config?.gomin != null) result.gomin(config.gomin.Value);
if(config?.bomin != null) result.bomin(config.bomin.Value);
if(config?.aomin != null) result.aomin(config.aomin.Value);
if(config?.romax != null) result.romax(config.romax.Value);
if(config?.gomax != null) result.gomax(config.gomax.Value);
if(config?.bomax != null) result.bomax(config.bomax.Value);
if(config?.aomax != null) result.aomax(config.aomax.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ColorlevelsFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set input red black point (from -1 to 1) (default 0)
/// </summary>
public double? rimin { get; set; }
/// <summary>
///  set input green black point (from -1 to 1) (default 0)
/// </summary>
public double? gimin { get; set; }
/// <summary>
///  set input blue black point (from -1 to 1) (default 0)
/// </summary>
public double? bimin { get; set; }
/// <summary>
///  set input alpha black point (from -1 to 1) (default 0)
/// </summary>
public double? aimin { get; set; }
/// <summary>
///  set input red white point (from -1 to 1) (default 1)
/// </summary>
public double? rimax { get; set; }
/// <summary>
///  set input green white point (from -1 to 1) (default 1)
/// </summary>
public double? gimax { get; set; }
/// <summary>
///  set input blue white point (from -1 to 1) (default 1)
/// </summary>
public double? bimax { get; set; }
/// <summary>
///  set input alpha white point (from -1 to 1) (default 1)
/// </summary>
public double? aimax { get; set; }
/// <summary>
///  set output red black point (from 0 to 1) (default 0)
/// </summary>
public double? romin { get; set; }
/// <summary>
///  set output green black point (from 0 to 1) (default 0)
/// </summary>
public double? gomin { get; set; }
/// <summary>
///  set output blue black point (from 0 to 1) (default 0)
/// </summary>
public double? bomin { get; set; }
/// <summary>
///  set output alpha black point (from 0 to 1) (default 0)
/// </summary>
public double? aomin { get; set; }
/// <summary>
///  set output red white point (from 0 to 1) (default 1)
/// </summary>
public double? romax { get; set; }
/// <summary>
///  set output green white point (from 0 to 1) (default 1)
/// </summary>
public double? gomax { get; set; }
/// <summary>
///  set output blue white point (from 0 to 1) (default 1)
/// </summary>
public double? bomax { get; set; }
/// <summary>
///  set output alpha white point (from 0 to 1) (default 1)
/// </summary>
public double? aomax { get; set; }
public string TimelineSupport { get; set; }
}
}
