using System;
using System.Collections.Generic;
using System.Text;
using Writer.Interfaces;
namespace Writer.Models.Formaters
{
    public class FormaterYML : IFormater 
    {
        public string GetFormarter()
        {
            return ".yml";
        }
    }
}
