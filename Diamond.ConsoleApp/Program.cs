namespace Diamond.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número ímpar para criar um diamante: ");
            int numberDiamond = int.Parse(Console.ReadLine());

            // matriz que armazena o diamante
            string[,] diamondMatrix = new string[numberDiamond, numberDiamond];

            int contFilledSpaces = 1;

            // calcula a linha do meio do diamente
            decimal temporaryValue = numberDiamond;
            decimal midDiamondLine = Math.Ceiling(temporaryValue / 2);

            for (int line = 1; line <= numberDiamond; line++)
            {
                // define a quantidade de espaços em branco que tem antes e depois dos espaços preenchidos
                int qtWhiteSpaces = (numberDiamond - contFilledSpaces) / 2;

                for (int column = 1; column <= numberDiamond; column++)
                {
                    if ((column <= qtWhiteSpaces) || (column > (numberDiamond - qtWhiteSpaces) && column <= numberDiamond))
                        diamondMatrix[(line-1), (column-1)] = " ";
                    else
                        diamondMatrix[(line-1), (column-1)] = "x";
                }
                // compara para saber se está no meio do diamante
                if (line == (numberDiamond - 1))
                    contFilledSpaces = 1;
                else
                {
                    if (line >= midDiamondLine)
                        contFilledSpaces -= 2;
                    else
                        contFilledSpaces += 2;
                }
            }

            // mostra a matriz diamondMatrix
            for (int line = 0; line < numberDiamond; line++)
            {
                Console.Write(" ");
                for (int column = 0; column < numberDiamond; column++)
                {
                    Console.Write(diamondMatrix[line,column]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
