namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. ssim360           VV-&gt;V      Calculate the SSIM between two 360 video streams.
    /// </summary>
    public class Ssim360FilterGen : ImageToImageFilter
    {
        internal Ssim360FilterGen(params ImageMap[] inputs) : base("ssim360", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set file where to store per-frame difference information
        /// </summary>
        public Ssim360FilterGen stats_file(String stats_file) => this.SetOption("stats_file", stats_file.ToString());
        /// <summary>
        ///  Set file where to store per-frame difference information
        /// </summary>
        public Ssim360FilterGen f(String f) => this.SetOption("f", f.ToString());
        /// <summary>
        ///  Specifies if non-luma channels must be computed (from 0 to 1) (default 1)
        /// </summary>
        public Ssim360FilterGen compute_chroma(int compute_chroma) => this.SetOptionRange("compute_chroma", compute_chroma, 0, 1);
        /// <summary>
        ///  Specifies the number of frames to be skipped from evaluation, for every evaluated frame (from 0 to 1e+06) (default 0)
        /// </summary>
        public Ssim360FilterGen frame_skip_ratio(int frame_skip_ratio) => this.SetOptionRange("frame_skip_ratio", frame_skip_ratio, 0, 1e+06);
        /// <summary>
        ///  projection of the reference video (from 0 to 4) (default e)
        /// </summary>
        public Ssim360FilterGen ref_projection(Ssim360FilterGenRef_projection ref_projection) => this.SetOption("ref_projection", ref_projection.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  projection of the main video (from 0 to 5) (default 5)
        /// </summary>
        public Ssim360FilterGen main_projection(Ssim360FilterGenMain_projection main_projection) => this.SetOption("main_projection", main_projection.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  stereo format of the reference video (from 0 to 2) (default mono)
        /// </summary>
        public Ssim360FilterGen ref_stereo(Ssim360FilterGenRef_stereo ref_stereo) => this.SetOption("ref_stereo", ref_stereo.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  stereo format of main video (from 0 to 3) (default 3)
        /// </summary>
        public Ssim360FilterGen main_stereo(Ssim360FilterGenMain_stereo main_stereo) => this.SetOption("main_stereo", main_stereo.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Expansion (padding) coefficient for each cube face of the reference video (from 0 to 10) (default 0)
        /// </summary>
        public Ssim360FilterGen ref_pad(float ref_pad) => this.SetOptionRange("ref_pad", ref_pad, 0, 10);
        /// <summary>
        ///  Expansion (padding) coefficient for each cube face of the main video (from 0 to 10) (default 0)
        /// </summary>
        public Ssim360FilterGen main_pad(float main_pad) => this.SetOptionRange("main_pad", main_pad, 0, 10);
        /// <summary>
        ///  Specifies if the tape based SSIM 360 algorithm must be used independent of the input video types (from 0 to 1) (default 0)
        /// </summary>
        public Ssim360FilterGen use_tape(int use_tape) => this.SetOptionRange("use_tape", use_tape, 0, 1);
        /// <summary>
        ///  Heatmap data for view-based evaluation. For heatmap file format, please refer to EntSphericalVideoHeatmapData.
        /// </summary>
        public Ssim360FilterGen heatmap_str(String heatmap_str) => this.SetOption("heatmap_str", heatmap_str.ToString());
        /// <summary>
        ///  Default heatmap dimension. Will be used when dimension is not specified in heatmap data. (from 1 to 4096) (default 32)
        /// </summary>
        public Ssim360FilterGen default_heatmap_width(int default_heatmap_width) => this.SetOptionRange("default_heatmap_width", default_heatmap_width, 1, 4096);
        /// <summary>
        ///  Default heatmap dimension. Will be used when dimension is not specified in heatmap data. (from 1 to 4096) (default 16)
        /// </summary>
        public Ssim360FilterGen default_heatmap_height(int default_heatmap_height) => this.SetOptionRange("default_heatmap_height", default_heatmap_height, 1, 4096);
    }

    /// <summary>
    ///  projection of the reference video (from 0 to 4) (default e)
    /// </summary>
    public enum Ssim360FilterGenRef_projection
    {
        /// <summary>
        /// e               4            ..FV....... equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("e")]
        e = 4,
        /// <summary>
        /// equirect        4            ..FV....... equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("equirect")]
        equirect = 4,
        /// <summary>
        /// c3x2            0            ..FV....... cubemap 3x2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c3x2")]
        c3x2 = 0,
        /// <summary>
        /// c2x3            1            ..FV....... cubemap 2x3
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c2x3")]
        c2x3 = 1,
        /// <summary>
        /// barrel          2            ..FV....... barrel facebook&#39;s 360 format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("barrel")]
        barrel = 2,
        /// <summary>
        /// barrelsplit     3            ..FV....... barrel split facebook&#39;s 360 format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("barrelsplit")]
        barrelsplit = 3
    }

    /// <summary>
    ///  projection of the main video (from 0 to 5) (default 5)
    /// </summary>
    public enum Ssim360FilterGenMain_projection
    {
        /// <summary>
        /// e               4            ..FV....... equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("e")]
        e = 4,
        /// <summary>
        /// equirect        4            ..FV....... equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("equirect")]
        equirect = 4,
        /// <summary>
        /// c3x2            0            ..FV....... cubemap 3x2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c3x2")]
        c3x2 = 0,
        /// <summary>
        /// c2x3            1            ..FV....... cubemap 2x3
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c2x3")]
        c2x3 = 1,
        /// <summary>
        /// barrel          2            ..FV....... barrel facebook&#39;s 360 format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("barrel")]
        barrel = 2,
        /// <summary>
        /// barrelsplit     3            ..FV....... barrel split facebook&#39;s 360 format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("barrelsplit")]
        barrelsplit = 3
    }

    /// <summary>
    ///  stereo format of the reference video (from 0 to 2) (default mono)
    /// </summary>
    public enum Ssim360FilterGenRef_stereo
    {
        /// <summary>
        /// mono            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mono")]
        mono = 2,
        /// <summary>
        /// tb              0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tb")]
        tb = 0,
        /// <summary>
        /// lr              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lr")]
        lr = 1
    }

    /// <summary>
    ///  stereo format of main video (from 0 to 3) (default 3)
    /// </summary>
    public enum Ssim360FilterGenMain_stereo
    {
        /// <summary>
        /// mono            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mono")]
        mono = 2,
        /// <summary>
        /// tb              0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tb")]
        tb = 0,
        /// <summary>
        /// lr              1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lr")]
        lr = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Calculate the SSIM between two 360 video streams.
        /// </summary>
        public static Ssim360FilterGen Ssim360FilterGen(this ImageMap input0, ImageMap input1) => new Ssim360FilterGen(input0, input1);
    }
}