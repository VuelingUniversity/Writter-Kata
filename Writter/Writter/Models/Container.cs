using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    class Container
    {
        //Diccionario para guardar los formatos de los archivos (string para el nombre, iniciar objeto)
        public Dictionary<string, IFormateable> ListFormat = new Dictionary<string, IFormateable>
        {
            {".json", new JsonFormat() },
            {".txt", new TxtFormat()  },
            {".xml", new XmlFormat() },
            {".yml", new YmlFormat() }

        };
        //crea un objeto del tipo factory para luego llamarlo al contenedor
        public Factory Factory;

        //
        public Container()
        {
            Factory = new Factory(ListFormat);
        }
    }
}
