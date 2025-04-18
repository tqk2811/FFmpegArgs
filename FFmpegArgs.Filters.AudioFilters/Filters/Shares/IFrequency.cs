using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFrequency
    {
    }
    
    /// <summary>
    /// 
    /// </summary>
    public static class IFrequencyExtension
    {

        /// <summary>
        /// set central frequency (from 0 to 999999) (default 3000)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="frequency"></param>
        /// <returns></returns>
        public static T Frequency<T>(this T t, double frequency) where T : BaseOption, IFrequency
            => t.SetOptionRange("f", frequency, 0, 999999);
    }
}
