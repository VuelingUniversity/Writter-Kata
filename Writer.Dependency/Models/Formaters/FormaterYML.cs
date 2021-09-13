using System;
using System.Collections.Generic;
using System.Text;
using Writer.Dependency.Interface;

namespace Writer.Dependency.Models.Formaters
{
    public class FormaterYml : IFormater
    {
        public string GetFormater()
        {
            return ".yml";
        }
    }
}
