/*
bandpass AVOptions:
  frequency         <double>     ..F.A....T. set central frequency (from 0 to 999999) (default 3000)
  f                 <double>     ..F.A....T. set central frequency (from 0 to 999999) (default 3000)
  width_type        <int>        ..F.A....T. set filter-width type (from 1 to 5) (default q)
     h               1            ..F.A....T. Hz
     q               3            ..F.A....T. Q-Factor
     o               2            ..F.A....T. octave
     s               4            ..F.A....T. slope
     k               5            ..F.A....T. kHz
  t                 <int>        ..F.A....T. set filter-width type (from 1 to 5) (default q)
     h               1            ..F.A....T. Hz
     q               3            ..F.A....T. Q-Factor
     o               2            ..F.A....T. octave
     s               4            ..F.A....T. slope
     k               5            ..F.A....T. kHz
  width             <double>     ..F.A....T. set band-width (from 0 to 99999) (default 0.5)
  w                 <double>     ..F.A....T. set band-width (from 0 to 99999) (default 0.5)
  csg               <boolean>    ..F.A....T. use constant skirt gain (default false)
  mix               <double>     ..F.A....T. set mix (from 0 to 1) (default 1)
  m                 <double>     ..F.A....T. set mix (from 0 to 1) (default 1)
  channels          <channel_layout> ..F.A....T. set channels to filter (default 0xffffffffffffffff)
  c                 <channel_layout> ..F.A....T. set channels to filter (default 0xffffffffffffffff)
  normalize         <boolean>    ..F.A....T. normalize coefficients (default false)
  n                 <boolean>    ..F.A....T. normalize coefficients (default false)
  transform         <int>        ..F.A...... set transform type (from 0 to 3) (default di)
     di              0            ..F.A...... direct form I
     dii             1            ..F.A...... direct form II
     tdii            2            ..F.A...... transposed direct form II
     latt            3            ..F.A...... lattice-ladder form
  a                 <int>        ..F.A...... set transform type (from 0 to 3) (default di)
     di              0            ..F.A...... direct form I
     dii             1            ..F.A...... direct form II
     tdii            2            ..F.A...... transposed direct form II
     latt            3            ..F.A...... lattice-ladder form
  precision         <int>        ..F.A...... set filtering precision (from -1 to 3) (default auto)
     auto            -1           ..F.A...... automatic
     s16             0            ..F.A...... signed 16-bit
     s32             1            ..F.A...... signed 32-bit
     f32             2            ..F.A...... floating-point single
     f64             3            ..F.A...... floating-point double
  r                 <int>        ..F.A...... set filtering precision (from -1 to 3) (default auto)
     auto            -1           ..F.A...... automatic
     s16             0            ..F.A...... signed 16-bit
     s32             1            ..F.A...... signed 32-bit
     f32             2            ..F.A...... floating-point single
     f64             3            ..F.A...... floating-point double
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC bandpass          A->A       Apply a two-pole Butterworth band-pass filter.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#bandpass
    /// </summary>
    public class BandpassFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal BandpassFilter(AudioMap audioMap) : base("bandpass", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// set central frequency (from 0 to 999999) (default 3000)
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public BandpassFilter Frequency(double frequency)
            => this.SetOptionRange("f", frequency, 0, 999999);

        /// <summary>
        /// set filter-width type (from 1 to 5) (default q)
        /// </summary>
        /// <param name="widthType"></param>
        /// <returns></returns>
        public BandpassFilter WidthType(BandpassWidthType widthType)
            => this.SetOption("t", widthType);

        /// <summary>
        /// set band-width (from 0 to 99999) (default 0.5)
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public BandpassFilter Width(double width)
            => this.SetOptionRange("w", width, 0, 99999);

        /// <summary>
        /// use constant skirt gain (default false)
        /// </summary>
        /// <param name="csg"></param>
        /// <returns></returns>
        public BandpassFilter Csg(bool csg)
            => this.SetOption("csg", csg.ToFFmpegFlag());

        /// <summary>
        /// How much to use filtered signal in output. Default is 1. Range is between 0 and 1.
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public BandpassFilter Mix(double mix)
            => this.SetOptionRange("m", mix, 0, 1);

        /// <summary>
        /// set channels to filter (default 0xffffffffffffffff)
        /// </summary>
        /// <param name="channels"></param>
        /// <returns></returns>
        public BandpassFilter Channels(ChannelLayout channels)
            => this.SetOption("c", channels.GetEnumAttribute<NameAttribute>().Name);

        /// <summary>
        /// Normalize biquad coefficients, by default is disabled. Enabling it will normalize magnitude response at DC to 0dB.
        /// </summary>
        /// <param name="normalize"></param>
        /// <returns></returns>
        public BandpassFilter Normalize(bool normalize)
            => this.SetOption("n", normalize.ToFFmpegFlag());
        /// <summary>
        /// Set transform type of IIR filter. (default di)
        /// </summary>
        /// <param name="transform"></param>
        /// <returns></returns>
        public BandpassFilter Transform(BandpassTransform transform)
            => this.SetOption("a", transform);
        /// <summary>
        /// set filtering precision (default auto)
        /// </summary>
        /// <param name="precision"></param>
        /// <returns></returns>
        public BandpassFilter Precision(BandpassPrecision precision)
            => this.SetOption("r", precision);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class BandpassFilterExtensions
    {
        /// <summary>
        /// Apply a two-pole Butterworth band-pass filter with central frequency frequency, and (3dB-point) band-width width. The csg option selects a constant skirt gain (peak gain = Q) instead of the default: constant 0dB peak gain. The filter roll off at 6dB per octave (20dB per decade).
        /// </summary>
        public static BandpassFilter BandpassFilter(this AudioMap audioMap)
          => new BandpassFilter(audioMap);
    }

    /// <summary>
    /// 
    /// </summary>
    public enum BandpassWidthType
    {
        /// <summary>
        /// Hz
        /// </summary>
        h,
        /// <summary>
        /// Q-Factor
        /// </summary>
        q,
        /// <summary>
        /// octave
        /// </summary>
        o,
        /// <summary>
        /// slope
        /// </summary>
        s,
        /// <summary>
        /// kHz
        /// </summary>
        k,

    }
    /// <summary>
    /// 
    /// </summary>
    public enum BandpassTransform
    {
        /// <summary>
        /// direct form I
        /// </summary>
        di,
        /// <summary>
        /// direct form II
        /// </summary>
        dii,
        /// <summary>
        /// transposed direct form II
        /// </summary>
        tdii,
        /// <summary>
        /// lattice-ladder form
        /// </summary>
        latt

    }

    /// <summary>
    /// 
    /// </summary>
    public enum BandpassPrecision
    {
        /// <summary>
        /// automatic
        /// </summary>
        auto,
        /// <summary>
        /// signed 16-bit
        /// </summary>
        s16,
        /// <summary>
        /// signed 32-bit
        /// </summary>
        s32,
        /// <summary>
        /// floating-point single
        /// </summary>
        f32,
        /// <summary>
        /// floating-point double
        /// </summary>
        f64

    }
}
