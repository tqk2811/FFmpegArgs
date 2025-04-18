/*
tonemap_opencl AVOptions:
   tonemap           <int>        ..FV....... tonemap algorithm selection (from 0 to 6) (default none)
     none            0            ..FV.......
     linear          1            ..FV.......
     gamma           2            ..FV.......
     clip            3            ..FV.......
     reinhard        4            ..FV.......
     hable           5            ..FV.......
     mobius          6            ..FV.......
   transfer          <int>        ..FV....... set transfer characteristic (from -1 to INT_MAX) (default bt709)
     bt709           1            ..FV.......
     bt2020          14           ..FV.......
   t                 <int>        ..FV....... set transfer characteristic (from -1 to INT_MAX) (default bt709)
     bt709           1            ..FV.......
     bt2020          14           ..FV.......
   matrix            <int>        ..FV....... set colorspace matrix (from -1 to INT_MAX) (default -1)
     bt709           1            ..FV.......
     bt2020          9            ..FV.......
   m                 <int>        ..FV....... set colorspace matrix (from -1 to INT_MAX) (default -1)
     bt709           1            ..FV.......
     bt2020          9            ..FV.......
   primaries         <int>        ..FV....... set color primaries (from -1 to INT_MAX) (default -1)
     bt709           1            ..FV.......
     bt2020          9            ..FV.......
   p                 <int>        ..FV....... set color primaries (from -1 to INT_MAX) (default -1)
     bt709           1            ..FV.......
     bt2020          9            ..FV.......
   range             <int>        ..FV....... set color range (from -1 to INT_MAX) (default -1)
     tv              1            ..FV.......
     pc              2            ..FV.......
     limited         1            ..FV.......
     full            2            ..FV.......
   r                 <int>        ..FV....... set color range (from -1 to INT_MAX) (default -1)
     tv              1            ..FV.......
     pc              2            ..FV.......
     limited         1            ..FV.......
     full            2            ..FV.......
   format            <pix_fmt>    ..FV....... output pixel format (default none)
   peak              <double>     ..FV....... signal peak override (from 0 to DBL_MAX) (default 0)
   param             <double>     ..FV....... tonemap parameter (from DBL_MIN to DBL_MAX) (default nan)
   desat             <double>     ..FV....... desaturation parameter (from 0 to DBL_MAX) (default 0.5)
   threshold         <double>     ..FV....... scene detection threshold (from 0 to DBL_MAX) (default 0.2)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... tonemap_opencl    V->V       Perform HDR to SDR conversion with tonemapping.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#tonemap_005fopencl
    /// </summary>
    public class TonemapOpenclFilter : ImageToImageFilter
    {
        internal TonemapOpenclFilter(ImageMap imageMap) : base("tonemap_opencl", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Specify the tone-mapping operator to be used.
        /// </summary>
        /// <param name="tonemap"></param>
        /// <returns></returns>
        public TonemapOpenclFilter Tonemap(TonemapOpenclTonemap tonemap)
            => this.SetOption("tonemap", tonemap);
        /// <summary>
        /// Tune the tone mapping algorithm. (default bt709)
        /// </summary>
        /// <param name="transfer"></param>
        /// <returns></returns>
        public TonemapOpenclFilter Transfer(TonemapOpenclMode transfer)
            => this.SetOption("t", transfer);
        /// <summary>
        /// Set the output colorspace matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public TonemapOpenclFilter Matrix(TonemapOpenclMode matrix)
            => this.SetOption("m", matrix);
        /// <summary>
        /// Set the output color primaries.
        /// </summary>
        /// <param name="primaries"></param>
        /// <returns></returns>
        public TonemapOpenclFilter Primaries(TonemapOpenclMode primaries)
            => this.SetOption("p", primaries);
        /// <summary>
        /// Set the output color range.
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public TonemapOpenclFilter Range(TonemapOpenclRange range)
            => this.SetOption("r", range);
        /// <summary>
        /// Specify the output pixel format.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public TonemapOpenclFilter Format(PixFmt format)
            => this.SetOption("format", format);
        /// <summary>
        /// Signal peak override. (from 0 to DBL_MAX) (default 0)
        /// </summary>
        /// <param name="peak"></param>
        /// <returns></returns>
        public TonemapOpenclFilter Peak(double peak)
            => this.SetOptionRange("peak", peak, 0, DBL_MAX);
        /// <summary>
        /// tonemap parameter (from DBL_MIN to DBL_MAX) (default nan)
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public TonemapOpenclFilter Param(double param)
            => this.SetOptionRange("param", param, DBL_MIN, DBL_MAX);
        /// <summary>
        /// Apply desaturation for highlights that exceed this level of brightness. The higher the parameter, the more color information will be preserved. This setting helps prevent unnaturally blown-out colors for super-highlights, by (smoothly) turning into white instead. This makes images feel more natural, at the cost of reducing information about out-of-range colors.<br>
        /// </br>The default value is 0.5, and the algorithm here is a little different from the cpu version tonemap currently.A setting of 0.0 disables this option.<br>
        /// </br>(from 0 to DBL_MAX) (default 0.5)
        /// </summary>
        /// <param name="desat"></param>
        /// <returns></returns>
        public TonemapOpenclFilter Desat(double desat)
            => this.SetOptionRange("desat", desat, 0, DBL_MAX);
        /// <summary>
        /// The tonemapping algorithm parameters is fine-tuned per each scene. And a threshold is used to detect whether the scene has changed or not. If the distance between the current frame average brightness and the current running average exceeds a threshold value, we would re-calculate scene average and peak brightness. The default value is 0.2.<br>
        /// </br>(from 0 to DBL_MAX) (default 0.2)
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public TonemapOpenclFilter Threshold(double threshold)
            => this.SetOptionRange("threshold", threshold, 0, DBL_MAX);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class TonemapOpenclFilterExtensions
    {
        /// <summary>
        /// Perform HDR(PQ/HLG) to SDR conversion with tone-mapping.
        /// </summary>
        public static TonemapOpenclFilter TonemapOpenclFilter(this ImageMap imageMap)
          => new TonemapOpenclFilter(imageMap);
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum TonemapOpenclTonemap
    {
        none = 0,
        linear = 1,
        gamma = 2,
        clip = 3,
        reinhard = 4,
        hable = 5,
        mobius = 6,
    }
    public enum TonemapOpenclMode
    {
        bt709,
        bt2020
    }

    public enum TonemapOpenclRange
    {
        tv = 1,
        pc = 2,
        limited = 1,
        full = 2
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
