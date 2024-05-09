/*
Global options (affect whole program instead of just one file):
-loglevel loglevel  set logging level
-v loglevel         set logging level
-report             generate a report
-max_alloc bytes    set maximum size of a single allocated block
-y                  overwrite output files
-n                  never overwrite output files
-ignore_unknown     Ignore unknown stream types
-filter_threads     number of non-complex filter threads
-filter_complex_threads  number of threads for -filter_complex
-stats              print progress report during encoding
-max_error_rate maximum error rate  ratio of decoding errors (0.0: no errors, 1.0: 100% errors) above which ffmpeg returns an error instead of success.
-vol volume         change audio volume (256=normal)
 */
namespace FFmpegArgs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg.html
    /// </summary>
    public static class GlobalOptionsExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="logLevel"></param>
        /// <returns></returns>
        public static T LogLevel<T>(this T ffmpegArg, LogLevel logLevel) where T : BaseArgsOptionFlag, IFFmpegArg
            => ffmpegArg.SetOption("-v", (int)logLevel);

        /// <summary>
        /// Generate a report
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <returns></returns>
        public static T Report<T>(this T ffmpegArg) where T : BaseArgsOptionFlag, IFFmpegArg
            => ffmpegArg.SetFlag("-report");

        /// <summary>
        /// Set the maximum size limit for allocating a block on the heap by ffmpeg’s family of malloc functions. Exercise extreme caution when using this option. Don’t use if you do not understand the full consequence of doing so. Default is INT_MAX.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="maxAlloc"></param>
        /// <returns></returns>
        public static T MaxAlloc<T>(this T ffmpegArg, int maxAlloc) where T : BaseArgsOptionFlag, IFFmpegArg
            => ffmpegArg.SetOptionRange("-max_alloc", maxAlloc, 1, int.MaxValue);

        /// <summary>
        /// Overwrite output files without asking.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <returns></returns>
        public static T OverWriteOutput<T>(this T ffmpegArg) where T : BaseArgsOptionFlag, IFFmpegArg
          => ffmpegArg.SetFlag("-y");

        /// <summary>
        /// Overwrite output files without asking.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <returns></returns>
        public static T Y<T>(this T ffmpegArg) where T : BaseArgsOptionFlag, IFFmpegArg
          => ffmpegArg.SetFlag("-y");

        /// <summary>
        /// Ignore input streams with unknown type instead of failing if copying such streams is attempted.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <returns></returns>
        public static T IgnoreUnknown<T>(this T ffmpegArg) where T : BaseArgsOptionFlag, IFFmpegArg
            => ffmpegArg.SetFlag("-ignore_unknown");

        /// <summary>
        /// Defines how many threads are used to process a filter pipeline. Each pipeline will produce a thread pool with this many threads available for parallel processing. The default is the number of available CPUs.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="filter_threads"></param>
        /// <returns></returns>
        public static T FilterThreads<T>(this T ffmpegArg, int filter_threads) where T : BaseArgsOptionFlag, IFFmpegArg
            => ffmpegArg.SetOptionRange("-filter_threads", filter_threads, -1, int.MaxValue);

        /// <summary>
        /// Defines how many threads are used to process a filter_complex graph. Similar to filter_threads but used for -filter_complex graphs only. The default is the number of available CPUs.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="filter_complex_threads"></param>
        /// <returns></returns>
        public static T FilterComplexThreads<T>(this T ffmpegArg, int filter_complex_threads) where T : BaseArgsOptionFlag, IFFmpegArg
           => ffmpegArg.SetOptionRange("-filter_complex_threads", filter_complex_threads, -1, int.MaxValue);

        /// <summary>
        /// Print encoding progress/statistics. It is on by default, to explicitly disable it you need to specify -nostats.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <returns></returns>
        public static T Stats<T>(this T ffmpegArg) where T : BaseArgsOptionFlag, IFFmpegArg
            => ffmpegArg.SetFlag("-stats");

        /// <summary>
        /// Set fraction of decoding frame failures across all inputs which when crossed ffmpeg will return exit code 69. Crossing this threshold does not terminate processing. Range is a floating-point number between 0 to 1. Default is 2/3.
        /// </summary>
        /// <param name="ffmpegArg"></param>
        /// <param name="max_error_rate"></param>
        /// <returns></returns>
        public static T MaxErrorRate<T>(this T ffmpegArg, float max_error_rate) where T : BaseArgsOptionFlag, IFFmpegArg
            => ffmpegArg.SetOptionRange("-max_error_rate", max_error_rate, 0.0, 1.0);


        ///// <summary>
        ///// change audio volume (256=normal)
        ///// </summary>
        ///// <param name="ffmpegArg"></param>
        ///// <param name="vol"></param>
        ///// <returns></returns>
        //public static FFmpegArg Vol(this FFmpegArg ffmpegArg, double vol)
        //    => ffmpegArg.SetOptionRange("-vol", vol, 0.0, 1.0);
    }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [Flags]
    public enum LogLevel : int
    {
        /// <summary>
        /// Show nothing at all; be silent.
        /// </summary>
        quiet = -8,//
        /// <summary>
        /// Only show fatal errors which could lead the process to crash, such as an assertion failure. This is not currently used for anything.
        /// </summary>
        panic = 0,
        /// <summary>
        /// Indicates that repeated log output should not be compressed to the first line and the "Last message repeated n times" line will be omitted.
        /// </summary>
        repeat = 2,
        /// <summary>
        /// Indicates that log output should add a [level] prefix to each message line. This can be used as an alternative to log coloring, e.g. when dumping the log to file.
        /// </summary>
        level = 4,
        /// <summary>
        /// Only show fatal errors. These are errors after which the process absolutely cannot continue.
        /// </summary>
        fatal = 8,//8                       0b00001000
        /// <summary>
        /// Show all errors, including ones which can be recovered from.
        /// </summary>
        error = 16,//16                     0b00010000
        /// <summary>
        /// Show all warnings and errors. Any message related to possibly incorrect or unexpected events will be shown.
        /// </summary>
        warning = fatal | error,//24        0b00011000
        /// <summary>
        /// Show informative messages during processing. This is in addition to warnings and errors. This is the default value.
        /// </summary>
        info = 32,//32                      0b00100000
        /// <summary>
        /// Same as info, except more verbose.
        /// </summary>
        verbose = info | fatal,//40         0b00101000
        /// <summary>
        /// Show everything, including debugging information.
        /// </summary>
        debug = info | error,//48           0b00110000
        /// <summary>
        /// fatal | info | error
        /// </summary>
        trace = fatal | info | error,//56   0b00111000
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
