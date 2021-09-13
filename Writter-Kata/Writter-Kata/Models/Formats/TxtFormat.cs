using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Formats
{
    public class TxtFormat : IFormat
    {
        public string ConversionDoc(string fileName)
        {
            return fileName + ".txt";
        }
    }
}
