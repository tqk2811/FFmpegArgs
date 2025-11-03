namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. aformat           A-&gt;A       Convert the input audio to one of the specified formats.
    /// </summary>
    public class AformatFilterGen : AudioToAudioFilter
    {
        internal AformatFilterGen(AudioMap input) : base("aformat", input)
        {
            AddMapOut();
        }
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert the input audio to one of the specified formats.
        /// </summary>
        public static AformatFilterGen AformatFilterGen(this AudioMap input0) => new AformatFilterGen(input0);
    }
}