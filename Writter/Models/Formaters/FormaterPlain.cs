﻿using System;
using System.Collections.Generic;
using System.Text;
using Writter.Interfaces;

namespace Writter.Models
{
    class FormaterPlain : IFormater
    {
        public string GetFormater()
        {
            return ".txt";
        }
    }
}
