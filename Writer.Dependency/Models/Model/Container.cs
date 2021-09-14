using System;
using System.Collections.Generic;
using System.Text;
using Writer.Dependency.Interface;
using Writer.Dependency.Models.Enums;
using Writer.Dependency.Models.Factory;
using Writer.Dependency.Models.Formaters;

namespace Writer.Dependency.Models
{
    public class Container
    {
        private readonly Dictionary<FormaterOptions, IFormater> _formatDictionary = new Dictionary<FormaterOptions, IFormater>
        {
            {FormaterOptions.Json, new FormaterJson() },
            { FormaterOptions.Plain, new FormaterPlain() },
            { FormaterOptions.Xml, new FormaterXml()},
            {FormaterOptions.Yml, new FormaterYml() }
        };

        private readonly IFactory _factory;

        public Container(string type)
        {
            if (type == "cloud")
            {
                _factory = new CloudWritting(_formatDictionary);
            }
            else if (type == "local")
            {
                _factory = new LocalWritting(_formatDictionary);
            }
        }
        public IFactory GetFactory()
        {
            return _factory;
        }
    }
}
