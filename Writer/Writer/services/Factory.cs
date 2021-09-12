using System;
using System.Collections.Generic;
using System.Text;
using Writer.interfaces;
using Writer.models;

namespace Writer.services
{
    class Factory : IFactory
    {
        private readonly Dictionary<string, Format> _formatList = setFormatList();

        private static Dictionary<string, Format> setFormatList ()
        {
            Dictionary<string, Format> formatList = new Dictionary<string, Format>();
            formatList.Add("json", new JsonFormatter());
            formatList.Add("txt", new TxtFormatter());
            formatList.Add("xml", new XmlFormatter());
            return formatList;
        }


        public WriterModel CreateWriter(string format)
        {
            return new WriterModel(_formatList[format]);
        }

        public void PrintDictionary()
        {
            Console.WriteLine("Formatos disponibles:");
            foreach (var v in _formatList)
            {
                Console.WriteLine($"\tArchivo {v.Key}");
            }
        }
    }
}
