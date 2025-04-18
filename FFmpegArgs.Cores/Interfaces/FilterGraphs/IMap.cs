using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMap
    {
        /// <summary>
        /// Name of map
        /// </summary>
        string MapName { get; }

        /// <summary>
        /// FilterGraph Content
        /// </summary>
        IFilterGraph FilterGraph { get; }

        /// <summary>
        /// This map is mapped to filter/output or not
        /// </summary>
        bool IsMapped { get; }

        /// <summary>
        /// This map is from input or not
        /// </summary>
        bool IsInput { get; }

        /// <summary>
        /// 
        /// </summary>
        int IndexOfInput { get; }

        /// <summary>
        /// 
        /// </summary>
        InputAVStream InputAVStream { get; }
        
        /// <summary>
        /// 
        /// </summary>
        OutputAVStream OutputAVStream { get; }
    }
}
