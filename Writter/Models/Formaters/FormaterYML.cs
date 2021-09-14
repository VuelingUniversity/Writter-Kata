using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models.Formaters
{
    class FormaterYML : IFormater
    {
        public string GetFormater()
        {
            return ".yml";
        }
    }
}
