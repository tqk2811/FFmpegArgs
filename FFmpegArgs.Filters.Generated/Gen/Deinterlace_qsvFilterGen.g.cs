namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... deinterlace_qsv   V-&gt;V       Quick Sync Video &quot;deinterlacing&quot;
    /// </summary>
    public class Deinterlace_qsvFilterGen : ImageToImageFilter
    {
        internal Deinterlace_qsvFilterGen(ImageMap input) : base("deinterlace_qsv", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set deinterlace mode (from 1 to 2) (default advanced)
        /// </summary>
        public Deinterlace_qsvFilterGen mode(Deinterlace_qsvFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set deinterlace mode (from 1 to 2) (default advanced)
    /// </summary>
    public enum Deinterlace_qsvFilterGenMode
    {
        /// <summary>
        /// bob             1            ..FV....... bob algorithm
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bob")]
        bob = 1,
        /// <summary>
        /// advanced        2            ..FV....... Motion adaptive algorithm
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("advanced")]
        advanced = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Quick Sync Video &quot;deinterlacing&quot;
        /// </summary>
        public static Deinterlace_qsvFilterGen Deinterlace_qsvFilterGen(this ImageMap input0) => new Deinterlace_qsvFilterGen(input0);
    }
}