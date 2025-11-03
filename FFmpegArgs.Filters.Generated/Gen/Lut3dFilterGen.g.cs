namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS lut3d             V-&gt;V       Adjust colors using a 3D LUT.
    /// </summary>
    public class Lut3dFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal Lut3dFilterGen(ImageMap input) : base("lut3d", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set 3D LUT file name
        /// </summary>
        public Lut3dFilterGen file(String file) => this.SetOption("file", file.ToStringInv());
        /// <summary>
        ///  when to process CLUT (from 0 to 1) (default all)
        /// </summary>
        public Lut3dFilterGen clut(Lut3dFilterGenClut clut) => this.SetOption("clut", clut.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  select interpolation mode (from 0 to 4) (default tetrahedral)
        /// </summary>
        public Lut3dFilterGen interp(Lut3dFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  when to process CLUT (from 0 to 1) (default all)
    /// </summary>
    public enum Lut3dFilterGenClut
    {
        /// <summary>
        /// first           0            ..FV.....T. process only first CLUT, ignore rest
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("first")]
        first = 0,
        /// <summary>
        /// all             1            ..FV.....T. process all CLUTs
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("all")]
        all = 1
    }

    /// <summary>
    ///  select interpolation mode (from 0 to 4) (default tetrahedral)
    /// </summary>
    public enum Lut3dFilterGenInterp
    {
        /// <summary>
        /// nearest         0            ..FV.....T. use values from the nearest defined points
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nearest")]
        nearest = 0,
        /// <summary>
        /// trilinear       1            ..FV.....T. interpolate values using the 8 points defining a cube
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("trilinear")]
        trilinear = 1,
        /// <summary>
        /// tetrahedral     2            ..FV.....T. interpolate values using a tetrahedron
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tetrahedral")]
        tetrahedral = 2,
        /// <summary>
        /// pyramid         3            ..FV.....T. interpolate values using a pyramid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pyramid")]
        pyramid = 3,
        /// <summary>
        /// prism           4            ..FV.....T. interpolate values using a prism
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("prism")]
        prism = 4
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Adjust colors using a 3D LUT.
        /// </summary>
        public static Lut3dFilterGen Lut3dFilterGen(this ImageMap input0) => new Lut3dFilterGen(input0);
    }
}