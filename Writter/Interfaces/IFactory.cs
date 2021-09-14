using System;
using System.Collections.Generic;
using System.Text;
using Writter.Models.Enums;

namespace Writter.Interfaces
{
    public interface IFactory
    {
         IWritter GetWritter(FormaterOptions option);
    }
}
