using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    /// <summary>
    /// BodyTag implements the ITag interface
    /// </summary>
    public class BodyTag : ITag
    {
        public string BeginTag()
        {
            return "<body>";
        }

        public string EndTag()
        {
            return "</body>";
        }
    }
}
