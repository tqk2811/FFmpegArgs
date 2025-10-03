﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... hwupload          V-&gt;V       Upload a normal frame to a hardware frame
    /// </summary>
    public class HwuploadFilterGen : ImageToImageFilter
    {
        internal HwuploadFilterGen(ImageMap input) : base("hwupload", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Derive a new device of this type
        /// </summary>
        public HwuploadFilterGen derive_device(String derive_device) => this.SetOption("derive_device", derive_device.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Upload a normal frame to a hardware frame
        /// </summary>
        public static HwuploadFilterGen HwuploadFilterGen(this ImageMap input0) => new HwuploadFilterGen(input0);
    }
}