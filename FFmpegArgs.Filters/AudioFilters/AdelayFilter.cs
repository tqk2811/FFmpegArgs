/*
adelay AVOptions:
  delays            <string>     ..F.A...... set list of delays for each channel
  all               <boolean>    ..F.A...... use last available delay for remained channels (default false)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// T.. adelay            A->A       Delay one or more audio channels.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#adelay
    /// </summary>
    public class AdelayFilter : AudioToAudioFilter, ITimelineSupport
    {
        internal AdelayFilter(AudioMap audioMap) : base("adelay", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set list of delays in milliseconds for each channel. Unused delays will be silently ignored. If number of given delays is smaller than number of channels all remaining channels will not be delayed.
        /// </summary>
        /// <param name="delays"></param>
        /// <returns></returns>
        public AdelayFilter Delays(params TimeSpan[] delays)
            => this.SetOption("delays", string.Join("|", delays.Select(x => x.TotalSeconds.ToString())));

        /// <summary>
        /// Set list of delays in milliseconds for each channel. Unused delays will be silently ignored. If number of given delays is smaller than number of channels all remaining channels will not be delayed.<br>
        /// </br>If you want to delay exact number of samples, append ’S’ to number. If you want instead to delay in seconds, append ’s’ to number.
        /// </summary>
        /// <param name="delays"></param>
        /// <returns></returns>
        public AdelayFilter Delays(params string[] delays)
            => this.SetOption("delays", string.Join("|", delays));


        /// <summary>
        /// Use last set delay for all remaining channels. By default is disabled. This option if enabled changes how option delays is interpreted.
        /// </summary>
        /// <param name="all"></param>
        /// <returns></returns>
        public AdelayFilter All(bool all)
            => this.SetOption("all", all.ToFFmpegFlag());

    }
    /// <summary>
    /// 
    /// </summary>
    public static class AdelayFilterExtensions
    {
        /// <summary>
        /// Delay one or more audio channels.<br>
        /// </br>Samples in delayed channel are filled with silence.
        /// </summary>
        public static AdelayFilter AdelayFilter(this AudioMap audioMap)
          => new AdelayFilter(audioMap);
    }
}
