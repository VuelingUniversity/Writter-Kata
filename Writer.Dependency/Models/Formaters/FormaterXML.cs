using System;
using System.Collections.Generic;
using System.Text;
using Writer.Dependency.Interface;

namespace Writer.Dependency.Models
{
    public class FormaterXml : IFormater
    {
        public string GetFormater()
        {
            return ".xml";
        }
    }
}
