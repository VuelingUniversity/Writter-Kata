using System;
using System.Collections.Generic;
using System.Text;
using Writer.Interfaces;
namespace Writer.Models.Formaters
{
    public class FormaterXML : IFormater
    {
        public string GetFormarter()
        {
            return ".xml";
        }
    }
}
