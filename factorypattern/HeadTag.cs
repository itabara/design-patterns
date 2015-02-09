using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    /// <summary>
    /// HeadTag implements the ITag interface
    /// </summary>
    public class HeadTag : ITag
    {
        public string BeginTag()
        {
            return "<head>";
        }

        public string EndTag()
        {
            return "</head>";
        }
    }
}
