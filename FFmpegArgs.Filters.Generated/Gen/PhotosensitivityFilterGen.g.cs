namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. photosensitivity  V-&gt;V       Filter out photosensitive epilepsy seizure-inducing flashes.
    /// </summary>
    public class PhotosensitivityFilterGen : ImageToImageFilter
    {
        internal PhotosensitivityFilterGen(ImageMap input) : base("photosensitivity", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set how many frames to use (from 2 to 240) (default 30)
        /// </summary>
        public PhotosensitivityFilterGen frames(int frames) => this.SetOptionRange("frames", frames, 2, 240);
        /// <summary>
        ///  set detection threshold factor (lower is stricter) (from 0.1 to FLT_MAX) (default 1)
        /// </summary>
        public PhotosensitivityFilterGen threshold(float threshold) => this.SetOptionRange("threshold", threshold, 0.1, FLT_MAX);
        /// <summary>
        ///  set pixels to skip when sampling frames (from 1 to 1024) (default 1)
        /// </summary>
        public PhotosensitivityFilterGen skip(int skip) => this.SetOptionRange("skip", skip, 1, 1024);
        /// <summary>
        ///  leave frames unchanged (default false)
        /// </summary>
        public PhotosensitivityFilterGen bypass(bool bypass) => this.SetOption("bypass", bypass.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Filter out photosensitive epilepsy seizure-inducing flashes.
        /// </summary>
        public static PhotosensitivityFilterGen PhotosensitivityFilterGen(this ImageMap input0) => new PhotosensitivityFilterGen(input0);
    }
}