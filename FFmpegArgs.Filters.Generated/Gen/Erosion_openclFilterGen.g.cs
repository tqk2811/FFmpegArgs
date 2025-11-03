namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. erosion_opencl    V-&gt;V       Apply erosion effect
    /// </summary>
    public class Erosion_openclFilterGen : ImageToImageFilter
    {
        internal Erosion_openclFilterGen(ImageMap input) : base("erosion_opencl", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set threshold for 1st plane (from 0 to 65535) (default 65535)
        /// </summary>
        public Erosion_openclFilterGen threshold0(float threshold0) => this.SetOptionRange("threshold0", threshold0, 0, 65535);
        /// <summary>
        ///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
        /// </summary>
        public Erosion_openclFilterGen threshold1(float threshold1) => this.SetOptionRange("threshold1", threshold1, 0, 65535);
        /// <summary>
        ///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
        /// </summary>
        public Erosion_openclFilterGen threshold2(float threshold2) => this.SetOptionRange("threshold2", threshold2, 0, 65535);
        /// <summary>
        ///  set threshold for 4th plane (from 0 to 65535) (default 65535)
        /// </summary>
        public Erosion_openclFilterGen threshold3(float threshold3) => this.SetOptionRange("threshold3", threshold3, 0, 65535);
        /// <summary>
        ///  set coordinates (from 0 to 255) (default 255)
        /// </summary>
        public Erosion_openclFilterGen coordinates(int coordinates) => this.SetOptionRange("coordinates", coordinates, 0, 255);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply erosion effect
        /// </summary>
        public static Erosion_openclFilterGen Erosion_openclFilterGen(this ImageMap input0) => new Erosion_openclFilterGen(input0);
    }
}