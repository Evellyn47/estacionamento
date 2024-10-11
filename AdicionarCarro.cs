using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evellyn
{
    internal class AdicionarCarro
    {
        private List<string> placas = new List<string>();

        //ADICIONAR VEICULOS
        public void RealizarCadastro()
        {
            Console.WriteLine("Nos informe a sua placa:");
            string placa = Console.ReadLine();
            placas.Add(placa);
            Console.WriteLine($"Sua placa foi cadastrada com sucesso: {placa}");
        }

        // REMOVER VEICULOS
        public bool RemoverVeiculo(string placa, Calculo cobranca)
        {

            if (placas.remove(placa))
            {
                Console.WriteLine("Quantas horas você permaneceu?");
                cobranca.quantidadeHora = Convert.ToDouble(Console.ReadLine());
                cobranca.Calcular();
                return true;
            }
            return false;


        }

        // LISTAR VEICULOS
        public void VerificarListaVeiculos()
        {
            Console.WriteLine("Lista de veículos cadastrados:");
            if (placas.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
                return;
            }

            foreach (string placa in placas)
            {
                Console.WriteLine($":{placa}");
            }
        }
    }
}