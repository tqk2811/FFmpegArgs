using FFmpegArgs.Cores.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Inputs
{
    public class FilterInput : VideoInput
    {
        readonly string _filter_string;
        public FilterInput(string filter)
        {
            if (string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            this._filter_string = filter;
        }

        public FilterGraph FilterGraph { get; } = new FilterGraph();
        public FilterInput()
        {

        }

        public override string ToString()
        {
            string filter = this._filter_string;
            if (string.IsNullOrWhiteSpace(filter)) filter = FilterGraph.GetFiltersInputArgs();
            if (string.IsNullOrWhiteSpace(filter)) throw new NullReferenceException($"{nameof(FilterInput)} is empty");

            List<string> args = new List<string>()
            {
                GetArgs(),
                filter.Contains(" ") ? $"-f lavfi -i \"{filter}\"" : $"-f lavfi -i {filter}"
            };

            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
