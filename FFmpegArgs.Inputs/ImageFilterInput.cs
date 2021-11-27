using FFmpegArgs.Cores.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Inputs
{
    public class ImageFilterInput : ImageInput
    {
         readonly string _filter;
        public ImageFilterInput(string filter)
        {
            if (string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            this._filter = filter;
        }

        public override string ToString()
        {
            List<string> args = new List<string>()
            {
                GetArgs(),
                _filter.Contains(" ") ? $"-f lavfi -i \"{_filter}\"" : $"-f lavfi -i {_filter}"
            };
            return $"{string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)))}";
        }
    }
}
