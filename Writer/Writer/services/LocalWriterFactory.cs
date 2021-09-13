using System;
using System.Collections.Generic;
using System.Text;
using Writer.interfaces;
using Writer.models;

namespace Writer.services
{
    public class LocalWriterFactory : IFactory
    {
        private readonly Dictionary<string, Format> _formatList;

        public LocalWriterFactory (Dictionary<string, Format> formatList)
        {
            _formatList = formatList;
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
