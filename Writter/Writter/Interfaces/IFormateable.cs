using System;
using System.Collections.Generic;
using System.Text;

namespace Writter.Interfaces
{
    interface IFormateable
    {
        //se implementan los metodos de las clases de los archivos
        string GetExtension();
        string GetContent();
    }
}

