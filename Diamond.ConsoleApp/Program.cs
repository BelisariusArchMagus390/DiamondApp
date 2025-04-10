namespace Diamond.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número ímpar para criar um diamante: ");
            int numberDiamond = int.Parse(Console.ReadLine());

            int contFilledSpaces = 1;

            // Calcula a linha do meio do diamente
            decimal temporaryValue = numberDiamond;
            decimal midDiamondLine = Math.Ceiling(temporaryValue / 2);

            for (int line = 1; line <= numberDiamond; line++)
            {
                // Define a quantidade de espaços em branco que tem antes e depois dos espaços preenchidos
                int qtWhiteSpaces = (numberDiamond - contFilledSpaces) / 2;
            }

            Console.ReadLine();
        }
    }
}
