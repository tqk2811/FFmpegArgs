/*
aiir AVOptions:
  zeros             <string>     ..F.A...... set B/numerator/zeros/reflection coefficients (default "1+0i 1-0i")
  z                 <string>     ..F.A...... set B/numerator/zeros/reflection coefficients (default "1+0i 1-0i")
  poles             <string>     ..F.A...... set A/denominator/poles/ladder coefficients (default "1+0i 1-0i")
  p                 <string>     ..F.A...... set A/denominator/poles/ladder coefficients (default "1+0i 1-0i")
  gains             <string>     ..F.A...... set channels gains (default "1|1")
  k                 <string>     ..F.A...... set channels gains (default "1|1")
  dry               <double>     ..F.A...... set dry gain (from 0 to 1) (default 1)
  wet               <double>     ..F.A...... set wet gain (from 0 to 1) (default 1)
  format            <int>        ..F.A...... set coefficients format (from -2 to 4) (default zp)
     ll              -2           ..F.A...... lattice-ladder function
     sf              -1           ..F.A...... analog transfer function
     tf              0            ..F.A...... digital transfer function
     zp              1            ..F.A...... Z-plane zeros/poles
     pr              2            ..F.A...... Z-plane zeros/poles (polar radians)
     pd              3            ..F.A...... Z-plane zeros/poles (polar degrees)
     sp              4            ..F.A...... S-plane zeros/poles
  f                 <int>        ..F.A...... set coefficients format (from -2 to 4) (default zp)
     ll              -2           ..F.A...... lattice-ladder function
     sf              -1           ..F.A...... analog transfer function
     tf              0            ..F.A...... digital transfer function
     zp              1            ..F.A...... Z-plane zeros/poles
     pr              2            ..F.A...... Z-plane zeros/poles (polar radians)
     pd              3            ..F.A...... Z-plane zeros/poles (polar degrees)
     sp              4            ..F.A...... S-plane zeros/poles
  process           <int>        ..F.A...... set kind of processing (from 0 to 2) (default s)
     d               0            ..F.A...... direct
     s               1            ..F.A...... serial
     p               2            ..F.A...... parallel
  r                 <int>        ..F.A...... set kind of processing (from 0 to 2) (default s)
     d               0            ..F.A...... direct
     s               1            ..F.A...... serial
     p               2            ..F.A...... parallel
  precision         <int>        ..F.A...... set filtering precision (from 0 to 3) (default dbl)
     dbl             0            ..F.A...... double-precision floating-point
     flt             1            ..F.A...... single-precision floating-point
     i32             2            ..F.A...... 32-bit integers
     i16             3            ..F.A...... 16-bit integers
  e                 <int>        ..F.A...... set precision (from 0 to 3) (default dbl)
     dbl             0            ..F.A...... double-precision floating-point
     flt             1            ..F.A...... single-precision floating-point
     i32             2            ..F.A...... 32-bit integers
     i16             3            ..F.A...... 16-bit integers
  normalize         <boolean>    ..F.A...... normalize coefficients (default true)
  n                 <boolean>    ..F.A...... normalize coefficients (default true)
  mix               <double>     ..F.A...... set mix (from 0 to 1) (default 1)
  response          <boolean>    ..FV....... show IR frequency response (default false)
  channel           <int>        ..FV....... set IR channel to display frequency response (from 0 to 1024) (default 0)
  size              <image_size> ..FV....... set video size (default "hd720")
  rate              <video_rate> ..FV....... set video rate (default "25")
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    ///  .S. aiir              A->N       Apply Infinite Impulse Response filter with supplied coefficients.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#aiir
    /// </summary>
    public class AiirFilter : AudioToAudioFilter, ISliceThreading
    {
        internal AiirFilter(AudioMap audioMap) : base("aiir", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set B/numerator/zeros/reflection coefficients. (default "1+0i 1-0i")
        /// </summary>
        /// <param name="zeros"></param>
        /// <returns></returns>
        public AiirFilter Zeros(string zeros)
            => this.SetOption("z", zeros);

        /// <summary>
        /// Set A/denominator/poles/ladder coefficients. (default "1+0i 1-0i")
        /// </summary>
        /// <param name="poles"></param>
        /// <returns></returns>
        public AiirFilter Poles(string poles)
            => this.SetOption("p", poles);

        /// <summary>
        /// Set channels gains. (default "1|1")
        /// </summary>
        /// <param name="gains"></param>
        /// <returns></returns>
        public AiirFilter Gains(string gains)
            => this.SetOption("k", gains);

        /// <summary>
        /// Set dry gain. (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="dry"></param>
        /// <returns></returns>
        public AiirFilter Dry(double dry)
            => this.SetOptionRange("dry", dry, 0, 1);

        /// <summary>
        /// Set wet gain. (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="wet"></param>
        /// <returns></returns>
        public AiirFilter Wet(double wet)
            => this.SetOptionRange("wet", wet, 0, 1);

        /// <summary>
        /// Set coefficients format.  (default zp)
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public AiirFilter Format(AiirFormat format)
            => this.SetOption("f", format.ToString());

        /// <summary>
        /// Set type of processing.
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        public AiirFilter Process(AiirProcess process)
            => this.SetOption("r", process.ToString());

        /// <summary>
        /// Set filtering precision.
        /// </summary>
        /// <param name="precision"></param>
        /// <returns></returns>
        public AiirFilter Precision(AiirPrecision precision)
            => this.SetOption("e", precision.ToString());

        /// <summary>
        /// Normalize filter coefficients, by default is enabled. Enabling it will normalize magnitude response at DC to 0dB.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public AiirFilter Normalize(bool flag)
            => this.SetOption("n", flag.ToFFmpegFlag());

        /// <summary>
        /// How much to use filtered signal in output. Default is 1. Range is between 0 and 1.
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public AiirFilter Mix(double mix)
            => this.SetOptionRange("mix", mix, 0, 1);

        /// <summary>
        /// Show IR frequency response, magnitude(magenta), phase(green) and group delay(yellow) in additional video stream. By default it is disabled.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public AiirFilter Response(bool flag)
            => this.SetOption("response", flag.ToFFmpegFlag());

        /// <summary>
        /// Set for which IR channel to display frequency response. By default is first channel displayed. This option is used only when response is enabled.<br>
        /// </br> (from 0 to 1024) (default 0)
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public AiirFilter Channel(int channel)
           => this.SetOptionRange("channel", channel, 0, 1);

        /// <summary>
        /// Set video stream size. This option is used only when response is enabled. (default "hd720")
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public AiirFilter Size(Size size)
           => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));

        /// <summary>
        /// Set video stream size. This option is used only when response is enabled. (default "hd720")
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public AiirFilter Size(VideoSizeUtils size)
           => this.SetOption("size", size.GetEnumAttribute<NameAttribute>().Name);

        /// <summary>
        /// set video rate (default "25")
        /// </summary>
        /// <param name="rate"></param>
        /// <returns></returns>
        public AiirFilter Rate(Rational rate)
            => this.SetOption("rate", rate);
    }
    /// <summary>
    /// </summary>
    public static class AiirFilterExtensions
    {
        /// <summary>
        /// Apply an arbitrary Infinite Impulse Response filter.
        /// </summary>
        public static AiirFilter AiirFilter(this AudioMap audioMap)
          => new AiirFilter(audioMap);
    }

    /// <summary>
    /// Set coefficients format.
    /// </summary>
    public enum AiirFormat
    {
        /// <summary>
        /// lattice-ladder function
        /// </summary>
        ll = -2,
        /// <summary>
        /// analog transfer function
        /// </summary>
        sf,
        /// <summary>
        /// digital transfer function
        /// </summary>
        tf,
        /// <summary>
        /// Z-plane zeros/poles, cartesian (default)
        /// </summary>
        zp,
        /// <summary>
        /// Z-plane zeros/poles, polar radians
        /// </summary>
        pr,
        /// <summary>
        /// Z-plane zeros/poles, polar degrees
        /// </summary>
        pd,
        /// <summary>
        /// S-plane zeros/poles
        /// </summary>
        sp,
    }

    /// <summary>
    /// Set type of processing.
    /// </summary>
    public enum AiirProcess
    {
        /// <summary>
        /// direct processing
        /// </summary>
        d,
        /// <summary>
        /// serial processing
        /// </summary>
        s,
        /// <summary>
        /// parallel processing
        /// </summary>
        p
    }

    /// <summary>
    /// Set filtering precision.
    /// </summary>
    public enum AiirPrecision
    {
        /// <summary>
        /// double-precision floating-point (default)
        /// </summary>
        dbl,
        /// <summary>
        /// single-precision floating-point
        /// </summary>
        flt,
        /// <summary>
        /// 32-bit integers
        /// </summary>
        i32,
        /// <summary>
        /// 16-bit integers
        /// </summary>
        i16
    }
}
