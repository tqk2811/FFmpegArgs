namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. aphasemeter       A-&gt;N       Convert input audio to phase meter video output.
    /// </summary>
    public class AphasemeterFilterGen : AudioToAudioFilter
    {
        internal AphasemeterFilterGen(AudioMap input, int outputCount) : base("aphasemeter", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public AphasemeterFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set video size (default &quot;800x400&quot;)
        /// </summary>
        public AphasemeterFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set red contrast (from 0 to 255) (default 2)
        /// </summary>
        public AphasemeterFilterGen rc(int rc) => this.SetOptionRange("rc", rc, 0, 255);
        /// <summary>
        ///  set green contrast (from 0 to 255) (default 7)
        /// </summary>
        public AphasemeterFilterGen gc(int gc) => this.SetOptionRange("gc", gc, 0, 255);
        /// <summary>
        ///  set blue contrast (from 0 to 255) (default 1)
        /// </summary>
        public AphasemeterFilterGen bc(int bc) => this.SetOptionRange("bc", bc, 0, 255);
        /// <summary>
        ///  set median phase color (default &quot;none&quot;)
        /// </summary>
        public AphasemeterFilterGen mpc(String mpc) => this.SetOption("mpc", mpc.ToString());
        /// <summary>
        ///  set video output (default true)
        /// </summary>
        public AphasemeterFilterGen video(bool video) => this.SetOption("video", video.ToFFmpegFlag());
        /// <summary>
        ///  set mono and out-of-phase detection output (default false)
        /// </summary>
        public AphasemeterFilterGen phasing(bool phasing) => this.SetOption("phasing", phasing.ToFFmpegFlag());
        /// <summary>
        ///  set phase tolerance for mono detection (from 0 to 1) (default 0)
        /// </summary>
        public AphasemeterFilterGen tolerance(float tolerance) => this.SetOptionRange("tolerance", tolerance, 0, 1);
        /// <summary>
        ///  set angle threshold for out-of-phase detection (from 90 to 180) (default 170)
        /// </summary>
        public AphasemeterFilterGen angle(float angle) => this.SetOptionRange("angle", angle, 90, 180);
        /// <summary>
        ///  set minimum mono or out-of-phase duration in seconds (default 2)
        /// </summary>
        public AphasemeterFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio to phase meter video output.
        /// </summary>
        public static AphasemeterFilterGen AphasemeterFilterGen(this AudioMap input0, int outputCount) => new AphasemeterFilterGen(input0, outputCount);
    }
}