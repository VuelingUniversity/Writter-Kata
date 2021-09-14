using System;
using Writter_Kata.ContainerFactory;
using Writter_Kata.Interfaces;

namespace Writter_Kata
{
    class Program
    {
        static void Main(string[] args)           
        {
            Console.WriteLine(@"Elija un espacio en el que crear el archivo
0 ---> Local
1 ---> Cloud");
            string TipoEntorno = Console.ReadLine();
            if (TipoEntorno == "0")
            {
                IWriter writer = WritterFactory.CreateWriter(Enum.FormatType.json);
                Console.WriteLine(writer.Write("Documento"));
            }
            if (TipoEntorno == "1")
            {
                IWriter writercloud = CloudFactory.CreateWriter(Enum.FormatType.json);
                Console.WriteLine(writercloud.Write("Documento"));
            }
            
            
        }
    }
}
