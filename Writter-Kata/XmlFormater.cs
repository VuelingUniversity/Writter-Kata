﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata
{
    class XmlFormater : IFormatable
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
