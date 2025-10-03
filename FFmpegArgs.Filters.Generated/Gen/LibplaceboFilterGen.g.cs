namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ..C libplacebo        N-&gt;V       Apply various GPU filters from libplacebo
    /// </summary>
    public class LibplaceboFilterGen : ImageToImageFilter, ICommandSupport
    {
        internal LibplaceboFilterGen(params ImageMap[] inputs) : base("libplacebo", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Number of inputs (from 1 to INT_MAX) (default 1)
        /// </summary>
        public LibplaceboFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 1, INT_MAX);
        /// <summary>
        ///  Output video frame width (default &quot;iw&quot;)
        /// </summary>
        public LibplaceboFilterGen w(String w) => this.SetOption("w", w.ToString());
        /// <summary>
        ///  Output video frame height (default &quot;ih&quot;)
        /// </summary>
        public LibplaceboFilterGen h(String h) => this.SetOption("h", h.ToString());
        /// <summary>
        ///  Output video frame rate (default &quot;none&quot;)
        /// </summary>
        public LibplaceboFilterGen fps(String fps) => this.SetOption("fps", fps.ToString());
        /// <summary>
        ///  Input video crop x (default &quot;(iw-cw)/2&quot;)
        /// </summary>
        public LibplaceboFilterGen crop_x(String crop_x) => this.SetOption("crop_x", crop_x.ToString());
        /// <summary>
        ///  Input video crop y (default &quot;(ih-ch)/2&quot;)
        /// </summary>
        public LibplaceboFilterGen crop_y(String crop_y) => this.SetOption("crop_y", crop_y.ToString());
        /// <summary>
        ///  Input video crop w (default &quot;iw&quot;)
        /// </summary>
        public LibplaceboFilterGen crop_w(String crop_w) => this.SetOption("crop_w", crop_w.ToString());
        /// <summary>
        ///  Input video crop h (default &quot;ih&quot;)
        /// </summary>
        public LibplaceboFilterGen crop_h(String crop_h) => this.SetOption("crop_h", crop_h.ToString());
        /// <summary>
        ///  Output video placement x (default &quot;(ow-pw)/2&quot;)
        /// </summary>
        public LibplaceboFilterGen pos_x(String pos_x) => this.SetOption("pos_x", pos_x.ToString());
        /// <summary>
        ///  Output video placement y (default &quot;(oh-ph)/2&quot;)
        /// </summary>
        public LibplaceboFilterGen pos_y(String pos_y) => this.SetOption("pos_y", pos_y.ToString());
        /// <summary>
        ///  Output video placement w (default &quot;ow&quot;)
        /// </summary>
        public LibplaceboFilterGen pos_w(String pos_w) => this.SetOption("pos_w", pos_w.ToString());
        /// <summary>
        ///  Output video placement h (default &quot;oh&quot;)
        /// </summary>
        public LibplaceboFilterGen pos_h(String pos_h) => this.SetOption("pos_h", pos_h.ToString());
        /// <summary>
        ///  Output video format
        /// </summary>
        public LibplaceboFilterGen format(String format) => this.SetOption("format", format.ToString());
        /// <summary>
        ///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
        /// </summary>
        public LibplaceboFilterGen force_original_aspect_ratio(LibplaceboFilterGenForce_original_aspect_ratio force_original_aspect_ratio) => this.SetOption("force_original_aspect_ratio", force_original_aspect_ratio.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  enforce that the output resolution is divisible by a defined integer when force_original_aspect_ratio is used (from 1 to 256) (default 1)
        /// </summary>
        public LibplaceboFilterGen force_divisible_by(int force_divisible_by) => this.SetOptionRange("force_divisible_by", force_divisible_by, 1, 256);
        /// <summary>
        ///  force SAR normalization to 1:1 by adjusting pos_x/y/w/h (default false)
        /// </summary>
        public LibplaceboFilterGen normalize_sar(bool normalize_sar) => this.SetOption("normalize_sar", normalize_sar.ToFFmpegFlag());
        /// <summary>
        ///  ratio between padding and cropping when normalizing SAR (0=pad, 1=crop) (from 0 to 1) (default 0)
        /// </summary>
        public LibplaceboFilterGen pad_crop_ratio(float pad_crop_ratio) => this.SetOptionRange("pad_crop_ratio", pad_crop_ratio, 0, 1);
        /// <summary>
        ///  Background fill color (default &quot;black&quot;)
        /// </summary>
        public LibplaceboFilterGen fillcolor(String fillcolor) => this.SetOption("fillcolor", fillcolor.ToString());
        /// <summary>
        ///  Corner rounding radius (from 0 to 1) (default 0)
        /// </summary>
        public LibplaceboFilterGen corner_rounding(float corner_rounding) => this.SetOptionRange("corner_rounding", corner_rounding, 0, 1);
        /// <summary>
        ///  Pass extra libplacebo-specific options using a :-separated list of key=value pairs
        /// </summary>
        public LibplaceboFilterGen extra_opts(String extra_opts) => this.SetOption("extra_opts", extra_opts.ToString());
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
        ///  Upscaler function (default &quot;spline36&quot;)
        /// </summary>
        public LibplaceboFilterGen upscaler(String upscaler) => this.SetOption("upscaler", upscaler.ToString());
        /// <summary>
        ///  Downscaler function (default &quot;mitchell&quot;)
        /// </summary>
        public LibplaceboFilterGen downscaler(String downscaler) => this.SetOption("downscaler", downscaler.ToString());
        /// <summary>
        ///  Frame mixing function (default &quot;none&quot;)
        /// </summary>
        public LibplaceboFilterGen frame_mixer(String frame_mixer) => this.SetOption("frame_mixer", frame_mixer.ToString());
        /// <summary>
        ///  Number of scaler LUT entries (from 0 to 256) (default 0)
        /// </summary>
        public LibplaceboFilterGen lut_entries(int lut_entries) => this.SetOptionRange("lut_entries", lut_entries, 0, 256);
        /// <summary>
        ///  Antiringing strength (for non-EWA filters) (from 0 to 1) (default 0)
        /// </summary>
        public LibplaceboFilterGen antiringing(float antiringing) => this.SetOptionRange("antiringing", antiringing, 0, 1);
        /// <summary>
        ///  Enable sigmoid upscaling (default true)
        /// </summary>
        public LibplaceboFilterGen sigmoid(bool sigmoid) => this.SetOption("sigmoid", sigmoid.ToFFmpegFlag());
        /// <summary>
        ///  Apply film grain metadata (default true)
        /// </summary>
        public LibplaceboFilterGen apply_filmgrain(bool apply_filmgrain) => this.SetOption("apply_filmgrain", apply_filmgrain.ToFFmpegFlag());
        /// <summary>
        ///  Apply Dolby Vision metadata (default true)
        /// </summary>
        public LibplaceboFilterGen apply_dolbyvision(bool apply_dolbyvision) => this.SetOption("apply_dolbyvision", apply_dolbyvision.ToFFmpegFlag());
        /// <summary>
        ///  Enable debanding (default false)
        /// </summary>
        public LibplaceboFilterGen deband(bool deband) => this.SetOption("deband", deband.ToFFmpegFlag());
        /// <summary>
        ///  Deband iterations (from 0 to 16) (default 1)
        /// </summary>
        public LibplaceboFilterGen deband_iterations(int deband_iterations) => this.SetOptionRange("deband_iterations", deband_iterations, 0, 16);
        /// <summary>
        ///  Deband threshold (from 0 to 1024) (default 4)
        /// </summary>
        public LibplaceboFilterGen deband_threshold(float deband_threshold) => this.SetOptionRange("deband_threshold", deband_threshold, 0, 1024);
        /// <summary>
        ///  Deband radius (from 0 to 1024) (default 16)
        /// </summary>
        public LibplaceboFilterGen deband_radius(float deband_radius) => this.SetOptionRange("deband_radius", deband_radius, 0, 1024);
        /// <summary>
        ///  Deband grain (from 0 to 1024) (default 6)
        /// </summary>
        public LibplaceboFilterGen deband_grain(float deband_grain) => this.SetOptionRange("deband_grain", deband_grain, 0, 1024);
        /// <summary>
        ///  Brightness boost (from -1 to 1) (default 0)
        /// </summary>
        public LibplaceboFilterGen brightness(float brightness) => this.SetOptionRange("brightness", brightness, -1, 1);
        /// <summary>
        ///  Contrast gain (from 0 to 16) (default 1)
        /// </summary>
        public LibplaceboFilterGen contrast(float contrast) => this.SetOptionRange("contrast", contrast, 0, 16);
        /// <summary>
        ///  Saturation gain (from 0 to 16) (default 1)
        /// </summary>
        public LibplaceboFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation, 0, 16);
        /// <summary>
        ///  Hue shift (from -3.14159 to 3.14159) (default 0)
        /// </summary>
        public LibplaceboFilterGen hue(float hue) => this.SetOptionRange("hue", hue, -3.14159, 3.14159);
        /// <summary>
        ///  Gamma adjustment (from 0 to 16) (default 1)
        /// </summary>
        public LibplaceboFilterGen gamma(float gamma) => this.SetOptionRange("gamma", gamma, 0, 16);
        /// <summary>
        ///  Enable dynamic peak detection for HDR tone-mapping (default true)
        /// </summary>
        public LibplaceboFilterGen peak_detect(bool peak_detect) => this.SetOption("peak_detect", peak_detect.ToFFmpegFlag());
        /// <summary>
        ///  Peak detection smoothing period (from 0 to 1000) (default 100)
        /// </summary>
        public LibplaceboFilterGen smoothing_period(float smoothing_period) => this.SetOptionRange("smoothing_period", smoothing_period, 0, 1000);
        /// <summary>
        ///  Peak detection minimum peak (from 0 to 100) (default 1)
        /// </summary>
        public LibplaceboFilterGen minimum_peak(float minimum_peak) => this.SetOptionRange("minimum_peak", minimum_peak, 0, 100);
        /// <summary>
        ///  Scene change low threshold (from -1 to 100) (default 5.5)
        /// </summary>
        public LibplaceboFilterGen scene_threshold_low(float scene_threshold_low) => this.SetOptionRange("scene_threshold_low", scene_threshold_low, -1, 100);
        /// <summary>
        ///  Scene change high threshold (from -1 to 100) (default 10)
        /// </summary>
        public LibplaceboFilterGen scene_threshold_high(float scene_threshold_high) => this.SetOptionRange("scene_threshold_high", scene_threshold_high, -1, 100);
        /// <summary>
        ///  Peak detection percentile (from 0 to 100) (default 99.995)
        /// </summary>
        public LibplaceboFilterGen percentile(float percentile) => this.SetOptionRange("percentile", percentile, 0, 100);
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
        public LibplaceboFilterGen tonemapping_param(float tonemapping_param) => this.SetOptionRange("tonemapping_param", tonemapping_param, 0, 100);
        /// <summary>
        ///  Inverse tone mapping (range expansion) (default false)
        /// </summary>
        public LibplaceboFilterGen inverse_tonemapping(bool inverse_tonemapping) => this.SetOption("inverse_tonemapping", inverse_tonemapping.ToFFmpegFlag());
        /// <summary>
        ///  Tone-mapping LUT size (from 2 to 1024) (default 256)
        /// </summary>
        public LibplaceboFilterGen tonemapping_lut_size(int tonemapping_lut_size) => this.SetOptionRange("tonemapping_lut_size", tonemapping_lut_size, 2, 1024);
        /// <summary>
        ///  HDR contrast recovery strength (from 0 to 3) (default 0.3)
        /// </summary>
        public LibplaceboFilterGen contrast_recovery(float contrast_recovery) => this.SetOptionRange("contrast_recovery", contrast_recovery, 0, 3);
        /// <summary>
        ///  HDR contrast recovery smoothness (from 1 to 32) (default 3.5)
        /// </summary>
        public LibplaceboFilterGen contrast_smoothness(float contrast_smoothness) => this.SetOptionRange("contrast_smoothness", contrast_smoothness, 1, 32);
        /// <summary>
        ///  Dither method to use (from -1 to 3) (default blue)
        /// </summary>
        public LibplaceboFilterGen dithering(LibplaceboFilterGenDithering dithering) => this.SetOption("dithering", dithering.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Dithering LUT size (from 1 to 8) (default 6)
        /// </summary>
        public LibplaceboFilterGen dither_lut_size(int dither_lut_size) => this.SetOptionRange("dither_lut_size", dither_lut_size, 1, 8);
        /// <summary>
        ///  Enable temporal dithering (default false)
        /// </summary>
        public LibplaceboFilterGen dither_temporal(bool dither_temporal) => this.SetOption("dither_temporal", dither_temporal.ToFFmpegFlag());
        /// <summary>
        ///  Colorblindness adaptation model (default 0)
        /// </summary>
        public LibplaceboFilterGen cones(LibplaceboFilterGenCones cones) => this.SetOption("cones", cones.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Colorblindness adaptation strength (from 0 to 10) (default 0)
        /// </summary>
        public LibplaceboFilterGen cone_strength(float cone_strength) => this.SetOptionRange("cone-strength", cone_strength, 0, 10);
        /// <summary>
        ///  Path to custom user shader (mpv .hook format)
        /// </summary>
        public LibplaceboFilterGen custom_shader_path(String custom_shader_path) => this.SetOption("custom_shader_path", custom_shader_path.ToString());
        /// <summary>
        ///  Custom user shader as binary (mpv .hook format)
        /// </summary>
        public LibplaceboFilterGen custom_shader_bin(String custom_shader_bin) => this.SetOption("custom_shader_bin", custom_shader_bin.ToString());
        /// <summary>
        ///  Skip anti-aliasing (default false)
        /// </summary>
        public LibplaceboFilterGen skip_aa(bool skip_aa) => this.SetOption("skip_aa", skip_aa.ToFFmpegFlag());
        /// <summary>
        ///  Polar LUT cutoff (from 0 to 1) (default 0)
        /// </summary>
        public LibplaceboFilterGen polar_cutoff(float polar_cutoff) => this.SetOptionRange("polar_cutoff", polar_cutoff, 0, 1);
        /// <summary>
        ///  Disable linear scaling (default false)
        /// </summary>
        public LibplaceboFilterGen disable_linear(bool disable_linear) => this.SetOption("disable_linear", disable_linear.ToFFmpegFlag());
        /// <summary>
        ///  Disable built-in scalers (default false)
        /// </summary>
        public LibplaceboFilterGen disable_builtin(bool disable_builtin) => this.SetOption("disable_builtin", disable_builtin.ToFFmpegFlag());
        /// <summary>
        ///  Force dithering (default false)
        /// </summary>
        public LibplaceboFilterGen force_dither(bool force_dither) => this.SetOption("force_dither", force_dither.ToFFmpegFlag());
        /// <summary>
        ///  Force-disable FBOs (default false)
        /// </summary>
        public LibplaceboFilterGen disable_fbos(bool disable_fbos) => this.SetOption("disable_fbos", disable_fbos.ToFFmpegFlag());
    }

    /// <summary>
    ///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
    /// </summary>
    public enum LibplaceboFilterGenForce_original_aspect_ratio
    {
        /// <summary>
        /// disable         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("disable")]
        disable = 0,
        /// <summary>
        /// decrease        1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("decrease")]
        decrease = 1,
        /// <summary>
        /// increase        2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("increase")]
        increase = 2
    }

    /// <summary>
    ///  select colorspace (from -1 to 14) (default auto)
    /// </summary>
    public enum LibplaceboFilterGenColorspace
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same colorspace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// gbr             0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gbr")]
        gbr = 0,
        /// <summary>
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
        /// <summary>
        /// unknown         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 2,
        /// <summary>
        /// bt470bg         5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 5,
        /// <summary>
        /// smpte170m       6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 6,
        /// <summary>
        /// smpte240m       7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 7,
        /// <summary>
        /// ycgco           8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ycgco")]
        ycgco = 8,
        /// <summary>
        /// bt2020nc        9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020nc")]
        bt2020nc = 9,
        /// <summary>
        /// bt2020c         10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020c")]
        bt2020c = 10,
        /// <summary>
        /// ictcp           14           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ictcp")]
        ictcp = 14
    }

    /// <summary>
    ///  select color range (from -1 to 2) (default auto)
    /// </summary>
    public enum LibplaceboFilterGenRange
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same color range
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// unspecified     0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 0,
        /// <summary>
        /// unknown         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 0,
        /// <summary>
        /// limited         1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("limited")]
        limited = 1,
        /// <summary>
        /// tv              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tv")]
        tv = 1,
        /// <summary>
        /// mpeg            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mpeg")]
        mpeg = 1,
        /// <summary>
        /// full            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 2,
        /// <summary>
        /// pc              2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 2,
        /// <summary>
        /// jpeg            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jpeg")]
        jpeg = 2
    }

    /// <summary>
    ///  select color primaries (from -1 to 22) (default auto)
    /// </summary>
    public enum LibplaceboFilterGenColor_primaries
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same color primaries
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
        /// <summary>
        /// unknown         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 2,
        /// <summary>
        /// bt470m          4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470m")]
        bt470m = 4,
        /// <summary>
        /// bt470bg         5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 5,
        /// <summary>
        /// smpte170m       6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 6,
        /// <summary>
        /// smpte240m       7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 7,
        /// <summary>
        /// film            8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("film")]
        film = 8,
        /// <summary>
        /// bt2020          9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020")]
        bt2020 = 9,
        /// <summary>
        /// smpte428        10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte428")]
        smpte428 = 10,
        /// <summary>
        /// smpte431        11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte431")]
        smpte431 = 11,
        /// <summary>
        /// smpte432        12           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte432")]
        smpte432 = 12,
        /// <summary>
        /// jedec-p22       22           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jedec-p22")]
        jedec_p22 = 22,
        /// <summary>
        /// ebu3213         22           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ebu3213")]
        ebu3213 = 22
    }

    /// <summary>
    ///  select color transfer (from -1 to 18) (default auto)
    /// </summary>
    public enum LibplaceboFilterGenColor_trc
    {
        /// <summary>
        /// auto            -1           ..FV....... keep the same color transfer
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// bt709           1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
        /// <summary>
        /// unknown         2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unknown")]
        unknown = 2,
        /// <summary>
        /// bt470m          4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470m")]
        bt470m = 4,
        /// <summary>
        /// bt470bg         5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 5,
        /// <summary>
        /// smpte170m       6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 6,
        /// <summary>
        /// smpte240m       7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 7,
        /// <summary>
        /// linear          8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 8,
        /// <summary>
        /// iec61966-2-4    11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-4")]
        iec61966_2_4 = 11,
        /// <summary>
        /// bt1361e         12           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt1361e")]
        bt1361e = 12,
        /// <summary>
        /// iec61966-2-1    13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("iec61966-2-1")]
        iec61966_2_1 = 13,
        /// <summary>
        /// bt2020-10       14           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020-10")]
        bt2020_10 = 14,
        /// <summary>
        /// bt2020-12       15           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020-12")]
        bt2020_12 = 15,
        /// <summary>
        /// smpte2084       16           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte2084")]
        smpte2084 = 16,
        /// <summary>
        /// arib-std-b67    18           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arib-std-b67")]
        arib_std_b67 = 18
    }

    /// <summary>
    ///  Gamut-mapping mode (from 0 to 8) (default perceptual)
    /// </summary>
    public enum LibplaceboFilterGenGamut_mode
    {
        /// <summary>
        /// clip            0            ..FV....... Hard-clip (RGB per-channel)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("clip")]
        clip = 0,
        /// <summary>
        /// perceptual      1            ..FV....... Colorimetric soft clipping
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("perceptual")]
        perceptual = 1,
        /// <summary>
        /// relative        2            ..FV....... Relative colorimetric clipping
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("relative")]
        relative = 2,
        /// <summary>
        /// saturation      3            ..FV....... Saturation mapping (RGB -&gt; RGB)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("saturation")]
        saturation = 3,
        /// <summary>
        /// absolute        4            ..FV....... Absolute colorimetric clipping
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("absolute")]
        absolute = 4,
        /// <summary>
        /// desaturate      5            ..FV....... Colorimetrically desaturate colors towards white
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("desaturate")]
        desaturate = 5,
        /// <summary>
        /// darken          6            ..FV....... Colorimetric clip with bias towards darkening image to fit gamut
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("darken")]
        darken = 6,
        /// <summary>
        /// warn            7            ..FV....... Highlight out-of-gamut colors
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("warn")]
        warn = 7,
        /// <summary>
        /// linear          8            ..FV....... Linearly reduce chromaticity to fit gamut
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 8
    }

    /// <summary>
    ///  Tone-mapping algorithm (from 0 to 11) (default auto)
    /// </summary>
    public enum LibplaceboFilterGenTonemapping
    {
        /// <summary>
        /// auto            0            ..FV....... Automatic selection
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = 0,
        /// <summary>
        /// clip            1            ..FV....... No tone mapping (clip
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("clip")]
        clip = 1,
        /// <summary>
        /// st2094-40       2            ..FV....... SMPTE ST 2094-40
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("st2094-40")]
        st2094_40 = 2,
        /// <summary>
        /// st2094-10       3            ..FV....... SMPTE ST 2094-10
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("st2094-10")]
        st2094_10 = 3,
        /// <summary>
        /// bt.2390         4            ..FV....... ITU-R BT.2390 EETF
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt.2390")]
        btDot2390 = 4,
        /// <summary>
        /// bt.2446a        5            ..FV....... ITU-R BT.2446 Method A
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt.2446a")]
        btDot2446a = 5,
        /// <summary>
        /// spline          6            ..FV....... Single-pivot polynomial spline
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("spline")]
        spline = 6,
        /// <summary>
        /// reinhard        7            ..FV....... Reinhard
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("reinhard")]
        reinhard = 7,
        /// <summary>
        /// mobius          8            ..FV....... Mobius
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mobius")]
        mobius = 8,
        /// <summary>
        /// hable           9            ..FV....... Filmic tone-mapping (Hable)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hable")]
        hable = 9,
        /// <summary>
        /// gamma           10           ..FV....... Gamma function with knee
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gamma")]
        gamma = 10,
        /// <summary>
        /// linear          11           ..FV....... Perceptually linear stretch
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 11
    }

    /// <summary>
    ///  Dither method to use (from -1 to 3) (default blue)
    /// </summary>
    public enum LibplaceboFilterGenDithering
    {
        /// <summary>
        /// none            -1           ..FV....... Disable dithering
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = -1,
        /// <summary>
        /// blue            0            ..FV....... Blue noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blue")]
        blue = 0,
        /// <summary>
        /// ordered         1            ..FV....... Ordered LUT
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ordered")]
        ordered = 1,
        /// <summary>
        /// ordered_fixed   2            ..FV....... Fixed function ordered
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ordered_fixed")]
        ordered_fixed = 2,
        /// <summary>
        /// white           3            ..FV....... White noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("white")]
        white = 3
    }

    /// <summary>
    ///  Colorblindness adaptation model (default 0)
    /// </summary>
    public enum LibplaceboFilterGenCones
    {
        /// <summary>
        /// l                            ..FV....... L cone
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("l")]
        l,
        /// <summary>
        /// m                            ..FV....... M cone
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("m")]
        m,
        /// <summary>
        /// s                            ..FV....... S cone
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply various GPU filters from libplacebo
        /// </summary>
        public static LibplaceboFilterGen LibplaceboFilterGen(this ImageMap input) => new LibplaceboFilterGen(input);
    }
}