namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. compand           A-&gt;A       Compress or expand audio dynamic range.
    /// </summary>
    public class CompandFilterGen : AudioToAudioFilter
    {
        internal CompandFilterGen(AudioMap input) : base("compand", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set time over which increase of volume is determined (default &quot;0&quot;)
        /// </summary>
        public CompandFilterGen attacks(String attacks) => this.SetOption("attacks", attacks.ToString());
        /// <summary>
        ///  set time over which decrease of volume is determined (default &quot;0.8&quot;)
        /// </summary>
        public CompandFilterGen decays(String decays) => this.SetOption("decays", decays.ToString());
        /// <summary>
        ///  set points of transfer function (default &quot;-70/-70|-60/-20|1/0&quot;)
        /// </summary>
        public CompandFilterGen points(String points) => this.SetOption("points", points.ToString());
        /// <summary>
        ///  set soft-knee (from 0.01 to 900) (default 0.01)
        /// </summary>
        public CompandFilterGen soft_knee(double soft_knee) => this.SetOptionRange("soft-knee", soft_knee, 0.01, 900);
        /// <summary>
        ///  set output gain (from -900 to 900) (default 0)
        /// </summary>
        public CompandFilterGen gain(double gain) => this.SetOptionRange("gain", gain, -900, 900);
        /// <summary>
        ///  set initial volume (from -900 to 0) (default 0)
        /// </summary>
        public CompandFilterGen volume(double volume) => this.SetOptionRange("volume", volume, -900, 0);
        /// <summary>
        ///  set delay for samples before sending them to volume adjuster (from 0 to 20) (default 0)
        /// </summary>
        public CompandFilterGen delay(double delay) => this.SetOptionRange("delay", delay, 0, 20);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Compress or expand audio dynamic range.
        /// </summary>
        public static CompandFilterGen CompandFilterGen(this AudioMap input0) => new CompandFilterGen(input0);
    }
}