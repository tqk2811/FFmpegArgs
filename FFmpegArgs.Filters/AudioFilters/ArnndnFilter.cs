/*
arnndn AVOptions:
  model             <string>     ..F.A....T. set model name
  m                 <string>     ..F.A....T. set model name
  mix               <float>      ..F.A....T. set output vs input mix (from -1 to 1) (default 1)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC arnndn            A->A       Reduce noise from speech using Recurrent Neural Networks.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#arnndn"/>
    /// </summary>
    public class ArnndnFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ArnndnFilter(AudioMap audioMap) : base("", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// set model name
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ArnndnFilter Model(string model)
            => this.SetOption("m", model);

        /// <summary>
        /// set output vs input mix (from -1 to 1) (default 1)<br>
        /// </br> Negative values are special, they set how much to keep filtered noise in the final filter output. Set this option to -1 to hear actual noise removed from input signal.
        /// </summary>
        /// <param name="mix"></param>
        /// <returns></returns>
        public ArnndnFilter Mix(float mix)
            => this.SetOptionRange("mix", mix, -1, 1);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class ArnndnFilterExtensions
    {
        /// <summary>
        /// Reduce noise from speech using Recurrent Neural Networks.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#arnndn"/>
        /// </summary>
        public static ArnndnFilter ArnndnFilter(this AudioMap audioMap)
          => new ArnndnFilter(audioMap);
    }
}
