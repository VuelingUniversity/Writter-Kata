using System;
using System.Collections.Generic;
using Writer.Dependency;
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
                Console.WriteLine("Donde quieres escribir el archivo en cloud o local");
                string res = Console.ReadLine();

                while (res != "cloud" && res != "local")
                {
                    Console.WriteLine("Lo has escrito mal: (cloud/local)");
                    res = Console.ReadLine();
                }
                var factory = new Container(res).GetFactory();

                Console.WriteLine("Que nombre le quieres poner al archivo");
                string nombre = Console.ReadLine();

                Console.WriteLine($"Que formato tiene el archivo {nombre}: (json/plain/xml/yml)");
                string formatString = Console.ReadLine();
                while (formatString != "json" && formatString != "plain" && formatString != "xml" && formatString != "yml")
                {
                    Console.WriteLine("Lo has esccrito mal: (json/plain/xml/yml)");
                    formatString = Console.ReadLine();
                }

                if (formatString == "json")
                {
                    var writer = factory.GetWriter(FormaterOptions.Json);
                    Console.WriteLine(writer.Write(nombre));
                }
                else if (formatString == "plain")
                {
                    var writer = factory.GetWriter(FormaterOptions.Plain);
                    Console.WriteLine(writer.Write(nombre));
                }
                else if (formatString == "xml")
                {
                    var writer = factory.GetWriter(FormaterOptions.Xml);
                    Console.WriteLine(writer.Write(nombre));
                }
                else if (formatString == "yml")
                {
                    var writer = factory.GetWriter(FormaterOptions.Yml);
                    Console.WriteLine(writer.Write(nombre));
                }
                Console.WriteLine($" El nombre de tu documento elegido es: {nombre} y el tipo de archivo es: {formatString} \n {nombre}.{formatString}");
            }

        }
        }
        }
