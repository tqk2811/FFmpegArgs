﻿namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... ciescope          V->V       Video CIE scope.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#ciescope
    /// </summary>
    public class CiescopeFilter : ImageToImageFilter
    {
        internal CiescopeFilter(ImageMap imageMap) : base("ciescope", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set color system.
        /// </summary>
        /// <param name="system"></param>
        /// <returns></returns>
        public CiescopeFilter System(CiescopeColorSystem system)
          => this.SetOption("system", system.ToString().Substring(1));
        /// <summary>
        /// Set CIE system.
        /// </summary>
        /// <param name="cie"></param>
        /// <returns></returns>
        public CiescopeFilter Cie(CiescopeCieSystem cie)
          => this.SetOption("cie", cie);
        /// <summary>
        /// Set what gamuts to draw.
        /// </summary>
        /// <param name="gamuts"></param>
        /// <returns></returns>
        public CiescopeFilter Gamuts(CiescopeColorSystem gamuts)
          => this.SetOption("gamuts", gamuts.ToString().Substring(1));
        /// <summary>
        /// Set ciescope size, by default set to 512. (from 256 to 8192) (default 512)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public CiescopeFilter Size(int s)
          => this.SetOptionRange("s", s, 256, 8192);
        /// <summary>
        /// Set intensity used to map input pixel values to CIE diagram. (from 0 to 1) (default 0.001)
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public CiescopeFilter Intensity(float i)
          => this.SetOptionRange("i", i, 0, 1);
        /// <summary>
        /// Set contrast used to draw tongue colors that are out of active color system gamut. (from 0 to 1) (default 0.75)
        /// </summary>
        /// <param name="contrast"></param>
        /// <returns></returns>
        public CiescopeFilter Contrast(float contrast)
          => this.SetOptionRange("contrast", contrast, 0, 1);
        /// <summary>
        /// Correct gamma displayed on scope, by default enabled.
        /// </summary>
        /// <param name="corrgamma"></param>
        /// <returns></returns>
        public CiescopeFilter Corrgamma(bool corrgamma)
          => this.SetOption("corrgamma", corrgamma.ToFFmpegFlag());
        /// <summary>
        /// Show white point on CIE diagram, by default disabled.
        /// </summary>
        /// <param name="showwhite"></param>
        /// <returns></returns>
        public CiescopeFilter Showwhite(bool showwhite)
          => this.SetOption("showwhite", showwhite.ToFFmpegFlag());
        /// <summary>
        /// Set input gamma. Used only with XYZ input color space. (from 0.1 to 6) (default 2.6)
        /// </summary>
        /// <param name="gamma"></param>
        /// <returns></returns>
        public CiescopeFilter Gamma(double gamma)
          => this.SetOptionRange("gamma", gamma, 0.1, 6);
    }
    public static class CiescopeFilterExtensions
    {
        /// <summary>
        /// Display CIE color diagram with pixels overlaid onto it.
        /// </summary>
        public static CiescopeFilter CiescopeFilter(this ImageMap imageMap)
          => new CiescopeFilter(imageMap);
    }
    public enum CiescopeColorSystem
    {
        _ntsc,
        _470m,
        _ebu,
        _470bg,
        _smpte,
        _240m,
        _apple,
        _widergb,
        _cie1931,
        _rec709,
        _hdtv,
        _uhdtv,
        _rec2020,
        _dcip3
    }
    public enum CiescopeCieSystem
    {
        xyy,
        ucs,
        luv
    }
}
