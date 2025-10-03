namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... flanger           A-&gt;A       Apply a flanging effect to the audio.
    /// </summary>
    public class FlangerFilterGen : AudioToAudioFilter
    {
        internal FlangerFilterGen(AudioMap input) : base("flanger", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  base delay in milliseconds (from 0 to 30) (default 0)
        /// </summary>
        public FlangerFilterGen delay(double delay) => this.SetOptionRange("delay", delay, 0, 30);
        /// <summary>
        ///  added swept delay in milliseconds (from 0 to 10) (default 2)
        /// </summary>
        public FlangerFilterGen depth(double depth) => this.SetOptionRange("depth", depth, 0, 10);
        /// <summary>
        ///  percentage regeneration (delayed signal feedback) (from -95 to 95) (default 0)
        /// </summary>
        public FlangerFilterGen regen(double regen) => this.SetOptionRange("regen", regen, -95, 95);
        /// <summary>
        ///  percentage of delayed signal mixed with original (from 0 to 100) (default 71)
        /// </summary>
        public FlangerFilterGen width(double width) => this.SetOptionRange("width", width, 0, 100);
        /// <summary>
        ///  sweeps per second (Hz) (from 0.1 to 10) (default 0.5)
        /// </summary>
        public FlangerFilterGen speed(double speed) => this.SetOptionRange("speed", speed, 0.1, 10);
        /// <summary>
        ///  swept wave shape (from 0 to 1) (default sinusoidal)
        /// </summary>
        public FlangerFilterGen shape(FlangerFilterGenShape shape) => this.SetOption("shape", shape.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  swept wave percentage phase-shift for multi-channel (from 0 to 100) (default 25)
        /// </summary>
        public FlangerFilterGen phase(double phase) => this.SetOptionRange("phase", phase, 0, 100);
        /// <summary>
        ///  delay-line interpolation (from 0 to 1) (default linear)
        /// </summary>
        public FlangerFilterGen interp(FlangerFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  swept wave shape (from 0 to 1) (default sinusoidal)
    /// </summary>
    public enum FlangerFilterGenShape
    {
        /// <summary>
        /// triangular      1            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("triangular")]
        triangular = 1,
        /// <summary>
        /// t               1            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("t")]
        t = 1,
        /// <summary>
        /// sinusoidal      0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sinusoidal")]
        sinusoidal = 0,
        /// <summary>
        /// s               0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s = 0
    }

    /// <summary>
    ///  delay-line interpolation (from 0 to 1) (default linear)
    /// </summary>
    public enum FlangerFilterGenInterp
    {
        /// <summary>
        /// linear          0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 0,
        /// <summary>
        /// quadratic       1            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quadratic")]
        quadratic = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply a flanging effect to the audio.
        /// </summary>
        public static FlangerFilterGen FlangerFilterGen(this AudioMap input0) => new FlangerFilterGen(input0);
    }
}