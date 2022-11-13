/*
anullsrc AVOptions:
  channel_layout    <string>     ..F.A...... set channel_layout (default "stereo")
  cl                <string>     ..F.A...... set channel_layout (default "stereo")
  sample_rate       <string>     ..F.A...... set sample rate (default "44100")
  r                 <string>     ..F.A...... set sample rate (default "44100")
  nb_samples        <int>        ..F.A...... set the number of samples per requested frame (from 1 to 65535) (default 1024)
  n                 <int>        ..F.A...... set the number of samples per requested frame (from 1 to 65535) (default 1024)
  duration          <duration>   ..F.A...... set the audio duration (default -0.000001)
  d                 <duration>   ..F.A...... set the audio duration (default -0.000001)
 */
namespace FFmpegArgs.Filters.AudioSources
{
    /// <summary>
    /// ... anullsrc          |->A       Null audio source, return empty audio frames.<br>
    /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#anullsrc"/>
    /// </summary>
    public class AnullsrcFilter : SourceAudioFilter
    {
        internal AnullsrcFilter(IAudioFilterGraph filterGraph) : base("anullsrc", filterGraph)
        {
            AddMapOut();
        }
        /// <summary>
        /// Specifies the channel layout, and can be either an integer or a string representing a channel layout. The default value of channel_layout is "stereo".
        /// Check the channel_layout_map definition in libavutil/channel_layout.c for the mapping between strings and channel layout values.
        /// </summary>
        /// <param name="channel_layout"></param>
        /// <returns></returns>
        public AnullsrcFilter ChannelLayout(ChannelLayout channel_layout)
          => this.SetOption("cl", channel_layout.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        /// Specifies the sample rate, and defaults to 44100.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public AnullsrcFilter SampleRate(int r)
          => this.SetOptionRange("r", r, 0, int.MaxValue);
        /// <summary>
        /// Set the number of samples per requested frames. (from 1 to 65535) (default 1024)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public AnullsrcFilter NbSamples(int n)
          => this.SetOptionRange("n", n, 1, 65535);
        /// <summary>
        /// Set the duration of the sourced audio<br></br>
        /// If not specified, or the expressed duration is negative, the audio is supposed to be generated forever.
        /// <br></br>(default -0.000001)
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public AnullsrcFilter Duration(TimeSpan d)
          => this.SetOptionRange("d", d, TimeSpan.MinValue, TimeSpan.MaxValue);
    }

    /// <summary>
    /// 
    /// </summary>
    public static class AnullsrcFilterExtensions
    {
        /// <summary>
        /// The null audio source, return unprocessed audio frames.<br>
        /// </br> It is mainly useful as a template and to be employed in analysis / debugging tools, or as the source for filters which ignore the input data (for example the sox synth filter).
        /// <br></br><see href="https://ffmpeg.org/ffmpeg-filters.html#anullsrc"/>
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static AnullsrcFilter AnullsrcFilter(this IAudioFilterGraph filterGraph)
          => new AnullsrcFilter(filterGraph);
    }
}
