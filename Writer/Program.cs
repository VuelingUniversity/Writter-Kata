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
            while (true)
            {
                Console.WriteLine("Choose writing site: local or cloud");
                string res = Console.ReadLine();
                var factory = new Container(res).GetFactory();

                Console.WriteLine("choose a file name");
                string name = Console.ReadLine();

                Console.WriteLine($"Choose a format for the file {name}: (json/plain/xml/yml)");
                string formatString = Console.ReadLine();

                if (formatString == "json")
                {
                    var writer = factory.GetWriter(FormaterOptions.Json);
                    Console.WriteLine(writer.Write(name));
                }
                else if (formatString == "plain")
                {
                    var writer = factory.GetWriter(FormaterOptions.Plain);
                    Console.WriteLine(writer.Write(name));
                }
                else if (formatString == "xml")
                {
                    var writer = factory.GetWriter(FormaterOptions.Xml);
                    Console.WriteLine(writer.Write(name));
                }
                else if (formatString == "yml")
                {
                    var writer = factory.GetWriter(FormaterOptions.Yml);
                    Console.WriteLine(writer.Write(name));
                }


            }
        }
    }
}
