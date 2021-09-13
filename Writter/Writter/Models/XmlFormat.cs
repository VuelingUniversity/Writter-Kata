using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    class XmlFormat : IFormateable
    {
        public string GetContent()
        {
            return "Contenido en formato xml";
        }

        public string GetExtension()
        {
            return "xml";
        }
    }
}
