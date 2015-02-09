using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    /// <summary>
    /// FooterTag implements the ITag interface
    /// </summary>
    public class FooterTag : ITag
    {
        public string BeginTag()
        {
            return "<footer>";
        }

        public string EndTag()
        {
            return "</footer>";
        }
    }
}
