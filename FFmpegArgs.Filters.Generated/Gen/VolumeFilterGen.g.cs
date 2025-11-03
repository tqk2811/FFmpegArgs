namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. volume            A-&gt;A       Change input volume.
    /// </summary>
    public class VolumeFilterGen : AudioToAudioFilter, ITimelineSupport
    {
        internal VolumeFilterGen(AudioMap input) : base("volume", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set volume adjustment expression (default &quot;1.0&quot;)
        /// </summary>
        public VolumeFilterGen volume(ExpressionValue volume) => this.SetOption("volume", (string)volume);
        /// <summary>
        ///  select mathematical precision (from 0 to 2) (default float)
        /// </summary>
        public VolumeFilterGen precision(VolumeFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify when to evaluate expressions (from 0 to 1) (default once)
        /// </summary>
        public VolumeFilterGen eval(VolumeFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Apply replaygain side data when present (from 0 to 3) (default drop)
        /// </summary>
        public VolumeFilterGen replaygain(VolumeFilterGenReplaygain replaygain) => this.SetOption("replaygain", replaygain.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Apply replaygain pre-amplification (from -15 to 15) (default 0)
        /// </summary>
        public VolumeFilterGen replaygain_preamp(double replaygain_preamp) => this.SetOptionRange("replaygain_preamp", replaygain_preamp, -15, 15);
        /// <summary>
        ///  Apply replaygain clipping prevention (default true)
        /// </summary>
        public VolumeFilterGen replaygain_noclip(bool replaygain_noclip) => this.SetOption("replaygain_noclip", replaygain_noclip.ToFFmpegFlag());
    }

    /// <summary>
    ///  select mathematical precision (from 0 to 2) (default float)
    /// </summary>
    public enum VolumeFilterGenPrecision
    {
        /// <summary>
        /// fixed           0            ..F.A...... select 8-bit fixed-point
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fixed")]
        _fixed = 0,
        /// <summary>
        /// float           1            ..F.A...... select 32-bit floating-point
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("float")]
        _float = 1,
        /// <summary>
        /// double          2            ..F.A...... select 64-bit floating-point
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("double")]
        _double = 2
    }

    /// <summary>
    ///  specify when to evaluate expressions (from 0 to 1) (default once)
    /// </summary>
    public enum VolumeFilterGenEval
    {
        /// <summary>
        /// once            0            ..F.A...... eval volume expression once
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("once")]
        once = 0,
        /// <summary>
        /// frame           1            ..F.A...... eval volume expression per-frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 1
    }

    /// <summary>
    ///  Apply replaygain side data when present (from 0 to 3) (default drop)
    /// </summary>
    public enum VolumeFilterGenReplaygain
    {
        /// <summary>
        /// drop            0            ..F.A...... replaygain side data is dropped
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("drop")]
        drop = 0,
        /// <summary>
        /// ignore          1            ..F.A...... replaygain side data is ignored
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ignore")]
        ignore = 1,
        /// <summary>
        /// track           2            ..F.A...... track gain is preferred
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("track")]
        track = 2,
        /// <summary>
        /// album           3            ..F.A...... album gain is preferred
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("album")]
        album = 3
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Change input volume.
        /// </summary>
        public static VolumeFilterGen VolumeFilterGen(this AudioMap input0) => new VolumeFilterGen(input0);
    }
}