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
  /// TS. colorspace        V->V       Convert between colorspaces.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#colorspace
  /// </summary>
  public class ColorspaceFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading
  {
    internal ColorspaceFilter(ImageMap imageMap) : base("colorspace", imageMap)
    {
      AddMapOut();
    }

    /// <summary>
    /// Specify all color properties at once.
    /// </summary>
    /// <param name="all"></param>
    /// <returns></returns>
    public ColorspaceFilter All(ColorspaceColorProperties all)
      => this.SetOption("all", all.GetAttribute<NameAttribute>().Name);

    /// <summary>
    /// Specify output colorspace.
    /// </summary>
    /// <param name="space"></param>
    /// <returns></returns>
    public ColorspaceFilter Space(ColorspaceSpace space)
      => this.SetOption("space", space);

    /// <summary>
    /// Specify output transfer characteristics.
    /// </summary>
    /// <param name="trc"></param>
    /// <returns></returns>
    public ColorspaceFilter Trc(ColorspaceTrc trc)
      => this.SetOption("str", trc.GetAttribute<NameAttribute>().Name);

    /// <summary>
    /// Specify output color primaries.
    /// </summary>
    /// <param name="primaries"></param>
    /// <returns></returns>
    public ColorspaceFilter Primaries(ColorspacePrimaries primaries)
      => this.SetOption("primaries", primaries.GetAttribute<NameAttribute>().Name);

    /// <summary>
    /// Specify output color range.
    /// </summary>
    /// <param name="range"></param>
    /// <returns></returns>
    public ColorspaceFilter Range(ColorspaceRange range)
      => this.SetOption("range", range);

    /// <summary>
    /// Specify output color format.
    /// </summary>
    /// <param name="format"></param>
    /// <returns></returns>
    public ColorspaceFilter Format(ColorspaceFormat format)
      => this.SetOption("format", format);

    /// <summary>
    /// Do a fast conversion, which skips gamma/primary correction.<br>
    /// </br> This will take significantly less CPU, but will be mathematically incorrect.<br>
    /// </br> To get output compatible with that produced by the colormatrix filter, use fast=1.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public ColorspaceFilter Fast(bool flag)
      => this.SetOption("fast", flag.ToFFmpegFlag());

    /// <summary>
    /// Specify dithering mode.
    /// </summary>
    /// <returns></returns>
    public ColorspaceFilter Dither(ColorspaceDither dither)
      => this.SetOption("dither", dither);

    /// <summary>
    /// Whitepoint adaptation mode.
    /// </summary>
    /// <param name="wpadapt"></param>
    /// <returns></returns>
    public ColorspaceFilter Wpadapt(ColorspaceWpadapt wpadapt)
      => this.SetOption("wpadapt", wpadapt);

    /// <summary>
    /// Override all input properties at once
    /// </summary>
    /// <param name="iall"></param>
    /// <returns></returns>
    public ColorspaceFilter IAll(ColorspaceColorProperties iall)
      => this.SetOption("iall", iall.GetAttribute<NameAttribute>().Name);

    /// <summary>
    /// Override input colorspace. 
    /// </summary>
    /// <param name="ispace"></param>
    /// <returns></returns>
    public ColorspaceFilter ISpace(ColorspaceSpace ispace)
      => this.SetOption("ispace", ispace);

    /// <summary>
    /// Override input color primaries
    /// </summary>
    /// <param name="iprimaries"></param>
    /// <returns></returns>
    public ColorspaceFilter IPrimaries(ColorspacePrimaries iprimaries)
      => this.SetOption("iprimaries", iprimaries.GetAttribute<NameAttribute>().Name);

    /// <summary>
    /// Override input transfer characteristics.
    /// </summary>
    /// <param name="itrc"></param>
    /// <returns></returns>
    public ColorspaceFilter ITrc(ColorspaceTrc itrc)
      => this.SetOption("itrc", itrc.GetAttribute<NameAttribute>().Name);

    /// <summary>
    /// Override input color range.
    /// </summary>
    /// <param name="irange"></param>
    /// <returns></returns>
    public ColorspaceFilter IRange(ColorspaceRange irange)
      => this.SetOption("irange", irange);
  }

  public static class ColorspaceFilterExtensions
  {
    /// <summary>
    /// Convert colorspace, transfer characteristics or color primaries. Input video needs to have an even size.<br></br>
    /// The filter converts the transfer characteristics, color space and color primaries to the specified user values. The output value, if not specified, is set to a default value based on the "all" property. If that property is also not specified, the filter will log an error. The output color range and format default to the same value as the input color range and format. The input transfer characteristics, color space, color primaries and color range should be set on the input data. If any of these are missing, the filter will log an error and no conversion will take place.
    /// </summary>
    public static ColorspaceFilter ColorspaceFilter(this ImageMap imageMap)
      => new ColorspaceFilter(imageMap);
  }

  public enum ColorspaceColorProperties
  {
    /// <summary>
    /// BT.470M
    /// </summary>
    [Name("bt470m")] bt470m,
    /// <summary>
    /// BT.470BG
    /// </summary>
    [Name("bt470bg")] bt470bg,
    /// <summary>
    /// BT.601-6 525
    /// </summary>
    [Name("bt601-6-525")] bt601_6_525,
    /// <summary>
    /// BT.601-6 625
    /// </summary>
    [Name("bt601-6-625")] bt601_6_625,
    /// <summary>
    /// BT.709
    /// </summary>
    [Name("bt709")] bt709,
    /// <summary>
    /// SMPTE-170M
    /// </summary>
    [Name("smpte170m")] smpte170m,
    /// <summary>
    /// SMPTE-240M
    /// </summary>
    [Name("smpte240m")] smpte240m,
    /// <summary>
    /// BT.2020
    /// </summary>
    [Name("bt2020")] bt2020
  }

  public enum ColorspaceSpace
  {
    /// <summary>
    /// BT.709
    /// </summary>
    bt709,
    /// <summary>
    /// FCC
    /// </summary>
    fcc,
    /// <summary>
    /// BT.470BG or BT.601-6 625
    /// </summary>
    bt470bg,
    /// <summary>
    /// SMPTE-170M or BT.601-6 525
    /// </summary>
    smpte170m,
    /// <summary>
    /// SMPTE-240M
    /// </summary>
    smpte240m,
    /// <summary>
    /// YCgCo
    /// </summary>
    ycgco,
    /// <summary>
    /// BT.2020 with non-constant luminance
    /// </summary>
    bt2020ncl
  }

  public enum ColorspaceTrc
  {
    /// <summary>
    /// BT.709
    /// </summary>
    [Name("bt709")] bt709,
    /// <summary>
    /// BT.470M
    /// </summary>
    [Name("bt470m")] bt470m,
    /// <summary>
    /// BT.470BG
    /// </summary>
    [Name("bt470bg")] bt470bg,
    /// <summary>
    /// Constant gamma of 2.2
    /// </summary>
    [Name("gamma22")] gamma22,
    /// <summary>
    /// Constant gamma of 2.8
    /// </summary>
    [Name("gamma28")] gamma28,
    /// <summary>
    /// SMPTE-170M, BT.601-6 625 or BT.601-6 525
    /// </summary>
    [Name("smpte170m")] smpte170m,
    /// <summary>
    /// SMPTE-240M
    /// </summary>
    [Name("smpte240m")] smpte240m,
    /// <summary>
    /// SRGB
    /// </summary>
    [Name("srgb")] srgb,
    /// <summary>
    /// iec61966-2-1
    /// </summary>
    [Name("iec61966-2-1")] iec61966_2_1,
    /// <summary>
    /// iec61966-2-4
    /// </summary>
    [Name("iec61966-2-4")] iec61966_2_4,
    /// <summary>
    /// xvycc
    /// </summary>
    [Name("xvycc")] xvycc,
    /// <summary>
    /// BT.2020 for 10-bits content
    /// </summary>
    [Name("bt2020-10")] bt2020_10,
    /// <summary>
    /// BT.2020 for 12-bits content
    /// </summary>
    [Name("bt2020-12")] bt2020_12
  }

  public enum ColorspacePrimaries
  {
    /// <summary>
    /// BT.709
    /// </summary>
    [Name("bt709")] bt709,
    /// <summary>
    /// BT.470M
    /// </summary>
    [Name("bt470m")] bt470m,
    /// <summary>
    /// BT.470BG or BT.601-6 625
    /// </summary>
    [Name("bt470bg")] bt470bg,
    /// <summary>
    /// SMPTE-170M or BT.601-6 525
    /// </summary>
    [Name("smpte170m")] smpte170m,
    /// <summary>
    /// SMPTE-240M
    /// </summary>
    [Name("smpte240m")] smpte240m,
    /// <summary>
    /// film
    /// </summary>
    [Name("film")] film,
    /// <summary>
    /// SMPTE-431
    /// </summary>
    [Name("smpte431")] smpte431,
    /// <summary>
    /// SMPTE-432
    /// </summary>
    [Name("smpte432")] smpte432,
    /// <summary>
    /// BT.2020
    /// </summary>
    [Name("bt2020")] bt2020,
    /// <summary>
    /// JEDEC P22 phosphors
    /// </summary>
    [Name("jedec-p22")] jedec_p22
  }

  public enum ColorspaceRange
  {
    /// <summary>
    /// TV (restricted) range
    /// </summary>
    tv,
    /// <summary>
    /// MPEG (restricted) range
    /// </summary>
    mpeg,
    /// <summary>
    /// PC (full) range
    /// </summary>
    pc,
    /// <summary>
    /// JPEG (full) range
    /// </summary>
    jpeg
  }

  public enum ColorspaceFormat
  {
    /// <summary>
    /// YUV 4:2:0 planar 8-bits
    /// </summary>
    yuv420p,
    /// <summary>
    /// YUV 4:2:0 planar 10-bits
    /// </summary>
    yuv420p10,
    /// <summary>
    /// YUV 4:2:0 planar 12-bits
    /// </summary>
    yuv420p12,
    /// <summary>
    /// YUV 4:2:2 planar 8-bits
    /// </summary>
    yuv422p,
    /// <summary>
    /// YUV 4:2:2 planar 10-bits
    /// </summary>
    yuv422p10,
    /// <summary>
    /// YUV 4:2:2 planar 12-bits
    /// </summary>
    yuv422p12,
    /// <summary>
    /// YUV 4:4:4 planar 8-bits
    /// </summary>
    yuv444p,
    /// <summary>
    /// YUV 4:4:4 planar 10-bits
    /// </summary>
    yuv444p10,
    /// <summary>
    /// YUV 4:4:4 planar 12-bits
    /// </summary>
    yuv444p12
  }

  public enum ColorspaceDither
  {
    /// <summary>
    /// No dithering
    /// </summary>
    none,
    /// <summary>
    /// Floyd-Steinberg dithering
    /// </summary>
    fsb
  }

  public enum ColorspaceWpadapt
  {
    /// <summary>
    /// Bradford whitepoint adaptation
    /// </summary>
    bradford,
    /// <summary>
    /// von Kries whitepoint adaptation
    /// </summary>
    vonkries,
    /// <summary>
    /// identity whitepoint adaptation (i.e. no whitepoint adaptation)
    /// </summary>
    identity
  }
}
