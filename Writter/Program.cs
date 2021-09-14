using System;
using System.Collections.Generic;
using Writter.Interfaces;
using Writter.Models;
using Writter.Models.Enums;


namespace Writter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Donde quieres escribir el archivo en cloud o local");
                string res = Console.ReadLine();

                while (res != "cloud" && res != "local")
                {
                    Console.WriteLine("Lo siento, esa opcion no es posible: (cloud/local)");
                    res = Console.ReadLine();
                }
                var factory = new Container(res).GetFactory();
                Console.WriteLine(" ");
                Console.WriteLine("Que nombre le quieres poner al archivo");
                string nombre = Console.ReadLine();
                
                Console.WriteLine(" ");
                Console.WriteLine($"Que formato tiene el archivo {nombre}: (json/plain/xml/yml)");
                string formatString = Console.ReadLine();
                while (formatString != "json" && formatString != "plain" && formatString != "xml" && formatString != "yml")
                {
                    Console.WriteLine("Lo siento, esa opcion no es posible: (json/plain/xml/yml)");
                    formatString = Console.ReadLine();
                }

                if (formatString == "json")
                {
                    var writer = factory.GetWritter(FormaterOptions.Json);
                    Console.WriteLine(" ");
                    Console.WriteLine(writer.Write(nombre));
                }
                else if (formatString == "plain")
                {
                    var writer = factory.GetWritter(FormaterOptions.Plain);
                    Console.WriteLine(" ");
                    Console.WriteLine(writer.Write(nombre));
                }
                else if (formatString == "xml")
                {
                    var writer = factory.GetWritter(FormaterOptions.Xml);
                    Console.WriteLine(" ");
                    Console.WriteLine(writer.Write(nombre));
                }
                else if (formatString == "yml")
                {
                    var writer = factory.GetWritter(FormaterOptions.Yml);
                    Console.WriteLine(" ");
                    Console.WriteLine(writer.Write(nombre));
                }
                Console.WriteLine(" ");
                Console.WriteLine("Perfecto!!!");
                Console.WriteLine(" ");
                Console.WriteLine("¿Deseas crear otro archivo?");
            }
        }
    }
}

