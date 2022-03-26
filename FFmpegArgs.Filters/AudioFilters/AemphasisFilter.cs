/*
aemphasis AVOptions:
  level_in          <double>     ..F.A....T. set input gain (from 0 to 64) (default 1)
  level_out         <double>     ..F.A....T. set output gain (from 0 to 64) (default 1)
  mode              <int>        ..F.A....T. set filter mode (from 0 to 1) (default reproduction)
     reproduction    0            ..F.A....T.
     production      1            ..F.A....T.
  type              <int>        ..F.A....T. set filter type (from 0 to 8) (default cd)
     col             0            ..F.A....T. Columbia
     emi             1            ..F.A....T. EMI
     bsi             2            ..F.A....T. BSI (78RPM)
     riaa            3            ..F.A....T. RIAA
     cd              4            ..F.A....T. Compact Disc (CD)
     50fm            5            ..F.A....T. 50µs (FM)
     75fm            6            ..F.A....T. 75µs (FM)
     50kf            7            ..F.A....T. 50µs (FM-KF)
     75kf            8            ..F.A....T. 75µs (FM-KF)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC aemphasis         A->A       Audio emphasis.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#aemphasis
    /// </summary>
    public class AemphasisFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AemphasisFilter(AudioMap audioMap) : base("aemphasis", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set input gain. (from 0 to 64) (default 1)
        /// </summary>
        /// <param name="level_in"></param>
        /// <returns></returns>
        public AemphasisFilter LevelIn(double level_in)
            => this.SetOptionRange("level_in", level_in, 0, 64);
        /// <summary>
        /// Set output gain. (from 0 to 64) (default 1)
        /// </summary>
        /// <param name="level_out"></param>
        /// <returns></returns>
        public AemphasisFilter LevelOut(double level_out)
            => this.SetOptionRange("level_out", level_out, 0, 64);

        /// <summary>
        /// Set filter mode. For restoring material use reproduction mode, otherwise use production mode. Default is reproduction mode.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public AemphasisFilter Mode(AemphasisMode mode)
            => this.SetOption("mode", mode);

        /// <summary>
        /// Set filter type. Selects medium. Default is cd.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public AemphasisFilter Type(AemphasisType type)
            => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AemphasisFilterExtensions
    {
        /// <summary>
        /// Audio emphasis filter creates or restores material directly taken from LPs or emphased CDs with different filter curves. E.g. to store music on vinyl the signal has to be altered by a filter first to even out the disadvantages of this recording medium. Once the material is played back the inverse filter has to be applied to restore the distortion of the frequency response.
        /// </summary>
        public static AemphasisFilter AemphasisFilter(this AudioMap audioMap)
          => new AemphasisFilter(audioMap);
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum AemphasisMode
    {
        reproduction,
        production
    }
    public enum AemphasisType
    {
        [Name("col")]col,
        [Name("emi")] emi,
        [Name("bsi")] bsi,
        [Name("riaa")] riaa,
        [Name("cd")] cd,
        [Name("50fm")] _50fm,
        [Name("75fm")] _75fm,
        [Name("50kf")] _50kf,
        [Name("75kf")] _75kf,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
