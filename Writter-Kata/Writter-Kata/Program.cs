using System;
using Writter_Kata.ContainerFactory;
using Writter_Kata.Interfaces;

namespace Writter_Kata
{
    class Program
    {
        static void Main(string[] args)           
        {
            IWriter writer = WritterFactory.CreateWriter(Enum.FormatType.json);           
            Console.WriteLine(writer.Write("Documento"));
        }
    }
}
