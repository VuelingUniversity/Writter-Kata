using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    class JsonFormat : IFormateable
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
