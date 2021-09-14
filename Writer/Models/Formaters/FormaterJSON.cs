using System;
using System.Collections.Generic;
using System.Text;
using Writer.Interfaces;
namespace Writer.Models.Formaters
{
    public class FormaterJSON :IFormater
    {
        public string GetFormarter()
        {
            return (".json");
        }

    }
}
