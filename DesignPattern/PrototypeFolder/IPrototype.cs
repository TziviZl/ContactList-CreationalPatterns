﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypeFolder
{
    internal interface IPrototype
    {
        IPrototype Clone();
    }
}
