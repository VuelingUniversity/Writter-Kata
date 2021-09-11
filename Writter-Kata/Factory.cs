using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata
{
    class Factory
    {
        private readonly Dictionary<string, IFormatable> _formatersList;  
        public Factory( Dictionary<string, IFormatable> formatersList)
        {
            _formatersList = formatersList;
        }
    }
}
