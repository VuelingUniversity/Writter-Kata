using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{
    public class Writer : IWriter
    {
        private IFormat formater;
        public Writer(IFormat formater)
        {
            this.formater=formater;
        }
    }
}
