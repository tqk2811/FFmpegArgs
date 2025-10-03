﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... testsrc           |-&gt;V       Generate test pattern.
    /// </summary>
    public class TestsrcFilterGen : SourceToImageFilter
    {
        internal TestsrcFilterGen(IImageFilterGraph input) : base("testsrc", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;320x240&quot;)
        /// </summary>
        public TestsrcFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public TestsrcFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set video duration (default -0.000001)
        /// </summary>
        public TestsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
        /// </summary>
        public TestsrcFilterGen sar(Rational sar) => this.SetOption("sar", sar.Check(0, INT_MAX));
        /// <summary>
        ///  set number of decimals to show (from 0 to 17) (default 0)
        /// </summary>
        public TestsrcFilterGen decimals(int decimals) => this.SetOptionRange("decimals", decimals, 0, 17);
        /// <summary>
        ///  set number of decimals to show (from 0 to 17) (default 0)
        /// </summary>
        public TestsrcFilterGen n(int n) => this.SetOptionRange("n", n, 0, 17);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate test pattern.
        /// </summary>
        public static TestsrcFilterGen TestsrcFilterGen(this IImageFilterGraph input) => new TestsrcFilterGen(input);
    }
}