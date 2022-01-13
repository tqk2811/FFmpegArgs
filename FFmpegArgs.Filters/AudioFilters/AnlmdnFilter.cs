/*
anlmdn AVOptions:
  s                 <float>      ..F.A....T. set denoising strength (from 1e-05 to 10) (default 1e-05)
  p                 <duration>   ..F.A....T. set patch duration (default 0.002)
  r                 <duration>   ..F.A....T. set research duration (default 0.006)
  o                 <int>        ..F.A....T. set output mode (from 0 to 2) (default o)
     i               0            ..F.A....T. input
     o               1            ..F.A....T. output
     n               2            ..F.A....T. noise
  m                 <float>      ..F.A....T. set smooth factor (from 1 to 15) (default 11)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    ///  TSC anlmdn            A->A       Reduce broadband noise from stream using Non-Local Means.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#anlmdn
    /// </summary>
    public class AnlmdnFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AnlmdnFilter(AudioMap audioMap) : base("anlmdn", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set denoising strength. (from 1e-05 to 10) (default 1e-05)
        /// </summary>
        /// <param name="strength"></param>
        /// <returns></returns>
        public AnlmdnFilter Strength(float strength)
            => this.SetOptionRange("s", strength, 1e-05, 10);

        /// <summary>
        /// Set patch radius duration. Allowed range is from 1 to 100 milliseconds. Default value is 2 milliseconds.
        /// </summary>
        /// <param name="patch"></param>
        /// <returns></returns>
        public AnlmdnFilter Patch(TimeSpan patch)
            => this.SetOptionRange("p", patch, TimeSpan.FromMilliseconds(1), TimeSpan.FromMilliseconds(100));

        /// <summary>
        /// Set research radius duration. Allowed range is from 2 to 300 milliseconds. Default value is 6 milliseconds.
        /// </summary>
        /// <param name="research"></param>
        /// <returns></returns>
        public AnlmdnFilter Research(TimeSpan research)
            => this.SetOptionRange("r", research, TimeSpan.FromMilliseconds(2), TimeSpan.FromMilliseconds(300));

        /// <summary>
        /// Set the output mode.
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        public AnlmdnFilter Output(AnlmdnOutput output)
            => this.SetOption("o", output);

        /// <summary>
        /// Set smooth factor. Default value is 11. Allowed range is from 1 to 15.
        /// </summary>
        /// <param name="smooth"></param>
        /// <returns></returns>
        public AnlmdnFilter Smooth(float smooth)
            => this.SetOptionRange("m", smooth, 1, 15);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AnlmdnFilterExtensions
    {
        /// <summary>
        /// Reduce broadband noise in audio samples using Non-Local Means algorithm.<br>
        /// </br>Each sample is adjusted by looking for other samples with similar contexts.This context similarity is defined by comparing their surrounding patches of size p.Patches are searched in an area of r around the sample.
        /// </summary>
        public static AnlmdnFilter AnlmdnFilter(this AudioMap audioMap)
          => new AnlmdnFilter(audioMap);
    }

    /// <summary>
    /// Set the output mode.
    /// </summary>
    public enum AnlmdnOutput
    {
        /// <summary>
        /// Pass input unchanged.
        /// </summary>
        i,
        /// <summary>
        /// Pass noise filtered out. (default)
        /// </summary>
        o,
        /// <summary>
        /// Pass only noise.
        /// </summary>
        n
    }
}
