/*
biquad AVOptions:
  a0                <double>     ..F.A....T. (from INT_MIN to INT_MAX) (default 1)
  a1                <double>     ..F.A....T. (from INT_MIN to INT_MAX) (default 0)
  a2                <double>     ..F.A....T. (from INT_MIN to INT_MAX) (default 0)
  b0                <double>     ..F.A....T. (from INT_MIN to INT_MAX) (default 0)
  b1                <double>     ..F.A....T. (from INT_MIN to INT_MAX) (default 0)
  b2                <double>     ..F.A....T. (from INT_MIN to INT_MAX) (default 0)
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
    /// TSC biquad            A->A       Apply a biquad IIR filter with the given coefficients.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#biquad
    /// </summary>
    public class BiquadFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport,
        IPrecision, ITransform, INormalize, IChannels
    {
        internal BiquadFilter(AudioMap audioMap) : base("biquad", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Change biquad parameter. (from INT_MIN to INT_MAX) (default 1)
        /// </summary>
        /// <param name="a0"></param>
        /// <returns></returns>
        public BiquadFilter A0(double a0)
            => this.SetOptionRange("a0", a0, INT_MIN,INT_MAX);
        /// <summary>
        /// Change biquad parameter. (from INT_MIN to INT_MAX) (default 1)
        /// </summary>
        /// <param name="a1"></param>
        /// <returns></returns>
        public BiquadFilter A1(double a1)
            => this.SetOptionRange("a1", a1, INT_MIN, INT_MAX);
        /// <summary>
        /// Change biquad parameter. (from INT_MIN to INT_MAX) (default 1)
        /// </summary>
        /// <param name="a2"></param>
        /// <returns></returns>
        public BiquadFilter A2(double a2)
            => this.SetOptionRange("a2", a2, INT_MIN, INT_MAX);
        /// <summary>
        /// Change biquad parameter. (from INT_MIN to INT_MAX) (default 1)
        /// </summary>
        /// <param name="b0"></param>
        /// <returns></returns>
        public BiquadFilter B0(double b0)
            => this.SetOptionRange("b0", b0, INT_MIN, INT_MAX);
        /// <summary>
        /// Change biquad parameter. (from INT_MIN to INT_MAX) (default 1)
        /// </summary>
        /// <param name="b1"></param>
        /// <returns></returns>
        public BiquadFilter B1(double b1)
            => this.SetOptionRange("b1", b1, INT_MIN, INT_MAX);
        /// <summary>
        /// Change biquad parameter. (from INT_MIN to INT_MAX) (default 1)
        /// </summary>
        /// <param name="b2"></param>
        /// <returns></returns>
        public BiquadFilter B2(double b2)
            => this.SetOptionRange("b2", b2, INT_MIN, INT_MAX);

        /// <summary>
        /// How much to use filtered signal in output. (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public BiquadFilter Mix(double mix)
           => this.SetOptionRange("m", mix, 0, 1);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class BiquadFilterExtensions
    {
        /// <summary>
        /// Apply a biquad IIR filter with the given coefficients. Where b0, b1, b2 and a0, a1, a2 are the numerator and denominator coefficients respectively. and channels, c specify which channels to filter, by default all available are filtered.
        /// </summary>
        public static BiquadFilter BiquadFilter(this AudioMap audioMap)
          => new BiquadFilter(audioMap);
    }
}
