using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata
{
    public class Factory
    {
        private readonly Dictionary<string, IFormatable> _formatersList;  
        public Factory( Dictionary<string, IFormatable> formatersList)
        {
            _formatersList = formatersList;
        }

        public Writter GetWritter(string formater) {
            return new Writter(_formatersList[formater]);
                
        }

    }
}
