namespace evellyn
{
    public class Calculo
    {
        public double valorEstacionamento { get; set; }
        public double valorHora { get; set; }
        public double quantidadeHora { get; set; }

        public void Calcular() // Correção: PascalCase no nome do método
        {
            double valorTotal = valorEstacionamento + (valorHora * quantidadeHora);
            Console.WriteLine("O valor total é: " + valorTotal.ToString("F2"));
        }
    }
}    