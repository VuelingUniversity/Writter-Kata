using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    class JsonFormat : IFormateable
    //Las clases format heredan de IFormateable, ya que comparten
    
    {
        // GetContent devuelve el contenido del archivo 
        public string GetContent()
        {
            return "Contenido en formato json";
        }
        //GetExtension devuelve la extension del archivo
        public string GetExtension()
        {
            return "json";
        }
    }
}
