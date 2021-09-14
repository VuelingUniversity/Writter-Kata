using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata.Interfaces
{
    public interface IWritteable
    {
        void Write(List<String> filesNames, string directory);
        void FormatAndMove(string to, string from);
    }
}
