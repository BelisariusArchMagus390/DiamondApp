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

            

            Console.ReadLine();
        }
    }
}
