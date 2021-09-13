using System;

namespace Writter_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(@"Where do you want to write)
1. File
2. Cloud");
            int option;
            Container container;

            try
            {
                Int32.TryParse(Console.ReadLine(), out option);
                container = new Container(option);

                container.Factory.GetWritter("json").Write("Archivo");
                container.Factory.GetWritter("txt").Write("Archivo");
                container.Factory.GetWritter("xml").Write("Archivo");
                container.Factory.GetWritter("yml").Write("Archivo");
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
           
           
        }
    }
}
