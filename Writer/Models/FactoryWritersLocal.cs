using System;
using System.Collections.Generic;
using System.Text;
using Writer.Interfaces;
using Writer.Models;
using Writer.Models.Enum;
namespace Writer.Models
{
    public class FactoryWriterLocal : IFactory
    {
        private Dictionary<FormaterOptions, IFormater> _formatersDicts;

        public FactoryWriterLocal(Dictionary<FormaterOptions, IFormater> dic)
        {
            _formatersDicts = dic;
        }
        public IWriter GetWriter(FormaterOptions option)
        {
            return new Writer(_formatersDicts[option]);
        }
    }
}
