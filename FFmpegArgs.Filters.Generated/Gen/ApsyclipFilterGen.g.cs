namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC apsyclip          A-&gt;A       Audio Psychoacoustic Clipper.
    /// </summary>
    public class ApsyclipFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ApsyclipFilterGen(AudioMap input) : base("apsyclip", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set input level (from 0.015625 to 64) (default 1)
        /// </summary>
        public ApsyclipFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in, 0.015625, 64);
        /// <summary>
        ///  set output level (from 0.015625 to 64) (default 1)
        /// </summary>
        public ApsyclipFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out, 0.015625, 64);
        /// <summary>
        ///  set clip level (from 0.015625 to 1) (default 1)
        /// </summary>
        public ApsyclipFilterGen clip(double clip) => this.SetOptionRange("clip", clip, 0.015625, 1);
        /// <summary>
        ///  enable difference (default false)
        /// </summary>
        public ApsyclipFilterGen diff(bool diff) => this.SetOption("diff", diff.ToFFmpegFlag());
        /// <summary>
        ///  set adaptive distortion (from 0 to 1) (default 0.5)
        /// </summary>
        public ApsyclipFilterGen adaptive(double adaptive) => this.SetOptionRange("adaptive", adaptive, 0, 1);
        /// <summary>
        ///  set iterations (from 1 to 20) (default 10)
        /// </summary>
        public ApsyclipFilterGen iterations(int iterations) => this.SetOptionRange("iterations", iterations, 1, 20);
        /// <summary>
        ///  set auto level (default false)
        /// </summary>
        public ApsyclipFilterGen level(bool level) => this.SetOption("level", level.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Audio Psychoacoustic Clipper.
        /// </summary>
        public static ApsyclipFilterGen ApsyclipFilterGen(this AudioMap input0) => new ApsyclipFilterGen(input0);
    }
}