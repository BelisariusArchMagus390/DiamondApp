using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.ConsoleApp
{
    internal class Diamond
    {
        public static int Size { get; set; }
        public string[,] DiamondMatrix { get; set; }

        public void createDiamond(int size)
        {
            Size = size;

            DiamondMatrix = new string[Size, Size];

            int contFilledSpaces = 1;

            // calcula a linha do meio do diamente
            decimal temporaryValue = Size;
            decimal midDiamondLine = Math.Ceiling(temporaryValue / 2);

            for (int line = 1; line <= Size; line++)
            {
                // define a quantidade de espaços em branco que tem antes e depois dos espaços preenchidos
                int qtWhiteSpaces = (Size - contFilledSpaces) / 2;

                for (int column = 1; column <= Size; column++)
                {
                    if ((column <= qtWhiteSpaces) || (column > (Size - qtWhiteSpaces) && column <= Size))
                        DiamondMatrix[(line - 1), (column - 1)] = " ";
                    else
                        DiamondMatrix[(line - 1), (column - 1)] = "x";
                }
                // compara para saber se está no meio do diamante
                if (line == (Size - 1))
                    contFilledSpaces = 1;
                else
                {
                    if (line >= midDiamondLine)
                        contFilledSpaces -= 2;
                    else
                        contFilledSpaces += 2;
                }
            }
        }
    }
}