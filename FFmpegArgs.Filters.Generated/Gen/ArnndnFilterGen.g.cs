namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS arnndn            A-&gt;A       Reduce noise from speech using Recurrent Neural Networks.
    /// </summary>
    public class ArnndnFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal ArnndnFilterGen(AudioMap input) : base("arnndn", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set model name
        /// </summary>
        public ArnndnFilterGen model(String model) => this.SetOption("model", model.ToStringInv());
        /// <summary>
        ///  set output vs input mix (from -1 to 1) (default 1)
        /// </summary>
        public ArnndnFilterGen mix(float mix) => this.SetOptionRange("mix", mix, -1, 1);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Reduce noise from speech using Recurrent Neural Networks.
        /// </summary>
        public static ArnndnFilterGen ArnndnFilterGen(this AudioMap input0) => new ArnndnFilterGen(input0);
    }
}