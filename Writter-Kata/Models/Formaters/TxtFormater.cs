using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata
{
   public class TxtFormater : IFormatable
    {
        public string GetContent()
        {
            return "Contenido en formato txt";
        }

        public string GetExtension()
        {
            return "txt";
        }
    }
}
