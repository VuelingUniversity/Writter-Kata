using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;

namespace Writter_Kata.Interfaces
{
    public interface IFormat
    {
      public string ConversionDoc(string fileName, FormatType ext);
       
    }
}
