/*
lowshelf AVOptions:
  frequency         <double>     ..F.A....T. set central frequency (from 0 to 999999) (default 100)
  f                 <double>     ..F.A....T. set central frequency (from 0 to 999999) (default 100)
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
  width             <double>     ..F.A....T. set shelf transition steep (from 0 to 99999) (default 0.5)
  w                 <double>     ..F.A....T. set shelf transition steep (from 0 to 99999) (default 0.5)
  gain              <double>     ..F.A....T. set gain (from -900 to 900) (default 0)
  g                 <double>     ..F.A....T. set gain (from -900 to 900) (default 0)
  poles             <int>        ..F.A...... set number of poles (from 1 to 2) (default 2)
  p                 <int>        ..F.A...... set number of poles (from 1 to 2) (default 2)
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
    /// TSC lowshelf          A->A       Apply a low shelf filter.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#bass_002c-lowshelf"/>
    /// </summary>
    public class LowshelfFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport,
        IPrecision, ITransform, INormalize, IChannels, IWidthType
    {
        internal LowshelfFilter(AudioMap audioMap) : base("lowshelf", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the filter’s central frequency and so can be used to extend or reduce the frequency range to be boosted or cut.<br>
        /// </br> (from 0 to 999999) (default 100)
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public LowshelfFilter Frequency(double frequency)
            => this.SetOptionRange("f", frequency, 0, 999999);

        /// <summary>
        /// Determine how steep is the filter’s shelf transition. (from 0 to 99999) (default 0.5)
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public LowshelfFilter Width(double width)
           => this.SetOptionRange("w", width, 0, 99999);
        /// <summary>
        /// Give the gain at 0 Hz. Its useful range is about -20 (for a large cut) to +20 (for a large boost). Beware of clipping when using a positive gain.<br>
        /// </br>(from -900 to 900) (default 0)
        /// </summary>
        /// <param name="gain"></param>
        /// <returns></returns>
        public LowshelfFilter Gain(double gain)
           => this.SetOptionRange("g", gain, -900, 900);
        /// <summary>
        /// Set number of poles. (from 1 to 2) (default 2)
        /// </summary>
        /// <param name="poles"></param>
        /// <returns></returns>
        public LowshelfFilter Poles(int poles)
           => this.SetOptionRange("p", poles, 1, 2);

        /// <summary>
        /// How much to use filtered signal in output. (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public LowshelfFilter Mix(double mix)
           => this.SetOptionRange("m", mix, 0, 1);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class LowshelfFilterExtensions
    {
        /// <summary>
        /// Boost or cut the bass (lower) frequencies of the audio using a two-pole shelving filter with a response similar to that of a standard hi-fi’s tone-controls. This is also known as shelving equalisation (EQ).<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#bass_002c-lowshelf"/>
        /// </summary>
        public static LowshelfFilter LowshelfFilter(this AudioMap audioMap)
          => new LowshelfFilter(audioMap);
    }
}
