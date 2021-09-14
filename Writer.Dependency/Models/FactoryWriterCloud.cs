using System;
using System.Collections.Generic;
using System.Text;
using Writer.Dependency.Interface;
using Writer.Dependency.Models.Enums;

namespace Writer.Dependency.Models
{
    public class FactoryWriterCloud : IFactory
    {
        private  Dictionary<FormaterOptions, IFormater> _formatersDicts;

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
