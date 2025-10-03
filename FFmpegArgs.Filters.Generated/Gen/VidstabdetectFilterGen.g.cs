namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... vidstabdetect     V-&gt;V       Extract relative transformations, pass 1 of 2 for stabilization (see vidstabtransform for pass 2).
    /// </summary>
    public class VidstabdetectFilterGen : ImageToImageFilter
    {
        internal VidstabdetectFilterGen(ImageMap input) : base("vidstabdetect", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  path to the file used to write the transforms (default &quot;transforms.trf&quot;)
        /// </summary>
        public VidstabdetectFilterGen result(String result) => this.SetOption("result", result.ToString());
        /// <summary>
        ///  how shaky is the video and how quick is the camera? 1: little (fast) 10: very strong/quick (slow) (from 1 to 10) (default 5)
        /// </summary>
        public VidstabdetectFilterGen shakiness(int shakiness) => this.SetOptionRange("shakiness", shakiness, 1, 10);
        /// <summary>
        ///  (&gt;=shakiness) 1: low 15: high (slow) (from 1 to 15) (default 15)
        /// </summary>
        public VidstabdetectFilterGen accuracy(int accuracy) => this.SetOptionRange("accuracy", accuracy, 1, 15);
        /// <summary>
        ///  region around minimum is scanned with 1 pixel resolution (from 1 to 32) (default 6)
        /// </summary>
        public VidstabdetectFilterGen stepsize(int stepsize) => this.SetOptionRange("stepsize", stepsize, 1, 32);
        /// <summary>
        ///  below this contrast a field is discarded (0-1) (from 0 to 1) (default 0.25)
        /// </summary>
        public VidstabdetectFilterGen mincontrast(double mincontrast) => this.SetOptionRange("mincontrast", mincontrast, 0, 1);
        /// <summary>
        ///  0: draw nothing; 1,2: show fields and transforms (from 0 to 2) (default 0)
        /// </summary>
        public VidstabdetectFilterGen show(int show) => this.SetOptionRange("show", show, 0, 2);
        /// <summary>
        ///  virtual tripod mode (if &gt;0): motion is compared to a reference reference frame (frame # is the value) (from 0 to INT_MAX) (default 0)
        /// </summary>
        public VidstabdetectFilterGen tripod(int tripod) => this.SetOptionRange("tripod", tripod, 0, INT_MAX);
        /// <summary>
        ///  transforms data file format (from 1 to 2) (default binary)
        /// </summary>
        public VidstabdetectFilterGen fileformat(VidstabdetectFilterGenFileformat fileformat) => this.SetOption("fileformat", fileformat.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  transforms data file format (from 1 to 2) (default binary)
    /// </summary>
    public enum VidstabdetectFilterGenFileformat
    {
        /// <summary>
        /// ascii           1            ..FV....... ASCII text
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ascii")]
        ascii = 1,
        /// <summary>
        /// binary          2            ..FV....... binary
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("binary")]
        binary = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Extract relative transformations, pass 1 of 2 for stabilization (see vidstabtransform for pass 2).
        /// </summary>
        public static VidstabdetectFilterGen VidstabdetectFilterGen(this ImageMap input0) => new VidstabdetectFilterGen(input0);
    }
}