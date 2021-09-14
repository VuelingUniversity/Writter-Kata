using System;
using System.Collections.Generic;
using System.Text;
using Writer.Dependency.Interface;
using Writer.Dependency.Models.Enums;


namespace Writer.Dependency.Models
{
    public class FactoryWriterLocal : IFactory
    {
        private Dictionary<FormaterOptions, IFormater> _format;
        public FactoryWriterLocal(Dictionary<FormaterOptions, IFormater> d)
        {
            _format = d;
        }
        public IWriter GetWriter(FormaterOptions options)
        {
            return new Writer(_format[options]);
        }
        }
    }

