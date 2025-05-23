namespace FFmpegArgs.Filters
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-resampler.html#Resampler-Options
    /// </summary>
    public interface IResamplerOptions : IFilter<AudioMap, AudioMap>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public static class ResamplerOptionsExtension
    {
        /// <summary>
        /// Set the number of input channels. Default value is 0. Setting this value is not mandatory if the corresponding channel layout in_channel_layout is set.
        /// </summary>
        public static T InChannelCount<T>(this T t, int ich) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("ich", ich, 0, int.MaxValue);
        /// <summary>
        /// Set the number of output channels. Default value is 0. Setting this value is not mandatory if the corresponding channel layout out_channel_layout is set.
        /// </summary>
        public static T OutChannelCount<T>(this T t, int och) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("och", och, 0, int.MaxValue);
        /// <summary>
        /// Set the number of used input channels. Default value is 0. This option is only used for special remapping.
        /// </summary>
        public static T UsedChannelCount<T>(this T t, int uch) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("uch", uch, 0, int.MaxValue);
        /// <summary>
        /// Set the input sample rate. Default value is 0.
        /// </summary>
        public static T InSampleRate<T>(this T t, int isr) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("isr", isr, 0, int.MaxValue);
        /// <summary>
        /// Set the output sample rate. Default value is 0.
        /// </summary>
        public static T OutSampleRate<T>(this T t, int osr) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("osr", osr, 0, int.MaxValue);
        /// <summary>
        /// Specify the input sample format. It is set by default to none.
        /// </summary>
        public static T InSampleFmt<T>(this T t, string isf) where T : BaseOption, IResamplerOptions
            => t.SetOption("isf", isf);
        /// <summary>
        /// Specify the output sample format. It is set by default to none.
        /// </summary>
        public static T OutSampleFmt<T>(this T t, string osf) where T : BaseOption, IResamplerOptions
            => t.SetOption("osf", osf);
        /// <summary>
        /// Set the internal sample format. Default value is none. This will automatically be chosen when it is not explicitly set.
        /// </summary>
        public static T InternalSampleFmt<T>(this T t, string tsf) where T : BaseOption, IResamplerOptions
            => t.SetOption("tsf", tsf);
        /// <summary>
        /// Set the input/output channel layout.
        /// </summary>
        public static T InChannelLayout<T>(this T t, ChannelLayout icl) where T : BaseOption, IResamplerOptions
            => t.SetOption("icl", icl.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        /// Set the input/output channel layout.
        /// </summary>
        public static T OutChannelLayout<T>(this T t, ChannelLayout ocl) where T : BaseOption, IResamplerOptions
            => t.SetOption("ocl", ocl.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        /// Set the center mix level. It is a value expressed in deciBel, and must be in the interval [-32,32].
        /// </summary>
        public static T CenterMixLevel<T>(this T t, int clev) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("clev", clev, -32, 32);
        /// <summary>
        /// Set the surround mix level. It is a value expressed in deciBel, and must be in the interval [-32,32].
        /// </summary>
        public static T SurroundMixLevel<T>(this T t, int slev) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("slev", slev, -32, 32);
        /// <summary>
        /// Set LFE mix into non LFE level. It is used when there is a LFE input but no LFE output. It is a value expressed in deciBel, and must be in the interval [-32,32].
        /// </summary>
        public static T LfeMixLevel<T>(this T t, int lfe_mix_level) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("lfe_mix_level", lfe_mix_level, -32, 32);
        /// <summary>
        /// Set rematrix volume. Default value is 1.0.
        /// </summary>
        public static T RematrixVolume<T>(this T t, double rmvol) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("rmvol", rmvol, double.MinValue, double.MaxValue);
        /// <summary>
        /// Set maximum output value for rematrixing. This can be used to prevent clipping vs. preventing volume reduction. A value of 1.0 prevents clipping.
        /// </summary>
        public static T RematrixMaxval<T>(this T t, double rematrix_maxval) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("rematrix_maxval", rematrix_maxval, double.MinValue, double.MaxValue);
        /// <summary>
        /// Set flags used by the converter. Default value is 0.
        /// </summary>
        public static T SwrFlags<T>(this T t, ResamplerOptionsSwrFlag flags) where T : BaseOption, IResamplerOptions
            => t.SetOption("flags", flags);
        /// <summary>
        /// Set the number of input channels. Default value is 0. Setting this value is not mandatory if the corresponding channel layout in_channel_layout is set.
        /// </summary>
        public static T DitherScale<T>(this T t, bool flag) where T : BaseOption, IResamplerOptions
            => t.SetOption("dither_scale", flag.ToFFmpegFlag());
        /// <summary>
        /// Set dither method. Default value is 0.
        /// </summary>
        public static T DitherMethod<T>(this T t, ResamplerOptionsDitherMethod dither_method) where T : BaseOption, IResamplerOptions
            => t.SetOption("dither_method", dither_method);
        /// <summary>
        /// Set resampling engine. Default value is swr.
        /// </summary>
        public static T Resampler<T>(this T t, ResamplerOptionsResampler resampler) where T : BaseOption, IResamplerOptions
            => t.SetOption("resampler", resampler);
        /// <summary>
        /// For swr only, set resampling filter size, default value is 32.
        /// </summary>
        public static T FilterSize<T>(this T t, double filter_size) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("filter_size", filter_size, double.MinValue, int.MaxValue);
        /// <summary>
        /// For swr only, set resampling phase shift, default value is 10, and must be in the interval [0,30].
        /// </summary>
        public static T PhaseShift<T>(this T t, double phase_shift) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("phase_shift", phase_shift, 0, 30);
        /// <summary>
        /// Use linear interpolation when enabled (the default). Disable it if you want to preserve speed instead of quality when exact_rational fails.
        /// </summary>
        public static T LinearInterp<T>(this T t, bool linear_interp) where T : BaseOption, IResamplerOptions
            => t.SetOption("linear_interp", linear_interp.ToFFmpegFlag());
        /// <summary>
        /// For swr only, when enabled, try to use exact phase_count based on input and output sample rate. However, if it is larger than 1 &lt;&lt; phase_shift, the phase_count will be 1 &lt;&lt; phase_shift as fallback. Default is enabled.
        /// </summary>
        public static T ExactRational<T>(this T t, bool exact_rational) where T : BaseOption, IResamplerOptions
            => t.SetOption("exact_rational", exact_rational.ToFFmpegFlag());
        /// <summary>
        /// Set cutoff frequency (swr: 6dB point; soxr: 0dB point) ratio; must be a float value between 0 and 1. Default value is 0.97 with swr, and 0.91 with soxr (which, with a sample-rate of 44100, preserves the entire audio band to 20kHz).
        /// </summary>
        public static T Cutoff<T>(this T t, float cutoff) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("cutoff", cutoff, 0, 1);
        /// <summary>
        /// For soxr only, the precision in bits to which the resampled signal will be calculated. The default value of 20 (which, with suitable dithering, is appropriate for a destination bit-depth of 16) gives SoX’s ’High Quality’; a value of 28 gives SoX’s ’Very High Quality’.
        /// </summary>
        public static T Precision<T>(this T t, double precision) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("precision", precision, double.MinValue, double.MaxValue);
        /// <summary>
        /// For soxr only, selects passband rolloff none (Chebyshev) &amp; higher-precision approximation for ’irrational’ ratios. Default value is 0.
        /// </summary>
        public static T Cheby<T>(this T t, double cheby) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("cheby", cheby, double.MinValue, double.MaxValue);
        /// <summary>
        /// For swr only, simple 1 parameter audio sync to timestamps using stretching, squeezing, filling and trimming. Setting this to 1 will enable filling and trimming, larger values represent the maximum amount in samples that the data may be stretched or squeezed for each second. Default value is 0, thus no compensation is applied to make the samples match the audio timestamps.
        /// </summary>
        public static T Async<T>(this T t, int async) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("async", async, 0, int.MaxValue);
        /// <summary>
        /// For swr only, assume the first pts should be this value. The time unit is 1 / sample rate. This allows for padding/trimming at the start of stream. By default, no assumption is made about the first frame’s expected pts, so no padding or trimming is done. For example, this could be set to 0 to pad the beginning with silence if an audio stream starts after the video stream or to trim any samples with a negative pts due to encoder delay.
        /// </summary>
        public static T FirstPts<T>(this T t, double first_pts) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("first_pts", first_pts, 0, double.MaxValue);
        /// <summary>
        /// For swr only, set the minimum difference between timestamps and audio data (in seconds) to trigger stretching/squeezing/filling or trimming of the data to make it match the timestamps. The default is that stretching/squeezing/filling and trimming is disabled (min_comp = FLT_MAX).
        /// </summary>
        public static T MinComp<T>(this T t, double min_comp) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("min_comp", min_comp, 0, double.MaxValue);
        /// <summary>
        /// For swr only, set the minimum difference between timestamps and audio data (in seconds) to trigger adding/dropping samples to make it match the timestamps. This option effectively is a threshold to select between hard (trim/fill) and soft (squeeze/stretch) compensation. Note that all compensation is by default disabled through min_comp. The default is 0.1.
        /// </summary>
        public static T MinHardComp<T>(this T t, double min_hard_comp) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("min_hard_comp", min_hard_comp, 0, double.MaxValue);
        /// <summary>
        /// For swr only, set duration (in seconds) over which data is stretched/squeezed to make it match the timestamps. Must be a non-negative double float value, default value is 1.0.
        /// </summary>
        public static T CompDuration<T>(this T t, double comp_duration) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("comp_duration", comp_duration, 0, double.MaxValue);
        /// <summary>
        /// For swr only, set maximum factor by which data is stretched/squeezed to make it match the timestamps. Must be a non-negative double float value, default value is 0.
        /// </summary>
        public static T MaxSoftComp<T>(this T t, double max_soft_comp) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("max_soft_comp", max_soft_comp, 0, double.MaxValue);
        /// <summary>
        /// Select matrixed stereo encoding.
        /// </summary>
        public static T MatrixEncoding<T>(this T t, ResamplerOptionsMatrixEncoding matrix_encoding) where T : BaseOption, IResamplerOptions
            => t.SetOption("matrix_encoding", matrix_encoding);
        /// <summary>
        /// For swr only, select resampling filter type. This only affects resampling operations.
        /// </summary>
        public static T FilterType<T>(this T t, ResamplerOptionsFilterType filter_type) where T : BaseOption, IResamplerOptions
            => t.SetOption("filter_type", filter_type);
        /// <summary>
        /// For swr only, set Kaiser window beta value. Must be a double float value in the interval [2,16], default value is 9.
        /// </summary>
        public static T KaiserBeta<T>(this T t, double kaiser_beta) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("kaiser_beta", kaiser_beta, 2, 16);
        /// <summary>
        /// For swr only, set number of used output sample bits for dithering. Must be an integer in the interval [0,64], default value is 0, which means it’s not used.
        /// </summary>
        public static T OutputSampleBits<T>(this T t, int output_sample_bits) where T : BaseOption, IResamplerOptions
            => t.SetOptionRange("output_sample_bits", output_sample_bits, 0, 64);
    }
    /// <summary>
    /// 
    /// </summary>
    public enum ResamplerOptionsSwrFlag
    {
        /// <summary>
        /// force resampling, this flag forces resampling to be used even when the input and output sample rates match.
        /// </summary>
        res
    }
    /// <summary>
    /// 
    /// </summary>
    public enum ResamplerOptionsDitherMethod
    {
        /// <summary>
        /// select rectangular dither
        /// </summary>
        rectangular,
        /// <summary>
        /// select triangular dither
        /// </summary>
        triangular,
        /// <summary>
        /// select triangular dither with high pass
        /// </summary>
        triangular_hp,
        /// <summary>
        /// select Lipshitz noise shaping dither.
        /// </summary>
        lipshitz,
        /// <summary>
        /// select Shibata noise shaping dither.
        /// </summary>
        shibata,
        /// <summary>
        /// select low Shibata noise shaping dither.
        /// </summary>
        low_shibata,
        /// <summary>
        /// select high Shibata noise shaping dither.
        /// </summary>
        high_shibata,
        /// <summary>
        /// select f-weighted noise shaping dither
        /// </summary>
        f_weighted,
        /// <summary>
        /// select modified-e-weighted noise shaping dither
        /// </summary>
        modified_e_weighted,
        /// <summary>
        /// select improved-e-weighted noise shaping dither
        /// </summary>
        improved_e_weighted
    }
    /// <summary>
    /// 
    /// </summary>
    public enum ResamplerOptionsResampler
    {
        /// <summary>
        /// select the native SW Resampler; filter options precision and cheby are not applicable in this case.
        /// </summary>
        swr,
        /// <summary>
        /// select the SoX Resampler (where available); compensation, and filter options filter_size, phase_shift, exact_rational, filter_type &amp; kaiser_beta, are not applicable in this case.
        /// </summary>
        soxr,
    }
    /// <summary>
    /// 
    /// </summary>
    public enum ResamplerOptionsMatrixEncoding
    {
        /// <summary>
        /// select none, default
        /// </summary>
        none,
        /// <summary>
        /// select Dolby
        /// </summary>
        dolby,
        /// <summary>
        /// select Dolby Pro Logic II
        /// </summary>
        dplii
    }
    /// <summary>
    /// 
    /// </summary>
    public enum ResamplerOptionsFilterType
    {
        /// <summary>
        /// select cubic
        /// </summary>
        cubic,
        /// <summary>
        /// select Blackman Nuttall windowed sinc
        /// </summary>
        blackman_nuttall,
        /// <summary>
        /// select Kaiser windowed sinc
        /// </summary>
        kaiser
    }
}
