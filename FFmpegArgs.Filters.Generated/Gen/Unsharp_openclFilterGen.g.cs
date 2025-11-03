namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. unsharp_opencl    V-&gt;V       Apply unsharp mask to input video
    /// </summary>
    public class Unsharp_openclFilterGen : ImageToImageFilter
    {
        internal Unsharp_openclFilterGen(ImageMap input) : base("unsharp_opencl", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set luma mask horizontal diameter (pixels) (from 1 to 23) (default 5)
        /// </summary>
        public Unsharp_openclFilterGen luma_msize_x(float luma_msize_x) => this.SetOptionRange("luma_msize_x", luma_msize_x, 1, 23);
        /// <summary>
        ///  Set luma mask horizontal diameter (pixels) (from 1 to 23) (default 5)
        /// </summary>
        public Unsharp_openclFilterGen lx(float lx) => this.SetOptionRange("lx", lx, 1, 23);
        /// <summary>
        ///  Set luma mask vertical diameter (pixels) (from 1 to 23) (default 5)
        /// </summary>
        public Unsharp_openclFilterGen luma_msize_y(float luma_msize_y) => this.SetOptionRange("luma_msize_y", luma_msize_y, 1, 23);
        /// <summary>
        ///  Set luma mask vertical diameter (pixels) (from 1 to 23) (default 5)
        /// </summary>
        public Unsharp_openclFilterGen ly(float ly) => this.SetOptionRange("ly", ly, 1, 23);
        /// <summary>
        ///  Set luma amount (multiplier) (from -10 to 10) (default 1)
        /// </summary>
        public Unsharp_openclFilterGen luma_amount(float luma_amount) => this.SetOptionRange("luma_amount", luma_amount, -10, 10);
        /// <summary>
        ///  Set luma amount (multiplier) (from -10 to 10) (default 1)
        /// </summary>
        public Unsharp_openclFilterGen la(float la) => this.SetOptionRange("la", la, -10, 10);
        /// <summary>
        ///  Set chroma mask horizontal diameter (pixels after subsampling) (from 1 to 23) (default 5)
        /// </summary>
        public Unsharp_openclFilterGen chroma_msize_x(float chroma_msize_x) => this.SetOptionRange("chroma_msize_x", chroma_msize_x, 1, 23);
        /// <summary>
        ///  Set chroma mask horizontal diameter (pixels after subsampling) (from 1 to 23) (default 5)
        /// </summary>
        public Unsharp_openclFilterGen cx(float cx) => this.SetOptionRange("cx", cx, 1, 23);
        /// <summary>
        ///  Set chroma mask vertical diameter (pixels after subsampling) (from 1 to 23) (default 5)
        /// </summary>
        public Unsharp_openclFilterGen chroma_msize_y(float chroma_msize_y) => this.SetOptionRange("chroma_msize_y", chroma_msize_y, 1, 23);
        /// <summary>
        ///  Set chroma mask vertical diameter (pixels after subsampling) (from 1 to 23) (default 5)
        /// </summary>
        public Unsharp_openclFilterGen cy(float cy) => this.SetOptionRange("cy", cy, 1, 23);
        /// <summary>
        ///  Set chroma amount (multiplier) (from -10 to 10) (default 0)
        /// </summary>
        public Unsharp_openclFilterGen chroma_amount(float chroma_amount) => this.SetOptionRange("chroma_amount", chroma_amount, -10, 10);
        /// <summary>
        ///  Set chroma amount (multiplier) (from -10 to 10) (default 0)
        /// </summary>
        public Unsharp_openclFilterGen ca(float ca) => this.SetOptionRange("ca", ca, -10, 10);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply unsharp mask to input video
        /// </summary>
        public static Unsharp_openclFilterGen Unsharp_openclFilterGen(this ImageMap input0) => new Unsharp_openclFilterGen(input0);
    }
}