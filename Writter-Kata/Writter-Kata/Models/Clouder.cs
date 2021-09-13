using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{
    public class Clouder : IWriter
    {
        private IFormat formater;

        public Clouder(IFormat formater)
        {
            this.formater = formater;
        }
        public string Write(string filename)
        {
            return formater.ConversionDoc(filename);
        }
    }
}
