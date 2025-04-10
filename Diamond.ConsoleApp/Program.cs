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

            // Calcula a linha do meio do diamente
            decimal temporaryValue = numberDiamond;
            decimal midDiamondLine = Math.Ceiling(temporaryValue / 2);

            for (int line = 1; line <= numberDiamond; line++)
            {
                // Define a quantidade de espaços em branco que tem antes e depois dos espaços preenchidos
                int qtWhiteSpaces = (numberDiamond - contFilledSpaces) / 2;

                for (int column = 1; column <= numberDiamond; column++)
                {
                    if ((column <= qtWhiteSpaces) || (column > (numberDiamond - qtWhiteSpaces) && column <= numberDiamond))
                        Console.Write(" ");
                    else
                        Console.Write("x");
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

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
