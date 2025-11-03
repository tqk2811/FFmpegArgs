namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. asetnsamples      A-&gt;A       Set the number of samples for each output audio frames.
    /// </summary>
    public class AsetnsamplesFilterGen : AudioToAudioFilter, ITimelineSupport
    {
        internal AsetnsamplesFilterGen(AudioMap input) : base("asetnsamples", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the number of per-frame output samples (from 1 to INT_MAX) (default 1024)
        /// </summary>
        public AsetnsamplesFilterGen nb_out_samples(int nb_out_samples) => this.SetOptionRange("nb_out_samples", nb_out_samples, 1, INT_MAX);
        /// <summary>
        ///  pad last frame with zeros (default true)
        /// </summary>
        public AsetnsamplesFilterGen pad(bool pad) => this.SetOption("pad", pad.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Set the number of samples for each output audio frames.
        /// </summary>
        public static AsetnsamplesFilterGen AsetnsamplesFilterGen(this AudioMap input0) => new AsetnsamplesFilterGen(input0);
    }
}