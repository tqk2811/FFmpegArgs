namespace FFmpegArgs.Cores.Enums
{
    /// <summary>
    /// https://github.com/FFmpeg/FFmpeg/blob/f6ab103bb5c2dd494620f7a28ae232efe497a4d1/libavutil/samplefmt.h#L58
    /// </summary>
    public enum AVSampleFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [Name("none")] AV_SAMPLE_FMT_NONE = -1,
        /// <summary>
        /// unsigned 8 bits
        /// </summary>
        [Name("u8")] AV_SAMPLE_FMT_U8,
        /// <summary>
        /// signed 16 bits
        /// </summary>
        [Name("s16")] AV_SAMPLE_FMT_S16,
        /// <summary>
        /// signed 32 bits
        /// </summary>
        [Name("s32")] AV_SAMPLE_FMT_S32,
        /// <summary>
        /// float
        /// </summary>
        [Name("flt")] AV_SAMPLE_FMT_FLT,
        /// <summary>
        /// double
        /// </summary>
        [Name("dbl")] AV_SAMPLE_FMT_DBL,
        /// <summary>
        /// unsigned 8 bits, planar
        /// </summary>
        [Name("u8p")] AV_SAMPLE_FMT_U8P,
        /// <summary>
        /// signed 16 bits, planar
        /// </summary>
        [Name("s16p")] AV_SAMPLE_FMT_S16P,
        /// <summary>
        /// signed 32 bits, planar
        /// </summary>
        [Name("s32p")] AV_SAMPLE_FMT_S32P,
        /// <summary>
        /// float, planar
        /// </summary>
        [Name("fltp")] AV_SAMPLE_FMT_FLTP,
        /// <summary>
        /// double, planar
        /// </summary>
        [Name("dblp")] AV_SAMPLE_FMT_DBLP,
        /// <summary>
        /// signed 64 bits
        /// </summary>
        [Name("s64")] AV_SAMPLE_FMT_S64,
        /// <summary>
        /// signed 64 bits, planar
        /// </summary>
        [Name("s64p")] AV_SAMPLE_FMT_S64P,
        /// <summary>
        /// Number of sample formats. DO NOT USE if linking dynamically
        /// </summary>
        [Name("nb")] AV_SAMPLE_FMT_NB
    };
}
