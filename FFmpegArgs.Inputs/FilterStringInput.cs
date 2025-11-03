//namespace FFmpegArgs.Inputs
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    public class FilterStringInput : VideoInput
//    {
//        readonly string _filter_string;
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="filter"></param>
//        /// <exception cref="ArgumentNullException"></exception>
//        public FilterStringInput(string filter)
//        {
//            if (string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
//            this._filter_string = filter;
//            this.Format(DemuxingFileFormat.lavfi);
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <returns></returns>
//        /// <exception cref="NullReferenceException"></exception>
//        public override string ToString()
//        {
//            string filter = this._filter_string;
//            List<string> args = new List<string>()
//            {
//                GetFlagArgs(),
//                GetOptionArgs(),
//                filter.Contains(" ") ? $"-i \"{filter}\"" : $"-i {filter}"
//            };
//            return string.Join(" ", args.Where(x => !string.IsNullOrWhiteSpace(x)));
//        }
//    }
//}
