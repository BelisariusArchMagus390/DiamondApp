﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Diamond.ConsoleApp
{
    internal class VerifiedInput
    {
        public string createInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
