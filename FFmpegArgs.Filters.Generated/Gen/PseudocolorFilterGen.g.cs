namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS pseudocolor       V-&gt;V       Make pseudocolored video frames.
    /// </summary>
    public class PseudocolorFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal PseudocolorFilterGen(ImageMap input) : base("pseudocolor", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set component #0 expression (default &quot;val&quot;)
        /// </summary>
        public PseudocolorFilterGen c0(ExpressionValue c0) => this.SetOption("c0", (string)c0);
        /// <summary>
        ///  set component #1 expression (default &quot;val&quot;)
        /// </summary>
        public PseudocolorFilterGen c1(ExpressionValue c1) => this.SetOption("c1", (string)c1);
        /// <summary>
        ///  set component #2 expression (default &quot;val&quot;)
        /// </summary>
        public PseudocolorFilterGen c2(ExpressionValue c2) => this.SetOption("c2", (string)c2);
        /// <summary>
        ///  set component #3 expression (default &quot;val&quot;)
        /// </summary>
        public PseudocolorFilterGen c3(ExpressionValue c3) => this.SetOption("c3", (string)c3);
        /// <summary>
        ///  set component as base (from 0 to 3) (default 0)
        /// </summary>
        public PseudocolorFilterGen index(int index) => this.SetOptionRange("index", index, 0, 3);
        /// <summary>
        ///  set preset (from -1 to 20) (default none)
        /// </summary>
        public PseudocolorFilterGen preset(PseudocolorFilterGenPreset preset) => this.SetOption("preset", preset.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set pseudocolor opacity (from 0 to 1) (default 1)
        /// </summary>
        public PseudocolorFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity, 0, 1);
    }

    /// <summary>
    ///  set preset (from -1 to 20) (default none)
    /// </summary>
    public enum PseudocolorFilterGenPreset
    {
        /// <summary>
        /// none            -1           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = -1,
        /// <summary>
        /// magma           0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("magma")]
        magma = 0,
        /// <summary>
        /// inferno         1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("inferno")]
        inferno = 1,
        /// <summary>
        /// plasma          2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("plasma")]
        plasma = 2,
        /// <summary>
        /// viridis         3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("viridis")]
        viridis = 3,
        /// <summary>
        /// turbo           4            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("turbo")]
        turbo = 4,
        /// <summary>
        /// cividis         5            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cividis")]
        cividis = 5,
        /// <summary>
        /// range1          6            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("range1")]
        range1 = 6,
        /// <summary>
        /// range2          7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("range2")]
        range2 = 7,
        /// <summary>
        /// shadows         8            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("shadows")]
        shadows = 8,
        /// <summary>
        /// highlights      9            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("highlights")]
        highlights = 9,
        /// <summary>
        /// solar           10           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("solar")]
        solar = 10,
        /// <summary>
        /// nominal         11           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nominal")]
        nominal = 11,
        /// <summary>
        /// preferred       12           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("preferred")]
        preferred = 12,
        /// <summary>
        /// total           13           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("total")]
        total = 13,
        /// <summary>
        /// spectral        14           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("spectral")]
        spectral = 14,
        /// <summary>
        /// cool            15           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cool")]
        cool = 15,
        /// <summary>
        /// heat            16           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("heat")]
        heat = 16,
        /// <summary>
        /// fiery           17           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fiery")]
        fiery = 17,
        /// <summary>
        /// blues           18           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blues")]
        blues = 18,
        /// <summary>
        /// green           19           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("green")]
        green = 19,
        /// <summary>
        /// helix           20           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("helix")]
        helix = 20
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Make pseudocolored video frames.
        /// </summary>
        public static PseudocolorFilterGen PseudocolorFilterGen(this ImageMap input0) => new PseudocolorFilterGen(input0);
    }
}