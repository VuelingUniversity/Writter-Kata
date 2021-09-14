using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;
using Writter.Models.Enums;

namespace Writter.Models
{
    public class FactoryCloud : IFactory
    {
        private Dictionary<FormaterOptions, IFormater> _formaterDicts;
        

        public FactoryCloud(Dictionary<FormaterOptions, IFormater> dic)
        {
            _formaterDicts = dic;
        }

        public IWritter GetWritter(FormaterOptions option)
        {
            return new Writer(_formaterDicts[option]);
        }
    }
}