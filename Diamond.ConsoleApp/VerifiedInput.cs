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

        public int verifiedIntInput(string message)
        {
            int returnedInputInt;

            while (true)
            {
                string inputStr = createInput(message);

                if (int.TryParse(inputStr, out int inputInt))
                {
                    returnedInputInt = inputInt;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n Erro! Foi digitado letras ou múltiplos números.");
                    Console.WriteLine(" Aperte Enter para continuar...");
                    Console.ReadLine();
                }
            }

            return returnedInputInt;
        }
    }
}
