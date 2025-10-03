using System.Text.RegularExpressions;
namespace Autogens.Filter
{
    internal class FilterData
    {
        /// <summary>
        /// libavutil\opt.h
        /// EDFVASXRBTP
        /// E               AV_OPT_FLAG_ENCODING_PARAM
        ///  D              AV_OPT_FLAG_DECODING_PARAM
        ///   F             AV_OPT_FLAG_FILTERING_PARAM
        ///    V            AV_OPT_FLAG_VIDEO_PARAM
        ///     A           AV_OPT_FLAG_AUDIO_PARAM
        ///      S          AV_OPT_FLAG_SUBTITLE_PARAM
        ///       X         AV_OPT_FLAG_EXPORT
        ///        R        AV_OPT_FLAG_READONLY
        ///         B       AV_OPT_FLAG_BSF_PARAM
        ///          T      AV_OPT_FLAG_RUNTIME_PARAM
        ///           P     AV_OPT_FLAG_DEPRECATED
        /// </summary>
        internal static Regex regex_DocLineMethod { get; } = new Regex("^(.*?) +(|[0-9A-z<>-]+) +([.EDFVASXRBTP]{11})(.*?|)$");
        static Regex regex_DocLineMethodFromTo { get; } = new Regex("from ([0-9A-Z-+._e]+) to ([0-9A-Z-+._e]+)");
        private FilterData()
        {
        }
        public static FilterData? Create(DocLine function)
        {
            Match match_method = regex_DocLineMethod.Match(function.LineData);
            if (!match_method.Success) return null;

            string description = match_method.Groups[4].Value;
            FilterData filterData = new FilterData()
            {
                Function = function,
                Name = match_method.Groups[1].Value.TrimStart('-'),
                Type = match_method.Groups[2].Value,
                Flag = match_method.Groups[3].Value,
                Description = description,
            };
            Match match_fromto = regex_DocLineMethodFromTo.Match(description);
            if (match_fromto.Success)
            {
                filterData.Min = match_fromto.Groups[1].Value;
                filterData.Max = match_fromto.Groups[2].Value;
            }
            return filterData;
        }
        public required DocLine Function { get; init; }
        public required string Name { get; init; }
        public required string Type { get; init; }
        public required string Flag { get; init; }
        public required string Description { get; init; }
        public string? Min { get; private set; }
        public string? Max { get; private set; }
    }
}
