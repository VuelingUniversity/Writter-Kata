using System;
using System.Collections.Generic;
using System.Text;
using Writer.Models;
using Writer.Models.Enum;

namespace Writer.Interfaces
{
    public interface IFactory
    {
        public IWriter GetWriter(FormaterOptions option);
    }
}
