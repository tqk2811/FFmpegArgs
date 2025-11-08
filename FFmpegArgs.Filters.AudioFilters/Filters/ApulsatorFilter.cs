/*
apulsator AVOptions:
  level_in          <double>     ..F.A...... set input gain (from 0.015625 to 64) (default 1)
  level_out         <double>     ..F.A...... set output gain (from 0.015625 to 64) (default 1)
  mode              <int>        ..F.A...... set mode (from 0 to 4) (default sine)
     sine            0            ..F.A......
     triangle        1            ..F.A......
     square          2            ..F.A......
     sawup           3            ..F.A......
     sawdown         4            ..F.A......
  amount            <double>     ..F.A...... set modulation (from 0 to 1) (default 1)
  offset_l          <double>     ..F.A...... set offset L (from 0 to 1) (default 0)
  offset_r          <double>     ..F.A...... set offset R (from 0 to 1) (default 0.5)
  width             <double>     ..F.A...... set pulse width (from 0 to 2) (default 1)
  timing            <int>        ..F.A...... set timing (from 0 to 2) (default hz)
     bpm             0            ..F.A......
     ms              1            ..F.A......
     hz              2            ..F.A......
  bpm               <double>     ..F.A...... set BPM (from 30 to 300) (default 120)
  ms                <int>        ..F.A...... set ms (from 10 to 2000) (default 500)
  hz                <double>     ..F.A...... set frequency (from 0.01 to 100) (default 2)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... apulsator         A->A       Audio pulsator.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#apulsator
    /// </summary>
    public class ApulsatorFilter : AudioToAudioFilter
    {
        internal ApulsatorFilter(AudioMap audioMap) : base("apulsator", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// set input gain (from 0.015625 to 64) (default 1)
        /// </summary>
        /// <param name="level_in"></param>
        /// <returns></returns>
        public ApulsatorFilter LevelIn(double level_in)
            => this.SetOptionRange("level_in", level_in, 0.015625, 64);

        /// <summary>
        /// set output gain (from 0.015625 to 64) (default 1)
        /// </summary>
        /// <param name="level_out"></param>
        /// <returns></returns>
        public ApulsatorFilter LevelOut(double level_out)
            => this.SetOptionRange("level_out", level_out, 0.015625, 64);

        /// <summary>
        /// set mode (from 0 to 4) (default sine)
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public ApulsatorFilter Mode(ApulsatorMode mode)
            => this.SetOption("mode", mode.ToString().ToLower());

        /// <summary>
        /// set modulation (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public ApulsatorFilter Amount(double amount)
            => this.SetOptionRange("amount", amount, 0, 1);

        /// <summary>
        /// set offset L (from 0 to 1) (default 0)
        /// </summary>
        /// <param name="offset_l"></param>
        /// <returns></returns>
        public ApulsatorFilter OffsetL(double offset_l)
           => this.SetOptionRange("offset_l", offset_l, 0, 1);

        /// <summary>
        /// set offset R (from 0 to 1) (default 0.5)
        /// </summary>
        /// <param name="offset_r"></param>
        /// <returns></returns>
        public ApulsatorFilter OffsetR(double offset_r)
           => this.SetOptionRange("offset_r", offset_r, 0, 1);

        /// <summary>
        /// set pulse width (from 0 to 2) (default 1)
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public ApulsatorFilter Width(double width)
           => this.SetOptionRange("width", width, 0, 2);

        /// <summary>
        /// set timing (from 0 to 2) (default hz)
        /// </summary>
        /// <param name="timing"></param>
        /// <returns></returns>
        public ApulsatorFilter Timing(ApulsatorMode timing)
            => this.SetOption("timing", timing.ToString().ToLower());

        /// <summary>
        /// set BPM (from 30 to 300) (default 120)
        /// </summary>
        /// <param name="bpm"></param>
        /// <returns></returns>
        public ApulsatorFilter Bpm(double bpm)
            => this.SetOptionRange("bpm", bpm, 30, 300);

        /// <summary>
        /// set ms (from 10 to 2000) (default 500)
        /// </summary>
        /// <param name="ms"></param>
        /// <returns></returns>
        public ApulsatorFilter Ms(int ms)
            => this.SetOptionRange("ms", ms, 10, 2000);

        /// <summary>
        /// set frequency (from 0.01 to 100) (default 2)
        /// </summary>
        /// <param name="hz"></param>
        /// <returns></returns>
        public ApulsatorFilter Hz(double hz)
            => this.SetOptionRange("hz", hz, 0.01, 100);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class ApulsatorFilterExtensions
    {
        /// <summary>
        /// Audio pulsator is something between an autopanner and a tremolo. But it can produce funny stereo effects as well. Pulsator changes the volume of the left and right channel based on a LFO (low frequency oscillator) with different waveforms and shifted phases. This filter have the ability to define an offset between left and right channel. An offset of 0 means that both LFO shapes match each other. The left and right channel are altered equally - a conventional tremolo. An offset of 50% means that the shape of the right channel is exactly shifted in phase (or moved backwards about half of the frequency) - pulsator acts as an autopanner. At 1 both curves match again. Every setting in between moves the phase shift gapless between all stages and produces some "bypassing" sounds with sine and triangle waveforms. The more you set the offset near 1 (starting from the 0.5) the faster the signal passes from the left to the right speaker.
        /// </summary>
        public static ApulsatorFilter ApulsatorFilter(this AudioMap audioMap)
          => new ApulsatorFilter(audioMap);
    }

    /// <summary>
    /// set mode (from 0 to 4) (default sine)
    /// </summary>
    public enum ApulsatorMode
    {
        /// <summary>
        /// 
        /// </summary>
        Sine = 0,
        /// <summary>
        /// 
        /// </summary>
        Triangle = 1,
        /// <summary>
        /// 
        /// </summary>
        Square = 2,
        /// <summary>
        /// 
        /// </summary>
        Sawup = 3,
        /// <summary>
        /// 
        /// </summary>
        Sawdown = 4
    }

    /// <summary>
    /// set timing (from 0 to 2) (default hz)
    /// </summary>
    public enum ApulsatorTiming
    {
        /// <summary>
        /// 
        /// </summary>
        Bpm = 0,
        /// <summary>
        /// 
        /// </summary>
        Ms = 1,
        /// <summary>
        /// 
        /// </summary>
        Hz = 2
    }
}
