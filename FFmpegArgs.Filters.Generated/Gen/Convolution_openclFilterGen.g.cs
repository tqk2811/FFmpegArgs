namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... convolution_opencl V-&gt;V       Apply convolution mask to input video
    /// </summary>
    public class Convolution_openclFilterGen : ImageToImageFilter
    {
        internal Convolution_openclFilterGen(ImageMap input) : base("convolution_opencl", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set matrix for 2nd plane (default &quot;0 0 0 0 1 0 0 0 0&quot;)
        /// </summary>
        public Convolution_openclFilterGen _0m(String _0m) => this.SetOption("0m", _0m.ToString());
        /// <summary>
        ///  set matrix for 2nd plane (default &quot;0 0 0 0 1 0 0 0 0&quot;)
        /// </summary>
        public Convolution_openclFilterGen _1m(String _1m) => this.SetOption("1m", _1m.ToString());
        /// <summary>
        ///  set matrix for 3rd plane (default &quot;0 0 0 0 1 0 0 0 0&quot;)
        /// </summary>
        public Convolution_openclFilterGen _2m(String _2m) => this.SetOption("2m", _2m.ToString());
        /// <summary>
        ///  set matrix for 4th plane (default &quot;0 0 0 0 1 0 0 0 0&quot;)
        /// </summary>
        public Convolution_openclFilterGen _3m(String _3m) => this.SetOption("3m", _3m.ToString());
        /// <summary>
        ///  set rdiv for 1nd plane (from 0 to INT_MAX) (default 1)
        /// </summary>
        public Convolution_openclFilterGen _0rdiv(float _0rdiv) => this.SetOptionRange("0rdiv", _0rdiv, 0, INT_MAX);
        /// <summary>
        ///  set rdiv for 2nd plane (from 0 to INT_MAX) (default 1)
        /// </summary>
        public Convolution_openclFilterGen _1rdiv(float _1rdiv) => this.SetOptionRange("1rdiv", _1rdiv, 0, INT_MAX);
        /// <summary>
        ///  set rdiv for 3rd plane (from 0 to INT_MAX) (default 1)
        /// </summary>
        public Convolution_openclFilterGen _2rdiv(float _2rdiv) => this.SetOptionRange("2rdiv", _2rdiv, 0, INT_MAX);
        /// <summary>
        ///  set rdiv for 4th plane (from 0 to INT_MAX) (default 1)
        /// </summary>
        public Convolution_openclFilterGen _3rdiv(float _3rdiv) => this.SetOptionRange("3rdiv", _3rdiv, 0, INT_MAX);
        /// <summary>
        ///  set bias for 1st plane (from 0 to INT_MAX) (default 0)
        /// </summary>
        public Convolution_openclFilterGen _0bias(float _0bias) => this.SetOptionRange("0bias", _0bias, 0, INT_MAX);
        /// <summary>
        ///  set bias for 2nd plane (from 0 to INT_MAX) (default 0)
        /// </summary>
        public Convolution_openclFilterGen _1bias(float _1bias) => this.SetOptionRange("1bias", _1bias, 0, INT_MAX);
        /// <summary>
        ///  set bias for 3rd plane (from 0 to INT_MAX) (default 0)
        /// </summary>
        public Convolution_openclFilterGen _2bias(float _2bias) => this.SetOptionRange("2bias", _2bias, 0, INT_MAX);
        /// <summary>
        ///  set bias for 4th plane (from 0 to INT_MAX) (default 0)
        /// </summary>
        public Convolution_openclFilterGen _3bias(float _3bias) => this.SetOptionRange("3bias", _3bias, 0, INT_MAX);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply convolution mask to input video
        /// </summary>
        public static Convolution_openclFilterGen Convolution_openclFilterGen(this ImageMap input0) => new Convolution_openclFilterGen(input0);
    }
}