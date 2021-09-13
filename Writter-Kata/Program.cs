using System;

namespace Writter_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.Factory.GetWritter("json").Write("Archivo");
            container.Factory.GetWritter("txt").Write("Archivo");
            container.Factory.GetWritter("xml").Write("Archivo");
            container.Factory.GetWritter("yml").Write("Archivo");
        }
    }
}
