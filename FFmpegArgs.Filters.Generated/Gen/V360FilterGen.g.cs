namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S v360              V-&gt;V       Convert 360 projection of video.
    /// </summary>
    public class V360FilterGen : ImageToImageFilter, ISliceThreading
    {
        internal V360FilterGen(ImageMap input) : base("v360", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set input projection (from 0 to 24) (default e)
        /// </summary>
        public V360FilterGen input(V360FilterGenInput input) => this.SetOption("input", input.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set output projection (from 0 to 24) (default c3x2)
        /// </summary>
        public V360FilterGen output(V360FilterGenOutput output) => this.SetOption("output", output.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set interpolation method (from 0 to 7) (default line)
        /// </summary>
        public V360FilterGen interp(V360FilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  output width (from 0 to 32767) (default 0)
        /// </summary>
        public V360FilterGen w(int w) => this.SetOptionRange("w", w, 0, 32767);
        /// <summary>
        ///  output height (from 0 to 32767) (default 0)
        /// </summary>
        public V360FilterGen h(int h) => this.SetOptionRange("h", h, 0, 32767);
        /// <summary>
        ///  input stereo format (from 0 to 2) (default 2d)
        /// </summary>
        public V360FilterGen in_stereo(V360FilterGenIn_stereo in_stereo) => this.SetOption("in_stereo", in_stereo.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  output stereo format (from 0 to 2) (default 2d)
        /// </summary>
        public V360FilterGen out_stereo(V360FilterGenOut_stereo out_stereo) => this.SetOption("out_stereo", out_stereo.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  input cubemap face order (default &quot;rludfb&quot;)
        /// </summary>
        public V360FilterGen in_forder(String in_forder) => this.SetOption("in_forder", in_forder.ToString());
        /// <summary>
        ///  output cubemap face order (default &quot;rludfb&quot;)
        /// </summary>
        public V360FilterGen out_forder(String out_forder) => this.SetOption("out_forder", out_forder.ToString());
        /// <summary>
        ///  input cubemap face rotation (default &quot;000000&quot;)
        /// </summary>
        public V360FilterGen in_frot(String in_frot) => this.SetOption("in_frot", in_frot.ToString());
        /// <summary>
        ///  output cubemap face rotation (default &quot;000000&quot;)
        /// </summary>
        public V360FilterGen out_frot(String out_frot) => this.SetOption("out_frot", out_frot.ToString());
        /// <summary>
        ///  percent input cubemap pads (from 0 to 0.1) (default 0)
        /// </summary>
        public V360FilterGen in_pad(float in_pad) => this.SetOptionRange("in_pad", in_pad, 0, 0.1);
        /// <summary>
        ///  percent output cubemap pads (from 0 to 0.1) (default 0)
        /// </summary>
        public V360FilterGen out_pad(float out_pad) => this.SetOptionRange("out_pad", out_pad, 0, 0.1);
        /// <summary>
        ///  fixed input cubemap pads (from 0 to 100) (default 0)
        /// </summary>
        public V360FilterGen fin_pad(int fin_pad) => this.SetOptionRange("fin_pad", fin_pad, 0, 100);
        /// <summary>
        ///  fixed output cubemap pads (from 0 to 100) (default 0)
        /// </summary>
        public V360FilterGen fout_pad(int fout_pad) => this.SetOptionRange("fout_pad", fout_pad, 0, 100);
        /// <summary>
        ///  yaw rotation (from -180 to 180) (default 0)
        /// </summary>
        public V360FilterGen yaw(float yaw) => this.SetOptionRange("yaw", yaw, -180, 180);
        /// <summary>
        ///  pitch rotation (from -180 to 180) (default 0)
        /// </summary>
        public V360FilterGen pitch(float pitch) => this.SetOptionRange("pitch", pitch, -180, 180);
        /// <summary>
        ///  roll rotation (from -180 to 180) (default 0)
        /// </summary>
        public V360FilterGen roll(float roll) => this.SetOptionRange("roll", roll, -180, 180);
        /// <summary>
        ///  rotation order (default &quot;ypr&quot;)
        /// </summary>
        public V360FilterGen rorder(String rorder) => this.SetOption("rorder", rorder.ToString());
        /// <summary>
        ///  output horizontal field of view (from 0 to 360) (default 0)
        /// </summary>
        public V360FilterGen h_fov(float h_fov) => this.SetOptionRange("h_fov", h_fov, 0, 360);
        /// <summary>
        ///  output vertical field of view (from 0 to 360) (default 0)
        /// </summary>
        public V360FilterGen v_fov(float v_fov) => this.SetOptionRange("v_fov", v_fov, 0, 360);
        /// <summary>
        ///  output diagonal field of view (from 0 to 360) (default 0)
        /// </summary>
        public V360FilterGen d_fov(float d_fov) => this.SetOptionRange("d_fov", d_fov, 0, 360);
        /// <summary>
        ///  flip out video horizontally (default false)
        /// </summary>
        public V360FilterGen h_flip(bool h_flip) => this.SetOption("h_flip", h_flip.ToFFmpegFlag());
        /// <summary>
        ///  flip out video vertically (default false)
        /// </summary>
        public V360FilterGen v_flip(bool v_flip) => this.SetOption("v_flip", v_flip.ToFFmpegFlag());
        /// <summary>
        ///  flip out video indepth (default false)
        /// </summary>
        public V360FilterGen d_flip(bool d_flip) => this.SetOption("d_flip", d_flip.ToFFmpegFlag());
        /// <summary>
        ///  flip in video horizontally (default false)
        /// </summary>
        public V360FilterGen ih_flip(bool ih_flip) => this.SetOption("ih_flip", ih_flip.ToFFmpegFlag());
        /// <summary>
        ///  flip in video vertically (default false)
        /// </summary>
        public V360FilterGen iv_flip(bool iv_flip) => this.SetOption("iv_flip", iv_flip.ToFFmpegFlag());
        /// <summary>
        ///  transpose video input (default false)
        /// </summary>
        public V360FilterGen in_trans(bool in_trans) => this.SetOption("in_trans", in_trans.ToFFmpegFlag());
        /// <summary>
        ///  transpose video output (default false)
        /// </summary>
        public V360FilterGen out_trans(bool out_trans) => this.SetOption("out_trans", out_trans.ToFFmpegFlag());
        /// <summary>
        ///  input horizontal field of view (from 0 to 360) (default 0)
        /// </summary>
        public V360FilterGen ih_fov(float ih_fov) => this.SetOptionRange("ih_fov", ih_fov, 0, 360);
        /// <summary>
        ///  input vertical field of view (from 0 to 360) (default 0)
        /// </summary>
        public V360FilterGen iv_fov(float iv_fov) => this.SetOptionRange("iv_fov", iv_fov, 0, 360);
        /// <summary>
        ///  input diagonal field of view (from 0 to 360) (default 0)
        /// </summary>
        public V360FilterGen id_fov(float id_fov) => this.SetOptionRange("id_fov", id_fov, 0, 360);
        /// <summary>
        ///  output horizontal off-axis offset (from -1 to 1) (default 0)
        /// </summary>
        public V360FilterGen h_offset(float h_offset) => this.SetOptionRange("h_offset", h_offset, -1, 1);
        /// <summary>
        ///  output vertical off-axis offset (from -1 to 1) (default 0)
        /// </summary>
        public V360FilterGen v_offset(float v_offset) => this.SetOptionRange("v_offset", v_offset, -1, 1);
        /// <summary>
        ///  build mask in alpha plane (default false)
        /// </summary>
        public V360FilterGen alpha_mask(bool alpha_mask) => this.SetOption("alpha_mask", alpha_mask.ToFFmpegFlag());
        /// <summary>
        ///  reset rotation (default false)
        /// </summary>
        public V360FilterGen reset_rot(bool reset_rot) => this.SetOption("reset_rot", reset_rot.ToFFmpegFlag());
    }

    /// <summary>
    ///  set input projection (from 0 to 24) (default e)
    /// </summary>
    public enum V360FilterGenInput
    {
        /// <summary>
        /// e               0            ..FV....... equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("e")]
        e = 0,
        /// <summary>
        /// equirect        0            ..FV....... equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("equirect")]
        equirect = 0,
        /// <summary>
        /// c3x2            1            ..FV....... cubemap 3x2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c3x2")]
        c3x2 = 1,
        /// <summary>
        /// c6x1            2            ..FV....... cubemap 6x1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c6x1")]
        c6x1 = 2,
        /// <summary>
        /// eac             3            ..FV....... equi-angular cubemap
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("eac")]
        eac = 3,
        /// <summary>
        /// dfisheye        5            ..FV....... dual fisheye
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dfisheye")]
        dfisheye = 5,
        /// <summary>
        /// flat            4            ..FV....... regular video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flat")]
        flat = 4,
        /// <summary>
        /// rectilinear     4            ..FV....... regular video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rectilinear")]
        rectilinear = 4,
        /// <summary>
        /// gnomonic        4            ..FV....... regular video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gnomonic")]
        gnomonic = 4,
        /// <summary>
        /// barrel          6            ..FV....... barrel facebook&#39;s 360 format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("barrel")]
        barrel = 6,
        /// <summary>
        /// fb              6            ..FV....... barrel facebook&#39;s 360 format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fb")]
        fb = 6,
        /// <summary>
        /// c1x6            7            ..FV....... cubemap 1x6
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c1x6")]
        c1x6 = 7,
        /// <summary>
        /// sg              8            ..FV....... stereographic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sg")]
        sg = 8,
        /// <summary>
        /// mercator        9            ..FV....... mercator
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mercator")]
        mercator = 9,
        /// <summary>
        /// ball            10           ..FV....... ball
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ball")]
        ball = 10,
        /// <summary>
        /// hammer          11           ..FV....... hammer
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hammer")]
        hammer = 11,
        /// <summary>
        /// sinusoidal      12           ..FV....... sinusoidal
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sinusoidal")]
        sinusoidal = 12,
        /// <summary>
        /// fisheye         13           ..FV....... fisheye
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fisheye")]
        fisheye = 13,
        /// <summary>
        /// pannini         14           ..FV....... pannini
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pannini")]
        pannini = 14,
        /// <summary>
        /// cylindrical     15           ..FV....... cylindrical
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cylindrical")]
        cylindrical = 15,
        /// <summary>
        /// tetrahedron     17           ..FV....... tetrahedron
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tetrahedron")]
        tetrahedron = 17,
        /// <summary>
        /// barrelsplit     18           ..FV....... barrel split facebook&#39;s 360 format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("barrelsplit")]
        barrelsplit = 18,
        /// <summary>
        /// tsp             19           ..FV....... truncated square pyramid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tsp")]
        tsp = 19,
        /// <summary>
        /// hequirect       20           ..FV....... half equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hequirect")]
        hequirect = 20,
        /// <summary>
        /// he              20           ..FV....... half equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("he")]
        he = 20,
        /// <summary>
        /// equisolid       21           ..FV....... equisolid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("equisolid")]
        equisolid = 21,
        /// <summary>
        /// og              22           ..FV....... orthographic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("og")]
        og = 22,
        /// <summary>
        /// octahedron      23           ..FV....... octahedron
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("octahedron")]
        octahedron = 23,
        /// <summary>
        /// cylindricalea   24           ..FV....... cylindrical equal area
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cylindricalea")]
        cylindricalea = 24
    }

    /// <summary>
    ///  set output projection (from 0 to 24) (default c3x2)
    /// </summary>
    public enum V360FilterGenOutput
    {
        /// <summary>
        /// e               0            ..FV....... equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("e")]
        e = 0,
        /// <summary>
        /// equirect        0            ..FV....... equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("equirect")]
        equirect = 0,
        /// <summary>
        /// c3x2            1            ..FV....... cubemap 3x2
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c3x2")]
        c3x2 = 1,
        /// <summary>
        /// c6x1            2            ..FV....... cubemap 6x1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c6x1")]
        c6x1 = 2,
        /// <summary>
        /// eac             3            ..FV....... equi-angular cubemap
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("eac")]
        eac = 3,
        /// <summary>
        /// dfisheye        5            ..FV....... dual fisheye
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dfisheye")]
        dfisheye = 5,
        /// <summary>
        /// flat            4            ..FV....... regular video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flat")]
        flat = 4,
        /// <summary>
        /// rectilinear     4            ..FV....... regular video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rectilinear")]
        rectilinear = 4,
        /// <summary>
        /// gnomonic        4            ..FV....... regular video
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gnomonic")]
        gnomonic = 4,
        /// <summary>
        /// barrel          6            ..FV....... barrel facebook&#39;s 360 format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("barrel")]
        barrel = 6,
        /// <summary>
        /// fb              6            ..FV....... barrel facebook&#39;s 360 format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fb")]
        fb = 6,
        /// <summary>
        /// c1x6            7            ..FV....... cubemap 1x6
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c1x6")]
        c1x6 = 7,
        /// <summary>
        /// sg              8            ..FV....... stereographic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sg")]
        sg = 8,
        /// <summary>
        /// mercator        9            ..FV....... mercator
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mercator")]
        mercator = 9,
        /// <summary>
        /// ball            10           ..FV....... ball
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ball")]
        ball = 10,
        /// <summary>
        /// hammer          11           ..FV....... hammer
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hammer")]
        hammer = 11,
        /// <summary>
        /// sinusoidal      12           ..FV....... sinusoidal
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sinusoidal")]
        sinusoidal = 12,
        /// <summary>
        /// fisheye         13           ..FV....... fisheye
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fisheye")]
        fisheye = 13,
        /// <summary>
        /// pannini         14           ..FV....... pannini
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pannini")]
        pannini = 14,
        /// <summary>
        /// cylindrical     15           ..FV....... cylindrical
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cylindrical")]
        cylindrical = 15,
        /// <summary>
        /// perspective     16           ..FV....... perspective
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("perspective")]
        perspective = 16,
        /// <summary>
        /// tetrahedron     17           ..FV....... tetrahedron
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tetrahedron")]
        tetrahedron = 17,
        /// <summary>
        /// barrelsplit     18           ..FV....... barrel split facebook&#39;s 360 format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("barrelsplit")]
        barrelsplit = 18,
        /// <summary>
        /// tsp             19           ..FV....... truncated square pyramid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tsp")]
        tsp = 19,
        /// <summary>
        /// hequirect       20           ..FV....... half equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hequirect")]
        hequirect = 20,
        /// <summary>
        /// he              20           ..FV....... half equirectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("he")]
        he = 20,
        /// <summary>
        /// equisolid       21           ..FV....... equisolid
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("equisolid")]
        equisolid = 21,
        /// <summary>
        /// og              22           ..FV....... orthographic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("og")]
        og = 22,
        /// <summary>
        /// octahedron      23           ..FV....... octahedron
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("octahedron")]
        octahedron = 23,
        /// <summary>
        /// cylindricalea   24           ..FV....... cylindrical equal area
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cylindricalea")]
        cylindricalea = 24
    }

    /// <summary>
    ///  set interpolation method (from 0 to 7) (default line)
    /// </summary>
    public enum V360FilterGenInterp
    {
        /// <summary>
        /// near            0            ..FV....... nearest neighbour
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("near")]
        near = 0,
        /// <summary>
        /// nearest         0            ..FV....... nearest neighbour
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nearest")]
        nearest = 0,
        /// <summary>
        /// line            1            ..FV....... bilinear interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("line")]
        line = 1,
        /// <summary>
        /// linear          1            ..FV....... bilinear interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 1,
        /// <summary>
        /// lagrange9       2            ..FV....... lagrange9 interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lagrange9")]
        lagrange9 = 2,
        /// <summary>
        /// cube            3            ..FV....... bicubic interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cube")]
        cube = 3,
        /// <summary>
        /// cubic           3            ..FV....... bicubic interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cubic")]
        cubic = 3,
        /// <summary>
        /// lanc            4            ..FV....... lanczos interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lanc")]
        lanc = 4,
        /// <summary>
        /// lanczos         4            ..FV....... lanczos interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lanczos")]
        lanczos = 4,
        /// <summary>
        /// sp16            5            ..FV....... spline16 interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sp16")]
        sp16 = 5,
        /// <summary>
        /// spline16        5            ..FV....... spline16 interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("spline16")]
        spline16 = 5,
        /// <summary>
        /// gauss           6            ..FV....... gaussian interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gauss")]
        gauss = 6,
        /// <summary>
        /// gaussian        6            ..FV....... gaussian interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gaussian")]
        gaussian = 6,
        /// <summary>
        /// mitchell        7            ..FV....... mitchell interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mitchell")]
        mitchell = 7
    }

    /// <summary>
    ///  input stereo format (from 0 to 2) (default 2d)
    /// </summary>
    public enum V360FilterGenIn_stereo
    {
        /// <summary>
        /// 2d              0            ..FV....... 2d mono
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2d")]
        _2d = 0,
        /// <summary>
        /// sbs             1            ..FV....... side by side
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbs")]
        sbs = 1,
        /// <summary>
        /// tb              2            ..FV....... top bottom
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tb")]
        tb = 2
    }

    /// <summary>
    ///  output stereo format (from 0 to 2) (default 2d)
    /// </summary>
    public enum V360FilterGenOut_stereo
    {
        /// <summary>
        /// 2d              0            ..FV....... 2d mono
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2d")]
        _2d = 0,
        /// <summary>
        /// sbs             1            ..FV....... side by side
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sbs")]
        sbs = 1,
        /// <summary>
        /// tb              2            ..FV....... top bottom
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tb")]
        tb = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert 360 projection of video.
        /// </summary>
        public static V360FilterGen V360FilterGen(this ImageMap input0) => new V360FilterGen(input0);
    }
}