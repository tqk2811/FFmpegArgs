/*
 */
namespace FFmpegArgs.Filters.AudioSources
{
    /// <summary>
    /// <br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#flite
    /// </summary>
    public class FliteFilter : SourceAudioFilter
    {
        internal FliteFilter(IAudioFilterGraph filterGraph) : base("flite", filterGraph)
        {
            AddMapOut();
        }
        /// <summary>
        /// If set to 1, list the names of the available voices and exit immediately. Default value is 0.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public FliteFilter ListVoices(bool flag)
          => this.SetOption("list_voices", flag.ToFFmpegFlag());
        /// <summary>
        /// Set the maximum number of samples per frame. Default value is 512.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public FliteFilter NbSamples(int n)
          => this.SetOptionRange("n", n, 0, int.MaxValue);
        /// <summary>
        /// Set the filename containing the text to speak.
        /// </summary>
        /// <param name="textFilePath"></param>
        /// <returns></returns>
        public FliteFilter TextFile(string textFilePath)
          => this.SetOption("textfile", textFilePath);
        /// <summary>
        /// Set the text to speak.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public FliteFilter Text(string text)
          => this.SetOption("text", text);
        /// <summary>
        /// Set the voice to use for the speech synthesis. Default value is kal. See also the list_voices option.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public FliteFilter Voice(string v)
          => this.SetOption("v", v);
    }

    /// <summary>
    /// 
    /// </summary>
    public static class FliteFilterExtensions
    {
        /// <summary>
        /// Synthesize a voice utterance using the libflite library.<br></br>
        /// To enable compilation of this filter you need to configure FFmpeg with --enable-libflite.<br></br>
        /// Note that versions of the flite library prior to 2.0 are not thread-safe.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static FliteFilter FliteFilter(this IAudioFilterGraph filterGraph)
          => new FliteFilter(filterGraph);
    }
}
