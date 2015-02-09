using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    /// <summary>
    /// ITag defines the interface of objects the factory method creates
    /// </summary>
    public interface ITag
    {
        string BeginTag();
        string EndTag();
    }
}
