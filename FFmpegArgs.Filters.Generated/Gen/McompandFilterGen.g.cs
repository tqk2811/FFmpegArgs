namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. mcompand          A-&gt;A       Multiband Compress or expand audio dynamic range.
    /// </summary>
    public class McompandFilterGen : AudioToAudioFilter
    {
        internal McompandFilterGen(AudioMap input) : base("mcompand", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set parameters for each band (default &quot;0.005,0.1 6 -47/-40,-34/-34,-17/-33 100 | 0.003,0.05 6 -47/-40,-34/-34,-17/-33 400 | 0.000625,0.0125 6 -47/-40,-34/-34,-15/-33 1600 | 0.0001,0.025 6 -47/-40,-34/-34,-31/-31,-0/-30 6400 | 0,0.025 6 -38/-31,-28/-28,-0/-25 22000&quot;)
        /// </summary>
        public McompandFilterGen args(String args) => this.SetOption("args", args.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Multiband Compress or expand audio dynamic range.
        /// </summary>
        public static McompandFilterGen McompandFilterGen(this AudioMap input0) => new McompandFilterGen(input0);
    }
}