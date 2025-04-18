/*
equalizer AVOptions:
   frequency         <double>     ..F.A....T. set central frequency (from 0 to 999999) (default 0)
   f                 <double>     ..F.A....T. set central frequency (from 0 to 999999) (default 0)
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
   width             <double>     ..F.A....T. set band-width (from 0 to 99999) (default 1)
   w                 <double>     ..F.A....T. set band-width (from 0 to 99999) (default 1)
   gain              <double>     ..F.A....T. set gain (from -900 to 900) (default 0)
   g                 <double>     ..F.A....T. set gain (from -900 to 900) (default 0)
   mix               <double>     ..F.A....T. set mix (from 0 to 1) (default 1)
   m                 <double>     ..F.A....T. set mix (from 0 to 1) (default 1)
   channels          <channel_layout> ..F.A....T. set channels to filter (default 0xffffffffffffffff)
   c                 <channel_layout> ..F.A....T. set channels to filter (default 0xffffffffffffffff)
   normalize         <boolean>    ..F.A....T. normalize coefficients (default false)
   n                 <boolean>    ..F.A....T. normalize coefficients (default false)
   transform         <int>        ..F.A...... set transform type (from 0 to 4) (default di)
     di              0            ..F.A...... direct form I
     dii             1            ..F.A...... direct form II
     tdii            2            ..F.A...... transposed direct form II
     latt            3            ..F.A...... lattice-ladder form
     svf             4            ..F.A...... state variable filter form
   a                 <int>        ..F.A...... set transform type (from 0 to 4) (default di)
     di              0            ..F.A...... direct form I
     dii             1            ..F.A...... direct form II
     tdii            2            ..F.A...... transposed direct form II
     latt            3            ..F.A...... lattice-ladder form
     svf             4            ..F.A...... state variable filter form
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
    /// TSC equalizer         A->A       Apply two-pole peaking equalization (EQ) filter.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#equalizer
    /// </summary>
    public class EqualizerFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport,
        IWidthType, ITransform, IPrecision
    {
        internal EqualizerFilter(AudioMap audioMap) : base("equalizer", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the filter’s central frequency in Hz. (from 0 to 999999) (default 0)
        /// </summary>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public EqualizerFilter Frequency(double frequency)
            => this.SetOptionRange("f", frequency, 0, 999999);
        /// <summary>
        /// Specify the band-width of a filter in width_type units. (from 0 to 99999) (default 1)
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public EqualizerFilter Width(double width)
            => this.SetOptionRange("w", width, 0, 99999);
        /// <summary>
        /// Set the required gain or attenuation in dB. Beware of clipping when using a positive gain. (from -900 to 900) (default 0)
        /// </summary>
        /// <param name="gain"></param>
        /// <returns></returns>
        public EqualizerFilter Gain(double gain)
            => this.SetOptionRange("g", gain, -900, 900);
        /// <summary>
        /// How much to use filtered signal in output. Default is 1. Range is between 0 and 1.
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public EqualizerFilter Mix(double mix)
            => this.SetOptionRange("m", mix, 0, 1);
        /// <summary>
        /// Specify which channels to filter, by default all available are filtered.
        /// </summary>
        /// <param name="channels"></param>
        /// <returns></returns>
        public EqualizerFilter Channels(ChannelLayout channels)
            => this.SetOption("c", (int)channels);
        /// <summary>
        /// Normalize biquad coefficients, by default is disabled. Enabling it will normalize magnitude response at DC to 0dB.
        /// </summary>
        /// <param name="normalize"></param>
        /// <returns></returns>
        public EqualizerFilter Normalize(bool normalize)
            => this.SetOption("n", normalize.ToFFmpegFlag());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class EqualizerFilterExtensions
    {
        /// <summary>
        /// Apply a two-pole peaking equalisation (EQ) filter. With this filter, the signal-level at and around a selected frequency can be increased or decreased, whilst (unlike bandpass and bandreject filters) that at all other frequencies is unchanged.<br>
        /// </br>In order to produce complex equalisation curves, this filter can be given several times, each with a different central frequency.
        /// </summary>
        public static EqualizerFilter EqualizerFilter(this AudioMap audioMap)
          => new EqualizerFilter(audioMap);
    }
}
