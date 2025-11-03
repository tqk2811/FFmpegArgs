namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS adrc              A-&gt;A       Audio Spectral Dynamic Range Controller.
    /// </summary>
    public class AdrcFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AdrcFilterGen(AudioMap input) : base("adrc", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the transfer expression (default &quot;p&quot;)
        /// </summary>
        public AdrcFilterGen transfer(ExpressionValue transfer) => this.SetOption("transfer", (string)transfer);
        /// <summary>
        ///  set the attack (from 1 to 1000) (default 50)
        /// </summary>
        public AdrcFilterGen attack(double attack) => this.SetOptionRange("attack", attack, 1, 1000);
        /// <summary>
        ///  set the release (from 5 to 2000) (default 100)
        /// </summary>
        public AdrcFilterGen release(double release) => this.SetOptionRange("release", release, 5, 2000);
        /// <summary>
        ///  set channels to filter (default &quot;all&quot;)
        /// </summary>
        public AdrcFilterGen channels(String channels) => this.SetOption("channels", channels.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Audio Spectral Dynamic Range Controller.
        /// </summary>
        public static AdrcFilterGen AdrcFilterGen(this AudioMap input0) => new AdrcFilterGen(input0);
    }
}