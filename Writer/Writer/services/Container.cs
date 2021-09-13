using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Writer.interfaces;
using Writer.models;

namespace Writer.services
{
    public static class Container
    {
        private static readonly Dictionary<string, Format> _formatList = SetDictionary();

        private static Dictionary<string, Format> SetDictionary ()
        {
            Dictionary<string, Format> formatList = new Dictionary<string, Format>();
            formatList.Add("json", new JsonFormatter());
            formatList.Add("txt", new TxtFormatter());
            formatList.Add("xml", new XmlFormatter());
            return formatList;
        }
        public static IServiceProvider Build(FactoryType type)
        {
            if (type.Equals(FactoryType.Local))
                return new ServiceCollection()
                    .AddSingleton<IFactory>(x => (new CloudWriterFactory(_formatList)))
                    .BuildServiceProvider();
            else return new ServiceCollection()
                    .AddSingleton<IFactory>(x => (new CloudWriterFactory(_formatList)))
                    .BuildServiceProvider();
        }

    }
}
