/*
convolution_opencl AVOptions:
   0m                <string>     ..FV....... set matrix for 2nd plane (default "0 0 0 0 1 0 0 0 0")
   1m                <string>     ..FV....... set matrix for 2nd plane (default "0 0 0 0 1 0 0 0 0")
   2m                <string>     ..FV....... set matrix for 3rd plane (default "0 0 0 0 1 0 0 0 0")
   3m                <string>     ..FV....... set matrix for 4th plane (default "0 0 0 0 1 0 0 0 0")
   0rdiv             <float>      ..FV....... set rdiv for 1nd plane (from 0 to INT_MAX) (default 1)
   1rdiv             <float>      ..FV....... set rdiv for 2nd plane (from 0 to INT_MAX) (default 1)
   2rdiv             <float>      ..FV....... set rdiv for 3rd plane (from 0 to INT_MAX) (default 1)
   3rdiv             <float>      ..FV....... set rdiv for 4th plane (from 0 to INT_MAX) (default 1)
   0bias             <float>      ..FV....... set bias for 1st plane (from 0 to INT_MAX) (default 0)
   1bias             <float>      ..FV....... set bias for 2nd plane (from 0 to INT_MAX) (default 0)
   2bias             <float>      ..FV....... set bias for 3rd plane (from 0 to INT_MAX) (default 0)
   3bias             <float>      ..FV....... set bias for 4th plane (from 0 to INT_MAX) (default 0)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... convolution_opencl V->V       Apply convolution mask to input video<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#convolution_005fopencl
    /// </summary>
    public class ConvolutionOpenclFilter : ImageToImageFilter
    {
        internal ConvolutionOpenclFilter(ImageMap imageMap) : base("convolution_opencl", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set matrix for each plane. Matrix is sequence of 9, 25 or 49 signed numbers. Default value for each plane is 0 0 0 0 1 0 0 0 0.
        /// </summary>
        /// <param name="_0m"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _0M(string _0m)
            => this.SetOption("0m", _0m);
        /// <summary>
        /// Set matrix for each plane. Matrix is sequence of 9, 25 or 49 signed numbers. Default value for each plane is 0 0 0 0 1 0 0 0 0.
        /// </summary>
        /// <param name="_1m"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _1M(string _1m)
            => this.SetOption("1m", _1m);
        /// <summary>
        /// Set matrix for each plane. Matrix is sequence of 9, 25 or 49 signed numbers. Default value for each plane is 0 0 0 0 1 0 0 0 0.
        /// </summary>
        /// <param name="_2m"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _2M(string _2m)
            => this.SetOption("2m", _2m);
        /// <summary>
        /// Set matrix for each plane. Matrix is sequence of 9, 25 or 49 signed numbers. Default value for each plane is 0 0 0 0 1 0 0 0 0.
        /// </summary>
        /// <param name="_3m"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _3M(string _3m)
            => this.SetOption("3m", _3m);

        /// <summary>
        /// Set multiplier for calculated value for each plane. If unset or 0, it will be sum of all matrix elements.<br>
        /// </br>(from 0 to INT_MAX) (default 1)
        /// </summary>
        /// <param name="_0rdiv"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _0rdiv(float _0rdiv)
            => this.SetOptionRange("0rdiv", _0rdiv, 0, INT_MAX);
        /// <summary>
        /// Set multiplier for calculated value for each plane. If unset or 0, it will be sum of all matrix elements.<br>
        /// </br>(from 0 to INT_MAX) (default 1)
        /// </summary>
        /// <param name="_1rdiv"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _1rdiv(float _1rdiv)
            => this.SetOptionRange("1rdiv", _1rdiv, 0, INT_MAX);
        /// <summary>
        /// Set multiplier for calculated value for each plane. If unset or 0, it will be sum of all matrix elements.<br>
        /// </br>(from 0 to INT_MAX) (default 1)
        /// </summary>
        /// <param name="_2rdiv"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _2rdiv(float _2rdiv)
            => this.SetOptionRange("2rdiv", _2rdiv, 0, INT_MAX);
        /// <summary>
        /// Set multiplier for calculated value for each plane. If unset or 0, it will be sum of all matrix elements.<br>
        /// </br>(from 0 to INT_MAX) (default 1)
        /// </summary>
        /// <param name="_3rdiv"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _3rdiv(float _3rdiv)
            => this.SetOptionRange("3rdiv", _3rdiv, 0, INT_MAX);

        /// <summary>
        /// Set bias for each plane. This value is added to the result of the multiplication. Useful for making the overall image brighter or darker.<br>
        /// </br>(from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="_0bias"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _0bias(float _0bias)
            => this.SetOptionRange("0bias", _0bias, 0, INT_MAX);
        /// <summary>
        /// Set bias for each plane. This value is added to the result of the multiplication. Useful for making the overall image brighter or darker.<br>
        /// </br>(from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="_1bias"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _1bias(float _1bias)
           => this.SetOptionRange("1bias", _1bias, 0, INT_MAX);
        /// <summary>
        /// Set bias for each plane. This value is added to the result of the multiplication. Useful for making the overall image brighter or darker.<br>
        /// </br>(from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="_2bias"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _2bias(float _2bias)
           => this.SetOptionRange("2bias", _2bias, 0, INT_MAX);
        /// <summary>
        /// Set bias for each plane. This value is added to the result of the multiplication. Useful for making the overall image brighter or darker.<br>
        /// </br>(from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="_3bias"></param>
        /// <returns></returns>
        public ConvolutionOpenclFilter _3bias(float _3bias)
           => this.SetOptionRange("3bias", _3bias, 0, INT_MAX);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class ConvolutionOpenclFilterExtensions
    {
        /// <summary>
        /// Apply convolution of 3x3, 5x5, 7x7 matrix.
        /// </summary>
        public static ConvolutionOpenclFilter ConvolutionOpenclFilter(this ImageMap imageMap)
          => new ConvolutionOpenclFilter(imageMap);
    }
}
