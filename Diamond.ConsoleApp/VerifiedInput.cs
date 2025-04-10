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
        private string createInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private void showErrorMessage(string typeError)
        {
            Console.Clear();
            Console.WriteLine($"\n Erro! A entrada digitada contém múltiplos elementos ou não é do tipo: {typeError}.");
            Console.WriteLine(" Aperte Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public int verifiedOddIntInput(string message)
        {
            int returnedInputInt;

            while (true)
            {
                string inputStr = createInput(message);

                if (int.TryParse(inputStr, out int inputInt))
                {
                    if ((inputInt % 2) != 0)
                    {
                        returnedInputInt = inputInt;
                        break;
                    }
                        
                }
                else
                {
                    showErrorMessage("inteiro ímpar");
                }
            }
            return returnedInputInt;
        }

        public int verifiedEvenIntInput(string message)
        {
            int returnedInputInt;

            while (true)
            {
                string inputStr = createInput(message);

                if (int.TryParse(inputStr, out int inputInt))
                {
                    if ((inputInt % 2) == 0)
                    {
                        returnedInputInt = inputInt;
                        break;
                    }

                }
                else
                {
                    showErrorMessage("inteiro par");
                }
            }
            return returnedInputInt;
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
                    showErrorMessage("inteiro");
                }
            }
            return returnedInputInt;
        }

        public double verifiedDoubleInput(string message)
        {
            double returnedInputDouble;

            while (true)
            {
                string inputStr = createInput(message);

                if (double.TryParse(inputStr, out double inputDouble))
                {
                    returnedInputDouble = inputDouble;
                    break;
                }
                else
                {
                    showErrorMessage("decimal");
                }
            }
            return returnedInputDouble;
        }

        public decimal verifiedDecimalInput(string message)
        {
            decimal returnedInputDecimal;

            while (true)
            {
                string inputStr = createInput(message);

                if (decimal.TryParse(inputStr, out decimal inputDecimal))
                {
                    returnedInputDecimal = inputDecimal;
                    break;
                }
                else
                {
                    showErrorMessage("decimal");
                }
            }
            return returnedInputDecimal;
        }

        public float verifiedFloatInput(string message)
        {
            float returnedInputFloat;

            while (true)
            {
                string inputStr = createInput(message);

                if (float.TryParse(inputStr, out float inputFloat))
                {
                    returnedInputFloat = inputFloat;
                    break;
                }
                else
                {
                    showErrorMessage("decimal");
                }
            }
            return returnedInputFloat;
        }

        public bool verifiedBoolInput(string message)
        {
            bool returnedInputBool;

            while (true)
            {
                string inputStr = createInput(message);

                if (bool.TryParse(inputStr, out bool inputBool))
                {
                    returnedInputBool = inputBool;
                    break;
                }
                else
                {
                    showErrorMessage("decimal");
                }
            }
            return returnedInputBool;
        }
    }
}
