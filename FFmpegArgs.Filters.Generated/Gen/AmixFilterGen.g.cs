namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ..C amix              N-&gt;A       Audio mixing.
    /// </summary>
    public class AmixFilterGen : AudioToAudioFilter, ICommandSupport
    {
        internal AmixFilterGen(params AudioMap[] inputs) : base("amix", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Number of inputs. (from 1 to 32767) (default 2)
        /// </summary>
        public AmixFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 1, 32767);
        /// <summary>
        ///  How to determine the end-of-stream. (from 0 to 2) (default longest)
        /// </summary>
        public AmixFilterGen duration(AmixFilterGenDuration duration) => this.SetOption("duration", duration.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Transition time, in seconds, for volume renormalization when an input stream ends. (from 0 to INT_MAX) (default 2)
        /// </summary>
        public AmixFilterGen dropout_transition(float dropout_transition) => this.SetOptionRange("dropout_transition", dropout_transition, 0, INT_MAX);
        /// <summary>
        ///  Set weight for each input. (default &quot;1 1&quot;)
        /// </summary>
        public AmixFilterGen weights(String weights) => this.SetOption("weights", weights.ToString());
        /// <summary>
        ///  Scale inputs (default true)
        /// </summary>
        public AmixFilterGen normalize(bool normalize) => this.SetOption("normalize", normalize.ToFFmpegFlag());
    }

    /// <summary>
    ///  How to determine the end-of-stream. (from 0 to 2) (default longest)
    /// </summary>
    public enum AmixFilterGenDuration
    {
        /// <summary>
        /// longest         0            ..F.A...... Duration of longest input.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("longest")]
        longest = 0,
        /// <summary>
        /// shortest        1            ..F.A...... Duration of shortest input.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("shortest")]
        shortest = 1,
        /// <summary>
        /// first           2            ..F.A...... Duration of first input.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("first")]
        first = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Audio mixing.
        /// </summary>
        public static AmixFilterGen AmixFilterGen(this AudioMap input) => new AmixFilterGen(input);
    }
}