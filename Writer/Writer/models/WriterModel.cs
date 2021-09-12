using System;
using System.Collections.Generic;
using System.Text;

namespace Writer.models
{
    public class WriterModel
    {
        public string formatName;

        public WriterModel(Format format)
        {
            this.formatName = format.extension;
        }

        public void Write(string fileName)
        {
            Console.WriteLine($"{fileName}.{formatName}");
        }
    }
}
