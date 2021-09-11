using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata
{
    class YmlFormater : IFormatable
    {
        public string GetContent()
        {
            return "Contenido en formato yml";
        }

        public string GetExtension()
        {
            return "yml";
        }
    }
}
