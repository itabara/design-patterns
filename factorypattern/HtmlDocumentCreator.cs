using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class HtmlDocumentCreator
    {
        private List<ITag> _tags = new List<ITag>();

        // Constructor calls abstract Factory method
        public HtmlDocumentCreator()
        {
            this.CreateTags();
        }

        public List<ITag> Tags
        {         
            get { return _tags; }
        }

        // Factory Method
        public abstract void CreateTags();
    }
}
