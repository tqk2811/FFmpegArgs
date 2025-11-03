/*
afade AVOptions:
  type              <int>        ..F.A....T. set the fade direction (from 0 to 1) (default in)
     in              0            ..F.A....T. fade-in
     out             1            ..F.A....T. fade-out
  t                 <int>        ..F.A....T. set the fade direction (from 0 to 1) (default in)
     in              0            ..F.A....T. fade-in
     out             1            ..F.A....T. fade-out
  start_sample      <int64>      ..F.A....T. set number of first sample to start fading (from 0 to I64_MAX) (default 0)
  ss                <int64>      ..F.A....T. set number of first sample to start fading (from 0 to I64_MAX) (default 0)
  nb_samples        <int64>      ..F.A....T. set number of samples for fade duration (from 1 to I64_MAX) (default 44100)
  ns                <int64>      ..F.A....T. set number of samples for fade duration (from 1 to I64_MAX) (default 44100)
  start_time        <duration>   ..F.A....T. set time to start fading (default 0)
  st                <duration>   ..F.A....T. set time to start fading (default 0)
  duration          <duration>   ..F.A....T. set fade duration (default 0)
  d                 <duration>   ..F.A....T. set fade duration (default 0)
  curve             <int>        ..F.A....T. set fade curve type (from -1 to 18) (default tri)
     nofade          -1           ..F.A....T. no fade; keep audio as-is
     tri             0            ..F.A....T. linear slope
     qsin            1            ..F.A....T. quarter of sine wave
     esin            2            ..F.A....T. exponential sine wave
     hsin            3            ..F.A....T. half of sine wave
     log             4            ..F.A....T. logarithmic
     ipar            5            ..F.A....T. inverted parabola
     qua             6            ..F.A....T. quadratic
     cub             7            ..F.A....T. cubic
     squ             8            ..F.A....T. square root
     cbr             9            ..F.A....T. cubic root
     par             10           ..F.A....T. parabola
     exp             11           ..F.A....T. exponential
     iqsin           12           ..F.A....T. inverted quarter of sine wave
     ihsin           13           ..F.A....T. inverted half of sine wave
     dese            14           ..F.A....T. double-exponential seat
     desi            15           ..F.A....T. double-exponential sigmoid
     losi            16           ..F.A....T. logistic sigmoid
     sinc            17           ..F.A....T. sine cardinal function
     isinc           18           ..F.A....T. inverted sine cardinal function
  c                 <int>        ..F.A....T. set fade curve type (from -1 to 18) (default tri)
     nofade          -1           ..F.A....T. no fade; keep audio as-is
     tri             0            ..F.A....T. linear slope
     qsin            1            ..F.A....T. quarter of sine wave
     esin            2            ..F.A....T. exponential sine wave
     hsin            3            ..F.A....T. half of sine wave
     log             4            ..F.A....T. logarithmic
     ipar            5            ..F.A....T. inverted parabola
     qua             6            ..F.A....T. quadratic
     cub             7            ..F.A....T. cubic
     squ             8            ..F.A....T. square root
     cbr             9            ..F.A....T. cubic root
     par             10           ..F.A....T. parabola
     exp             11           ..F.A....T. exponential
     iqsin           12           ..F.A....T. inverted quarter of sine wave
     ihsin           13           ..F.A....T. inverted half of sine wave
     dese            14           ..F.A....T. double-exponential seat
     desi            15           ..F.A....T. double-exponential sigmoid
     losi            16           ..F.A....T. logistic sigmoid
     sinc            17           ..F.A....T. sine cardinal function
     isinc           18           ..F.A....T. inverted sine cardinal function
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// T.C afade             A->A       Fade in/out input audio.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#afade-1
    /// </summary>
    public class AfadeFilter : AudioToAudioFilter, ITimelineSupport, ICommandSupport
    {
        internal AfadeFilter(AudioMap audioMap) : base("afade", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Specify the effect type, can be either in for fade-in, or out for a fade-out effect. Default is in.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public AfadeFilter Type(AfadeType type)
            => this.SetOption("t", type.ToString().ToLowerInvariant());
        /// <summary>
        /// Specify the number of the start sample for starting to apply the fade effect. Default is 0.
        /// </summary>
        /// <param name="start_sample"></param>
        /// <returns></returns>
        public AfadeFilter StartSample(long start_sample)
          => this.SetOptionRange("ss", start_sample, 0, long.MaxValue);
        /// <summary>
        /// Specify the number of samples for which the fade effect has to last.<br>
        /// </br> At the end of the fade-in effect the output audio will have the same volume as the input audio, at the end of the fade-out transition the output audio will be silence.<br>
        /// </br> Default is 44100.
        /// </summary>
        /// <param name="nb_samples"></param>
        /// <returns></returns>
        public AfadeFilter NbSamples(int nb_samples)
          => this.SetOptionRange("ns", nb_samples, 1, int.MaxValue);
        /// <summary>
        /// Specify the start time of the fade effect. Default is 0. The value must be specified as a time duration.<br>
        /// </br> If set this option is used instead of start_sample.
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public AfadeFilter StartTime(TimeSpan st)
          => this.SetOptionRange("st", st, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Specify the duration of the fade effect.<br>
        /// </br> At the end of the fade-in effect the output audio will have the same volume as the input audio, at the end of the fade-out transition the output audio will be silence.<br>
        /// </br> By default the duration is determined by nb_samples. If set this option is used instead of nb_samples.
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public AfadeFilter Duration(TimeSpan duration)
            => this.SetOptionRange("d", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Set curve for fade transition.
        /// </summary>
        /// <param name="curve"></param>
        /// <returns></returns>
        public AfadeFilter Curve(AfadeCurve curve)
            => this.SetOption("curve", curve.ToString());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AfadeFilterExtension
    {
        /// <summary>
        /// Apply fade-in/out effect to input audio.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AfadeFilter AfadeFilter(this AudioMap audioMap)
            => new AfadeFilter(audioMap);
    }
    /// <summary>
    /// 
    /// </summary>
    public enum AfadeType
    {
        /// <summary>
        /// fade-in
        /// </summary>
        In,
        /// <summary>
        /// fade-out
        /// </summary>
        Out
    }
    /// <summary>
    /// 
    /// </summary>
    public enum AfadeCurve
    {
        /// <summary>
        /// select triangular, linear slope (default)
        /// </summary>
        tri,
        /// <summary>
        /// select quarter of sine wave
        /// </summary>
        qsin,
        /// <summary>
        /// select half of sine wave
        /// </summary>
        hsin,
        /// <summary>
        /// select exponential sine wave
        /// </summary>
        esin,
        /// <summary>
        /// select logarithmic
        /// </summary>
        log,
        /// <summary>
        /// select inverted parabola
        /// </summary>
        ipar,
        /// <summary>
        /// select quadratic
        /// </summary>
        qua,
        /// <summary>
        /// select cubic
        /// </summary>
        cub,
        /// <summary>
        /// select square root
        /// </summary>
        squ,
        /// <summary>
        /// select cubic root
        /// </summary>
        cbr,
        /// <summary>
        /// select parabola
        /// </summary>
        par,
        /// <summary>
        /// select exponential
        /// </summary>
        exp,
        /// <summary>
        /// select inverted quarter of sine wave
        /// </summary>
        iqsin,
        /// <summary>
        /// select inverted half of sine wave
        /// </summary>
        ihsin,
        /// <summary>
        /// select double-exponential seat
        /// </summary>
        dese,
        /// <summary>
        /// select double-exponential sigmoid
        /// </summary>
        desi,
        /// <summary>
        /// select logistic sigmoid
        /// </summary>
        losi,
        /// <summary>
        /// select sine cardinal function
        /// </summary>
        sinc,
        /// <summary>
        /// select inverted sine cardinal function
        /// </summary>
        isinc,
        /// <summary>
        /// no fade applied
        /// </summary>
        nofade,
    }
}
