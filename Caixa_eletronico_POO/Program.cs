namespace caixa_eletronico_POO;

public class Program 
{
    public static void Main() 
    {
        char opcao;
        bool sair = false;

        Cliente cliente = new Cliente(01, "Leonardo", "Rua A, 123", "senha");

        Conta conta = new Conta(1000, "Corrente", cliente);

        Console.WriteLine("Bem-vindo ao Caixa Eletrônico!\n");

        Console.WriteLine("Digite seu ID: ");
        int.TryParse(Console.ReadLine(), out int id);

        Console.WriteLine("digite sua senha: ");
        string senha = Console.ReadLine();

        if(!cliente.Autenticar(id, senha))
        {
            Console.WriteLine("\nID ou senha incorretos! Encerrando programa...");
            return;
        }

        else
        {
            Console.WriteLine("\nLogin realizado com sucesso! Bem-vindo, " + cliente.Nome + "!");
            Pausar();
        }

        do
        {
            Console.Clear();
            Console.WriteLine("------------Menu------------\n");
            Console.WriteLine("1. Consultar Saldo\n");
            Console.WriteLine("2. Sacar\n");
            Console.WriteLine("3. Depositar\n");
            Console.WriteLine("4. Sair\n");

            Console.Write("Digite aqui: ");
            if (!char.TryParse(Console.ReadLine(), out opcao))
            {
                continue;
            }

            switch (opcao)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("\nMostrando saldo...");
                    Console.WriteLine("R$: " + conta.ConsultarSaldo());
                    Pausar();
                    break;

                case '2':
                    Console.Clear();
                    Console.WriteLine("\nDigite o valor que deseja sacar: ");
                    decimal.TryParse(Console.ReadLine(), out decimal valorSaque);

                    if(conta.Sacar(valorSaque))
                    {
                        Console.WriteLine("\nSaque realizado com sucesso!");
                        Console.WriteLine("Saldo atual R$: " + conta.ConsultarSaldo());
                        Pausar();
                    }
                    else
                    {
                        Console.WriteLine("\nSaldo insuficiente ou valor inválido para realizar o saque.");
                        Pausar();
                    }
                    break;

                case '3':

                    Console.Clear();
                    Console.WriteLine("\nDigite o valor que deseja depositar: ");
                    decimal.TryParse(Console.ReadLine(), out decimal valorDeposito);

                    if (conta.Depositar(valorDeposito))
                    {
                        Console.WriteLine("\nDepósito realizado com sucesso!");
                        Console.WriteLine("Saldo atual R$: " + conta.ConsultarSaldo());
                        Pausar();
                    }
                    else
                    {
                        Console.WriteLine("\nValor inválido para realizar o depósito!");
                        Pausar();
                    }
                    break;
                case '4':
                    Console.WriteLine("\nEncerrando programa... Obrigado por usar nosso serviço!");
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida! Digite valor de 1 a 4.");
                    Pausar();
                    break;
            }
        }while (!sair);
    }
    //---------------------------------------------------------------------------
    public static void Pausar()
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}