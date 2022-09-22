/*
lv2 AVOptions:
   plugin            <string>     ..F.A...... set plugin uri
   p                 <string>     ..F.A...... set plugin uri
   controls          <string>     ..F.A...... set plugin options
   c                 <string>     ..F.A...... set plugin options
   sample_rate       <int>        ..F.A...... set sample rate (from 1 to INT_MAX) (default 44100)
   s                 <int>        ..F.A...... set sample rate (from 1 to INT_MAX) (default 44100)
   nb_samples        <int>        ..F.A...... set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
   n                 <int>        ..F.A...... set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
   duration          <duration>   ..F.A...... set audio duration (default -0.000001)
   d                 <duration>   ..F.A...... set audio duration (default -0.000001)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... lv2               N->A       Apply LV2 effect.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#lv2"/>
    /// </summary>
    public class Lv2Filter : AudioToAudioFilter
    {
        internal Lv2Filter(AudioMap audioMap) : base("lv2", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// set plugin uri
        /// </summary>
        /// <param name="plugin"></param>
        /// <returns></returns>
        public Lv2Filter Plugin(string plugin)
            => this.SetOption("p", plugin);

        /// <summary>
        /// set plugin options
        /// </summary>
        /// <param name="controls"></param>
        /// <returns></returns>
        public Lv2Filter Controls(string controls)
            => this.SetOption("c", controls);

        /// <summary>
        /// set sample rate (from 1 to INT_MAX) (default 44100)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Lv2Filter SampleRate(int s)
            => this.SetOptionRange("s", s, 1, INT_MAX);

        /// <summary>
        /// set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Lv2Filter NbSamples(int n)
            => this.SetOptionRange("n", n, 1, INT_MAX);

        /// <summary>
        /// set audio duration (default -0.000001)
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public Lv2Filter Duration(TimeSpan duration)
            => this.SetOptionRange("d", duration, TimeSpan.MinValue, TimeSpan.MaxValue);
    }

    /// <summary>
    /// 
    /// </summary>
    public static class Lv2FilterExtension
    {
        /// <summary>
        /// Load a LV2 (LADSPA Version 2) plugin.<br></br>
        /// <see href="https://ffmpeg.org/ffmpeg-filters.html#lv2"/>
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static Lv2Filter Lv2Filter(this AudioMap audioMap)
            => new Lv2Filter(audioMap);
    }
}
