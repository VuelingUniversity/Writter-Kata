using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;

namespace Writter_Kata
{
    public class FactoryCloud : IFactoryable
    {
        private readonly Dictionary<string, IFormatable> _formatersList;
        public FactoryCloud(Dictionary<string, IFormatable> formatersList)
        {
            _formatersList = formatersList;
        }

        public IWritteable GetWritter(string formater)
        {
            return new WritterCloud(_formatersList[formater]);
        }

        
    }
}
