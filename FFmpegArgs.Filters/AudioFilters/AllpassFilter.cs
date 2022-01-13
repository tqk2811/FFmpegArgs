/*
allpass AVOptions:
  frequency         <double>     ..F.A....T. set central frequency (from 0 to 999999) (default 3000)
  f                 <double>     ..F.A....T. set central frequency (from 0 to 999999) (default 3000)
  width_type        <int>        ..F.A....T. set filter-width type (from 1 to 5) (default h)
     h               1            ..F.A....T. Hz
     q               3            ..F.A....T. Q-Factor
     o               2            ..F.A....T. octave
     s               4            ..F.A....T. slope
     k               5            ..F.A....T. kHz
  t                 <int>        ..F.A....T. set filter-width type (from 1 to 5) (default h)
     h               1            ..F.A....T. Hz
     q               3            ..F.A....T. Q-Factor
     o               2            ..F.A....T. octave
     s               4            ..F.A....T. slope
     k               5            ..F.A....T. kHz
  width             <double>     ..F.A....T. set filter-width (from 0 to 99999) (default 707.1)
  w                 <double>     ..F.A....T. set filter-width (from 0 to 99999) (default 707.1)
  mix               <double>     ..F.A....T. set mix (from 0 to 1) (default 1)
  m                 <double>     ..F.A....T. set mix (from 0 to 1) (default 1)
  channels          <channel_layout> ..F.A....T. set channels to filter (default 0xffffffffffffffff)
  c                 <channel_layout> ..F.A....T. set channels to filter (default 0xffffffffffffffff)
  normalize         <boolean>    ..F.A....T. normalize coefficients (default false)
  n                 <boolean>    ..F.A....T. normalize coefficients (default false)
  order             <int>        ..F.A....T. set filter order (from 1 to 2) (default 2)
  o                 <int>        ..F.A....T. set filter order (from 1 to 2) (default 2)
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
    ///  TSC allpass           A->A       Apply a two-pole all-pass filter.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#allpass
    /// </summary>
    public class AllpassFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AllpassFilter(AudioMap audioMap) : base("allpass", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set frequency in Hz. (from 0 to 999999) (default 3000)
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public AllpassFilter Frequency(double frequency)
            => this.SetOptionRange("f", frequency, 0, 999999);

        /// <summary>
        /// Set method to specify band-width of filter.
        /// </summary>
        /// <param name="widthType"></param>
        /// <returns></returns>
        public AllpassFilter WidthType(AllpassWidthType widthType)
            => this.SetOption("t", widthType);

        /// <summary>
        /// Specify the band-width of a filter in width_type units. (from 0 to 99999) (default 707.1)
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public AllpassFilter Width(double width)
            => this.SetOptionRange("w", width, 0, 99999);

        /// <summary>
        /// How much to use filtered signal in output. (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public AllpassFilter Mix(double mix)
            => this.SetOptionRange("m", mix, 0, 1);

        /// <summary>
        /// Specify which channels to filter, by default all available are filtered.
        /// </summary>
        /// <param name="channels"></param>
        /// <returns></returns>
        public AllpassFilter Channels(ChannelLayout channels)
            => this.SetOption("c", channels.GetEnumAttribute<NameAttribute>().Name);

        /// <summary>
        /// Normalize biquad coefficients, by default is disabled. Enabling it will normalize magnitude response at DC to 0dB.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public AllpassFilter Normalize(bool flag)
            => this.SetOption("n", flag.ToFFmpegFlag());

        /// <summary>
        /// Set the filter order (from 1 to 2) (default 2)
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public AllpassFilter Order(int order)
            => this.SetOptionRange("o", order, 1, 2);

        /// <summary>
        /// Set transform type of IIR filter.
        /// </summary>
        /// <param name="transform"></param>
        /// <returns></returns>
        public AllpassFilter Transform(AllpassTransform transform)
            => this.SetOption("a", transform);

        /// <summary>
        /// Set precison of filtering.
        /// </summary>
        /// <param name="precision"></param>
        /// <returns></returns>
        public AllpassFilter Precision(AllpassPrecision precision)
            => this.SetOption("r", precision);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class AllpassFilterExtensions
    {
        /// <summary>
        /// Apply a two-pole all-pass filter with central frequency (in Hz) frequency, and filter-width width. An all-pass filter changes the audio’s frequency to phase relationship without changing its frequency to amplitude relationship.
        /// </summary>
        public static AllpassFilter AllpassFilter(this AudioMap audioMap)
          => new AllpassFilter(audioMap);
    }

    /// <summary>
    /// set filter-width type
    /// </summary>
    public enum AllpassWidthType
    {
        /// <summary>
        /// Hz (default)
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
        k
    }

    /// <summary>
    /// set transform type
    /// </summary>
    public enum AllpassTransform
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
    /// set filtering precision
    /// </summary>
    public enum AllpassPrecision
    {
        /// <summary>
        /// automatic (default)
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
