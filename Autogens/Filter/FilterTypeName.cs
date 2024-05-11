using System.Collections.Generic;

namespace Autogens.Filter
{
    class FilterTypeName
    {
        public string Inheritance { get; set; }
        public List<string> CtorArgs { get; set; } = new List<string>();
        public string CtorArgsInheritance { get; set; }
        public string CtorBody { get; set; }
        public List<string> ExtensionArgs { get; set; } = new List<string>();
        public List<string> ExtensionParams { get; set; } = new List<string>();
    }
}
