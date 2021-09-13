using System;
using System.ComponentModel;
using Writter.Models;
using Container = Writter.Models.Container;

namespace Writter
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicia un objeto contenedor el cual recibe un objeto de factory(GetWritter) y otro de Writter (Writte)
            var container = new Container();
            container.Factory.GetWritter(".json").Write("Archivo");

            
            
        }
    }
}
