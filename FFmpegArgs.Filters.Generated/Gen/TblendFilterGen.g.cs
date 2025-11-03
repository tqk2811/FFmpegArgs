namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS tblend            V-&gt;V       Blend successive frames.
    /// </summary>
    public class TblendFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal TblendFilterGen(ImageMap input) : base("tblend", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set component #0 blend mode (from 0 to 39) (default normal)
        /// </summary>
        public TblendFilterGen c0_mode(TblendFilterGenC0_mode c0_mode) => this.SetOption("c0_mode", c0_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set component #1 blend mode (from 0 to 39) (default normal)
        /// </summary>
        public TblendFilterGen c1_mode(TblendFilterGenC1_mode c1_mode) => this.SetOption("c1_mode", c1_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set component #2 blend mode (from 0 to 39) (default normal)
        /// </summary>
        public TblendFilterGen c2_mode(TblendFilterGenC2_mode c2_mode) => this.SetOption("c2_mode", c2_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set component #3 blend mode (from 0 to 39) (default normal)
        /// </summary>
        public TblendFilterGen c3_mode(TblendFilterGenC3_mode c3_mode) => this.SetOption("c3_mode", c3_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set blend mode for all components (from -1 to 39) (default -1)
        /// </summary>
        public TblendFilterGen all_mode(TblendFilterGenAll_mode all_mode) => this.SetOption("all_mode", all_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set color component #0 expression
        /// </summary>
        public TblendFilterGen c0_expr(ExpressionValue c0_expr) => this.SetOption("c0_expr", (string)c0_expr);
        /// <summary>
        ///  set color component #1 expression
        /// </summary>
        public TblendFilterGen c1_expr(ExpressionValue c1_expr) => this.SetOption("c1_expr", (string)c1_expr);
        /// <summary>
        ///  set color component #2 expression
        /// </summary>
        public TblendFilterGen c2_expr(ExpressionValue c2_expr) => this.SetOption("c2_expr", (string)c2_expr);
        /// <summary>
        ///  set color component #3 expression
        /// </summary>
        public TblendFilterGen c3_expr(ExpressionValue c3_expr) => this.SetOption("c3_expr", (string)c3_expr);
        /// <summary>
        ///  set expression for all color components
        /// </summary>
        public TblendFilterGen all_expr(ExpressionValue all_expr) => this.SetOption("all_expr", (string)all_expr);
        /// <summary>
        ///  set color component #0 opacity (from 0 to 1) (default 1)
        /// </summary>
        public TblendFilterGen c0_opacity(double c0_opacity) => this.SetOptionRange("c0_opacity", c0_opacity, 0, 1);
        /// <summary>
        ///  set color component #1 opacity (from 0 to 1) (default 1)
        /// </summary>
        public TblendFilterGen c1_opacity(double c1_opacity) => this.SetOptionRange("c1_opacity", c1_opacity, 0, 1);
        /// <summary>
        ///  set color component #2 opacity (from 0 to 1) (default 1)
        /// </summary>
        public TblendFilterGen c2_opacity(double c2_opacity) => this.SetOptionRange("c2_opacity", c2_opacity, 0, 1);
        /// <summary>
        ///  set color component #3 opacity (from 0 to 1) (default 1)
        /// </summary>
        public TblendFilterGen c3_opacity(double c3_opacity) => this.SetOptionRange("c3_opacity", c3_opacity, 0, 1);
        /// <summary>
        ///  set opacity for all color components (from 0 to 1) (default 1)
        /// </summary>
        public TblendFilterGen all_opacity(double all_opacity) => this.SetOptionRange("all_opacity", all_opacity, 0, 1);
    }

    /// <summary>
    ///  set component #0 blend mode (from 0 to 39) (default normal)
    /// </summary>
    public enum TblendFilterGenC0_mode
    {
        /// <summary>
        /// addition        1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("addition")]
        addition = 1,
        /// <summary>
        /// addition128     28           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("addition128")]
        addition128 = 28,
        /// <summary>
        /// grainmerge      28           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grainmerge")]
        grainmerge = 28,
        /// <summary>
        /// and             2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("and")]
        and = 2,
        /// <summary>
        /// average         3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("average")]
        average = 3,
        /// <summary>
        /// burn            4            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("burn")]
        burn = 4,
        /// <summary>
        /// darken          5            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("darken")]
        darken = 5,
        /// <summary>
        /// difference      6            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("difference")]
        difference = 6,
        /// <summary>
        /// difference128   7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("difference128")]
        difference128 = 7,
        /// <summary>
        /// grainextract    7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grainextract")]
        grainextract = 7,
        /// <summary>
        /// divide          8            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("divide")]
        divide = 8,
        /// <summary>
        /// dodge           9            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dodge")]
        dodge = 9,
        /// <summary>
        /// exclusion       10           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exclusion")]
        exclusion = 10,
        /// <summary>
        /// extremity       32           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("extremity")]
        extremity = 32,
        /// <summary>
        /// freeze          31           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("freeze")]
        freeze = 31,
        /// <summary>
        /// glow            27           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("glow")]
        glow = 27,
        /// <summary>
        /// hardlight       11           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardlight")]
        hardlight = 11,
        /// <summary>
        /// hardmix         25           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardmix")]
        hardmix = 25,
        /// <summary>
        /// heat            30           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("heat")]
        heat = 30,
        /// <summary>
        /// lighten         12           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lighten")]
        lighten = 12,
        /// <summary>
        /// linearlight     26           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linearlight")]
        linearlight = 26,
        /// <summary>
        /// multiply        13           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply")]
        multiply = 13,
        /// <summary>
        /// multiply128     29           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply128")]
        multiply128 = 29,
        /// <summary>
        /// negation        14           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("negation")]
        negation = 14,
        /// <summary>
        /// normal          0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// or              15           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("or")]
        or = 15,
        /// <summary>
        /// overlay         16           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("overlay")]
        overlay = 16,
        /// <summary>
        /// phoenix         17           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("phoenix")]
        phoenix = 17,
        /// <summary>
        /// pinlight        18           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pinlight")]
        pinlight = 18,
        /// <summary>
        /// reflect         19           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("reflect")]
        reflect = 19,
        /// <summary>
        /// screen          20           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("screen")]
        screen = 20,
        /// <summary>
        /// softlight       21           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("softlight")]
        softlight = 21,
        /// <summary>
        /// subtract        22           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("subtract")]
        subtract = 22,
        /// <summary>
        /// vividlight      23           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vividlight")]
        vividlight = 23,
        /// <summary>
        /// xor             24           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xor")]
        xor = 24,
        /// <summary>
        /// softdifference  33           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("softdifference")]
        softdifference = 33,
        /// <summary>
        /// geometric       34           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("geometric")]
        geometric = 34,
        /// <summary>
        /// harmonic        35           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("harmonic")]
        harmonic = 35,
        /// <summary>
        /// bleach          36           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bleach")]
        bleach = 36,
        /// <summary>
        /// stain           37           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stain")]
        stain = 37,
        /// <summary>
        /// interpolate     38           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("interpolate")]
        interpolate = 38,
        /// <summary>
        /// hardoverlay     39           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardoverlay")]
        hardoverlay = 39
    }

    /// <summary>
    ///  set component #1 blend mode (from 0 to 39) (default normal)
    /// </summary>
    public enum TblendFilterGenC1_mode
    {
        /// <summary>
        /// addition        1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("addition")]
        addition = 1,
        /// <summary>
        /// addition128     28           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("addition128")]
        addition128 = 28,
        /// <summary>
        /// grainmerge      28           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grainmerge")]
        grainmerge = 28,
        /// <summary>
        /// and             2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("and")]
        and = 2,
        /// <summary>
        /// average         3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("average")]
        average = 3,
        /// <summary>
        /// burn            4            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("burn")]
        burn = 4,
        /// <summary>
        /// darken          5            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("darken")]
        darken = 5,
        /// <summary>
        /// difference      6            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("difference")]
        difference = 6,
        /// <summary>
        /// difference128   7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("difference128")]
        difference128 = 7,
        /// <summary>
        /// grainextract    7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grainextract")]
        grainextract = 7,
        /// <summary>
        /// divide          8            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("divide")]
        divide = 8,
        /// <summary>
        /// dodge           9            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dodge")]
        dodge = 9,
        /// <summary>
        /// exclusion       10           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exclusion")]
        exclusion = 10,
        /// <summary>
        /// extremity       32           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("extremity")]
        extremity = 32,
        /// <summary>
        /// freeze          31           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("freeze")]
        freeze = 31,
        /// <summary>
        /// glow            27           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("glow")]
        glow = 27,
        /// <summary>
        /// hardlight       11           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardlight")]
        hardlight = 11,
        /// <summary>
        /// hardmix         25           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardmix")]
        hardmix = 25,
        /// <summary>
        /// heat            30           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("heat")]
        heat = 30,
        /// <summary>
        /// lighten         12           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lighten")]
        lighten = 12,
        /// <summary>
        /// linearlight     26           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linearlight")]
        linearlight = 26,
        /// <summary>
        /// multiply        13           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply")]
        multiply = 13,
        /// <summary>
        /// multiply128     29           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply128")]
        multiply128 = 29,
        /// <summary>
        /// negation        14           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("negation")]
        negation = 14,
        /// <summary>
        /// normal          0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// or              15           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("or")]
        or = 15,
        /// <summary>
        /// overlay         16           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("overlay")]
        overlay = 16,
        /// <summary>
        /// phoenix         17           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("phoenix")]
        phoenix = 17,
        /// <summary>
        /// pinlight        18           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pinlight")]
        pinlight = 18,
        /// <summary>
        /// reflect         19           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("reflect")]
        reflect = 19,
        /// <summary>
        /// screen          20           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("screen")]
        screen = 20,
        /// <summary>
        /// softlight       21           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("softlight")]
        softlight = 21,
        /// <summary>
        /// subtract        22           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("subtract")]
        subtract = 22,
        /// <summary>
        /// vividlight      23           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vividlight")]
        vividlight = 23,
        /// <summary>
        /// xor             24           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xor")]
        xor = 24,
        /// <summary>
        /// softdifference  33           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("softdifference")]
        softdifference = 33,
        /// <summary>
        /// geometric       34           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("geometric")]
        geometric = 34,
        /// <summary>
        /// harmonic        35           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("harmonic")]
        harmonic = 35,
        /// <summary>
        /// bleach          36           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bleach")]
        bleach = 36,
        /// <summary>
        /// stain           37           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stain")]
        stain = 37,
        /// <summary>
        /// interpolate     38           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("interpolate")]
        interpolate = 38,
        /// <summary>
        /// hardoverlay     39           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardoverlay")]
        hardoverlay = 39
    }

    /// <summary>
    ///  set component #2 blend mode (from 0 to 39) (default normal)
    /// </summary>
    public enum TblendFilterGenC2_mode
    {
        /// <summary>
        /// addition        1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("addition")]
        addition = 1,
        /// <summary>
        /// addition128     28           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("addition128")]
        addition128 = 28,
        /// <summary>
        /// grainmerge      28           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grainmerge")]
        grainmerge = 28,
        /// <summary>
        /// and             2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("and")]
        and = 2,
        /// <summary>
        /// average         3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("average")]
        average = 3,
        /// <summary>
        /// burn            4            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("burn")]
        burn = 4,
        /// <summary>
        /// darken          5            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("darken")]
        darken = 5,
        /// <summary>
        /// difference      6            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("difference")]
        difference = 6,
        /// <summary>
        /// difference128   7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("difference128")]
        difference128 = 7,
        /// <summary>
        /// grainextract    7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grainextract")]
        grainextract = 7,
        /// <summary>
        /// divide          8            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("divide")]
        divide = 8,
        /// <summary>
        /// dodge           9            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dodge")]
        dodge = 9,
        /// <summary>
        /// exclusion       10           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exclusion")]
        exclusion = 10,
        /// <summary>
        /// extremity       32           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("extremity")]
        extremity = 32,
        /// <summary>
        /// freeze          31           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("freeze")]
        freeze = 31,
        /// <summary>
        /// glow            27           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("glow")]
        glow = 27,
        /// <summary>
        /// hardlight       11           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardlight")]
        hardlight = 11,
        /// <summary>
        /// hardmix         25           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardmix")]
        hardmix = 25,
        /// <summary>
        /// heat            30           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("heat")]
        heat = 30,
        /// <summary>
        /// lighten         12           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lighten")]
        lighten = 12,
        /// <summary>
        /// linearlight     26           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linearlight")]
        linearlight = 26,
        /// <summary>
        /// multiply        13           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply")]
        multiply = 13,
        /// <summary>
        /// multiply128     29           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply128")]
        multiply128 = 29,
        /// <summary>
        /// negation        14           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("negation")]
        negation = 14,
        /// <summary>
        /// normal          0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// or              15           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("or")]
        or = 15,
        /// <summary>
        /// overlay         16           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("overlay")]
        overlay = 16,
        /// <summary>
        /// phoenix         17           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("phoenix")]
        phoenix = 17,
        /// <summary>
        /// pinlight        18           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pinlight")]
        pinlight = 18,
        /// <summary>
        /// reflect         19           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("reflect")]
        reflect = 19,
        /// <summary>
        /// screen          20           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("screen")]
        screen = 20,
        /// <summary>
        /// softlight       21           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("softlight")]
        softlight = 21,
        /// <summary>
        /// subtract        22           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("subtract")]
        subtract = 22,
        /// <summary>
        /// vividlight      23           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vividlight")]
        vividlight = 23,
        /// <summary>
        /// xor             24           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xor")]
        xor = 24,
        /// <summary>
        /// softdifference  33           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("softdifference")]
        softdifference = 33,
        /// <summary>
        /// geometric       34           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("geometric")]
        geometric = 34,
        /// <summary>
        /// harmonic        35           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("harmonic")]
        harmonic = 35,
        /// <summary>
        /// bleach          36           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bleach")]
        bleach = 36,
        /// <summary>
        /// stain           37           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stain")]
        stain = 37,
        /// <summary>
        /// interpolate     38           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("interpolate")]
        interpolate = 38,
        /// <summary>
        /// hardoverlay     39           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardoverlay")]
        hardoverlay = 39
    }

    /// <summary>
    ///  set component #3 blend mode (from 0 to 39) (default normal)
    /// </summary>
    public enum TblendFilterGenC3_mode
    {
        /// <summary>
        /// addition        1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("addition")]
        addition = 1,
        /// <summary>
        /// addition128     28           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("addition128")]
        addition128 = 28,
        /// <summary>
        /// grainmerge      28           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grainmerge")]
        grainmerge = 28,
        /// <summary>
        /// and             2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("and")]
        and = 2,
        /// <summary>
        /// average         3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("average")]
        average = 3,
        /// <summary>
        /// burn            4            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("burn")]
        burn = 4,
        /// <summary>
        /// darken          5            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("darken")]
        darken = 5,
        /// <summary>
        /// difference      6            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("difference")]
        difference = 6,
        /// <summary>
        /// difference128   7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("difference128")]
        difference128 = 7,
        /// <summary>
        /// grainextract    7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grainextract")]
        grainextract = 7,
        /// <summary>
        /// divide          8            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("divide")]
        divide = 8,
        /// <summary>
        /// dodge           9            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dodge")]
        dodge = 9,
        /// <summary>
        /// exclusion       10           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exclusion")]
        exclusion = 10,
        /// <summary>
        /// extremity       32           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("extremity")]
        extremity = 32,
        /// <summary>
        /// freeze          31           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("freeze")]
        freeze = 31,
        /// <summary>
        /// glow            27           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("glow")]
        glow = 27,
        /// <summary>
        /// hardlight       11           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardlight")]
        hardlight = 11,
        /// <summary>
        /// hardmix         25           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardmix")]
        hardmix = 25,
        /// <summary>
        /// heat            30           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("heat")]
        heat = 30,
        /// <summary>
        /// lighten         12           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lighten")]
        lighten = 12,
        /// <summary>
        /// linearlight     26           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linearlight")]
        linearlight = 26,
        /// <summary>
        /// multiply        13           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply")]
        multiply = 13,
        /// <summary>
        /// multiply128     29           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply128")]
        multiply128 = 29,
        /// <summary>
        /// negation        14           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("negation")]
        negation = 14,
        /// <summary>
        /// normal          0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// or              15           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("or")]
        or = 15,
        /// <summary>
        /// overlay         16           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("overlay")]
        overlay = 16,
        /// <summary>
        /// phoenix         17           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("phoenix")]
        phoenix = 17,
        /// <summary>
        /// pinlight        18           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pinlight")]
        pinlight = 18,
        /// <summary>
        /// reflect         19           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("reflect")]
        reflect = 19,
        /// <summary>
        /// screen          20           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("screen")]
        screen = 20,
        /// <summary>
        /// softlight       21           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("softlight")]
        softlight = 21,
        /// <summary>
        /// subtract        22           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("subtract")]
        subtract = 22,
        /// <summary>
        /// vividlight      23           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vividlight")]
        vividlight = 23,
        /// <summary>
        /// xor             24           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xor")]
        xor = 24,
        /// <summary>
        /// softdifference  33           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("softdifference")]
        softdifference = 33,
        /// <summary>
        /// geometric       34           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("geometric")]
        geometric = 34,
        /// <summary>
        /// harmonic        35           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("harmonic")]
        harmonic = 35,
        /// <summary>
        /// bleach          36           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bleach")]
        bleach = 36,
        /// <summary>
        /// stain           37           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stain")]
        stain = 37,
        /// <summary>
        /// interpolate     38           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("interpolate")]
        interpolate = 38,
        /// <summary>
        /// hardoverlay     39           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardoverlay")]
        hardoverlay = 39
    }

    /// <summary>
    ///  set blend mode for all components (from -1 to 39) (default -1)
    /// </summary>
    public enum TblendFilterGenAll_mode
    {
        /// <summary>
        /// addition        1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("addition")]
        addition = 1,
        /// <summary>
        /// addition128     28           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("addition128")]
        addition128 = 28,
        /// <summary>
        /// grainmerge      28           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grainmerge")]
        grainmerge = 28,
        /// <summary>
        /// and             2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("and")]
        and = 2,
        /// <summary>
        /// average         3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("average")]
        average = 3,
        /// <summary>
        /// burn            4            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("burn")]
        burn = 4,
        /// <summary>
        /// darken          5            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("darken")]
        darken = 5,
        /// <summary>
        /// difference      6            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("difference")]
        difference = 6,
        /// <summary>
        /// difference128   7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("difference128")]
        difference128 = 7,
        /// <summary>
        /// grainextract    7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("grainextract")]
        grainextract = 7,
        /// <summary>
        /// divide          8            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("divide")]
        divide = 8,
        /// <summary>
        /// dodge           9            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dodge")]
        dodge = 9,
        /// <summary>
        /// exclusion       10           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exclusion")]
        exclusion = 10,
        /// <summary>
        /// extremity       32           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("extremity")]
        extremity = 32,
        /// <summary>
        /// freeze          31           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("freeze")]
        freeze = 31,
        /// <summary>
        /// glow            27           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("glow")]
        glow = 27,
        /// <summary>
        /// hardlight       11           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardlight")]
        hardlight = 11,
        /// <summary>
        /// hardmix         25           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardmix")]
        hardmix = 25,
        /// <summary>
        /// heat            30           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("heat")]
        heat = 30,
        /// <summary>
        /// lighten         12           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lighten")]
        lighten = 12,
        /// <summary>
        /// linearlight     26           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linearlight")]
        linearlight = 26,
        /// <summary>
        /// multiply        13           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply")]
        multiply = 13,
        /// <summary>
        /// multiply128     29           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply128")]
        multiply128 = 29,
        /// <summary>
        /// negation        14           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("negation")]
        negation = 14,
        /// <summary>
        /// normal          0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// or              15           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("or")]
        or = 15,
        /// <summary>
        /// overlay         16           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("overlay")]
        overlay = 16,
        /// <summary>
        /// phoenix         17           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("phoenix")]
        phoenix = 17,
        /// <summary>
        /// pinlight        18           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pinlight")]
        pinlight = 18,
        /// <summary>
        /// reflect         19           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("reflect")]
        reflect = 19,
        /// <summary>
        /// screen          20           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("screen")]
        screen = 20,
        /// <summary>
        /// softlight       21           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("softlight")]
        softlight = 21,
        /// <summary>
        /// subtract        22           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("subtract")]
        subtract = 22,
        /// <summary>
        /// vividlight      23           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vividlight")]
        vividlight = 23,
        /// <summary>
        /// xor             24           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xor")]
        xor = 24,
        /// <summary>
        /// softdifference  33           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("softdifference")]
        softdifference = 33,
        /// <summary>
        /// geometric       34           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("geometric")]
        geometric = 34,
        /// <summary>
        /// harmonic        35           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("harmonic")]
        harmonic = 35,
        /// <summary>
        /// bleach          36           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bleach")]
        bleach = 36,
        /// <summary>
        /// stain           37           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stain")]
        stain = 37,
        /// <summary>
        /// interpolate     38           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("interpolate")]
        interpolate = 38,
        /// <summary>
        /// hardoverlay     39           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardoverlay")]
        hardoverlay = 39
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Blend successive frames.
        /// </summary>
        public static TblendFilterGen TblendFilterGen(this ImageMap input0) => new TblendFilterGen(input0);
    }
}