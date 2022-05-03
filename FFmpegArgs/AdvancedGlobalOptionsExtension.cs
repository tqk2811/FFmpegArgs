/*
Advanced global options:
-cpuflags flags     force specific cpu flags
-cpucount count     force specific cpu count
-hide_banner hide_banner  do not show program banner
-copy_unknown       Copy unknown stream types
-recast_media       allow recasting stream type in order to force a decoder of different media type
-benchmark          add timings for benchmarking
-benchmark_all      add timings for each task
-progress url       write program-readable progress information
-stdin              enable or disable interaction on standard input
-timelimit limit    set max runtime in seconds in CPU user time
-dump               dump each input packet
-hex                when dumping packets, also dump the payload
-vsync              video sync method
-frame_drop_threshold   frame drop threshold
-async              audio sync method
-adrift_threshold threshold  audio drift threshold
-copyts             copy timestamps
-start_at_zero      shift input timestamps to start at 0 when using copyts
-copytb mode        copy input stream time base when stream copying
-dts_delta_threshold threshold  timestamp discontinuity delta threshold
-dts_error_threshold threshold  timestamp error delta threshold
-xerror error       exit on error
-abort_on flags     abort on the specified condition flags
-filter_complex graph_description  create a complex filtergraph
-lavfi graph_description  create a complex filtergraph
-filter_complex_script filename  read complex filtergraph description from a file
-auto_conversion_filters  enable automatic conversion filters globally
-stats_period time  set the period at which ffmpeg updates stats and -progress output
-debug_ts           print timestamp debugging info
-psnr               calculate PSNR of compressed frames
-vstats             dump video coding statistics to file
-vstats_file file   dump video coding statistics to file
-vstats_version     Version of the vstats format to use.
-qphist             show QP histogram
-sdp_file file      specify a file in which to print sdp information
-qsv_device device  set QSV hardware device (DirectX adapter index, DRM path or X11 display name)
-init_hw_device args  initialise hardware device
-filter_hw_device device  set hardware device used when filtering
 */
namespace FFmpegArgs
{
    /// <summary>
    /// 
    /// </summary>
    public static class AdvancedGlobalOptionsExtension
    {

        
        /// <summary>
        /// Override detection of CPU count. This option is intended for testing. Do not use it unless you know what you’re doing.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static FFmpegArg CpuCount(this FFmpegArg ffmpegArg, int count)
            => ffmpegArg.SetOptionRange("-cpucount", count, 0, int.MaxValue);

        /// <summary>
        /// Suppress printing banner.<br>
        /// </br>All FFmpeg tools will normally show a copyright notice, build options and library versions.This option can be used to suppress printing this information.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <returns></returns>
        public static FFmpegArg HideBanner(this FFmpegArg ffmpegArg)
            => ffmpegArg.SetFlag("-hide_banner");












        /// <summary>
        /// Allow forcing a decoder of a different media type than the one detected or designated by the demuxer. Useful for decoding media data muxed as data streams.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <returns></returns>
        public static FFmpegArg RecastMedia(this FFmpegArg ffmpegArg)
          => ffmpegArg.SetFlag("-recast_media");
        /// <summary>
        /// Set period at which encoding progress/statistics are updated. Default is 0.5 seconds.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="time">Set period at which encoding progress/statistics are updated. Default is 0.5 seconds.</param>
        /// <returns></returns>
        public static FFmpegArg StatsPeriod(this FFmpegArg ffmpegArg, TimeSpan time)
          => ffmpegArg.SetOptionRange("-stats_period", time, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Enable automatically inserting format conversion filters in all filter graphs, including those defined by -vf, -af, -filter_complex and -lavfi. If filter format negotiation requires a conversion, the initialization of the filters will fail. Conversions can still be performed by inserting the relevant conversion filter (scale, aresample) in the graph. On by default, to explicitly disable it you need to specify -noauto_conversion_filters.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <returns></returns>
        public static FFmpegArg NoautoConversionFilters(this FFmpegArg ffmpegArg)
            => ffmpegArg.SetFlag("-noauto_conversion_filters");
        /// <summary>
        /// Set threads using, default: 0 (auto detect cpu core)
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="threads"></param>
        /// <returns></returns>
        public static FFmpegArg Threads(this FFmpegArg ffmpegArg, int threads)
            => ffmpegArg.SetOptionRange("-threads", threads, 0, int.MaxValue);
    }
}
