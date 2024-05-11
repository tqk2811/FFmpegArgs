namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ..C libplacebo        N->V       Apply various GPU filters from libplacebo
/// </summary>
public class LibplaceboFilterGen : ImageToImageFilter,ICommandSupport
{
internal LibplaceboFilterGen(params ImageMap[] inputs) : base("libplacebo",inputs) { AddMapOut(); }
/// <summary>
///  Number of inputs (from 1 to INT_MAX) (default 1)
/// </summary>
public LibplaceboFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs,1,INT_MAX);
/// <summary>
///  Output video frame width (default "iw")
/// </summary>
public LibplaceboFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Output video frame height (default "ih")
/// </summary>
public LibplaceboFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Output video frame rate (default "none")
/// </summary>
public LibplaceboFilterGen fps(string fps) => this.SetOption("fps",fps);
/// <summary>
///  Input video crop x (default "(iw-cw)/2")
/// </summary>
public LibplaceboFilterGen crop_x(string crop_x) => this.SetOption("crop_x",crop_x);
/// <summary>
///  Input video crop y (default "(ih-ch)/2")
/// </summary>
public LibplaceboFilterGen crop_y(string crop_y) => this.SetOption("crop_y",crop_y);
/// <summary>
///  Input video crop w (default "iw")
/// </summary>
public LibplaceboFilterGen crop_w(string crop_w) => this.SetOption("crop_w",crop_w);
/// <summary>
///  Input video crop h (default "ih")
/// </summary>
public LibplaceboFilterGen crop_h(string crop_h) => this.SetOption("crop_h",crop_h);
/// <summary>
///  Output video placement x (default "(ow-pw)/2")
/// </summary>
public LibplaceboFilterGen pos_x(string pos_x) => this.SetOption("pos_x",pos_x);
/// <summary>
///  Output video placement y (default "(oh-ph)/2")
/// </summary>
public LibplaceboFilterGen pos_y(string pos_y) => this.SetOption("pos_y",pos_y);
/// <summary>
///  Output video placement w (default "ow")
/// </summary>
public LibplaceboFilterGen pos_w(string pos_w) => this.SetOption("pos_w",pos_w);
/// <summary>
///  Output video placement h (default "oh")
/// </summary>
public LibplaceboFilterGen pos_h(string pos_h) => this.SetOption("pos_h",pos_h);
/// <summary>
///  Output video format
/// </summary>
public LibplaceboFilterGen format(string format) => this.SetOption("format",format);
/// <summary>
///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
/// </summary>
public LibplaceboFilterGen force_original_aspect_ratio(LibplaceboFilterGenForce_original_aspect_ratio force_original_aspect_ratio) => this.SetOption("force_original_aspect_ratio", force_original_aspect_ratio.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  enforce that the output resolution is divisible by a defined integer when force_original_aspect_ratio is used (from 1 to 256) (default 1)
/// </summary>
public LibplaceboFilterGen force_divisible_by(int force_divisible_by) => this.SetOptionRange("force_divisible_by", force_divisible_by,1,256);
/// <summary>
///  force SAR normalization to 1:1 by adjusting pos_x/y/w/h (default false)
/// </summary>
public LibplaceboFilterGen normalize_sar(bool normalize_sar) => this.SetOption("normalize_sar",normalize_sar.ToFFmpegFlag());
/// <summary>
///  ratio between padding and cropping when normalizing SAR (0=pad, 1=crop) (from 0 to 1) (default 0)
/// </summary>
public LibplaceboFilterGen pad_crop_ratio(float pad_crop_ratio) => this.SetOptionRange("pad_crop_ratio", pad_crop_ratio,0,1);
/// <summary>
///  Background fill color (default "black")
/// </summary>
public LibplaceboFilterGen fillcolor(string fillcolor) => this.SetOption("fillcolor",fillcolor);
/// <summary>
///  Corner rounding radius (from 0 to 1) (default 0)
/// </summary>
public LibplaceboFilterGen corner_rounding(float corner_rounding) => this.SetOptionRange("corner_rounding", corner_rounding,0,1);
/// <summary>
///  Pass extra libplacebo-specific options using a :-separated list of key=value pairs
/// </summary>
public LibplaceboFilterGen extra_opts(string extra_opts) => this.SetOption("extra_opts",extra_opts);
/// <summary>
///  select colorspace (from -1 to 14) (default auto)
/// </summary>
public LibplaceboFilterGen colorspace(LibplaceboFilterGenColorspace colorspace) => this.SetOption("colorspace", colorspace.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select color range (from -1 to 2) (default auto)
/// </summary>
public LibplaceboFilterGen range(LibplaceboFilterGenRange range) => this.SetOption("range", range.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select color primaries (from -1 to 22) (default auto)
/// </summary>
public LibplaceboFilterGen color_primaries(LibplaceboFilterGenColor_primaries color_primaries) => this.SetOption("color_primaries", color_primaries.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select color transfer (from -1 to 18) (default auto)
/// </summary>
public LibplaceboFilterGen color_trc(LibplaceboFilterGenColor_trc color_trc) => this.SetOption("color_trc", color_trc.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Upscaler function (default "spline36")
/// </summary>
public LibplaceboFilterGen upscaler(string upscaler) => this.SetOption("upscaler",upscaler);
/// <summary>
///  Downscaler function (default "mitchell")
/// </summary>
public LibplaceboFilterGen downscaler(string downscaler) => this.SetOption("downscaler",downscaler);
/// <summary>
///  Frame mixing function (default "none")
/// </summary>
public LibplaceboFilterGen frame_mixer(string frame_mixer) => this.SetOption("frame_mixer",frame_mixer);
/// <summary>
///  Number of scaler LUT entries (from 0 to 256) (default 0)
/// </summary>
public LibplaceboFilterGen lut_entries(int lut_entries) => this.SetOptionRange("lut_entries", lut_entries,0,256);
/// <summary>
///  Antiringing strength (for non-EWA filters) (from 0 to 1) (default 0)
/// </summary>
public LibplaceboFilterGen antiringing(float antiringing) => this.SetOptionRange("antiringing", antiringing,0,1);
/// <summary>
///  Enable sigmoid upscaling (default true)
/// </summary>
public LibplaceboFilterGen sigmoid(bool sigmoid) => this.SetOption("sigmoid",sigmoid.ToFFmpegFlag());
/// <summary>
///  Apply film grain metadata (default true)
/// </summary>
public LibplaceboFilterGen apply_filmgrain(bool apply_filmgrain) => this.SetOption("apply_filmgrain",apply_filmgrain.ToFFmpegFlag());
/// <summary>
///  Apply Dolby Vision metadata (default true)
/// </summary>
public LibplaceboFilterGen apply_dolbyvision(bool apply_dolbyvision) => this.SetOption("apply_dolbyvision",apply_dolbyvision.ToFFmpegFlag());
/// <summary>
///  Enable debanding (default false)
/// </summary>
public LibplaceboFilterGen deband(bool deband) => this.SetOption("deband",deband.ToFFmpegFlag());
/// <summary>
///  Deband iterations (from 0 to 16) (default 1)
/// </summary>
public LibplaceboFilterGen deband_iterations(int deband_iterations) => this.SetOptionRange("deband_iterations", deband_iterations,0,16);
/// <summary>
///  Deband threshold (from 0 to 1024) (default 4)
/// </summary>
public LibplaceboFilterGen deband_threshold(float deband_threshold) => this.SetOptionRange("deband_threshold", deband_threshold,0,1024);
/// <summary>
///  Deband radius (from 0 to 1024) (default 16)
/// </summary>
public LibplaceboFilterGen deband_radius(float deband_radius) => this.SetOptionRange("deband_radius", deband_radius,0,1024);
/// <summary>
///  Deband grain (from 0 to 1024) (default 6)
/// </summary>
public LibplaceboFilterGen deband_grain(float deband_grain) => this.SetOptionRange("deband_grain", deband_grain,0,1024);
/// <summary>
///  Brightness boost (from -1 to 1) (default 0)
/// </summary>
public LibplaceboFilterGen brightness(float brightness) => this.SetOptionRange("brightness", brightness,-1,1);
/// <summary>
///  Contrast gain (from 0 to 16) (default 1)
/// </summary>
public LibplaceboFilterGen contrast(float contrast) => this.SetOptionRange("contrast", contrast,0,16);
/// <summary>
///  Saturation gain (from 0 to 16) (default 1)
/// </summary>
public LibplaceboFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation,0,16);
/// <summary>
///  Hue shift (from -3.14159 to 3.14159) (default 0)
/// </summary>
public LibplaceboFilterGen hue(float hue) => this.SetOptionRange("hue", hue,-3.14159,3.14159);
/// <summary>
///  Gamma adjustment (from 0 to 16) (default 1)
/// </summary>
public LibplaceboFilterGen gamma(float gamma) => this.SetOptionRange("gamma", gamma,0,16);
/// <summary>
///  Enable dynamic peak detection for HDR tone-mapping (default true)
/// </summary>
public LibplaceboFilterGen peak_detect(bool peak_detect) => this.SetOption("peak_detect",peak_detect.ToFFmpegFlag());
/// <summary>
///  Peak detection smoothing period (from 0 to 1000) (default 100)
/// </summary>
public LibplaceboFilterGen smoothing_period(float smoothing_period) => this.SetOptionRange("smoothing_period", smoothing_period,0,1000);
/// <summary>
///  Peak detection minimum peak (from 0 to 100) (default 1)
/// </summary>
public LibplaceboFilterGen minimum_peak(float minimum_peak) => this.SetOptionRange("minimum_peak", minimum_peak,0,100);
/// <summary>
///  Scene change low threshold (from -1 to 100) (default 5.5)
/// </summary>
public LibplaceboFilterGen scene_threshold_low(float scene_threshold_low) => this.SetOptionRange("scene_threshold_low", scene_threshold_low,-1,100);
/// <summary>
///  Scene change high threshold (from -1 to 100) (default 10)
/// </summary>
public LibplaceboFilterGen scene_threshold_high(float scene_threshold_high) => this.SetOptionRange("scene_threshold_high", scene_threshold_high,-1,100);
/// <summary>
///  Peak detection percentile (from 0 to 100) (default 99.995)
/// </summary>
public LibplaceboFilterGen percentile(float percentile) => this.SetOptionRange("percentile", percentile,0,100);
/// <summary>
///  Gamut-mapping mode (from 0 to 8) (default perceptual)
/// </summary>
public LibplaceboFilterGen gamut_mode(LibplaceboFilterGenGamut_mode gamut_mode) => this.SetOption("gamut_mode", gamut_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Tone-mapping algorithm (from 0 to 11) (default auto)
/// </summary>
public LibplaceboFilterGen tonemapping(LibplaceboFilterGenTonemapping tonemapping) => this.SetOption("tonemapping", tonemapping.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Tunable parameter for some tone-mapping functions (from 0 to 100) (default 0)
/// </summary>
public LibplaceboFilterGen tonemapping_param(float tonemapping_param) => this.SetOptionRange("tonemapping_param", tonemapping_param,0,100);
/// <summary>
///  Inverse tone mapping (range expansion) (default false)
/// </summary>
public LibplaceboFilterGen inverse_tonemapping(bool inverse_tonemapping) => this.SetOption("inverse_tonemapping",inverse_tonemapping.ToFFmpegFlag());
/// <summary>
///  Tone-mapping LUT size (from 2 to 1024) (default 256)
/// </summary>
public LibplaceboFilterGen tonemapping_lut_size(int tonemapping_lut_size) => this.SetOptionRange("tonemapping_lut_size", tonemapping_lut_size,2,1024);
/// <summary>
///  HDR contrast recovery strength (from 0 to 3) (default 0.3)
/// </summary>
public LibplaceboFilterGen contrast_recovery(float contrast_recovery) => this.SetOptionRange("contrast_recovery", contrast_recovery,0,3);
/// <summary>
///  HDR contrast recovery smoothness (from 1 to 32) (default 3.5)
/// </summary>
public LibplaceboFilterGen contrast_smoothness(float contrast_smoothness) => this.SetOptionRange("contrast_smoothness", contrast_smoothness,1,32);
/// <summary>
///  Desaturation strength (from -1 to 1) (default -1)
/// </summary>
[Obsolete]
public LibplaceboFilterGen desaturation_strength(float desaturation_strength) => this.SetOptionRange("desaturation_strength", desaturation_strength,-1,1);
/// <summary>
///  Desaturation exponent (from -1 to 10) (default -1)
/// </summary>
[Obsolete]
public LibplaceboFilterGen desaturation_exponent(float desaturation_exponent) => this.SetOptionRange("desaturation_exponent", desaturation_exponent,-1,10);
/// <summary>
///  Highlight out-of-gamut colors (default false)
/// </summary>
[Obsolete]
public LibplaceboFilterGen gamut_warning(bool gamut_warning) => this.SetOption("gamut_warning",gamut_warning.ToFFmpegFlag());
/// <summary>
///  Enable desaturating colorimetric gamut clipping (default false)
/// </summary>
[Obsolete]
public LibplaceboFilterGen gamut_clipping(bool gamut_clipping) => this.SetOption("gamut_clipping",gamut_clipping.ToFFmpegFlag());
/// <summary>
///  Rendering intent (from 0 to 3) (default perceptual)
/// </summary>
[Obsolete]
public LibplaceboFilterGen intent(LibplaceboFilterGenIntent intent) => this.SetOption("intent", intent.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Tone-mapping mode (from 0 to 4) (default auto)
/// </summary>
[Obsolete]
public LibplaceboFilterGen tonemapping_mode(LibplaceboFilterGenTonemapping_mode tonemapping_mode) => this.SetOption("tonemapping_mode", tonemapping_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Crosstalk factor for tone-mapping (from 0 to 0.3) (default 0.04)
/// </summary>
[Obsolete]
public LibplaceboFilterGen tonemapping_crosstalk(float tonemapping_crosstalk) => this.SetOptionRange("tonemapping_crosstalk", tonemapping_crosstalk,0,0.3);
/// <summary>
///  Tone-mapping overshoot margin (from 0 to 1) (default 0.05)
/// </summary>
[Obsolete]
public LibplaceboFilterGen overshoot(float overshoot) => this.SetOptionRange("overshoot", overshoot,0,1);
/// <summary>
///  Tone-mapping hybrid LMS mixing coefficient (from 0 to 1) (default 0.2)
/// </summary>
public LibplaceboFilterGen hybrid_mix(float hybrid_mix) => this.SetOptionRange("hybrid_mix", hybrid_mix,0,1);
/// <summary>
///  Dither method to use (from -1 to 3) (default blue)
/// </summary>
public LibplaceboFilterGen dithering(LibplaceboFilterGenDithering dithering) => this.SetOption("dithering", dithering.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Dithering LUT size (from 1 to 8) (default 6)
/// </summary>
public LibplaceboFilterGen dither_lut_size(int dither_lut_size) => this.SetOptionRange("dither_lut_size", dither_lut_size,1,8);
/// <summary>
///  Enable temporal dithering (default false)
/// </summary>
public LibplaceboFilterGen dither_temporal(bool dither_temporal) => this.SetOption("dither_temporal",dither_temporal.ToFFmpegFlag());
/// <summary>
///  Colorblindness adaptation model (default 0)
/// </summary>
public LibplaceboFilterGen cones(LibplaceboFilterGenCones cones) => this.SetOption("cones", cones.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  Colorblindness adaptation strength (from 0 to 10) (default 0)
/// </summary>
public LibplaceboFilterGen cone_strength(float cone_strength) => this.SetOptionRange("cone-strength", cone_strength,0,10);
/// <summary>
///  Path to custom user shader (mpv .hook format)
/// </summary>
public LibplaceboFilterGen custom_shader_path(string custom_shader_path) => this.SetOption("custom_shader_path",custom_shader_path);
/// <summary>
///  Custom user shader as binary (mpv .hook format)
/// </summary>
public LibplaceboFilterGen custom_shader_bin(string custom_shader_bin) => this.SetOption("custom_shader_bin",custom_shader_bin);
/// <summary>
///  Skip anti-aliasing (default false)
/// </summary>
public LibplaceboFilterGen skip_aa(bool skip_aa) => this.SetOption("skip_aa",skip_aa.ToFFmpegFlag());
/// <summary>
///  Polar LUT cutoff (from 0 to 1) (default 0)
/// </summary>
public LibplaceboFilterGen polar_cutoff(float polar_cutoff) => this.SetOptionRange("polar_cutoff", polar_cutoff,0,1);
/// <summary>
///  Disable linear scaling (default false)
/// </summary>
public LibplaceboFilterGen disable_linear(bool disable_linear) => this.SetOption("disable_linear",disable_linear.ToFFmpegFlag());
/// <summary>
///  Disable built-in scalers (default false)
/// </summary>
public LibplaceboFilterGen disable_builtin(bool disable_builtin) => this.SetOption("disable_builtin",disable_builtin.ToFFmpegFlag());
/// <summary>
///  Deprecated, does nothing (default false)
/// </summary>
[Obsolete]
public LibplaceboFilterGen force_icc_lut(bool force_icc_lut) => this.SetOption("force_icc_lut",force_icc_lut.ToFFmpegFlag());
/// <summary>
///  Force dithering (default false)
/// </summary>
public LibplaceboFilterGen force_dither(bool force_dither) => this.SetOption("force_dither",force_dither.ToFFmpegFlag());
/// <summary>
///  Force-disable FBOs (default false)
/// </summary>
public LibplaceboFilterGen disable_fbos(bool disable_fbos) => this.SetOption("disable_fbos",disable_fbos.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply various GPU filters from libplacebo
/// </summary>
public static LibplaceboFilterGen LibplaceboFilterGen(this IEnumerable<ImageMap> inputs) => new LibplaceboFilterGen(inputs.ToArray());
}
/// <summary>
///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
/// </summary>
public enum LibplaceboFilterGenForce_original_aspect_ratio
{
/// <summary>
/// disable         0            ..FV.......
/// </summary>
[Name("disable")] disable,
/// <summary>
/// decrease        1            ..FV.......
/// </summary>
[Name("decrease")] decrease,
/// <summary>
/// increase        2            ..FV.......
/// </summary>
[Name("increase")] increase,
}

/// <summary>
///  select colorspace (from -1 to 14) (default auto)
/// </summary>
public enum LibplaceboFilterGenColorspace
{
/// <summary>
/// auto            -1           ..FV....... keep the same colorspace
/// </summary>
[Name("auto")] auto,
/// <summary>
/// gbr             0            ..FV.......
/// </summary>
[Name("gbr")] gbr,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// ycgco           8            ..FV.......
/// </summary>
[Name("ycgco")] ycgco,
/// <summary>
/// bt2020nc        9            ..FV.......
/// </summary>
[Name("bt2020nc")] bt2020nc,
/// <summary>
/// bt2020c         10           ..FV.......
/// </summary>
[Name("bt2020c")] bt2020c,
/// <summary>
/// ictcp           14           ..FV.......
/// </summary>
[Name("ictcp")] ictcp,
}

/// <summary>
///  select color range (from -1 to 2) (default auto)
/// </summary>
public enum LibplaceboFilterGenRange
{
/// <summary>
/// auto            -1           ..FV....... keep the same color range
/// </summary>
[Name("auto")] auto,
/// <summary>
/// unspecified     0            ..FV.......
/// </summary>
[Name("unspecified")] unspecified,
/// <summary>
/// unknown         0            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// limited         1            ..FV.......
/// </summary>
[Name("limited")] limited,
/// <summary>
/// tv              1            ..FV.......
/// </summary>
[Name("tv")] tv,
/// <summary>
/// mpeg            1            ..FV.......
/// </summary>
[Name("mpeg")] mpeg,
/// <summary>
/// full            2            ..FV.......
/// </summary>
[Name("full")] full,
/// <summary>
/// pc              2            ..FV.......
/// </summary>
[Name("pc")] pc,
/// <summary>
/// jpeg            2            ..FV.......
/// </summary>
[Name("jpeg")] jpeg,
}

/// <summary>
///  select color primaries (from -1 to 22) (default auto)
/// </summary>
public enum LibplaceboFilterGenColor_primaries
{
/// <summary>
/// auto            -1           ..FV....... keep the same color primaries
/// </summary>
[Name("auto")] auto,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// film            8            ..FV.......
/// </summary>
[Name("film")] film,
/// <summary>
/// bt2020          9            ..FV.......
/// </summary>
[Name("bt2020")] bt2020,
/// <summary>
/// smpte428        10           ..FV.......
/// </summary>
[Name("smpte428")] smpte428,
/// <summary>
/// smpte431        11           ..FV.......
/// </summary>
[Name("smpte431")] smpte431,
/// <summary>
/// smpte432        12           ..FV.......
/// </summary>
[Name("smpte432")] smpte432,
/// <summary>
/// jedec-p22       22           ..FV.......
/// </summary>
[Name("jedec-p22")] jedec_p22,
/// <summary>
/// ebu3213         22           ..FV.......
/// </summary>
[Name("ebu3213")] ebu3213,
}

/// <summary>
///  select color transfer (from -1 to 18) (default auto)
/// </summary>
public enum LibplaceboFilterGenColor_trc
{
/// <summary>
/// auto            -1           ..FV....... keep the same color transfer
/// </summary>
[Name("auto")] auto,
/// <summary>
/// bt709           1            ..FV.......
/// </summary>
[Name("bt709")] bt709,
/// <summary>
/// unknown         2            ..FV.......
/// </summary>
[Name("unknown")] unknown,
/// <summary>
/// bt470m          4            ..FV.......
/// </summary>
[Name("bt470m")] bt470m,
/// <summary>
/// bt470bg         5            ..FV.......
/// </summary>
[Name("bt470bg")] bt470bg,
/// <summary>
/// smpte170m       6            ..FV.......
/// </summary>
[Name("smpte170m")] smpte170m,
/// <summary>
/// smpte240m       7            ..FV.......
/// </summary>
[Name("smpte240m")] smpte240m,
/// <summary>
/// linear          8            ..FV.......
/// </summary>
[Name("linear")] linear,
/// <summary>
/// iec61966-2-4    11           ..FV.......
/// </summary>
[Name("iec61966-2-4")] iec61966_2_4,
/// <summary>
/// bt1361e         12           ..FV.......
/// </summary>
[Name("bt1361e")] bt1361e,
/// <summary>
/// iec61966-2-1    13           ..FV.......
/// </summary>
[Name("iec61966-2-1")] iec61966_2_1,
/// <summary>
/// bt2020-10       14           ..FV.......
/// </summary>
[Name("bt2020-10")] bt2020_10,
/// <summary>
/// bt2020-12       15           ..FV.......
/// </summary>
[Name("bt2020-12")] bt2020_12,
/// <summary>
/// smpte2084       16           ..FV.......
/// </summary>
[Name("smpte2084")] smpte2084,
/// <summary>
/// arib-std-b67    18           ..FV.......
/// </summary>
[Name("arib-std-b67")] arib_std_b67,
}

/// <summary>
///  Gamut-mapping mode (from 0 to 8) (default perceptual)
/// </summary>
public enum LibplaceboFilterGenGamut_mode
{
/// <summary>
/// clip            0            ..FV....... Hard-clip (RGB per-channel)
/// </summary>
[Name("clip")] clip,
/// <summary>
/// perceptual      1            ..FV....... Colorimetric soft clipping
/// </summary>
[Name("perceptual")] perceptual,
/// <summary>
/// relative        2            ..FV....... Relative colorimetric clipping
/// </summary>
[Name("relative")] relative,
/// <summary>
/// saturation      3            ..FV....... Saturation mapping (RGB -> RGB)
/// </summary>
[Name("saturation")] saturation,
/// <summary>
/// absolute        4            ..FV....... Absolute colorimetric clipping
/// </summary>
[Name("absolute")] absolute,
/// <summary>
/// desaturate      5            ..FV....... Colorimetrically desaturate colors towards white
/// </summary>
[Name("desaturate")] desaturate,
/// <summary>
/// darken          6            ..FV....... Colorimetric clip with bias towards darkening image to fit gamut
/// </summary>
[Name("darken")] darken,
/// <summary>
/// warn            7            ..FV....... Highlight out-of-gamut colors
/// </summary>
[Name("warn")] warn,
/// <summary>
/// linear          8            ..FV....... Linearly reduce chromaticity to fit gamut
/// </summary>
[Name("linear")] linear,
}

/// <summary>
///  Tone-mapping algorithm (from 0 to 11) (default auto)
/// </summary>
public enum LibplaceboFilterGenTonemapping
{
/// <summary>
/// auto            0            ..FV....... Automatic selection
/// </summary>
[Name("auto")] auto,
/// <summary>
/// clip            1            ..FV....... No tone mapping (clip
/// </summary>
[Name("clip")] clip,
/// <summary>
/// st2094-40       2            ..FV....... SMPTE ST 2094-40
/// </summary>
[Name("st2094-40")] st2094_40,
/// <summary>
/// st2094-10       3            ..FV....... SMPTE ST 2094-10
/// </summary>
[Name("st2094-10")] st2094_10,
/// <summary>
/// bt.2390         4            ..FV....... ITU-R BT.2390 EETF
/// </summary>
[Name("bt.2390")] btDot2390,
/// <summary>
/// bt.2446a        5            ..FV....... ITU-R BT.2446 Method A
/// </summary>
[Name("bt.2446a")] btDot2446a,
/// <summary>
/// spline          6            ..FV....... Single-pivot polynomial spline
/// </summary>
[Name("spline")] spline,
/// <summary>
/// reinhard        7            ..FV....... Reinhard
/// </summary>
[Name("reinhard")] reinhard,
/// <summary>
/// mobius          8            ..FV....... Mobius
/// </summary>
[Name("mobius")] mobius,
/// <summary>
/// hable           9            ..FV....... Filmic tone-mapping (Hable)
/// </summary>
[Name("hable")] hable,
/// <summary>
/// gamma           10           ..FV....... Gamma function with knee
/// </summary>
[Name("gamma")] gamma,
/// <summary>
/// linear          11           ..FV....... Perceptually linear stretch
/// </summary>
[Name("linear")] linear,
}

/// <summary>
///  Rendering intent (from 0 to 3) (default perceptual)
/// </summary>
public enum LibplaceboFilterGenIntent
{
/// <summary>
/// perceptual      0            ..FV....... Perceptual
/// </summary>
[Name("perceptual")] perceptual,
/// <summary>
/// relative        1            ..FV....... Relative colorimetric
/// </summary>
[Name("relative")] relative,
/// <summary>
/// absolute        3            ..FV....... Absolute colorimetric
/// </summary>
[Name("absolute")] absolute,
/// <summary>
/// saturation      2            ..FV....... Saturation mapping
/// </summary>
[Name("saturation")] saturation,
}

/// <summary>
///  Tone-mapping mode (from 0 to 4) (default auto)
/// </summary>
public enum LibplaceboFilterGenTonemapping_mode
{
/// <summary>
/// auto            0            ..FV....... Automatic selection
/// </summary>
[Name("auto")] auto,
/// <summary>
/// rgb             1            ..FV....... Per-channel (RGB)
/// </summary>
[Name("rgb")] rgb,
/// <summary>
/// max             2            ..FV....... Maximum component
/// </summary>
[Name("max")] max,
/// <summary>
/// hybrid          3            ..FV....... Hybrid of Luma/RGB
/// </summary>
[Name("hybrid")] hybrid,
/// <summary>
/// luma            4            ..FV....... Luminance
/// </summary>
[Name("luma")] luma,
}

/// <summary>
///  Dither method to use (from -1 to 3) (default blue)
/// </summary>
public enum LibplaceboFilterGenDithering
{
/// <summary>
/// none            -1           ..FV....... Disable dithering
/// </summary>
[Name("none")] none,
/// <summary>
/// blue            0            ..FV....... Blue noise
/// </summary>
[Name("blue")] blue,
/// <summary>
/// ordered         1            ..FV....... Ordered LUT
/// </summary>
[Name("ordered")] ordered,
/// <summary>
/// ordered_fixed   2            ..FV....... Fixed function ordered
/// </summary>
[Name("ordered_fixed")] ordered_fixed,
/// <summary>
/// white           3            ..FV....... White noise
/// </summary>
[Name("white")] white,
}

/// <summary>
///  Colorblindness adaptation model (default 0)
/// </summary>
public enum LibplaceboFilterGenCones
{
/// <summary>
/// l                            ..FV....... L cone
/// </summary>
[Name("l")] l,
/// <summary>
/// m                            ..FV....... M cone
/// </summary>
[Name("m")] m,
/// <summary>
/// s                            ..FV....... S cone
/// </summary>
[Name("s")] s,
}

}
