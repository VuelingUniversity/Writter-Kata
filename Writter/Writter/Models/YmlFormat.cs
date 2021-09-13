using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    class YmlFormat : IFormateable
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
