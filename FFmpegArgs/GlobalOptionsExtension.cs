using System;

namespace FFmpegArgs
{
    public static class GlobalOptionsExtension
    {
        /// <summary>
        /// Overwrite output files without asking.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <returns></returns>
        public static FFmpegArg OverWriteOutput(this FFmpegArg ffmpegArg)
          => ffmpegArg.SetFlag("-y");

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
        /// <param name="filterGraph"></param>
        /// <param name="time">Set period at which encoding progress/statistics are updated. Default is 0.5 seconds.</param>
        /// <returns></returns>
        public static FFmpegArg StatsPeriod(this FFmpegArg ffmpegArg, double time)
          => ffmpegArg.SetOptionRange("-stats_period", time, 0, double.MaxValue);

        /// <summary>
        /// Set period at which encoding progress/statistics are updated. Default is 0.5 seconds.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <param name="time">Set period at which encoding progress/statistics are updated. Default is 0.5 seconds.</param>
        /// <returns></returns>
        public static FFmpegArg StatsPeriod(this FFmpegArg ffmpegArg, TimeSpan time)
          => ffmpegArg.SetOptionRange("-stats_period", time, TimeSpan.Zero, TimeSpan.MaxValue);

        /// <summary>
        /// Defines how many threads are used to process a filter_complex graph. Similar to filter_threads but used for -filter_complex graphs only. The default is the number of available CPUs.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <param name="threads"></param>
        /// <returns></returns>
        public static FFmpegArg FilterComplexThreads(this FFmpegArg ffmpegArg, int threads)
          => ffmpegArg.SetOptionRange("-filter_complex_threads", threads, 1, int.MaxValue);

        /// <summary>
        /// Set fraction of decoding frame failures across all inputs which when crossed ffmpeg will return exit code 69. Crossing this threshold does not terminate processing. Range is a floating-point number between 0 to 1. Default is 2/3.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static FFmpegArg MaxErrorRate(this FFmpegArg ffmpegArg, float rate)
          => ffmpegArg.SetOptionRange("-max_error_rate", rate, 0, 1);

        /// <summary>
        /// Enable automatically inserting format conversion filters in all filter graphs, including those defined by -vf, -af, -filter_complex and -lavfi. If filter format negotiation requires a conversion, the initialization of the filters will fail. Conversions can still be performed by inserting the relevant conversion filter (scale, aresample) in the graph. On by default, to explicitly disable it you need to specify -noauto_conversion_filters.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static FFmpegArg noauto_conversion_filters(this FFmpegArg ffmpegArg)
            => ffmpegArg.SetFlag("-noauto_conversion_filters");

    }
}
