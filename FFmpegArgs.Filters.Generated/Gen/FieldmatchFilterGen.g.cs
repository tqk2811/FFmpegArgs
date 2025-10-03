namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... fieldmatch        N-&gt;V       Field matching for inverse telecine.
    /// </summary>
    public class FieldmatchFilterGen : ImageToImageFilter
    {
        internal FieldmatchFilterGen(params ImageMap[] inputs) : base("fieldmatch", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  specify the assumed field order (from -1 to 1) (default auto)
        /// </summary>
        public FieldmatchFilterGen order(FieldmatchFilterGenOrder order) => this.SetOption("order", order.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the matching mode or strategy to use (from 0 to 5) (default pc_n)
        /// </summary>
        public FieldmatchFilterGen mode(FieldmatchFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  mark main input as a pre-processed input and activate clean source input stream (default false)
        /// </summary>
        public FieldmatchFilterGen ppsrc(bool ppsrc) => this.SetOption("ppsrc", ppsrc.ToFFmpegFlag());
        /// <summary>
        ///  set the field to match from (from -1 to 1) (default auto)
        /// </summary>
        public FieldmatchFilterGen field(FieldmatchFilterGenField field) => this.SetOption("field", field.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set whether or not chroma is included during the match comparisons (default true)
        /// </summary>
        public FieldmatchFilterGen mchroma(bool mchroma) => this.SetOption("mchroma", mchroma.ToFFmpegFlag());
        /// <summary>
        ///  define an exclusion band which excludes the lines between y0 and y1 from the field matching decision (from 0 to INT_MAX) (default 0)
        /// </summary>
        public FieldmatchFilterGen y0(int y0) => this.SetOptionRange("y0", y0, 0, INT_MAX);
        /// <summary>
        ///  define an exclusion band which excludes the lines between y0 and y1 from the field matching decision (from 0 to INT_MAX) (default 0)
        /// </summary>
        public FieldmatchFilterGen y1(int y1) => this.SetOptionRange("y1", y1, 0, INT_MAX);
        /// <summary>
        ///  set scene change detection threshold (from 0 to 100) (default 12)
        /// </summary>
        public FieldmatchFilterGen scthresh(double scthresh) => this.SetOptionRange("scthresh", scthresh, 0, 100);
        /// <summary>
        ///  set combmatching mode (from 0 to 2) (default sc)
        /// </summary>
        public FieldmatchFilterGen combmatch(FieldmatchFilterGenCombmatch combmatch) => this.SetOption("combmatch", combmatch.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  enable comb debug (from 0 to 2) (default none)
        /// </summary>
        public FieldmatchFilterGen combdbg(FieldmatchFilterGenCombdbg combdbg) => this.SetOption("combdbg", combdbg.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the area combing threshold used for combed frame detection (from -1 to 255) (default 9)
        /// </summary>
        public FieldmatchFilterGen cthresh(int cthresh) => this.SetOptionRange("cthresh", cthresh, -1, 255);
        /// <summary>
        ///  set whether or not chroma is considered in the combed frame decision (default false)
        /// </summary>
        public FieldmatchFilterGen chroma(bool chroma) => this.SetOption("chroma", chroma.ToFFmpegFlag());
        /// <summary>
        ///  set the x-axis size of the window used during combed frame detection (from 4 to 512) (default 16)
        /// </summary>
        public FieldmatchFilterGen blockx(int blockx) => this.SetOptionRange("blockx", blockx, 4, 512);
        /// <summary>
        ///  set the y-axis size of the window used during combed frame detection (from 4 to 512) (default 16)
        /// </summary>
        public FieldmatchFilterGen blocky(int blocky) => this.SetOptionRange("blocky", blocky, 4, 512);
        /// <summary>
        ///  set the number of combed pixels inside any of the blocky by blockx size blocks on the frame for the frame to be detected as combed (from 0 to INT_MAX) (default 80)
        /// </summary>
        public FieldmatchFilterGen combpel(int combpel) => this.SetOptionRange("combpel", combpel, 0, INT_MAX);
    }

    /// <summary>
    ///  specify the assumed field order (from -1 to 1) (default auto)
    /// </summary>
    public enum FieldmatchFilterGenOrder
    {
        /// <summary>
        /// auto            -1           ..FV....... auto detect parity
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// bff             0            ..FV....... assume bottom field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bff")]
        bff = 0,
        /// <summary>
        /// tff             1            ..FV....... assume top field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tff")]
        tff = 1
    }

    /// <summary>
    ///  set the matching mode or strategy to use (from 0 to 5) (default pc_n)
    /// </summary>
    public enum FieldmatchFilterGenMode
    {
        /// <summary>
        /// pc              0            ..FV....... 2-way match (p/c)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc")]
        pc = 0,
        /// <summary>
        /// pc_n            1            ..FV....... 2-way match + 3rd match on combed (p/c + u)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc_n")]
        pc_n = 1,
        /// <summary>
        /// pc_u            2            ..FV....... 2-way match + 3rd match (same order) on combed (p/c + u)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc_u")]
        pc_u = 2,
        /// <summary>
        /// pc_n_ub         3            ..FV....... 2-way match + 3rd match on combed + 4th/5th matches if still combed (p/c + u + u/b)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pc_n_ub")]
        pc_n_ub = 3,
        /// <summary>
        /// pcn             4            ..FV....... 3-way match (p/c/n)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcn")]
        pcn = 4,
        /// <summary>
        /// pcn_ub          5            ..FV....... 3-way match + 4th/5th matches on combed (p/c/n + u/b)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcn_ub")]
        pcn_ub = 5
    }

    /// <summary>
    ///  set the field to match from (from -1 to 1) (default auto)
    /// </summary>
    public enum FieldmatchFilterGenField
    {
        /// <summary>
        /// auto            -1           ..FV....... automatic (same value as &#39;order&#39;)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1,
        /// <summary>
        /// bottom          0            ..FV....... bottom field
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottom")]
        bottom = 0,
        /// <summary>
        /// top             1            ..FV....... top field
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("top")]
        top = 1
    }

    /// <summary>
    ///  set combmatching mode (from 0 to 2) (default sc)
    /// </summary>
    public enum FieldmatchFilterGenCombmatch
    {
        /// <summary>
        /// none            0            ..FV....... disable combmatching
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// sc              1            ..FV....... enable combmatching only on scene change
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sc")]
        sc = 1,
        /// <summary>
        /// full            2            ..FV....... enable combmatching all the time
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 2
    }

    /// <summary>
    ///  enable comb debug (from 0 to 2) (default none)
    /// </summary>
    public enum FieldmatchFilterGenCombdbg
    {
        /// <summary>
        /// none            0            ..FV....... no forced calculation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// pcn             1            ..FV....... calculate p/c/n
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcn")]
        pcn = 1,
        /// <summary>
        /// pcnub           2            ..FV....... calculate p/c/n/u/b
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pcnub")]
        pcnub = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Field matching for inverse telecine.
        /// </summary>
        public static FieldmatchFilterGen FieldmatchFilterGen(this ImageMap input) => new FieldmatchFilterGen(input);
    }
}