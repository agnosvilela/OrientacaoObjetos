using System;

namespace Contas
{
    public class Conta
    {
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        // adicionando métodos a classe conta.

        public void ExibirExtrato()
        {
            Console.WriteLine(" Conta nº: " + Numero);
            Console.WriteLine("Data de Abertura: " + DataAbertura);
            Console.WriteLine("  Saldo: " + Saldo);

        }
    }
}