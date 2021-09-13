using System;
using System.Collections.Generic;
using System.Text;
using Writer.Dependency.Interface;
using Writer.Dependency.Models.Enums;

namespace Writer.Dependency.Models
{
    public class FactoryWriters
    {
        private readonly Dictionary<FormaterOptions, IFormater> _formatDictionary;

        public FactoryWriters(Dictionary<FormaterOptions, IFormater> dictionary)
        {
            _formatDictionary = dictionary;
        }
        public IWriter GetWriter(FormaterOptions option)
        {
            return new Writer(_formatDictionary[option]);
        }
    }
    
}
