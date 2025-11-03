namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS adenorm           A-&gt;A       Remedy denormals by adding extremely low-level noise.
    /// </summary>
    public class AdenormFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AdenormFilterGen(AudioMap input) : base("adenorm", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set level (from -451 to -90) (default -351)
        /// </summary>
        public AdenormFilterGen level(double level) => this.SetOptionRange("level", level, -451, -90);
        /// <summary>
        ///  set type (from 0 to 3) (default dc)
        /// </summary>
        public AdenormFilterGen type(AdenormFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set type (from 0 to 3) (default dc)
    /// </summary>
    public enum AdenormFilterGenType
    {
        /// <summary>
        /// dc              0            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dc")]
        dc = 0,
        /// <summary>
        /// ac              1            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ac")]
        ac = 1,
        /// <summary>
        /// square          2            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("square")]
        square = 2,
        /// <summary>
        /// pulse           3            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pulse")]
        pulse = 3
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Remedy denormals by adding extremely low-level noise.
        /// </summary>
        public static AdenormFilterGen AdenormFilterGen(this AudioMap input0) => new AdenormFilterGen(input0);
    }
}