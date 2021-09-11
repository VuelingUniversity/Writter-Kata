using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata
{
    class JsonFormater : IFormatable
    {
        public string GetContent()
        {
            return "Contenido en formato json";
        }

        public string GetExtension()
        {
            return "json";
        }
    }
}
