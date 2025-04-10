namespace Diamond.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VerifiedInput vi = new VerifiedInput();
            Diamond d = new Diamond();

            string message = " Digite um número ímpar para criar um diamante: ";
            int numberDiamond = vi.verifiedOddIntInput(message);

            d.createDiamond(numberDiamond);

            d.showDiamond();

            Console.ReadLine();
        }
    }
}
