using System;
using System.Collections.Generic;
using System.Text;
using Writer.Models;
using Writer.Interfaces;
using Writer.Models.Enum;

namespace Writer.Models
{
    public class FactoryWriterCloud : IFactory
    {
        private Dictionary<FormaterOptions, IFormater> _formatersDicts;


        public FactoryWriterCloud(Dictionary<FormaterOptions, IFormater> dic)
        {
            _formatersDicts = dic;
        }
        public IWriter GetWriter(FormaterOptions option)
        {
            return new Writer(_formatersDicts[option]);
        }

    }
}
