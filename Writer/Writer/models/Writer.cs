using System;
using System.Collections.Generic;
using System.Text;

namespace WriterKata.models
{
    class Writer
    {
        public string formatName;

        public Writer(Format format)
        {
            this.formatName = format.extension;
        }

        public void Write(string fileName)
        {
            Console.WriteLine($"{fileName}.{formatName}");
        }
    }
}
