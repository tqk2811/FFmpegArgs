namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS atilt             A-&gt;A       Apply spectral tilt to audio.
    /// </summary>
    public class AtiltFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AtiltFilterGen(AudioMap input) : base("atilt", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set central frequency (from 20 to 192000) (default 10000)
        /// </summary>
        public AtiltFilterGen freq(double freq) => this.SetOptionRange("freq", freq, 20, 192000);
        /// <summary>
        ///  set filter slope (from -1 to 1) (default 0)
        /// </summary>
        public AtiltFilterGen slope(double slope) => this.SetOptionRange("slope", slope, -1, 1);
        /// <summary>
        ///  set filter width (from 100 to 10000) (default 1000)
        /// </summary>
        public AtiltFilterGen width(double width) => this.SetOptionRange("width", width, 100, 10000);
        /// <summary>
        ///  set filter order (from 2 to 30) (default 5)
        /// </summary>
        public AtiltFilterGen order(int order) => this.SetOptionRange("order", order, 2, 30);
        /// <summary>
        ///  set input level (from 0 to 4) (default 1)
        /// </summary>
        public AtiltFilterGen level(double level) => this.SetOptionRange("level", level, 0, 4);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply spectral tilt to audio.
        /// </summary>
        public static AtiltFilterGen AtiltFilterGen(this AudioMap input0) => new AtiltFilterGen(input0);
    }
}