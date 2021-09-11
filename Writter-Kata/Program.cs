using System;

namespace Writter_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.Factory.GetWritter("json").Write("Archivo");
        }
    }
}
