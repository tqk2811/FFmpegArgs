namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. blend_vulkan      VV-&gt;V      Blend two video frames in Vulkan
    /// </summary>
    public class Blend_vulkanFilterGen : ImageToImageFilter
    {
        internal Blend_vulkanFilterGen(params ImageMap[] inputs) : base("blend_vulkan", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set component #0 blend mode (from 0 to 39) (default normal)
        /// </summary>
        public Blend_vulkanFilterGen c0_mode(Blend_vulkanFilterGenC0_mode c0_mode) => this.SetOption("c0_mode", c0_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set component #1 blend mode (from 0 to 39) (default normal)
        /// </summary>
        public Blend_vulkanFilterGen c1_mode(Blend_vulkanFilterGenC1_mode c1_mode) => this.SetOption("c1_mode", c1_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set component #2 blend mode (from 0 to 39) (default normal)
        /// </summary>
        public Blend_vulkanFilterGen c2_mode(Blend_vulkanFilterGenC2_mode c2_mode) => this.SetOption("c2_mode", c2_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set component #3 blend mode (from 0 to 39) (default normal)
        /// </summary>
        public Blend_vulkanFilterGen c3_mode(Blend_vulkanFilterGenC3_mode c3_mode) => this.SetOption("c3_mode", c3_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set blend mode for all components (from -1 to 39) (default -1)
        /// </summary>
        public Blend_vulkanFilterGen all_mode(Blend_vulkanFilterGenAll_mode all_mode) => this.SetOption("all_mode", all_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set color component #0 opacity (from 0 to 1) (default 1)
        /// </summary>
        public Blend_vulkanFilterGen c0_opacity(double c0_opacity) => this.SetOptionRange("c0_opacity", c0_opacity, 0, 1);
        /// <summary>
        ///  set color component #1 opacity (from 0 to 1) (default 1)
        /// </summary>
        public Blend_vulkanFilterGen c1_opacity(double c1_opacity) => this.SetOptionRange("c1_opacity", c1_opacity, 0, 1);
        /// <summary>
        ///  set color component #2 opacity (from 0 to 1) (default 1)
        /// </summary>
        public Blend_vulkanFilterGen c2_opacity(double c2_opacity) => this.SetOptionRange("c2_opacity", c2_opacity, 0, 1);
        /// <summary>
        ///  set color component #3 opacity (from 0 to 1) (default 1)
        /// </summary>
        public Blend_vulkanFilterGen c3_opacity(double c3_opacity) => this.SetOptionRange("c3_opacity", c3_opacity, 0, 1);
        /// <summary>
        ///  set opacity for all color components (from 0 to 1) (default 1)
        /// </summary>
        public Blend_vulkanFilterGen all_opacity(double all_opacity) => this.SetOptionRange("all_opacity", all_opacity, 0, 1);
    }

    /// <summary>
    ///  set component #0 blend mode (from 0 to 39) (default normal)
    /// </summary>
    public enum Blend_vulkanFilterGenC0_mode
    {
        /// <summary>
        /// normal          0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// multiply        13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply")]
        multiply = 13
    }

    /// <summary>
    ///  set component #1 blend mode (from 0 to 39) (default normal)
    /// </summary>
    public enum Blend_vulkanFilterGenC1_mode
    {
        /// <summary>
        /// normal          0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// multiply        13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply")]
        multiply = 13
    }

    /// <summary>
    ///  set component #2 blend mode (from 0 to 39) (default normal)
    /// </summary>
    public enum Blend_vulkanFilterGenC2_mode
    {
        /// <summary>
        /// normal          0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// multiply        13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply")]
        multiply = 13
    }

    /// <summary>
    ///  set component #3 blend mode (from 0 to 39) (default normal)
    /// </summary>
    public enum Blend_vulkanFilterGenC3_mode
    {
        /// <summary>
        /// normal          0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// multiply        13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply")]
        multiply = 13
    }

    /// <summary>
    ///  set blend mode for all components (from -1 to 39) (default -1)
    /// </summary>
    public enum Blend_vulkanFilterGenAll_mode
    {
        /// <summary>
        /// normal          0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("normal")]
        normal = 0,
        /// <summary>
        /// multiply        13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multiply")]
        multiply = 13
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Blend two video frames in Vulkan
        /// </summary>
        public static Blend_vulkanFilterGen Blend_vulkanFilterGen(this ImageMap input0, ImageMap input1) => new Blend_vulkanFilterGen(input0, input1);
    }
}