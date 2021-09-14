using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;
using Writter.Models.Enums;

namespace Writter.Models
{
    class FactoryLocal : IFactory
    {
        private Dictionary<FormaterOptions, IFormater> _formaterDicts;

        public FactoryLocal(Dictionary<FormaterOptions, IFormater> dic)
        {
            _formaterDicts = dic;
        }
        public IWritter GetWritter(FormaterOptions option)
        {
            return new Writer(_formaterDicts[option]);
        }
    }
}
