using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Writer.services;
using Writer.models;
using Writer.interfaces;

namespace WriterKata
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = Container.Build();
            serviceProvider.GetService<IFactory>().PrintDictionary();
            Console.WriteLine("\nEscribe la extensión del archivo que quieras crear");
            string extension = Console.ReadLine();
            Console.WriteLine("\nEscribe el nombre de archivo para crearlo");
            string fileName = Console.ReadLine();

            try {
            WriterModel w = serviceProvider.GetService<IFactory>().CreateWriter(extension);
            w.Write(fileName);
            } catch(KeyNotFoundException) 
            {
                Console.WriteLine("La extensión que has introducido no pertenece a un formato de archivo válido");
            }
        }
    }
}
