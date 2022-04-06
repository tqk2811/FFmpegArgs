/*
acontrast AVOptions:
  contrast          <float>      ..F.A...... set contrast (from 0 to 100) (default 33)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    ///  ... acontrast         A->A       Simple audio dynamic range compression/expansion filter.<br></br>
    ///  https://ffmpeg.org/ffmpeg-filters.html#acontrast
    /// </summary>
    public class AcontrastFilter : AudioToAudioFilter
    {
        internal AcontrastFilter(AudioMap audioMap) : base("acontrast", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set contrast. Default is 33. Allowed range is between 0 and 100.
        /// </summary>
        /// <param name="contrast"></param>
        /// <returns></returns>
        public AcontrastFilter Contrast(float contrast)
            => this.SetOptionRange("contrast", contrast, 0, 100);
    }
    
    /// <summary>
    /// 
    /// </summary>
    public static class AcontrastFilterExtension
    {
        /// <summary>
        /// Simple audio dynamic range compression/expansion filter.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AcontrastFilter AcontrastFilter(this AudioMap audioMap)
            => new AcontrastFilter(audioMap);
    }
}
