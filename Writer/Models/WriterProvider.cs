using System;
using System.Collections.Generic;
using System.Text;
using Writer.Interfaces;
using Writer.Models.Formaters;
using Writer.Models.Enum;
namespace Writer.Models
{
    public class WriterProvider
    {
        private readonly Dictionary<FormaterOptions, IFormater> _dictFormaters = new Dictionary<FormaterOptions, IFormater>
        {
            {FormaterOptions.Json, new FormaterJSON() },
            { FormaterOptions.Plain, new FormaterPlain() },
            { FormaterOptions.Xml, new FormaterXML()},
            {FormaterOptions.Yml, new FormaterYML() }
        };
        private IFactory _factoryObject;


        public WriterProvider(string type)
        {
            if (type == "cloud")
            {
                _factoryObject = new FactoryWriterCloud(_dictFormaters);
            }
            else if (type == "local")
            {
                _factoryObject = new FactoryWriterLocal(_dictFormaters);
            }
        }
        public IFactory GetFactory()
        {
            return _factoryObject;
        }


    }
}
}
