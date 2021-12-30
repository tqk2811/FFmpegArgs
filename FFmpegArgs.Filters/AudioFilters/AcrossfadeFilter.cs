/*
acrossfade AVOptions:
  nb_samples        <int>        ..F.A...... set number of samples for cross fade duration (from 1 to 2.14748e+08) (default 44100)
  ns                <int>        ..F.A...... set number of samples for cross fade duration (from 1 to 2.14748e+08) (default 44100)
  duration          <duration>   ..F.A...... set cross fade duration (default 0)
  d                 <duration>   ..F.A...... set cross fade duration (default 0)
  overlap           <boolean>    ..F.A...... overlap 1st stream end with 2nd stream start (default true)
  o                 <boolean>    ..F.A...... overlap 1st stream end with 2nd stream start (default true)
  curve1            <int>        ..F.A...... set fade curve type for 1st stream (from -1 to 18) (default tri)
     nofade          -1           ..F.A...... no fade; keep audio as-is
     tri             0            ..F.A...... linear slope
     qsin            1            ..F.A...... quarter of sine wave
     esin            2            ..F.A...... exponential sine wave
     hsin            3            ..F.A...... half of sine wave
     log             4            ..F.A...... logarithmic
     ipar            5            ..F.A...... inverted parabola
     qua             6            ..F.A...... quadratic
     cub             7            ..F.A...... cubic
     squ             8            ..F.A...... square root
     cbr             9            ..F.A...... cubic root
     par             10           ..F.A...... parabola
     exp             11           ..F.A...... exponential
     iqsin           12           ..F.A...... inverted quarter of sine wave
     ihsin           13           ..F.A...... inverted half of sine wave
     dese            14           ..F.A...... double-exponential seat
     desi            15           ..F.A...... double-exponential sigmoid
     losi            16           ..F.A...... logistic sigmoid
     sinc            17           ..F.A...... sine cardinal function
     isinc           18           ..F.A...... inverted sine cardinal function
  c1                <int>        ..F.A...... set fade curve type for 1st stream (from -1 to 18) (default tri)
     nofade          -1           ..F.A...... no fade; keep audio as-is
     tri             0            ..F.A...... linear slope
     qsin            1            ..F.A...... quarter of sine wave
     esin            2            ..F.A...... exponential sine wave
     hsin            3            ..F.A...... half of sine wave
     log             4            ..F.A...... logarithmic
     ipar            5            ..F.A...... inverted parabola
     qua             6            ..F.A...... quadratic
     cub             7            ..F.A...... cubic
     squ             8            ..F.A...... square root
     cbr             9            ..F.A...... cubic root
     par             10           ..F.A...... parabola
     exp             11           ..F.A...... exponential
     iqsin           12           ..F.A...... inverted quarter of sine wave
     ihsin           13           ..F.A...... inverted half of sine wave
     dese            14           ..F.A...... double-exponential seat
     desi            15           ..F.A...... double-exponential sigmoid
     losi            16           ..F.A...... logistic sigmoid
     sinc            17           ..F.A...... sine cardinal function
     isinc           18           ..F.A...... inverted sine cardinal function
  curve2            <int>        ..F.A...... set fade curve type for 2nd stream (from -1 to 18) (default tri)
     nofade          -1           ..F.A...... no fade; keep audio as-is
     tri             0            ..F.A...... linear slope
     qsin            1            ..F.A...... quarter of sine wave
     esin            2            ..F.A...... exponential sine wave
     hsin            3            ..F.A...... half of sine wave
     log             4            ..F.A...... logarithmic
     ipar            5            ..F.A...... inverted parabola
     qua             6            ..F.A...... quadratic
     cub             7            ..F.A...... cubic
     squ             8            ..F.A...... square root
     cbr             9            ..F.A...... cubic root
     par             10           ..F.A...... parabola
     exp             11           ..F.A...... exponential
     iqsin           12           ..F.A...... inverted quarter of sine wave
     ihsin           13           ..F.A...... inverted half of sine wave
     dese            14           ..F.A...... double-exponential seat
     desi            15           ..F.A...... double-exponential sigmoid
     losi            16           ..F.A...... logistic sigmoid
     sinc            17           ..F.A...... sine cardinal function
     isinc           18           ..F.A...... inverted sine cardinal function
  c2                <int>        ..F.A...... set fade curve type for 2nd stream (from -1 to 18) (default tri)
     nofade          -1           ..F.A...... no fade; keep audio as-is
     tri             0            ..F.A...... linear slope
     qsin            1            ..F.A...... quarter of sine wave
     esin            2            ..F.A...... exponential sine wave
     hsin            3            ..F.A...... half of sine wave
     log             4            ..F.A...... logarithmic
     ipar            5            ..F.A...... inverted parabola
     qua             6            ..F.A...... quadratic
     cub             7            ..F.A...... cubic
     squ             8            ..F.A...... square root
     cbr             9            ..F.A...... cubic root
     par             10           ..F.A...... parabola
     exp             11           ..F.A...... exponential
     iqsin           12           ..F.A...... inverted quarter of sine wave
     ihsin           13           ..F.A...... inverted half of sine wave
     dese            14           ..F.A...... double-exponential seat
     desi            15           ..F.A...... double-exponential sigmoid
     losi            16           ..F.A...... logistic sigmoid
     sinc            17           ..F.A...... sine cardinal function
     isinc           18           ..F.A...... inverted sine cardinal function
 */

using FFmpegArgs.Cores.Maps;
using System;

namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... acrossfade        AA->A      Cross fade two input audio streams.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#acrossfade
    /// </summary>
    public class AcrossfadeFilter : AudioToAudioFilter
    {
        internal AcrossfadeFilter(params AudioMap[] audioMaps) : base("acrossfade", audioMaps)
        {
            AddMapOut();
        }

        /// <summary>
        /// Specify the number of samples for which the cross fade effect has to last.<br>
        /// </br> At the end of the cross fade effect the first input audio will be completely silent.<br>
        /// </br> (from 1 to 2.14748e+08) (default 44100)
        /// </summary>
        /// <param name="ns"></param>
        /// <returns></returns>
        public AcrossfadeFilter NbSamples(int ns)
          => this.SetOptionRange("ns", ns, 1, 2.14748e+08);

        /// <summary>
        /// Specify the duration of the cross fade effect.<br>
        /// </br> By default the duration is determined by nb_samples.<br>
        /// </br> If set this option is used instead of nb_samples.
        /// </summary>
        /// <param name="d">total seconds</param>
        /// <returns></returns>
        public AcrossfadeFilter Duration(TimeSpan d)
          => this.SetOptionRange("d", d, TimeSpan.Zero, TimeSpan.MaxValue);

        /// <summary>
        /// Should first stream end overlap with second stream start. Default is enabled.
        /// </summary>
        /// <param name="overlap"></param>
        /// <returns></returns>
        public AcrossfadeFilter Overlap(bool overlap)
          => this.SetOption("o", overlap.ToFFmpegFlag());

        /// <summary>
        /// Set curve for cross fade transition for first stream.
        /// </summary>
        /// <param name="overlap"></param>
        /// <returns></returns>
        public AcrossfadeFilter Curve1(AcrossfadeCurve curve)
          => this.SetOption("c1", curve.ToString());

        /// <summary>
        /// Set curve for cross fade transition for second stream.
        /// </summary>
        /// <param name="overlap"></param>
        /// <returns></returns>
        public AcrossfadeFilter Curve2(AcrossfadeCurve curve)
          => this.SetOption("c2", curve.ToString());
    }

    public static class AcrossfadeFilterExtension
    {
        /// <summary>
        /// Apply cross fade from one input audio stream to another input audio stream.<br>
        /// </br> The cross fade is applied for specified duration near the end of first stream.
        /// </summary>
        /// <returns></returns>
        public static AcrossfadeFilter AcrossfadeFilter(this AudioMap first, AudioMap second)
            => new AcrossfadeFilter(first, second);
    }

    public enum AcrossfadeCurve
    {
        /// <summary>
        /// no fade; keep audio as-is
        /// </summary>
        nofad = -1,
        /// <summary>
        /// linear slope
        /// </summary>
        tri,
        /// <summary>
        /// quarter of sine wave
        /// </summary>
        qsin,
        /// <summary>
        /// exponential sine wave
        /// </summary>
        esin,
        /// <summary>
        /// half of sine wave
        /// </summary>
        hsin,
        /// <summary>
        /// logarithmic
        /// </summary>
        log,
        /// <summary>
        /// inverted parabola
        /// </summary>
        ipar,
        /// <summary>
        /// quadratic
        /// </summary>
        qua,
        /// <summary>
        /// cubic
        /// </summary>
        cub,
        /// <summary>
        /// square root
        /// </summary>
        squ,
        /// <summary>
        /// cubic root
        /// </summary>
        cbr,
        /// <summary>
        /// parabola
        /// </summary>
        par,
        /// <summary>
        /// exponential
        /// </summary>
        exp,
        /// <summary>
        /// inverted quarter of sine wave
        /// </summary>
        iqsin,
        /// <summary>
        /// inverted half of sine wave
        /// </summary>
        ihsin,
        /// <summary>
        /// double-exponential seat
        /// </summary>
        dese,
        /// <summary>
        /// double-exponential sigmoid
        /// </summary>
        desi,
        /// <summary>
        /// logistic sigmoid
        /// </summary>
        losi,
        /// <summary>
        /// sine cardinal function
        /// </summary>
        sinc,
        /// <summary>
        /// inverted sine cardinal function
        /// </summary>
        isinc
    }
}
