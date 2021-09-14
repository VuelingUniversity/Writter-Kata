using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    public class FormaterJSON : IFormater
    {
        public string GetFormater()
        {
            return ".json";
        }
    }
}
