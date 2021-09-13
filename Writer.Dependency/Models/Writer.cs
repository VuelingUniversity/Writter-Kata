﻿using System;
using System.Collections.Generic;
using System.Text;
using Writer.Dependency.Interface;

namespace Writer.Dependency.Models
{
    public class Writer : IWriter
    {
        private readonly IFormater formater;

        public Writer(IFormater formater)
        {
            this.formater = formater;
        }

        public string Write(string fileName)
        {
            return $"{fileName}{formater.GetFormater()}";
        }
    }
}
