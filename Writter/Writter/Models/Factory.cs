using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    class Factory
    {
        //se crea el dictionary con el key value
        private readonly Dictionary<string, IFormateable> _ListFormat;
        //En el constructor de factory le paso el dictionary
        public Factory(Dictionary<string, IFormateable> extensionsList)
        {
            _ListFormat = extensionsList;
        }
        //creo un objeto writter donde le paso el diccionario con la interfaz que le añade
    
        public Writter GetWritter(string formatType)
        {
            return new Writter(_ListFormat[formatType]);
        }
    }
}
