using System;
using System.Collections.Generic;
using System.Text;
using Writer.Models.Enum;
using Writer.Interfaces;

namespace Writer.Models
{
    public class Writer : IWriter
    {
        private readonly IFormater formater;

        public Writer(IFormater formater)
        {
            this.formater = formater;
        }
        public string Write(string msg)
        {
            return $"{msg}{formater.GetFormarter()}";
        }
    }
}
