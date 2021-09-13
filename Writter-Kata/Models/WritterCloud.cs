using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{
    public class WritterCloud : IWritteable
    {
        private IFormatable _formater;
        public WritterCloud(IFormatable formater)
        {
            _formater = formater;
        }

        public void Write(string fileName)
        {
            Console.WriteLine("Hello from cloud");
            Console.WriteLine($"{fileName}.{_formater.GetExtension()} : {_formater.GetContent()}");
        }
    }
}
