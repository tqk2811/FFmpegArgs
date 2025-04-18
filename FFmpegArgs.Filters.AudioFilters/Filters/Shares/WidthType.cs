using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// set filter-width type 
    /// </summary>
    public enum WidthType
    {
        /// <summary>
        /// Hz
        /// </summary>
        h,
        /// <summary>
        /// Q-Factor
        /// </summary>
        q,
        /// <summary>
        /// octave
        /// </summary>
        o,
        /// <summary>
        /// slope
        /// </summary>
        s,
        /// <summary>
        /// kHz
        /// </summary>
        k

    }
}
