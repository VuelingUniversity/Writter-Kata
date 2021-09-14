using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Writter_Kata.Interfaces;

namespace Writter_Kata
{
    public class Writter : IWritteable
    {
        private IFormatable _formater;
        public Writter(IFormatable formater)
        {
            _formater = formater;
        }

        

        // Tendra que crear la carpeta y formatear los archivos de dentro de la carpeta
        //public void Write(string fileName) {
        //    string route = @"C:\Users\nettrim\Documents\Writter";
        //    if (!File.Exists(@$"{route}\{fileName}.{_formater.GetExtension()}"))
        //    {
        //        File.Create(@$"{route}\{fileName}.{_formater.GetExtension()}");
        //    }
        //    Console.WriteLine("El archivo ya existe");

        //}
        public void Write(List<String> filesNames, string directory)
        {
           string route = @$"C:\Users\nettrim\Documents\Writter\{directory}";
            var extension = _formater.GetExtension();

            if (!Directory.Exists(route))
            {
                Directory.CreateDirectory(route);
            }

            Parallel.ForEach(filesNames, (file) =>
            {
                if (!File.Exists(@$"{route}\{file}.{extension}"))
                {
               File.Create(@$"{route}\{file}.{extension}");                 
                }
            });   
        }

        public void FormatAndMove(string to, string from)
        {
            // 1 argumento es el directorio a donde queremos mover los archivos, 2 argumento es donde stan ahora los archivos
            string current = @$"C:\Users\nettrim\Documents\Writter\{from}";
            string[] files = Directory.GetFiles(current);
            var extension = _formater.GetExtension();
            Parallel.ForEach(files, fileName =>
            {
              
                File.Copy(@$"{fileName}", $@"{to}\{Path.GetFileNameWithoutExtension(fileName)}.{extension}");
            });  
            }



    }
}
