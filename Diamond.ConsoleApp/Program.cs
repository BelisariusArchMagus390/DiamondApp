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
                Console.WriteLine(" 3 - Diamante animado");
                Console.WriteLine(" 4 - Sair");

                Console.Write("\n Escolha uma das opções: ");
                char optionMenu = Console.ReadLine()[0];

                switch (optionMenu)
                {
                    // cria o diamante
                    case '1':
                        Console.Clear();

                        message = " Digite um número ímpar para criar um diamante: ";
                        sizeDiamond = vi.verifiedOddIntInput(message);

                        d.createDiamond(sizeDiamond);
                        break;

                    // mostra o diamante
                    case '2':
                        Console.Clear();

                        if (sizeDiamond != 0)
                        {
                            d.showDiamond();
                        }
                        else
                        {
                            Console.WriteLine($"\n Erro! O tamanho do diamante não foi especificado.");
                        }

                        Console.WriteLine("\n Aperte Enter para continuar...");
                        Console.ReadLine();
                        break;

                    // sai do programa
                    case '3':
                        optionExit = true;
                        break;

                    case '4':
                        Console.Clear();

                        d.animatedDiamond();

                        Console.WriteLine("\n Aperte Enter para continuar...");
                        Console.ReadLine();
                        break;

                    // erro de entrada da opção
                    default:
                        Console.Clear();
                        Console.WriteLine("\n Erro! Opção incorreta.");
                        Console.WriteLine(" Aperte Enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
