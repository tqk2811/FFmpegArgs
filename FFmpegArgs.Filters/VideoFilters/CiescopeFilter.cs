using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FFmpegArgs.Filters.VideoFilters
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
    /// <param name="system"></param>
    /// <returns></returns>
    public CiescopeFilter Gamuts(CiescopeColorSystem system)
      => this.SetOption("system", system.ToString().Substring(1));

    /// <summary>
    /// Set ciescope size, by default set to 512.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public CiescopeFilter Size(int s)
      => this.SetOptionRange("s", s, 0, int.MaxValue);

#warning Need more info
        // #NeedMoreInfo
    /// <summary>
    /// Set intensity used to map input pixel values to CIE diagram.
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public CiescopeFilter Intensity(string i)
      => this.SetOption("i", i);

#warning Need more info
        // #NeedMoreInfo
    /// <summary>
    /// Set contrast used to draw tongue colors that are out of active color system gamut.
    /// </summary>
    /// <param name="contrast"></param>
    /// <returns></returns>
    public CiescopeFilter Contrast(string contrast)
      => this.SetOption("contrast", contrast);

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

#warning Need more info
        // #NeedMoreInfo
    /// <summary>
    /// Set input gamma. Used only with XYZ input color space.
    /// </summary>
    /// <param name="gamma"></param>
    /// <returns></returns>
    public CiescopeFilter Gamma(string gamma)
      => this.SetOption("gamma", gamma);
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
