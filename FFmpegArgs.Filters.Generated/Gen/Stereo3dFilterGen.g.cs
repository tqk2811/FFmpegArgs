namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S stereo3d          V-&gt;V       Convert video stereoscopic 3D view.
    /// </summary>
    public class Stereo3dFilterGen : ImageToImageFilter, ISliceThreading
    {
        internal Stereo3dFilterGen(ImageMap input) : base("stereo3d", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set input format (from 16 to 32) (default sbsl)
        /// </summary>
        public Stereo3dFilterGen _in(Stereo3dFilterGenIn _in) => this.SetOption("in", _in.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set output format (from 0 to 32) (default arcd)
        /// </summary>
        public Stereo3dFilterGen _out(Stereo3dFilterGenOut _out) => this.SetOption("out", _out.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set input format (from 16 to 32) (default sbsl)
    /// </summary>
    public enum Stereo3dFilterGenIn
    {
        /// <summary>
        /// ab2l            24           ..FV....... above below half height left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ab2l")]
        ab2l = 24,
        /// <summary>
        /// tb2l            24           ..FV....... above below half height left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tb2l")]
        tb2l = 24,
        /// <summary>
        /// ab2r            25           ..FV....... above below half height right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ab2r")]
        ab2r = 25,
        /// <summary>
        /// tb2r            25           ..FV....... above below half height right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tb2r")]
        tb2r = 25,
        /// <summary>
        /// abl             22           ..FV....... above below left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("abl")]
        abl = 22,
        /// <summary>
        /// tbl             22           ..FV....... above below left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tbl")]
        tbl = 22,
        /// <summary>
        /// abr             23           ..FV....... above below right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("abr")]
        abr = 23,
        /// <summary>
        /// tbr             23           ..FV....... above below right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tbr")]
        tbr = 23,
        /// <summary>
        /// al              26           ..FV....... alternating frames left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("al")]
        al = 26,
        /// <summary>
        /// ar              27           ..FV....... alternating frames right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ar")]
        ar = 27,
        /// <summary>
        /// sbs2l           20           ..FV....... side by side half width left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbs2l")]
        sbs2l = 20,
        /// <summary>
        /// sbs2r           21           ..FV....... side by side half width right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbs2r")]
        sbs2r = 21,
        /// <summary>
        /// sbsl            18           ..FV....... side by side left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbsl")]
        sbsl = 18,
        /// <summary>
        /// sbsr            19           ..FV....... side by side right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbsr")]
        sbsr = 19,
        /// <summary>
        /// irl             16           ..FV....... interleave rows left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("irl")]
        irl = 16,
        /// <summary>
        /// irr             17           ..FV....... interleave rows right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("irr")]
        irr = 17,
        /// <summary>
        /// icl             30           ..FV....... interleave columns left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("icl")]
        icl = 30,
        /// <summary>
        /// icr             31           ..FV....... interleave columns right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("icr")]
        icr = 31
    }

    /// <summary>
    ///  set output format (from 0 to 32) (default arcd)
    /// </summary>
    public enum Stereo3dFilterGenOut
    {
        /// <summary>
        /// ab2l            24           ..FV....... above below half height left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ab2l")]
        ab2l = 24,
        /// <summary>
        /// tb2l            24           ..FV....... above below half height left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tb2l")]
        tb2l = 24,
        /// <summary>
        /// ab2r            25           ..FV....... above below half height right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ab2r")]
        ab2r = 25,
        /// <summary>
        /// tb2r            25           ..FV....... above below half height right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tb2r")]
        tb2r = 25,
        /// <summary>
        /// abl             22           ..FV....... above below left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("abl")]
        abl = 22,
        /// <summary>
        /// tbl             22           ..FV....... above below left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tbl")]
        tbl = 22,
        /// <summary>
        /// abr             23           ..FV....... above below right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("abr")]
        abr = 23,
        /// <summary>
        /// tbr             23           ..FV....... above below right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tbr")]
        tbr = 23,
        /// <summary>
        /// agmc            6            ..FV....... anaglyph green magenta color
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("agmc")]
        agmc = 6,
        /// <summary>
        /// agmd            7            ..FV....... anaglyph green magenta dubois
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("agmd")]
        agmd = 7,
        /// <summary>
        /// agmg            4            ..FV....... anaglyph green magenta gray
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("agmg")]
        agmg = 4,
        /// <summary>
        /// agmh            5            ..FV....... anaglyph green magenta half color
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("agmh")]
        agmh = 5,
        /// <summary>
        /// al              26           ..FV....... alternating frames left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("al")]
        al = 26,
        /// <summary>
        /// ar              27           ..FV....... alternating frames right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ar")]
        ar = 27,
        /// <summary>
        /// arbg            12           ..FV....... anaglyph red blue gray
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arbg")]
        arbg = 12,
        /// <summary>
        /// arcc            2            ..FV....... anaglyph red cyan color
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arcc")]
        arcc = 2,
        /// <summary>
        /// arcd            3            ..FV....... anaglyph red cyan dubois
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arcd")]
        arcd = 3,
        /// <summary>
        /// arcg            0            ..FV....... anaglyph red cyan gray
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arcg")]
        arcg = 0,
        /// <summary>
        /// arch            1            ..FV....... anaglyph red cyan half color
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("arch")]
        arch = 1,
        /// <summary>
        /// argg            13           ..FV....... anaglyph red green gray
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("argg")]
        argg = 13,
        /// <summary>
        /// aybc            10           ..FV....... anaglyph yellow blue color
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("aybc")]
        aybc = 10,
        /// <summary>
        /// aybd            11           ..FV....... anaglyph yellow blue dubois
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("aybd")]
        aybd = 11,
        /// <summary>
        /// aybg            8            ..FV....... anaglyph yellow blue gray
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("aybg")]
        aybg = 8,
        /// <summary>
        /// aybh            9            ..FV....... anaglyph yellow blue half color
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("aybh")]
        aybh = 9,
        /// <summary>
        /// irl             16           ..FV....... interleave rows left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("irl")]
        irl = 16,
        /// <summary>
        /// irr             17           ..FV....... interleave rows right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("irr")]
        irr = 17,
        /// <summary>
        /// ml              14           ..FV....... mono left
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ml")]
        ml = 14,
        /// <summary>
        /// mr              15           ..FV....... mono right
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mr")]
        mr = 15,
        /// <summary>
        /// sbs2l           20           ..FV....... side by side half width left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbs2l")]
        sbs2l = 20,
        /// <summary>
        /// sbs2r           21           ..FV....... side by side half width right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbs2r")]
        sbs2r = 21,
        /// <summary>
        /// sbsl            18           ..FV....... side by side left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbsl")]
        sbsl = 18,
        /// <summary>
        /// sbsr            19           ..FV....... side by side right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbsr")]
        sbsr = 19,
        /// <summary>
        /// chl             28           ..FV....... checkerboard left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("chl")]
        chl = 28,
        /// <summary>
        /// chr             29           ..FV....... checkerboard right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("chr")]
        chr = 29,
        /// <summary>
        /// icl             30           ..FV....... interleave columns left first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("icl")]
        icl = 30,
        /// <summary>
        /// icr             31           ..FV....... interleave columns right first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("icr")]
        icr = 31,
        /// <summary>
        /// hdmi            32           ..FV....... HDMI frame pack
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hdmi")]
        hdmi = 32
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert video stereoscopic 3D view.
        /// </summary>
        public static Stereo3dFilterGen Stereo3dFilterGen(this ImageMap input0) => new Stereo3dFilterGen(input0);
    }
}