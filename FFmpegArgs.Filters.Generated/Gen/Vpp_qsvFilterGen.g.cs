namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... vpp_qsv           V-&gt;V       Quick Sync Video &quot;VPP&quot;
/// </summary>
public class Vpp_qsvFilterGen : ImageToImageFilter
{
internal Vpp_qsvFilterGen(ImageMap input) : base("vpp_qsv",input) { AddMapOut(); }
/// <summary>
///  deinterlace mode: 0=off, 1=bob, 2=advanced (from 0 to 2) (default 0)
/// </summary>
public Vpp_qsvFilterGen deinterlace(Vpp_qsvFilterGenDeinterlace deinterlace) => this.SetOption("deinterlace", deinterlace.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  denoise level [0, 100] (from 0 to 100) (default 0)
/// </summary>
public Vpp_qsvFilterGen denoise(int denoise) => this.SetOptionRange("denoise", denoise,0,100);
/// <summary>
///  enhancement level [0, 100] (from 0 to 100) (default 0)
/// </summary>
public Vpp_qsvFilterGen detail(int detail) => this.SetOptionRange("detail", detail,0,100);
/// <summary>
///  output framerate (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public Vpp_qsvFilterGen framerate(Rational framerate) => this.SetOption("framerate",framerate.Check(0,DBL_MAX));
/// <summary>
///  Enable ProcAmp (from 0 to 1) (default 0)
/// </summary>
public Vpp_qsvFilterGen procamp(int procamp) => this.SetOptionRange("procamp", procamp,0,1);
/// <summary>
///  ProcAmp hue (from -180 to 180) (default 0)
/// </summary>
public Vpp_qsvFilterGen hue(float hue) => this.SetOptionRange("hue", hue,-180,180);
/// <summary>
///  ProcAmp saturation (from 0 to 10) (default 1)
/// </summary>
public Vpp_qsvFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation,0,10);
/// <summary>
///  ProcAmp contrast (from 0 to 10) (default 1)
/// </summary>
public Vpp_qsvFilterGen contrast(float contrast) => this.SetOptionRange("contrast", contrast,0,10);
/// <summary>
///  ProcAmp brightness (from -100 to 100) (default 0)
/// </summary>
public Vpp_qsvFilterGen brightness(float brightness) => this.SetOptionRange("brightness", brightness,-100,100);
/// <summary>
///  set transpose direction (from -1 to 6) (default -1)
/// </summary>
public Vpp_qsvFilterGen transpose(Vpp_qsvFilterGenTranspose transpose) => this.SetOption("transpose", transpose.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the width crop area expression (default &quot;iw&quot;)
/// </summary>
public Vpp_qsvFilterGen cw(ExpressionValue cw) => this.SetOption("cw",(string)cw);
/// <summary>
///  set the height crop area expression (default &quot;ih&quot;)
/// </summary>
public Vpp_qsvFilterGen ch(ExpressionValue ch) => this.SetOption("ch",(string)ch);
/// <summary>
///  set the x crop area expression (default &quot;(in_w-out_w)/2&quot;)
/// </summary>
public Vpp_qsvFilterGen cx(ExpressionValue cx) => this.SetOption("cx",(string)cx);
/// <summary>
///  set the y crop area expression (default &quot;(in_h-out_h)/2&quot;)
/// </summary>
public Vpp_qsvFilterGen cy(ExpressionValue cy) => this.SetOption("cy",(string)cy);
/// <summary>
///  Output video width(0=input video width, -1=keep input video aspect) (default &quot;cw&quot;)
/// </summary>
public Vpp_qsvFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  Output video height(0=input video height, -1=keep input video aspect) (default &quot;w*ch/cw&quot;)
/// </summary>
public Vpp_qsvFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  Output pixel format (default &quot;same&quot;)
/// </summary>
public Vpp_qsvFilterGen format(string format) => this.SetOption("format",format);
/// <summary>
///  Internal parallelization depth, the higher the value the higher the latency. (from 0 to INT_MAX) (default 4)
/// </summary>
public Vpp_qsvFilterGen async_depth(int async_depth) => this.SetOptionRange("async_depth", async_depth,0,INT_MAX);
/// <summary>
///  scaling &amp; format conversion mode (mode compute(3), vd(4) and ve(5) are only available on some platforms) (from 0 to 5) (default auto)
/// </summary>
public Vpp_qsvFilterGen scale_mode(Vpp_qsvFilterGenScale_mode scale_mode) => this.SetOption("scale_mode", scale_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Generate output at frame rate or field rate, available only for deinterlace mode (from 0 to 1) (default frame)
/// </summary>
public Vpp_qsvFilterGen rate(Vpp_qsvFilterGenRate rate) => this.SetOption("rate", rate.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Output color range (from 0 to 2) (default 0)
/// </summary>
public Vpp_qsvFilterGen out_range(Vpp_qsvFilterGenOut_range out_range) => this.SetOption("out_range", out_range.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Output color matrix coefficient set
/// </summary>
public Vpp_qsvFilterGen out_color_matrix(string out_color_matrix) => this.SetOption("out_color_matrix",out_color_matrix);
/// <summary>
///  Output color primaries
/// </summary>
public Vpp_qsvFilterGen out_color_primaries(string out_color_primaries) => this.SetOption("out_color_primaries",out_color_primaries);
/// <summary>
///  Output color transfer characteristics
/// </summary>
public Vpp_qsvFilterGen out_color_transfer(string out_color_transfer) => this.SetOption("out_color_transfer",out_color_transfer);
/// <summary>
///  Perform tonemapping (0=disable tonemapping, 1=perform tonemapping if the input has HDR metadata) (from 0 to 1) (default 0)
/// </summary>
public Vpp_qsvFilterGen tonemap(int tonemap) => this.SetOptionRange("tonemap", tonemap,0,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Quick Sync Video &quot;VPP&quot;
/// </summary>
public static Vpp_qsvFilterGen Vpp_qsvFilterGen(this ImageMap input0) => new Vpp_qsvFilterGen(input0);
}
/// <summary>
///  deinterlace mode: 0=off, 1=bob, 2=advanced (from 0 to 2) (default 0)
/// </summary>
public enum Vpp_qsvFilterGenDeinterlace
{
/// <summary>
/// bob             1            ..FV....... Bob deinterlace mode.
/// </summary>
[Name("bob")] bob,
/// <summary>
/// advanced        2            ..FV....... Advanced deinterlace mode.
/// </summary>
[Name("advanced")] advanced,
}

/// <summary>
///  set transpose direction (from -1 to 6) (default -1)
/// </summary>
public enum Vpp_qsvFilterGenTranspose
{
/// <summary>
/// cclock_hflip    0            ..FV....... rotate counter-clockwise with horizontal flip
/// </summary>
[Name("cclock_hflip")] cclock_hflip,
/// <summary>
/// clock           1            ..FV....... rotate clockwise
/// </summary>
[Name("clock")] clock,
/// <summary>
/// cclock          2            ..FV....... rotate counter-clockwise
/// </summary>
[Name("cclock")] cclock,
/// <summary>
/// clock_hflip     3            ..FV....... rotate clockwise with horizontal flip
/// </summary>
[Name("clock_hflip")] clock_hflip,
/// <summary>
/// reversal        4            ..FV....... rotate by half-turn
/// </summary>
[Name("reversal")] reversal,
/// <summary>
/// hflip           5            ..FV....... flip horizontally
/// </summary>
[Name("hflip")] hflip,
/// <summary>
/// vflip           6            ..FV....... flip vertically
/// </summary>
[Name("vflip")] vflip,
}

/// <summary>
///  scaling &amp; format conversion mode (mode compute(3), vd(4) and ve(5) are only available on some platforms) (from 0 to 5) (default auto)
/// </summary>
public enum Vpp_qsvFilterGenScale_mode
{
/// <summary>
/// auto            0            ..FV....... auto mode
/// </summary>
[Name("auto")] auto,
/// <summary>
/// low_power       1            ..FV....... low power mode
/// </summary>
[Name("low_power")] low_power,
/// <summary>
/// hq              2            ..FV....... high quality mode
/// </summary>
[Name("hq")] hq,
/// <summary>
/// compute         3            ..FV....... compute
/// </summary>
[Name("compute")] compute,
/// <summary>
/// vd              4            ..FV....... vd
/// </summary>
[Name("vd")] vd,
/// <summary>
/// ve              5            ..FV....... ve
/// </summary>
[Name("ve")] ve,
}

/// <summary>
///  Generate output at frame rate or field rate, available only for deinterlace mode (from 0 to 1) (default frame)
/// </summary>
public enum Vpp_qsvFilterGenRate
{
/// <summary>
/// frame           0            ..FV....... Output at frame rate (one frame of output for each field-pair)
/// </summary>
[Name("frame")] frame,
/// <summary>
/// field           1            ..FV....... Output at field rate (one frame of output for each field)
/// </summary>
[Name("field")] field,
}

/// <summary>
///  Output color range (from 0 to 2) (default 0)
/// </summary>
public enum Vpp_qsvFilterGenOut_range
{
/// <summary>
/// full            2            ..FV....... Full range
/// </summary>
[Name("full")] full,
/// <summary>
/// limited         1            ..FV....... Limited range
/// </summary>
[Name("limited")] limited,
/// <summary>
/// jpeg            2            ..FV....... Full range
/// </summary>
[Name("jpeg")] jpeg,
/// <summary>
/// mpeg            1            ..FV....... Limited range
/// </summary>
[Name("mpeg")] mpeg,
/// <summary>
/// tv              1            ..FV....... Limited range
/// </summary>
[Name("tv")] tv,
/// <summary>
/// pc              2            ..FV....... Full range
/// </summary>
[Name("pc")] pc,
}

}
