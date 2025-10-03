namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC afftdn            A-&gt;A       Denoise audio samples using FFT.
    /// </summary>
    public class AfftdnFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AfftdnFilterGen(AudioMap input) : base("afftdn", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the noise reduction (from 0.01 to 97) (default 12)
        /// </summary>
        public AfftdnFilterGen noise_reduction(float noise_reduction) => this.SetOptionRange("noise_reduction", noise_reduction, 0.01, 97);
        /// <summary>
        ///  set the noise reduction (from 0.01 to 97) (default 12)
        /// </summary>
        public AfftdnFilterGen nr(float nr) => this.SetOptionRange("nr", nr, 0.01, 97);
        /// <summary>
        ///  set the noise floor (from -80 to -20) (default -50)
        /// </summary>
        public AfftdnFilterGen noise_floor(float noise_floor) => this.SetOptionRange("noise_floor", noise_floor, -80, -20);
        /// <summary>
        ///  set the noise floor (from -80 to -20) (default -50)
        /// </summary>
        public AfftdnFilterGen nf(float nf) => this.SetOptionRange("nf", nf, -80, -20);
        /// <summary>
        ///  set the noise type (from 0 to 3) (default white)
        /// </summary>
        public AfftdnFilterGen noise_type(AfftdnFilterGenNoise_type noise_type) => this.SetOption("noise_type", noise_type.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the noise type (from 0 to 3) (default white)
        /// </summary>
        public AfftdnFilterGen nt(AfftdnFilterGenNt nt) => this.SetOption("nt", nt.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the custom bands noise
        /// </summary>
        public AfftdnFilterGen band_noise(String band_noise) => this.SetOption("band_noise", band_noise.ToString());
        /// <summary>
        ///  set the custom bands noise
        /// </summary>
        public AfftdnFilterGen bn(String bn) => this.SetOption("bn", bn.ToString());
        /// <summary>
        ///  set the residual floor (from -80 to -20) (default -38)
        /// </summary>
        public AfftdnFilterGen residual_floor(float residual_floor) => this.SetOptionRange("residual_floor", residual_floor, -80, -20);
        /// <summary>
        ///  set the residual floor (from -80 to -20) (default -38)
        /// </summary>
        public AfftdnFilterGen rf(float rf) => this.SetOptionRange("rf", rf, -80, -20);
        /// <summary>
        ///  track noise (default false)
        /// </summary>
        public AfftdnFilterGen track_noise(bool track_noise) => this.SetOption("track_noise", track_noise.ToFFmpegFlag());
        /// <summary>
        ///  track noise (default false)
        /// </summary>
        public AfftdnFilterGen tn(bool tn) => this.SetOption("tn", tn.ToFFmpegFlag());
        /// <summary>
        ///  track residual (default false)
        /// </summary>
        public AfftdnFilterGen track_residual(bool track_residual) => this.SetOption("track_residual", track_residual.ToFFmpegFlag());
        /// <summary>
        ///  set output mode (from 0 to 2) (default output)
        /// </summary>
        public AfftdnFilterGen output_mode(AfftdnFilterGenOutput_mode output_mode) => this.SetOption("output_mode", output_mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set output mode (from 0 to 2) (default output)
        /// </summary>
        public AfftdnFilterGen om(AfftdnFilterGenOm om) => this.SetOption("om", om.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set adaptivity factor (from 0 to 1) (default 0.5)
        /// </summary>
        public AfftdnFilterGen adaptivity(float adaptivity) => this.SetOptionRange("adaptivity", adaptivity, 0, 1);
        /// <summary>
        ///  set noise floor offset factor (from -2 to 2) (default 1)
        /// </summary>
        public AfftdnFilterGen floor_offset(float floor_offset) => this.SetOptionRange("floor_offset", floor_offset, -2, 2);
        /// <summary>
        ///  set noise floor offset factor (from -2 to 2) (default 1)
        /// </summary>
        public AfftdnFilterGen fo(float fo) => this.SetOptionRange("fo", fo, -2, 2);
        /// <summary>
        ///  set the noise floor link (from 0 to 3) (default min)
        /// </summary>
        public AfftdnFilterGen noise_link(AfftdnFilterGenNoise_link noise_link) => this.SetOption("noise_link", noise_link.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the noise floor link (from 0 to 3) (default min)
        /// </summary>
        public AfftdnFilterGen nl(AfftdnFilterGenNl nl) => this.SetOption("nl", nl.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set band multiplier (from 0.2 to 5) (default 1.25)
        /// </summary>
        public AfftdnFilterGen band_multiplier(float band_multiplier) => this.SetOptionRange("band_multiplier", band_multiplier, 0.2, 5);
        /// <summary>
        ///  set band multiplier (from 0.2 to 5) (default 1.25)
        /// </summary>
        public AfftdnFilterGen bm(float bm) => this.SetOptionRange("bm", bm, 0.2, 5);
        /// <summary>
        ///  set sample noise mode (from 0 to 2) (default none)
        /// </summary>
        public AfftdnFilterGen sample_noise(AfftdnFilterGenSample_noise sample_noise) => this.SetOption("sample_noise", sample_noise.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set sample noise mode (from 0 to 2) (default none)
        /// </summary>
        public AfftdnFilterGen sn(AfftdnFilterGenSn sn) => this.SetOption("sn", sn.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set gain smooth radius (from 0 to 50) (default 0)
        /// </summary>
        public AfftdnFilterGen gain_smooth(int gain_smooth) => this.SetOptionRange("gain_smooth", gain_smooth, 0, 50);
        /// <summary>
        ///  set gain smooth radius (from 0 to 50) (default 0)
        /// </summary>
        public AfftdnFilterGen gs(int gs) => this.SetOptionRange("gs", gs, 0, 50);
    }

    /// <summary>
    ///  set the noise type (from 0 to 3) (default white)
    /// </summary>
    public enum AfftdnFilterGenNoise_type
    {
        /// <summary>
        /// white           0            ..F.A...... white noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("white")]
        white = 0,
        /// <summary>
        /// w               0            ..F.A...... white noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("w")]
        w = 0,
        /// <summary>
        /// vinyl           1            ..F.A...... vinyl noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vinyl")]
        vinyl = 1,
        /// <summary>
        /// v               1            ..F.A...... vinyl noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("v")]
        v = 1,
        /// <summary>
        /// shellac         2            ..F.A...... shellac noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("shellac")]
        shellac = 2,
        /// <summary>
        /// s               2            ..F.A...... shellac noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s = 2,
        /// <summary>
        /// custom          3            ..F.A...... custom noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("custom")]
        custom = 3,
        /// <summary>
        /// c               3            ..F.A...... custom noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c")]
        c = 3
    }

    /// <summary>
    ///  set the noise type (from 0 to 3) (default white)
    /// </summary>
    public enum AfftdnFilterGenNt
    {
        /// <summary>
        /// white           0            ..F.A...... white noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("white")]
        white = 0,
        /// <summary>
        /// w               0            ..F.A...... white noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("w")]
        w = 0,
        /// <summary>
        /// vinyl           1            ..F.A...... vinyl noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vinyl")]
        vinyl = 1,
        /// <summary>
        /// v               1            ..F.A...... vinyl noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("v")]
        v = 1,
        /// <summary>
        /// shellac         2            ..F.A...... shellac noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("shellac")]
        shellac = 2,
        /// <summary>
        /// s               2            ..F.A...... shellac noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s = 2,
        /// <summary>
        /// custom          3            ..F.A...... custom noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("custom")]
        custom = 3,
        /// <summary>
        /// c               3            ..F.A...... custom noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c")]
        c = 3
    }

    /// <summary>
    ///  set output mode (from 0 to 2) (default output)
    /// </summary>
    public enum AfftdnFilterGenOutput_mode
    {
        /// <summary>
        /// input           0            ..F.A....T. input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = 0,
        /// <summary>
        /// i               0            ..F.A....T. input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("i")]
        i = 0,
        /// <summary>
        /// output          1            ..F.A....T. output
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("output")]
        output = 1,
        /// <summary>
        /// o               1            ..F.A....T. output
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("o")]
        o = 1,
        /// <summary>
        /// noise           2            ..F.A....T. noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("noise")]
        noise = 2,
        /// <summary>
        /// n               2            ..F.A....T. noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("n")]
        n = 2
    }

    /// <summary>
    ///  set output mode (from 0 to 2) (default output)
    /// </summary>
    public enum AfftdnFilterGenOm
    {
        /// <summary>
        /// input           0            ..F.A....T. input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("input")]
        input = 0,
        /// <summary>
        /// i               0            ..F.A....T. input
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("i")]
        i = 0,
        /// <summary>
        /// output          1            ..F.A....T. output
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("output")]
        output = 1,
        /// <summary>
        /// o               1            ..F.A....T. output
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("o")]
        o = 1,
        /// <summary>
        /// noise           2            ..F.A....T. noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("noise")]
        noise = 2,
        /// <summary>
        /// n               2            ..F.A....T. noise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("n")]
        n = 2
    }

    /// <summary>
    ///  set the noise floor link (from 0 to 3) (default min)
    /// </summary>
    public enum AfftdnFilterGenNoise_link
    {
        /// <summary>
        /// none            0            ..F.A....T. none
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// min             1            ..F.A....T. min
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("min")]
        min = 1,
        /// <summary>
        /// max             2            ..F.A....T. max
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("max")]
        max = 2,
        /// <summary>
        /// average         3            ..F.A....T. average
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("average")]
        average = 3
    }

    /// <summary>
    ///  set the noise floor link (from 0 to 3) (default min)
    /// </summary>
    public enum AfftdnFilterGenNl
    {
        /// <summary>
        /// none            0            ..F.A....T. none
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// min             1            ..F.A....T. min
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("min")]
        min = 1,
        /// <summary>
        /// max             2            ..F.A....T. max
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("max")]
        max = 2,
        /// <summary>
        /// average         3            ..F.A....T. average
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("average")]
        average = 3
    }

    /// <summary>
    ///  set sample noise mode (from 0 to 2) (default none)
    /// </summary>
    public enum AfftdnFilterGenSample_noise
    {
        /// <summary>
        /// none            0            ..F.A....T. none
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// start           1            ..F.A....T. start
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("start")]
        start = 1,
        /// <summary>
        /// begin           1            ..F.A....T. start
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("begin")]
        begin = 1,
        /// <summary>
        /// stop            2            ..F.A....T. stop
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stop")]
        stop = 2,
        /// <summary>
        /// end             2            ..F.A....T. stop
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("end")]
        end = 2
    }

    /// <summary>
    ///  set sample noise mode (from 0 to 2) (default none)
    /// </summary>
    public enum AfftdnFilterGenSn
    {
        /// <summary>
        /// none            0            ..F.A....T. none
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// start           1            ..F.A....T. start
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("start")]
        start = 1,
        /// <summary>
        /// begin           1            ..F.A....T. start
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("begin")]
        begin = 1,
        /// <summary>
        /// stop            2            ..F.A....T. stop
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stop")]
        stop = 2,
        /// <summary>
        /// end             2            ..F.A....T. stop
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("end")]
        end = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Denoise audio samples using FFT.
        /// </summary>
        public static AfftdnFilterGen AfftdnFilterGen(this AudioMap input0) => new AfftdnFilterGen(input0);
    }
}