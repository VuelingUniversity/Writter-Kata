﻿using System;
using System.Collections.Generic;
using System.Text;
using Writer.Dependency.Interface;
using Writer.Dependency.Models;
using Writer.Dependency.Models.Enums;
using Writer.Dependency.Models.Formaters;

namespace Writer.Dependency
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
        private IFactory _factoryObject;


        public Container(string type)
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