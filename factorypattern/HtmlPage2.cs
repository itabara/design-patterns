using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    /// <summary>
    /// A 'HtmlDocumentCreator' class
    /// </summary>
    public class HtmlPage2 : HtmlDocumentCreator
    {
        public override void CreateTags()
        {
            // Factory Method implementation
            this.Tags.Add(new HtmlTag());
            this.Tags.Add(new BodyTag());            
        }
    }
}
