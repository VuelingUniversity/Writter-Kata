using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Writer.Dependency.Interface;

namespace Writer.Dependency.Models
{
    public class Writer : IWriter
    {
        private IFormater formater;
        private string target = @"C:\Users\avicenteb\Documents\Parallel\source";

        public Writer(IFormater formater)
        {
            this.formater = formater;
        }

        public string Write(string msg)
        {
            return $"{msg}{formater.GetFormater()}";
        }

        public void RenameFile(string msg)
        {
            //foreach(string path in Directory.GetFiles(target))
            //{
            //    File.Delete(path);
                
            //}
            Console.WriteLine("Que archivo quieres formatear");
            string name = Console.ReadLine();
            var listFiles = Directory.GetFiles(target);
            var list = listFiles.Where(x => x.Split("\\")[x.Split("\\").Length -1] == name);
            if (list.Any())
            {
                File.Delete($"{target}\\{name}");
            }
            else
            {
                Console.WriteLine("No existe el archivo");
            }
            var file = File.Create($"{target}\\{msg}{formater.GetFormater()}");
            file.Close();
        }
    }
}
