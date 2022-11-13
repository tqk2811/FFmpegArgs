/*
atempo AVOptions:
  tempo             <double>     ..F.A....T. set tempo scale factor (from 0.5 to 100) (default 1)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ..C atempo            A->A       Adjust audio tempo.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#atempo"/>
    /// </summary>
    public class AtempoFilter : AudioToAudioFilter, ICommandSupport
    {
        internal AtempoFilter(AudioMap audioMap) : base("atempo", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// set tempo scale factor (from 0.5 to 100) (default 1)
        /// </summary>
        /// <param name="tempo"></param>
        /// <returns></returns>
        public AtempoFilter Tempo(double tempo)
            => this.SetOptionRange("tempo", tempo, 0.5, 100);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class AtempoFilterExtensions
    {
        /// <summary>
        /// Adjust audio tempo.<br>
        /// </br>The filter accepts exactly one parameter, the audio tempo.If not specified then the filter will assume nominal 1.0 tempo.Tempo must be in the[0.5, 100.0] range.<br>
        /// </br>Note that tempo greater than 2 will skip some samples rather than blend them in. If for any reason this is a concern it is always possible to daisy-chain several instances of atempo to achieve the desired product tempo.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#atempo"/>
        /// </summary>
        public static AtempoFilter AtempoFilter(this AudioMap audioMap)
          => new AtempoFilter(audioMap);
    }
}
