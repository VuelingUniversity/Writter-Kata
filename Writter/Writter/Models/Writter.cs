using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    public class Writter : IFormateable
    {
        //llama interfaz y crea objeto tipo de interfaz
        private IFormateable _formatType;
            //crea objeto ttipo writer donde pasa la interfaz
            public Writter(IFormateable formatType)
        {
            _formatType = formatType;
        }
        public void Write(string Name)
        {
            Console.WriteLine($"{Name}.{_formatType.GetExtension()} : {_formatType.GetContent()}");
        }

            //write le pasa nombre del archivo con la extension y luego el contenido del archivo
            //desde el main
    }
}
