using System;
using System.Collections.Generic;
using WriterKata.models;

namespace WriterKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Format> formatList = new Dictionary<string, Format>();
            formatList.Add("json", new JsonFormatter());
            formatList.Add("txt", new TxtFormatter());
            formatList.Add("xml", new XmlFormatter());
            Factory factory = new Factory(formatList);
            Writer w = factory.createWriter("json");
            w.Write("HolaMundo");

        }
    }
}
