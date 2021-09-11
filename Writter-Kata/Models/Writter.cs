using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata
{
    public class Writter
    {
        private IFormatable _formater;
        public Writter(IFormatable formater)
        {
            _formater = formater;
        }

        public void Write(string fileName) {
            Console.WriteLine($"{fileName}.{_formater.GetExtension()} : {_formater.GetContent()}");
        }
    }
}
