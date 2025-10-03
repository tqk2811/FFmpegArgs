﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... field             V-&gt;V       Extract a field from the input video.
    /// </summary>
    public class FieldFilterGen : ImageToImageFilter
    {
        internal FieldFilterGen(ImageMap input) : base("field", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set field type (top or bottom) (from 0 to 1) (default top)
        /// </summary>
        public FieldFilterGen type(FieldFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set field type (top or bottom) (from 0 to 1) (default top)
    /// </summary>
    public enum FieldFilterGenType
    {
        /// <summary>
        /// top             0            ..FV....... select top field
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("top")]
        top = 0,
        /// <summary>
        /// bottom          1            ..FV....... select bottom field
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bottom")]
        bottom = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Extract a field from the input video.
        /// </summary>
        public static FieldFilterGen FieldFilterGen(this ImageMap input0) => new FieldFilterGen(input0);
    }
}