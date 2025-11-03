namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. dialoguenhance    A-&gt;A       Audio Dialogue Enhancement.
    /// </summary>
    public class DialoguenhanceFilterGen : AudioToAudioFilter, ITimelineSupport
    {
        internal DialoguenhanceFilterGen(AudioMap input) : base("dialoguenhance", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set original center factor (from 0 to 1) (default 1)
        /// </summary>
        public DialoguenhanceFilterGen original(double original) => this.SetOptionRange("original", original, 0, 1);
        /// <summary>
        ///  set dialogue enhance factor (from 0 to 3) (default 1)
        /// </summary>
        public DialoguenhanceFilterGen enhance(double enhance) => this.SetOptionRange("enhance", enhance, 0, 3);
        /// <summary>
        ///  set voice detection factor (from 2 to 32) (default 2)
        /// </summary>
        public DialoguenhanceFilterGen voice(double voice) => this.SetOptionRange("voice", voice, 2, 32);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Audio Dialogue Enhancement.
        /// </summary>
        public static DialoguenhanceFilterGen DialoguenhanceFilterGen(this AudioMap input0) => new DialoguenhanceFilterGen(input0);
    }
}