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
        internal FilterData(DocLine function)
        {
            this.Function = function;
            Match match_method = regex_DocLineMethod.Match(function.LineData);
            IsSuccess = match_method.Success;
            if (IsSuccess)
            {
                Name = match_method.Groups[1].Value;
                Type = match_method.Groups[2].Value;
                Flag = match_method.Groups[3].Value;
                Description = match_method.Groups[4].Value;
                Match match_fromto = regex_DocLineMethodFromTo.Match(Description);
                if (match_fromto.Success)
                {
                    Min = match_fromto.Groups[1].Value;
                    Max = match_fromto.Groups[2].Value;
                }
            }
        }
        public DocLine Function { get; }
        public bool IsSuccess { get; }
        public string Name { get; }
        public string Type { get; }
        public string Flag { get; }
        public string Description { get; }
        public string Min { get; }
        public string Max { get; }
    }
}
