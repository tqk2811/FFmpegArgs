/*
anoisesrc AVOptions:
  sample_rate       <int>        ..F.A...... set sample rate (from 15 to INT_MAX) (default 48000)
  r                 <int>        ..F.A...... set sample rate (from 15 to INT_MAX) (default 48000)
  amplitude         <double>     ..F.A...... set amplitude (from 0 to 1) (default 1)
  a                 <double>     ..F.A...... set amplitude (from 0 to 1) (default 1)
  duration          <duration>   ..F.A...... set duration (default 0)
  d                 <duration>   ..F.A...... set duration (default 0)
  color             <int>        ..F.A...... set noise color (from 0 to 5) (default white)
     white           0            ..F.A......
     pink            1            ..F.A......
     brown           2            ..F.A......
     blue            3            ..F.A......
     violet          4            ..F.A......
     velvet          5            ..F.A......
  colour            <int>        ..F.A...... set noise color (from 0 to 5) (default white)
     white           0            ..F.A......
     pink            1            ..F.A......
     brown           2            ..F.A......
     blue            3            ..F.A......
     violet          4            ..F.A......
     velvet          5            ..F.A......
  c                 <int>        ..F.A...... set noise color (from 0 to 5) (default white)
     white           0            ..F.A......
     pink            1            ..F.A......
     brown           2            ..F.A......
     blue            3            ..F.A......
     violet          4            ..F.A......
     velvet          5            ..F.A......
  seed              <int64>      ..F.A...... set random seed (from -1 to UINT32_MAX) (default -1)
  s                 <int64>      ..F.A...... set random seed (from -1 to UINT32_MAX) (default -1)
  nb_samples        <int>        ..F.A...... set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
  n                 <int>        ..F.A...... set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
 */
namespace FFmpegArgs.Filters.AudioSources
{
    /// <summary>
    /// ... anoisesrc         |->A       Generate a noise audio signal.<br>
    /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#anoisesrc"/>
    /// </summary>
    public class AnoisesrcFilter : SourceAudioFilter
    {
        internal AnoisesrcFilter(IAudioFilterGraph filterGraph) : base("anoisesrc", filterGraph)
        {
            AddMapOut();
        }
        /// <summary>
        /// Specify the sample rate. (from 15 to INT_MAX) (default 48000)
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public AnoisesrcFilter SampleRate(int r)
          => this.SetOptionRange("r", r, 15, INT_MAX);
        /// <summary>
        /// Specify the amplitude of the generated audio stream. (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public AnoisesrcFilter Amplitude(double a)
          => this.SetOptionRange("a", a, 0.0, 1.0);
        /// <summary>
        /// Specify the duration of the generated audio stream. Not specifying this option results in noise with an infinite length.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public AnoisesrcFilter Duration(TimeSpan d)
          => this.SetOptionRange("d", d, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Specify the color of noise. Available noise colors are white, pink, brown, blue, violet and velvet. Default color is white.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public AnoisesrcFilter Color(AnoisesrcColor c)
          => this.SetOption("c", c);
        /// <summary>
        /// Specify a value used to seed the PRNG. (from -1 to UINT32_MAX) (default -1)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public AnoisesrcFilter Seed(long s)
          => this.SetOptionRange("s", s, -1, UINT32_MAX);
        /// <summary>
        /// Set the number of samples per each output frame, (from 1 to INT_MAX) (default 1024)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public AnoisesrcFilter NbSamples(int n)
          => this.SetOptionRange("n", n, 1, INT_MAX);
    }

    /// <summary>
    /// 
    /// </summary>
    public static class AnoisesrcFilterExtensions
    {
        /// <summary>
        /// Generate a noise audio signal.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#anoisesrc"/>
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static AnoisesrcFilter AnoisesrcFilter(this IAudioFilterGraph filterGraph)
          => new AnoisesrcFilter(filterGraph);
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum AnoisesrcColor
    {
        white,
        pink,
        brown,
        blue,
        violet,
        velvet
    }
    #pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
