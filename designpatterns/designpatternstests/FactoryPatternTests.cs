using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.FactoryPattern;

namespace designpatternstests
{
    [TestClass]
    public class FactoryPatternTests
    {
        [TestMethod]
        public void InvokeFactoryPattern()
        {
            // Note: constructors call Factory Method
            HtmlDocumentCreator[] htmlDocuments = new HtmlDocumentCreator[2];
            htmlDocuments[0] = new HtmlPage1();
            htmlDocuments[1] = new HtmlPage2();

            // Display document pages
            foreach (HtmlDocumentCreator htmlDocument in htmlDocuments)
            {
                Console.WriteLine("\n" + htmlDocument.GetType().Name + "--");
                foreach (ITag shape in htmlDocument.Tags)
                {
                    Console.WriteLine(shape.BeginTag() + " " + shape.EndTag());
                }
            }
        }

    }
}
