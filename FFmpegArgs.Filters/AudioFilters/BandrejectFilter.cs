﻿/*
bandreject AVOptions:
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
    /// TSC bandreject        A->A       Apply a two-pole Butterworth band-reject filter.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#bandreject
    /// </summary>
    public class BandrejectFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport,
        IWidthType, ITransform, IPrecision, INormalize, IChannels, IFrequency
    {
        internal BandrejectFilter(AudioMap audioMap) : base("bandreject", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// set band-width (from 0 to 99999) (default 0.5)
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public BandrejectFilter Width(double width)
            => this.SetOptionRange("w", width, 0, 99999);

        /// <summary>
        /// How much to use filtered signal in output. Default is 1. Range is between 0 and 1.
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public BandrejectFilter Mix(double mix)
            => this.SetOptionRange("m", mix, 0, 1);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class BandrejectFilterExtensions
    {
        /// <summary>
        /// Apply a two-pole Butterworth band-reject filter with central frequency frequency, and (3dB-point) band-width width. The filter roll off at 6dB per octave (20dB per decade).
        /// </summary>
        public static BandrejectFilter BandrejectFilter(this AudioMap audioMap)
          => new BandrejectFilter(audioMap);
    }
}
