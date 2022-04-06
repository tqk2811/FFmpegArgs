/*
adynamicequalizer AVOptions:
   threshold         <double>     ..F.A....T. set detection threshold (from 0 to 100) (default 0)
   dfrequency        <double>     ..F.A....T. set detection frequency (from 2 to 1e+06) (default 1000)
   dqfactor          <double>     ..F.A....T. set detection Q factor (from 0.001 to 1000) (default 1)
   tfrequency        <double>     ..F.A....T. set target frequency (from 2 to 1e+06) (default 1000)
   tqfactor          <double>     ..F.A....T. set target Q factor (from 0.001 to 1000) (default 1)
   attack            <double>     ..F.A....T. set attack duration (from 1 to 2000) (default 20)
   release           <double>     ..F.A....T. set release duration (from 1 to 2000) (default 200)
   knee              <double>     ..F.A....T. set knee factor (from 0 to 8) (default 1)
   ratio             <double>     ..F.A....T. set ratio factor (from 1 to 20) (default 1)
   makeup            <double>     ..F.A....T. set makeup gain (from 0 to 30) (default 0)
   range             <double>     ..F.A....T. set max gain (from 0 to 200) (default 0)
   slew              <double>     ..F.A....T. set slew factor (from 1 to 200) (default 1)
   mode              <int>        ..F.A....T. set mode (from -1 to 1) (default cut)
     listen          -1           ..F.A....T.
     cut             0            ..F.A....T.
     boost           1            ..F.A....T.
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC adynamicequalizer A->A       Apply Dynamic Equalization of input audio.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#adynamicequalizer
    /// </summary>
    public class AdynamicequalizerFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AdynamicequalizerFilter(AudioMap audioMap) : base("adynamicequalizer", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the detection threshold used to trigger equalization. Threshold detection is using bandpass filter. Default value is 0. Allowed range is from 0 to 100.
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Threshold(double threshold)
            => this.SetOptionRange("threshold", threshold, 0, 100);

        /// <summary>
        /// Set the detection frequency in Hz used for bandpass filter used to trigger equalization. Default value is 1000 Hz. Allowed range is between 2 and 1000000 Hz.
        /// </summary>
        /// <param name="dfrequency"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Dfrequency(double dfrequency)
            => this.SetOptionRange("dfrequency", dfrequency, 2, 1e+06);
        
        /// <summary>
        /// Set the detection resonance factor for bandpass filter used to trigger equalization. Default value is 1. Allowed range is from 0.001 to 1000.
        /// </summary>
        /// <param name="dqfactor"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Dqfactor(double dqfactor)
           => this.SetOptionRange("dqfactor", dqfactor, 0.001, 1000);

        /// <summary>
        /// Set the target frequency of equalization filter. Default value is 1000 Hz. Allowed range is between 2 and 1000000 Hz.
        /// </summary>
        /// <param name="tfrequency"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Tfrequency(double tfrequency)
          => this.SetOptionRange("tfrequency", tfrequency, 2, 1e+06);

        /// <summary>
        /// Set the target resonance factor for target equalization filter. Default value is 1. Allowed range is from 0.001 to 1000.
        /// </summary>
        /// <param name="tqfactor"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Tqfactor(double tqfactor)
          => this.SetOptionRange("tqfactor", tqfactor, 0.001, 1000);

        /// <summary>
        /// Set the amount of milliseconds the signal from detection has to rise above the detection threshold before equalization starts. Default is 20. Allowed range is between 1 and 2000.
        /// </summary>
        /// <param name="attack"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Attack(double attack)
          => this.SetOptionRange("attack", attack, 1, 2000);

        /// <summary>
        /// Set the amount of milliseconds the signal from detection has to fall below the detection threshold before equalization ends. Default is 200. Allowed range is between 1 and 2000.
        /// </summary>
        /// <param name="release"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Release(double release)
          => this.SetOptionRange("release", release, 1, 2000);

        /// <summary>
        /// Curve the sharp knee around the detection threshold to calculate equalization gain more softly. Default is 1. Allowed range is between 0 and 8.
        /// </summary>
        /// <param name="knee"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Knee(double knee)
          => this.SetOptionRange("knee", knee, 0, 8);

        /// <summary>
        /// Set the ratio by which the equalization gain is raised. Default is 1. Allowed range is between 1 and 20.
        /// </summary>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Ratio(double ratio)
          => this.SetOptionRange("ratio", ratio, 1, 20);

        /// <summary>
        /// Set the makeup offset in dB by which the equalization gain is raised. Default is 0. Allowed range is between 0 and 30.
        /// </summary>
        /// <param name="makeup"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Makeup(double makeup)
          => this.SetOptionRange("makeup", makeup, 0, 30);

        /// <summary>
        /// Set the max allowed cut/boost amount in dB. Default is 0. Allowed range is from 0 to 200.
        /// </summary>
        /// <param name="attack"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Range(double attack)
          => this.SetOptionRange("attack", attack, 0, 200);

        /// <summary>
        /// Set the slew factor. Default is 1. Allowed range is from 1 to 200.
        /// </summary>
        /// <param name="slew"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Slew(double slew)
          => this.SetOptionRange("slew", slew, 1, 200);

        /// <summary>
        /// Set the mode of filter operation
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public AdynamicequalizerFilter Mode(AdynamicequalizerMode mode)
          => this.SetOption("mode", mode.ToString().ToLower());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AdynamicequalizerFilterExtensions
    {
        /// <summary>
        /// Apply dynamic equalization to input audio stream.
        /// </summary>
        public static AdynamicequalizerFilter AdynamicequalizerFilter(this AudioMap audioMap)
          => new AdynamicequalizerFilter(audioMap);
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum AdynamicequalizerMode
    {
        Listen,
        Cut,
        Boost,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
