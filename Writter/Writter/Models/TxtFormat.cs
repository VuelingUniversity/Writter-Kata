using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    class TxtFormat : IFormateable
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
