namespace Diamond.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criação de objetos
            VerifiedInput vi = new VerifiedInput();
            Diamond d = new Diamond();

            int sizeDiamond = 0;
            string message = "";
            bool optionExit = false;

            while(optionExit == false)
            {
                Console.Clear();
                Console.WriteLine("\n 1 - Criar diamante");
                Console.WriteLine(" 2 - Mostrar diamante");
                Console.WriteLine(" 3 - Sair");

                Console.Write("\n Escolha uma das opções: ");
                char optionMenu = Console.ReadLine()[0];

                switch (optionMenu)
                {
                    case '1':
                        Console.Clear();
                        // cria o diamante
                        d.createDiamond(sizeDiamond);                        

                        message = " Digite um número ímpar para criar um diamante: ";
                        sizeDiamond = vi.verifiedOddIntInput(message);
                        break;

                    case '2':
                        Console.Clear();

                        if (sizeDiamond != 0)
                        {
                            // mostra o diamante
                            d.showDiamond();
                        }
                        else
                        {
                            Console.WriteLine($"\n Erro! O tamanho do diamante não foi especificado.");
                        }

                        Console.WriteLine(" Aperte Enter para continuar...");
                        Console.ReadLine();
                        break;

                    case '3':
                        optionExit = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" Erro! Opção incorreta.");
                        Console.WriteLine(" Aperte Enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
