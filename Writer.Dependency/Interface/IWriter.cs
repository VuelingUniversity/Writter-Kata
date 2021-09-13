using System;
using System.Collections.Generic;
using System.Text;

namespace Writer.Dependency.Interface
{
    public interface IWriter
    {
        public string Write(string fileName);
    }
}
