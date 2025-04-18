/*
acrusher AVOptions:
  level_in          <double>     ..F.A....T. set level in (from 0.015625 to 64) (default 1)
  level_out         <double>     ..F.A....T. set level out (from 0.015625 to 64) (default 1)
  bits              <double>     ..F.A....T. set bit reduction (from 1 to 64) (default 8)
  mix               <double>     ..F.A....T. set mix (from 0 to 1) (default 0.5)
  mode              <int>        ..F.A....T. set mode (from 0 to 1) (default lin)
     lin             0            ..F.A....T. linear
     log             1            ..F.A....T. logarithmic
  dc                <double>     ..F.A....T. set DC (from 0.25 to 4) (default 1)
  aa                <double>     ..F.A....T. set anti-aliasing (from 0 to 1) (default 0.5)
  samples           <double>     ..F.A....T. set sample reduction (from 1 to 250) (default 1)
  lfo               <boolean>    ..F.A....T. enable LFO (default false)
  lforange          <double>     ..F.A....T. set LFO depth (from 1 to 250) (default 20)
  lforate           <double>     ..F.A....T. set LFO rate (from 0.01 to 200) (default 0.3)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    ///  ..C acrusher          A->A       Reduce audio bit resolution.<br>
    ///  </br>https://ffmpeg.org/ffmpeg-filters.html#acrusher (need more info)
    /// </summary>
    public class AcrusherFilter : AudioToAudioFilter, ICommandSupport
    {
        internal AcrusherFilter(AudioMap audioMap) : base("acrusher", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set level in. (from 0.015625 to 64) (default 1)
        /// </summary>
        /// <param name="level_in"></param>
        /// <returns></returns>
        public AcrusherFilter LevelIn(double level_in)
          => this.SetOptionRange("level_in", level_in, 0.015625, 64);
        /// <summary>
        /// Set level out. (from 0.015625 to 64) (default 1)
        /// </summary>
        /// <param name="level_out"></param>
        /// <returns></returns>
        public AcrusherFilter LevelOut(double level_out)
         => this.SetOptionRange("level_out", level_out, 0.015625, 64);
        /// <summary>
        /// Set bit reduction. (from 1 to 64) (default 8)
        /// </summary>
        /// <param name="bits"></param>
        /// <returns></returns>
        public AcrusherFilter Bits(double bits)
          => this.SetOptionRange("bits", bits, 1, 64);
        /// <summary>
        /// Set mixing amount. (from 0 to 1) (default 0.5)
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public AcrusherFilter Mix(double mix)
          => this.SetOptionRange("mix", mix, 0, 1);
        /// <summary>
        /// Can be linear: lin or logarithmic: log.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public AcrusherFilter Mode(AcrusherMode mode)
          => this.SetOption("mode", mode);
        /// <summary>
        /// Set DC. (from 0.25 to 4) (default 1)
        /// </summary>
        /// <param name="dc"></param>
        /// <returns></returns>
        public AcrusherFilter DC(double dc)
         => this.SetOptionRange("dc", dc, 0.25, 4);
        /// <summary>
        /// Set anti-aliasing. (from 0 to 1) (default 0.5)
        /// </summary>
        /// <param name="aa"></param>
        /// <returns></returns>
        public AcrusherFilter AA(double aa)
         => this.SetOptionRange("aa", aa, 0, 1);
        /// <summary>
        /// Set sample reduction. (from 1 to 250) (default 1)
        /// </summary>
        /// <param name="lforange"></param>
        /// <returns></returns>
        public AcrusherFilter Samples(double lforange)
         => this.SetOptionRange("samples", lforange, 1, 250);
        /// <summary>
        /// Enable LFO. By default disabled.
        /// </summary>
        /// <param name="lfo"></param>
        /// <returns></returns>
        public AcrusherFilter Lfo(bool lfo)
         => this.SetOption("lfo", lfo.ToFFmpegFlag());
        /// <summary>
        /// Set LFO depth. (from 1 to 250) (default 20)
        /// </summary>
        /// <param name="lforange"></param>
        /// <returns></returns>
        public AcrusherFilter LfoRange(double lforange)
        => this.SetOptionRange("lforange", lforange, 1, 250);
        /// <summary>
        /// Set LFO rate. (from 0.01 to 200) (default 0.3)
        /// </summary>
        /// <param name="lforate"></param>
        /// <returns></returns>
        public AcrusherFilter LfoRate(double lforate)
        => this.SetOptionRange("lforate", lforate, 0.01, 200);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AcrusherFilterExtension
    {
        /// <summary>
        /// Reduce audio bit resolution.<br>
        /// </br>This filter is bit crusher with enhanced functionality.A bit crusher is used to audibly reduce number of bits an audio signal is sampled with.This doesn’t change the bit depth at all, it just produces the effect.Material reduced in bit depth sounds more harsh and "digital". This filter is able to even round to continuous values instead of discrete bit depths. Additionally it has a D/C offset which results in different crushing of the lower and the upper half of the signal. An Anti-Aliasing setting is able to produce "softer" crushing sounds.<br>
        /// </br>Another feature of this filter is the logarithmic mode.This setting switches from linear distances between bits to logarithmic ones.The result is a much more "natural" sounding crusher which doesn’t gate low signals for example.The human ear has a logarithmic perception, so this kind of crushing is much more pleasant.Logarithmic crushing is also able to get anti-aliased.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AcrusherFilter AcrusherFilter(this AudioMap audioMap)
            => new AcrusherFilter(audioMap);
    }
    /// <summary>
    /// 
    /// </summary>
    public enum AcrusherMode
    {
        /// <summary>
        /// linear
        /// </summary>
        lin,
        /// <summary>
        /// logarithmic
        /// </summary>
        log
    }
}
