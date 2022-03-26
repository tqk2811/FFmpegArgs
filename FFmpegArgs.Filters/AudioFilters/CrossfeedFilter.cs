/*
crossfeed AVOptions:
  strength          <double>     ..F.A....T. set crossfeed strength (from 0 to 1) (default 0.2)
  range             <double>     ..F.A....T. set soundstage wideness (from 0 to 1) (default 0.5)
  slope             <double>     ..F.A....T. set curve slope (from 0.01 to 1) (default 0.5)
  level_in          <double>     ..F.A....T. set level in (from 0 to 1) (default 0.9)
  level_out         <double>     ..F.A....T. set level out (from 0 to 1) (default 1)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// T.C crossfeed         A->A       Apply headphone crossfeed filter.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#crossfeed
    /// </summary>
    public class CrossfeedFilter : AudioToAudioFilter, ITimelineSupport, ICommandSupport
    {
        internal CrossfeedFilter(AudioMap audioMap) : base("crossfeed", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// set crossfeed strength (from 0 to 1) (default 0.2)<br>
        /// </br>This sets gain of low shelf filter for side part of stereo image. Default is -6dB. Max allowed is -30db when strength is set to 1.
        /// </summary>
        /// <param name="strength"></param>
        /// <returns></returns>
        public CrossfeedFilter Strength(double strength)
            => this.SetOptionRange("strength", strength, 0, 1);
        /// <summary>
        /// set soundstage wideness (from 0 to 1) (default 0.5)<br>
        /// </br>This sets cut off frequency of low shelf filter. Default is cut off near 1550 Hz. With range set to 1 cut off frequency is set to 2100 Hz.
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public CrossfeedFilter Range(double range)
            => this.SetOptionRange("range", range, 0, 1);
        /// <summary>
        /// Set curve slope of low shelf filter. (from 0.01 to 1) (default 0.5)
        /// </summary>
        /// <param name="slope"></param>
        /// <returns></returns>
        public CrossfeedFilter Slope(double slope)
            => this.SetOptionRange("slope", slope, 0.01, 1);
        /// <summary>
        /// Set level in (from 0 to 1) (default 0.9)
        /// </summary>
        /// <param name="levelIn"></param>
        /// <returns></returns>
        public CrossfeedFilter LevelIn(double levelIn)
            => this.SetOptionRange("level_in", levelIn, 0, 1);
        /// <summary>
        /// Set level out (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="levelOut"></param>
        /// <returns></returns>
        public CrossfeedFilter LevelOut(double levelOut)
            => this.SetOptionRange("level_out", levelOut, 0, 1);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class CrossfeedFilterExtensions
    {
        /// <summary>
        /// Apply headphone crossfeed filter.<br>
        /// </br>Crossfeed is the process of blending the left and right channels of stereo audio recording.It is mainly used to reduce extreme stereo separation of low frequencies.<br>
        /// </br>The intent is to produce more speaker like sound to the listener.
        /// </summary>
        public static CrossfeedFilter CrossfeedFilter(this AudioMap audioMap)
          => new CrossfeedFilter(audioMap);
    }
}
