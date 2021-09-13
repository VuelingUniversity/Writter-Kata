using System;
using System.Collections.Generic;
using Writer.Dependency.Interface;
using Writer.Dependency.Models;
using Writer.Dependency.Models.Enums;

namespace Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<FormaterOptions, IFormater> dictFormaters = new Dictionary<FormaterOptions, IFormater>();
            dictFormaters.Add(FormaterOptions.Json, new FormaterJSON());
            
            FactoryWriters factory = new FactoryWriters(dictFormaters);
            var writerJson = factory.GetWriter(FormaterOptions.Json);

        }
    }
}
