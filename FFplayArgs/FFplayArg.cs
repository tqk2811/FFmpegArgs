using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFplayArgs
{
    public class FFplayArg
    {
        readonly List<BaseInput> _inputs = new List<BaseInput>();
        public IEnumerable<BaseInput> Inputs { get { return _inputs; } }
    }
}
