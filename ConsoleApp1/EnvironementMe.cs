﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EnvironementMe : Interface.IEnvironementMe
    {
        public String getUserNamle()
        {
            return Environment.UserName;
        }
    }
}