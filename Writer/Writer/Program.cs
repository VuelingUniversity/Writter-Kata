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

            Console.WriteLine(@"Quieres crear el archivo en la nube o en local?
    Escribe 0 para crear un archivo en tu ordenador
    Escribe 1 para crear un archivo en la nube");
            int option = 0;
            Int32.TryParse(Console.ReadLine(), out option);
            FactoryType type;
            if (option == 0)
            {
                type = FactoryType.Local;
                WriterCreation(type);
            }
            else if (option == 1)
            {
                type = FactoryType.Cloud;
                WriterCreation(type);
            } else
            {
                Console.WriteLine("Input no válido, se cerrará el programa");
            }



        }

        private static void WriterCreation(FactoryType type)
        {
            var serviceProvider = Container.Build(type);
            serviceProvider.GetService<IFactory>().PrintDictionary();
            Console.WriteLine("\nEscribe la extensión del archivo que quieras crear");
            string extension = Console.ReadLine();
            Console.WriteLine("\nEscribe el nombre de archivo para crearlo");
            string fileName = Console.ReadLine();
            try
            {
                WriterModel w = serviceProvider.GetService<IFactory>().CreateWriter(extension);
                w.Write(fileName);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("La extensión que has introducido no pertenece a un formato de archivo válido");
            }
        }
    }
}
