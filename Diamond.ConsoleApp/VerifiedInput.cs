using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Diamond.ConsoleApp
{
    internal class VerifiedInput
    {
        public string createInput()
        {
            Console.Write("\n Digite o número que quer verificar se é um primo: ");
            return Console.ReadLine();
        }
    }
}
