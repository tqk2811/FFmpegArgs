/*
crystalizer AVOptions:
  i                 <float>      ..F.A....T. set intensity (from -10 to 10) (default 2)
  c                 <boolean>    ..F.A....T. enable clipping (default true)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC crystalizer       A->A       Simple audio noise sharpening filter.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#crystalizer"/>
    /// </summary>
    public class CrystalizerFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal CrystalizerFilter(AudioMap audioMap) : base("crystalizer", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Sets the intensity of effect (default: 2.0). Must be in range between -10.0 to 0 (unchanged sound) to 10.0 (maximum effect). To inverse filtering use negative value.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public CrystalizerFilter Intensity(float i)
            => this.SetOptionRange("i", i, -10, 10);

        /// <summary>
        /// Enable clipping (default: true)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public CrystalizerFilter Clipping(bool c)
            => this.SetOption("c", c.ToFFmpegFlag());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class CrystalizerFilterExtensions
    {
        /// <summary>
        /// Simple algorithm for audio noise sharpening.<br>
        /// </br>This filter linearly increases differences betweeen each audio sample.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#crystalizer"/>
        /// </summary>
        public static CrystalizerFilter CrystalizerFilter(this AudioMap audioMap)
          => new CrystalizerFilter(audioMap);
    }
}
