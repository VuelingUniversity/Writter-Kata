using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{


    public class WritterCloud : IWritteable
    {
        private IFormatable _formater;
        public WritterCloud(IFormatable formater)
        {
            _formater = formater;
        }

     
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
