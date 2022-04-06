/*
acrossover AVOptions:
  split             <string>     ..F.A...... set split frequencies (default "500")
  order             <int>        ..F.A...... set filter order (from 0 to 9) (default 4th)
     2nd             0            ..F.A...... 2nd order (12 dB/8ve)
     4th             1            ..F.A...... 4th order (24 dB/8ve)
     6th             2            ..F.A...... 6th order (36 dB/8ve)
     8th             3            ..F.A...... 8th order (48 dB/8ve)
     10th            4            ..F.A...... 10th order (60 dB/8ve)
     12th            5            ..F.A...... 12th order (72 dB/8ve)
     14th            6            ..F.A...... 14th order (84 dB/8ve)
     16th            7            ..F.A...... 16th order (96 dB/8ve)
     18th            8            ..F.A...... 18th order (108 dB/8ve)
     20th            9            ..F.A...... 20th order (120 dB/8ve)
  level             <float>      ..F.A...... set input gain (from 0 to 1) (default 1)
  gain              <string>     ..F.A...... set output bands gain (default "1.f")
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// .S. acrossover        A->N       Split audio into per-bands streams.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#acrossover
    /// </summary>
    public class AcrossoverFilter : AudioToAudioFilter, ISliceThreading
    {
        internal AcrossoverFilter(int[] hzSplit, AudioMap audioMap) : base("acrossover", audioMap)
        {
            this.SetOption("split", string.Join(" ", hzSplit));
            AddMultiMapOut(hzSplit.Length + 1);
        }
        /// <summary>
        /// Set filter order for each band split. This controls filter roll-off or steepness of filter transfer function
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public AcrossoverFilter Order(AcrossoverOrder order)
          => this.SetOption("order", order.ToString().Substring(1));
        /// <summary>
        /// Set input gain level. Allowed range is from 0 to 1. Default value is 1.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public AcrossoverFilter Level(float level)
          => this.SetOptionRange("level", level, 0, 1);
        /// <summary>
        /// set output bands gain (default "1.f")
        /// </summary>
        /// <param name="gain"></param>
        /// <returns></returns>
        public AcrossoverFilter Gain(string gain)
           => this.SetOption("gain", gain);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AcrossoverFilterExtension
    {
        /// <summary>
        /// Split audio stream into several bands.<br>
        /// </br>This filter splits audio stream into two or more frequency ranges.Summing all streams back will give flat output.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="hzSplit">Set split frequencies. Those must be positive and increasing.</param>
        /// <returns></returns>
        public static AcrossoverFilter AcrossoverFilter(this AudioMap audioMap, params int[] hzSplit)
        {
            if (hzSplit.Length == 0) throw new ArgumentNullException(nameof(hzSplit));
            if (hzSplit.Any(x => x <= 0)) throw new InvalidOperationException("Hz requied > 0");
            return new AcrossoverFilter(hzSplit, audioMap);
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public enum AcrossoverOrder
    {
        /// <summary>
        /// 12 dB per octave.
        /// </summary>
        _2nd,
        /// <summary>
        /// 24 dB per octave.
        /// </summary>
        _4th,
        /// <summary>
        /// 36 dB per octave.
        /// </summary>
        _6th,
        /// <summary>
        /// 48 dB per octave.
        /// </summary>
        _8th,
        /// <summary>
        /// 60 dB per octave.
        /// </summary>
        _10th,
        /// <summary>
        /// 72 dB per octave.
        /// </summary>
        _12th,
        /// <summary>
        /// 84 dB per octave.
        /// </summary>
        _14th,
        /// <summary>
        /// 96 dB per octave.
        /// </summary>
        _16th,
        /// <summary>
        /// 108 dB per octave.
        /// </summary>
        _18th,
        /// <summary>
        /// 120 dB per octave.
        /// </summary>
        _20th
    }
}
