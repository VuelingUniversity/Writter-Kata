﻿using System;
using System.Collections.Generic;
using System.Text;
using Writer.Dependency.Models.Enums;

namespace Writer.Dependency.Interface
{
    interface IFactory
    {
        public IWriter GetWriter(FormaterOptions option);

    }
}