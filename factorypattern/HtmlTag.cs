using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    /// <summary>
    /// HtmlTag implements the ITag interface
    /// </summary>
    public class HtmlTag : ITag
    {
        public string BeginTag()
        {
            return "<html>";
        }

        public string EndTag()
        {
            return "</html>";
        }
    }
}
