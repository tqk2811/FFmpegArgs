﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... paletteuse        VV-&gt;V      Use a palette to downsample an input video stream.
    /// </summary>
    public class PaletteuseFilterGen : ImageToImageFilter
    {
        internal PaletteuseFilterGen(params ImageMap[] inputs) : base("paletteuse", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  select dithering mode (from 0 to 8) (default sierra2_4a)
        /// </summary>
        public PaletteuseFilterGen dither(PaletteuseFilterGenDither dither) => this.SetOption("dither", dither.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set scale for bayer dithering (from 0 to 5) (default 2)
        /// </summary>
        public PaletteuseFilterGen bayer_scale(int bayer_scale) => this.SetOptionRange("bayer_scale", bayer_scale, 0, 5);
        /// <summary>
        ///  set frame difference mode (from 0 to 1) (default 0)
        /// </summary>
        public PaletteuseFilterGen diff_mode(PaletteuseFilterGenDiff_mode diff_mode) => this.SetOption("diff_mode", diff_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  take new palette for each output frame (default false)
        /// </summary>
        public PaletteuseFilterGen _new(bool _new) => this.SetOption("new", _new.ToFFmpegFlag());
        /// <summary>
        ///  set the alpha threshold for transparency (from 0 to 255) (default 128)
        /// </summary>
        public PaletteuseFilterGen alpha_threshold(int alpha_threshold) => this.SetOptionRange("alpha_threshold", alpha_threshold, 0, 255);
        /// <summary>
        ///  save Graphviz graph of the kdtree in specified file
        /// </summary>
        public PaletteuseFilterGen debug_kdtree(String debug_kdtree) => this.SetOption("debug_kdtree", debug_kdtree.ToString());
    }

    /// <summary>
    ///  select dithering mode (from 0 to 8) (default sierra2_4a)
    /// </summary>
    public enum PaletteuseFilterGenDither
    {
        /// <summary>
        /// bayer           1            ..FV....... ordered 8x8 bayer dithering (deterministic)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bayer")]
        bayer = 1,
        /// <summary>
        /// heckbert        2            ..FV....... dithering as defined by Paul Heckbert in 1982 (simple error diffusion)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("heckbert")]
        heckbert = 2,
        /// <summary>
        /// floyd_steinberg 3            ..FV....... Floyd and Steingberg dithering (error diffusion)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("floyd_steinberg")]
        floyd_steinberg = 3,
        /// <summary>
        /// sierra2         4            ..FV....... Frankie Sierra dithering v2 (error diffusion)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sierra2")]
        sierra2 = 4,
        /// <summary>
        /// sierra2_4a      5            ..FV....... Frankie Sierra dithering v2 &quot;Lite&quot; (error diffusion)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sierra2_4a")]
        sierra2_4a = 5,
        /// <summary>
        /// sierra3         6            ..FV....... Frankie Sierra dithering v3 (error diffusion)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sierra3")]
        sierra3 = 6,
        /// <summary>
        /// burkes          7            ..FV....... Burkes dithering (error diffusion)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("burkes")]
        burkes = 7,
        /// <summary>
        /// atkinson        8            ..FV....... Atkinson dithering by Bill Atkinson at Apple Computer (error diffusion)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("atkinson")]
        atkinson = 8
    }

    /// <summary>
    ///  set frame difference mode (from 0 to 1) (default 0)
    /// </summary>
    public enum PaletteuseFilterGenDiff_mode
    {
        /// <summary>
        /// rectangle       1            ..FV....... process smallest different rectangle
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rectangle")]
        rectangle = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Use a palette to downsample an input video stream.
        /// </summary>
        public static PaletteuseFilterGen PaletteuseFilterGen(this ImageMap input0, ImageMap input1) => new PaletteuseFilterGen(input0, input1);
    }
}