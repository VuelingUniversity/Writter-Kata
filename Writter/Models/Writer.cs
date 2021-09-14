using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    public class Writer : IWritter
    {
        private IFormater formater;

        public Writer(IFormater formater)
        {
            this.formater = formater;
        }
        public string Write(string msg)
        {
            return $"{msg}{formater.GetFormater()}";
        }
    }
}
