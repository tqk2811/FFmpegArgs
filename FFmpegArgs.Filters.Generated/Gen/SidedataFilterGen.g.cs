namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. sidedata          V-&gt;V       Manipulate video frame side data.
    /// </summary>
    public class SidedataFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal SidedataFilterGen(ImageMap input) : base("sidedata", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set a mode of operation (from 0 to 1) (default select)
        /// </summary>
        public SidedataFilterGen mode(SidedataFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set side data type (from -1 to INT_MAX) (default -1)
        /// </summary>
        public SidedataFilterGen type(SidedataFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set a mode of operation (from 0 to 1) (default select)
    /// </summary>
    public enum SidedataFilterGenMode
    {
        /// <summary>
        /// select          0            ..FV....... select frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("select")]
        select = 0,
        /// <summary>
        /// delete          1            ..FV....... delete side data
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("delete")]
        delete = 1
    }

    /// <summary>
    ///  set side data type (from -1 to INT_MAX) (default -1)
    /// </summary>
    public enum SidedataFilterGenType
    {
        /// <summary>
        /// PANSCAN         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("PANSCAN")]
        PANSCAN = 0,
        /// <summary>
        /// A53_CC          1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("A53_CC")]
        A53_CC = 1,
        /// <summary>
        /// STEREO3D        2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("STEREO3D")]
        STEREO3D = 2,
        /// <summary>
        /// MATRIXENCODING  3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("MATRIXENCODING")]
        MATRIXENCODING = 3,
        /// <summary>
        /// DOWNMIX_INFO    4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("DOWNMIX_INFO")]
        DOWNMIX_INFO = 4,
        /// <summary>
        /// REPLAYGAIN      5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("REPLAYGAIN")]
        REPLAYGAIN = 5,
        /// <summary>
        /// DISPLAYMATRIX   6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("DISPLAYMATRIX")]
        DISPLAYMATRIX = 6,
        /// <summary>
        /// AFD             7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("AFD")]
        AFD = 7,
        /// <summary>
        /// MOTION_VECTORS  8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("MOTION_VECTORS")]
        MOTION_VECTORS = 8,
        /// <summary>
        /// SKIP_SAMPLES    9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("SKIP_SAMPLES")]
        SKIP_SAMPLES = 9,
        /// <summary>
        /// AUDIO_SERVICE_TYPE 10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("AUDIO_SERVICE_TYPE")]
        AUDIO_SERVICE_TYPE = 10,
        /// <summary>
        /// MASTERING_DISPLAY_METADATA 11           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("MASTERING_DISPLAY_METADATA")]
        MASTERING_DISPLAY_METADATA = 11,
        /// <summary>
        /// GOP_TIMECODE    12           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("GOP_TIMECODE")]
        GOP_TIMECODE = 12,
        /// <summary>
        /// SPHERICAL       13           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("SPHERICAL")]
        SPHERICAL = 13,
        /// <summary>
        /// CONTENT_LIGHT_LEVEL 14           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("CONTENT_LIGHT_LEVEL")]
        CONTENT_LIGHT_LEVEL = 14,
        /// <summary>
        /// ICC_PROFILE     15           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ICC_PROFILE")]
        ICC_PROFILE = 15,
        /// <summary>
        /// S12M_TIMECOD    16           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("S12M_TIMECOD")]
        S12M_TIMECOD = 16,
        /// <summary>
        /// DYNAMIC_HDR_PLUS 17           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("DYNAMIC_HDR_PLUS")]
        DYNAMIC_HDR_PLUS = 17,
        /// <summary>
        /// REGIONS_OF_INTEREST 18           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("REGIONS_OF_INTEREST")]
        REGIONS_OF_INTEREST = 18,
        /// <summary>
        /// VIDEO_ENC_PARAMS 19           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("VIDEO_ENC_PARAMS")]
        VIDEO_ENC_PARAMS = 19,
        /// <summary>
        /// SEI_UNREGISTERED 20           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("SEI_UNREGISTERED")]
        SEI_UNREGISTERED = 20,
        /// <summary>
        /// FILM_GRAIN_PARAMS 21           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("FILM_GRAIN_PARAMS")]
        FILM_GRAIN_PARAMS = 21,
        /// <summary>
        /// DETECTION_BOUNDING_BOXES 22           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("DETECTION_BOUNDING_BOXES")]
        DETECTION_BOUNDING_BOXES = 22,
        /// <summary>
        /// DETECTION_BBOXES 22           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("DETECTION_BBOXES")]
        DETECTION_BBOXES = 22,
        /// <summary>
        /// DOVI_RPU_BUFFER 23           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("DOVI_RPU_BUFFER")]
        DOVI_RPU_BUFFER = 23,
        /// <summary>
        /// DOVI_METADATA   24           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("DOVI_METADATA")]
        DOVI_METADATA = 24,
        /// <summary>
        /// DYNAMIC_HDR_VIVID 25           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("DYNAMIC_HDR_VIVID")]
        DYNAMIC_HDR_VIVID = 25,
        /// <summary>
        /// AMBIENT_VIEWING_ENVIRONMENT 26           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("AMBIENT_VIEWING_ENVIRONMENT")]
        AMBIENT_VIEWING_ENVIRONMENT = 26,
        /// <summary>
        /// VIDEO_HINT      27           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("VIDEO_HINT")]
        VIDEO_HINT = 27
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Manipulate video frame side data.
        /// </summary>
        public static SidedataFilterGen SidedataFilterGen(this ImageMap input0) => new SidedataFilterGen(input0);
    }
}