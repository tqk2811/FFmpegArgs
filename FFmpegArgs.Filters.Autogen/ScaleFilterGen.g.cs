namespace FFmpegArgs.Filters.Autogens
{
public class ScaleFilterGen : ImageToImageFilter,ICommandSupport
{
internal ScaleFilterGen(ImageMap input) : base("scale",input) { AddMapOut(); }
/// <summary>
///  Output video width
/// </summary>
public ScaleFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  Output video height
/// </summary>
public ScaleFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  Flags to pass to libswscale (default "bilinear")
/// </summary>
public ScaleFilterGen flags(string flags) => this.SetOption("flags",flags);
/// <summary>
///  set interlacing (default false)
/// </summary>
public ScaleFilterGen interl(bool interl) => this.SetOption("interl",interl.ToFFmpegFlag());
/// <summary>
///  set input YCbCr type (default "auto")
/// </summary>
public ScaleFilterGen in_color_matrix(string in_color_matrix) => this.SetOption("in_color_matrix",in_color_matrix);
/// <summary>
///  set output YCbCr type
/// </summary>
public ScaleFilterGen out_color_matrix(string out_color_matrix) => this.SetOption("out_color_matrix",out_color_matrix);
/// <summary>
///  set input color range (from 0 to 2) (default auto)
/// </summary>
public ScaleFilterGen in_range(ScaleFilterGenIn_range in_range) => this.SetOption("in_range", in_range.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set output color range (from 0 to 2) (default auto)
/// </summary>
public ScaleFilterGen out_range(ScaleFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  input vertical chroma position in luma grid/256 (from -513 to 512) (default -513)
/// </summary>
public ScaleFilterGen in_v_chr_pos(int in_v_chr_pos) => this.SetOptionRange("in_v_chr_pos", in_v_chr_pos,-513,512);
/// <summary>
///  input horizontal chroma position in luma grid/256 (from -513 to 512) (default -513)
/// </summary>
public ScaleFilterGen in_h_chr_pos(int in_h_chr_pos) => this.SetOptionRange("in_h_chr_pos", in_h_chr_pos,-513,512);
/// <summary>
///  output vertical chroma position in luma grid/256 (from -513 to 512) (default -513)
/// </summary>
public ScaleFilterGen out_v_chr_pos(int out_v_chr_pos) => this.SetOptionRange("out_v_chr_pos", out_v_chr_pos,-513,512);
/// <summary>
///  output horizontal chroma position in luma grid/256 (from -513 to 512) (default -513)
/// </summary>
public ScaleFilterGen out_h_chr_pos(int out_h_chr_pos) => this.SetOptionRange("out_h_chr_pos", out_h_chr_pos,-513,512);
/// <summary>
///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
/// </summary>
public ScaleFilterGen force_original_aspect_ratio(ScaleFilterGenForce_original_aspect_ratio force_original_aspect_ratio) => this.SetOption("force_original_aspect_ratio", force_original_aspect_ratio.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  enforce that the output resolution is divisible by a defined integer when force_original_aspect_ratio is used (from 1 to 256) (default 1)
/// </summary>
public ScaleFilterGen force_divisible_by(int force_divisible_by) => this.SetOptionRange("force_divisible_by", force_divisible_by,1,256);
/// <summary>
///  Scaler param 0 (from INT_MIN to INT_MAX) (default 123456)
/// </summary>
public ScaleFilterGen param0(double param0) => this.SetOptionRange("param0", param0,INT_MIN,INT_MAX);
/// <summary>
///  Scaler param 1 (from INT_MIN to INT_MAX) (default 123456)
/// </summary>
public ScaleFilterGen param1(double param1) => this.SetOptionRange("param1", param1,INT_MIN,INT_MAX);
/// <summary>
///  set the number of slices (debug purpose only) (from 0 to INT_MAX) (default 0)
/// </summary>
public ScaleFilterGen nb_slices(int nb_slices) => this.SetOptionRange("nb_slices", nb_slices,0,INT_MAX);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public ScaleFilterGen eval(ScaleFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
}
public static class ScaleFilterGenExtensions
{
/// <summary>
/// Scale the input video size and/or convert the image format.
/// </summary>
public static ScaleFilterGen ScaleFilterGen(this ImageMap input0) => new ScaleFilterGen(input0);
/// <summary>
/// Scale the input video size and/or convert the image format.
/// </summary>
public static ScaleFilterGen ScaleFilterGen(this ImageMap input0,ScaleFilterGenConfig config)
{
var result = new ScaleFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.width)) result.width(config.width);
if(!string.IsNullOrWhiteSpace(config?.height)) result.height(config.height);
if(!string.IsNullOrWhiteSpace(config?.flags)) result.flags(config.flags);
if(config?.interl != null) result.interl(config.interl.Value);
if(!string.IsNullOrWhiteSpace(config?.in_color_matrix)) result.in_color_matrix(config.in_color_matrix);
if(!string.IsNullOrWhiteSpace(config?.out_color_matrix)) result.out_color_matrix(config.out_color_matrix);
if(config?.in_range != null) result.in_range(config.in_range.Value);
if(config?.out_range != null) result.out_range(config.out_range.Value);
if(config?.in_v_chr_pos != null) result.in_v_chr_pos(config.in_v_chr_pos.Value);
if(config?.in_h_chr_pos != null) result.in_h_chr_pos(config.in_h_chr_pos.Value);
if(config?.out_v_chr_pos != null) result.out_v_chr_pos(config.out_v_chr_pos.Value);
if(config?.out_h_chr_pos != null) result.out_h_chr_pos(config.out_h_chr_pos.Value);
if(config?.force_original_aspect_ratio != null) result.force_original_aspect_ratio(config.force_original_aspect_ratio.Value);
if(config?.force_divisible_by != null) result.force_divisible_by(config.force_divisible_by.Value);
if(config?.param0 != null) result.param0(config.param0.Value);
if(config?.param1 != null) result.param1(config.param1.Value);
if(config?.nb_slices != null) result.nb_slices(config.nb_slices.Value);
if(config?.eval != null) result.eval(config.eval.Value);
return result;
}
}
public class ScaleFilterGenConfig
{
/// <summary>
///  Output video width
/// </summary>
public string width { get; set; }
/// <summary>
///  Output video height
/// </summary>
public string height { get; set; }
/// <summary>
///  Flags to pass to libswscale (default "bilinear")
/// </summary>
public string flags { get; set; }
/// <summary>
///  set interlacing (default false)
/// </summary>
public bool? interl { get; set; }
/// <summary>
///  set input YCbCr type (default "auto")
/// </summary>
public string in_color_matrix { get; set; }
/// <summary>
///  set output YCbCr type
/// </summary>
public string out_color_matrix { get; set; }
/// <summary>
///  set input color range (from 0 to 2) (default auto)
/// </summary>
public ScaleFilterGenIn_range? in_range { get; set; }
/// <summary>
///  set output color range (from 0 to 2) (default auto)
/// </summary>
public ScaleFilterGenOut_range? out_range { get; set; }
/// <summary>
///  input vertical chroma position in luma grid/256 (from -513 to 512) (default -513)
/// </summary>
public int? in_v_chr_pos { get; set; }
/// <summary>
///  input horizontal chroma position in luma grid/256 (from -513 to 512) (default -513)
/// </summary>
public int? in_h_chr_pos { get; set; }
/// <summary>
///  output vertical chroma position in luma grid/256 (from -513 to 512) (default -513)
/// </summary>
public int? out_v_chr_pos { get; set; }
/// <summary>
///  output horizontal chroma position in luma grid/256 (from -513 to 512) (default -513)
/// </summary>
public int? out_h_chr_pos { get; set; }
/// <summary>
///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
/// </summary>
public ScaleFilterGenForce_original_aspect_ratio? force_original_aspect_ratio { get; set; }
/// <summary>
///  enforce that the output resolution is divisible by a defined integer when force_original_aspect_ratio is used (from 1 to 256) (default 1)
/// </summary>
public int? force_divisible_by { get; set; }
/// <summary>
///  Scaler param 0 (from INT_MIN to INT_MAX) (default 123456)
/// </summary>
public double? param0 { get; set; }
/// <summary>
///  Scaler param 1 (from INT_MIN to INT_MAX) (default 123456)
/// </summary>
public double? param1 { get; set; }
/// <summary>
///  set the number of slices (debug purpose only) (from 0 to INT_MAX) (default 0)
/// </summary>
public int? nb_slices { get; set; }
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default init)
/// </summary>
public ScaleFilterGenEval? eval { get; set; }
}
public enum ScaleFilterGenIn_range
{
[Name("auto")] auto,
[Name("unknown")] unknown,
[Name("full")] full,
[Name("limited")] limited,
[Name("jpeg")] jpeg,
[Name("mpeg")] mpeg,
[Name("tv")] tv,
[Name("pc")] pc,
}

public enum ScaleFilterGenOut_range
{
[Name("auto")] auto,
[Name("unknown")] unknown,
[Name("full")] full,
[Name("limited")] limited,
[Name("jpeg")] jpeg,
[Name("mpeg")] mpeg,
[Name("tv")] tv,
[Name("pc")] pc,
}

public enum ScaleFilterGenForce_original_aspect_ratio
{
[Name("disable")] disable,
[Name("decrease")] decrease,
[Name("increase")] increase,
}

public enum ScaleFilterGenEval
{
[Name("init")] init,
[Name("frame")] frame,
}

}
