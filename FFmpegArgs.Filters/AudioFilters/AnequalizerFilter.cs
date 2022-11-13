/*
anequalizer AVOptions:
  params            <string>     ..F.A...... (default "")
  curves            <boolean>    ..FV....... draw frequency response curves (default false)
  size              <image_size> ..FV....... set video size (default "hd720")
  mgain             <double>     ..FV....... set max gain (from -900 to 900) (default 60)
  fscale            <int>        ..FV....... set frequency scale (from 0 to 1) (default log)
     lin             0            ..FV....... linear
     log             1            ..FV....... logarithmic
  colors            <string>     ..FV....... set channels curves colors (default "red|green|blue|yellow|orange|lime|pink|magenta|brown")
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC anequalizer       A->N       Apply high-order audio parametric multi band equalizer.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#anequalizer"/>
    /// </summary>
    public class AnequalizerFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AnequalizerFilter(AudioMap audioMap) : base("anequalizer", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// This option string is in format: "cchn f=cf w=w g=g t=f | ..." Each equalizer band is separated by ’|’.<br>
        /// </br>For more infomation: https://ffmpeg.org/ffmpeg-filters.html#anequalizer
        /// </summary>
        /// <param name="params"></param>
        /// <returns></returns>
        public AnequalizerFilter Params(string @params)
            => this.SetOption("params", @params);

        /// <summary>
        /// With this option activated frequency response of anequalizer is displayed in video stream. (default false)
        /// </summary>
        /// <param name="curves"></param>
        /// <returns></returns>
        public AnequalizerFilter Curves(bool curves)
            => this.SetOption("curves", curves.ToFFmpegFlag());

        /// <summary>
        /// Set video stream size. Only useful if curves option is activated. (default "hd720")
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public AnequalizerFilter Size(VideoSizeUtils size)
            => this.SetOption("size", size.GetEnumAttribute<NameAttribute>().Name);

        /// <summary>
        /// Set video stream size. Only useful if curves option is activated. (default "hd720")
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public AnequalizerFilter Size(Size size)
            => this.SetOption("size", $"{size.Width}x{size.Height}");

        /// <summary>
        /// Set max gain that will be displayed. Only useful if curves option is activated. Setting this to a reasonable value makes it possible to display gain which is derived from neighbour bands which are too close to each other and thus produce higher gain when both are activated.<br>
        /// </br>(from -900 to 900) (default 60)
        /// </summary>
        /// <param name="mgain"></param>
        /// <returns></returns>
        public AnequalizerFilter Mgain(double mgain)
            => this.SetOptionRange("mgain", mgain, -900, 900);

        /// <summary>
        /// Set frequency scale used to draw frequency response in video output. Can be linear or logarithmic. Default is logarithmic.
        /// </summary>
        /// <param name="fscale"></param>
        /// <returns></returns>
        public AnequalizerFilter Fscale(AnequalizerFscale fscale)
            => this.SetOption("fscale", fscale);

        /// <summary>
        /// Set color for each channel curve which is going to be displayed in video stream. This is list of color names separated by space or by ’|’. Unrecognised or missing colors will be replaced by white color.<br>
        /// </br>(default "red|green|blue|yellow|orange|lime|pink|magenta|brown")
        /// </summary>
        /// <param name="colors"></param>
        /// <returns></returns>
        public AnequalizerFilter Colors(string colors)
            => this.SetOption("colors", colors);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AnequalizerFilterExtensions
    {
        /// <summary>
        /// High-order parametric multiband equalizer for each channel.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#anequalizer"/>
        /// </summary>
        public static AnequalizerFilter AnequalizerFilter(this AudioMap audioMap)
          => new AnequalizerFilter(audioMap);
    }

    /// <summary>
    /// set frequency scale
    /// </summary>
    public enum AnequalizerFscale
    {
        /// <summary>
        /// linear
        /// </summary>
        lin,
        /// <summary>
        /// logarithmic
        /// </summary>
        log
    }
}
