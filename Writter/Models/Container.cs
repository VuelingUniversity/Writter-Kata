using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;
using Writter.Models.Enums;
using Writter.Models.Formaters;

namespace Writter.Models
{
    public class Container
    {
        private readonly Dictionary<FormaterOptions, IFormater> _dictFormaters = new Dictionary<FormaterOptions, IFormater>
        {
            {FormaterOptions.Json, new FormaterJSON() },
            { FormaterOptions.Plain, new FormaterPlain() },
            { FormaterOptions.Xml, new FormaterXML()},
            {FormaterOptions.Yml, new FormaterYML() }
        };

        public IFactory _factoryObject;

        public Container(string type)
        {
            if (type == "cloud")
            {
                _factoryObject = new FactoryCloud(_dictFormaters);
            }
            else if (type == "local")
            {
                _factoryObject = new FactoryLocal(_dictFormaters);
            }
        }
        public IFactory GetFactory()
        {
            return _factoryObject;
        }

        /*private void IsCloud(bool isCloud)
         {
         }
        */
    }
}
