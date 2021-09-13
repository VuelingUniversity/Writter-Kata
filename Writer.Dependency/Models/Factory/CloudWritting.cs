using System;
using System.Collections.Generic;
using System.Text;
using Writer.Dependency.Interface;
using Writer.Dependency.Models.Enums;

namespace Writer.Dependency.Models.Factory
{
    public class CloudWritting : IFactory
    {
        private readonly Dictionary<FormaterOptions, IFormater> _formatersDicts;


        public CloudWritting(Dictionary<FormaterOptions, IFormater> dic)
        {
            _formatersDicts = dic;
        }
        public IWriter GetWriter(FormaterOptions option)
        {
            return new Writer(_formatersDicts[option]);
        }

    }
}
