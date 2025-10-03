namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... superequalizer    A-&gt;A       Apply 18 band equalization filter.
    /// </summary>
    public class SuperequalizerFilterGen : AudioToAudioFilter
    {
        internal SuperequalizerFilterGen(AudioMap input) : base("superequalizer", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set 65Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _1b(float _1b) => this.SetOptionRange("1b", _1b, 0, 20);
        /// <summary>
        ///  set 92Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _2b(float _2b) => this.SetOptionRange("2b", _2b, 0, 20);
        /// <summary>
        ///  set 131Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _3b(float _3b) => this.SetOptionRange("3b", _3b, 0, 20);
        /// <summary>
        ///  set 185Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _4b(float _4b) => this.SetOptionRange("4b", _4b, 0, 20);
        /// <summary>
        ///  set 262Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _5b(float _5b) => this.SetOptionRange("5b", _5b, 0, 20);
        /// <summary>
        ///  set 370Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _6b(float _6b) => this.SetOptionRange("6b", _6b, 0, 20);
        /// <summary>
        ///  set 523Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _7b(float _7b) => this.SetOptionRange("7b", _7b, 0, 20);
        /// <summary>
        ///  set 740Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _8b(float _8b) => this.SetOptionRange("8b", _8b, 0, 20);
        /// <summary>
        ///  set 1047Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _9b(float _9b) => this.SetOptionRange("9b", _9b, 0, 20);
        /// <summary>
        ///  set 1480Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _10b(float _10b) => this.SetOptionRange("10b", _10b, 0, 20);
        /// <summary>
        ///  set 2093Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _11b(float _11b) => this.SetOptionRange("11b", _11b, 0, 20);
        /// <summary>
        ///  set 2960Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _12b(float _12b) => this.SetOptionRange("12b", _12b, 0, 20);
        /// <summary>
        ///  set 4186Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _13b(float _13b) => this.SetOptionRange("13b", _13b, 0, 20);
        /// <summary>
        ///  set 5920Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _14b(float _14b) => this.SetOptionRange("14b", _14b, 0, 20);
        /// <summary>
        ///  set 8372Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _15b(float _15b) => this.SetOptionRange("15b", _15b, 0, 20);
        /// <summary>
        ///  set 11840Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _16b(float _16b) => this.SetOptionRange("16b", _16b, 0, 20);
        /// <summary>
        ///  set 16744Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _17b(float _17b) => this.SetOptionRange("17b", _17b, 0, 20);
        /// <summary>
        ///  set 20000Hz band gain (from 0 to 20) (default 1)
        /// </summary>
        public SuperequalizerFilterGen _18b(float _18b) => this.SetOptionRange("18b", _18b, 0, 20);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply 18 band equalization filter.
        /// </summary>
        public static SuperequalizerFilterGen SuperequalizerFilterGen(this AudioMap input0) => new SuperequalizerFilterGen(input0);
    }
}