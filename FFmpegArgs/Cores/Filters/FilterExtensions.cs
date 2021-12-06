using System.Linq;
using System.Collections.Generic;
namespace FFmpegArgs.Cores.Filters
{
    internal static class FilterExtensions
    {
        /// <summary>
        /// https://ffmpeg.org/ffmpeg-filters.html#Notes-on-filtergraph-escaping <br></br>
        /// Text Level
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static string FiltergraphEscapingLv1(this string input)
        {
            return input
                ?.Replace(@"'", @"\'")
                ?.Replace(@":", @"\:");
        }

        /// <summary>
        /// Filter level
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static string FiltergraphEscapingLv2(this string input)
        {
            return input
              ?.Replace(@"\'", @"\\\'")
              ?.Replace(@"\:", @"\\:")
              ?.Replace(@"[", @"\[")
              ?.Replace(@"]", @"\]")
              ?.Replace(@";", @"\;")
              ?.Replace(@",", @"\,");
        }

        /// <summary>
        /// OS shell level
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static string FiltergraphEscapingLv3(this string input)
        {
            return input?.Replace(@"\", @"\\");
        }


        internal static string GetFilterOptions(this IEnumerable<KeyValuePair<string,string>> options)
        {
            return string.Join(":", options.Select(x => $"{x.Key}={x.Value.FiltergraphEscapingLv1()}")).FiltergraphEscapingLv2();
        }
    }
}
