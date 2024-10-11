namespace evellyn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdicionarCarro estacionamento = new AdicionarCarro();
            bool encerrar = true;
            int opcao = 0;

            Calculo calculos = new Calculo();

            Console.WriteLine("Qual é o valor do estacionamento?");
            calculos.valorEstacionamento = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Qual é o valor por hora?");
            calculos.valorHora = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine(
                "             == ESTACIONAMENTO ==\n" +
                "[1]-Para cadastrar mais veículos\n" +
                "[2]-Para remover veículo\n" +
                "[3]-Para verificar a lista de veículos\n" +
                "[4]-Para sair");

                Console.WriteLine("Digite a opção:");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        estacionamento.RealizarCadastro();
                        break;

                    case 2:
                        Console.WriteLine("Qual é a placa do veículo que você deseja remover?");
                        string removerPlaca = Console.ReadLine().ToLower();

                        if (estacionamento.RemoverVeiculo(removerPlaca, calculos))
                        {
                            Console.WriteLine("Carro removido.");
                        }
                        else
                        {
                            Console.WriteLine("Carro não encontrado.");
                        }
                        break;

                    case 3:
                        estacionamento.VerificarListaVeiculos(); 
                        break;

                    case 4:
                        encerrar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;
                }
            } while (encerrar);
        }
    }
}