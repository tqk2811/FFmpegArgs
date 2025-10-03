namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... abench            A-&gt;A       Benchmark part of a filtergraph.
    /// </summary>
    public class AbenchFilterGen : AudioToAudioFilter
    {
        internal AbenchFilterGen(AudioMap input) : base("abench", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set action (from 0 to 1) (default start)
        /// </summary>
        public AbenchFilterGen action(AbenchFilterGenAction action) => this.SetOption("action", action.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set action (from 0 to 1) (default start)
    /// </summary>
    public enum AbenchFilterGenAction
    {
        /// <summary>
        /// start           0            ..F.A...... start timer
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("start")]
        start = 0,
        /// <summary>
        /// stop            1            ..F.A...... stop timer
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stop")]
        stop = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Benchmark part of a filtergraph.
        /// </summary>
        public static AbenchFilterGen AbenchFilterGen(this AudioMap input0) => new AbenchFilterGen(input0);
    }
}