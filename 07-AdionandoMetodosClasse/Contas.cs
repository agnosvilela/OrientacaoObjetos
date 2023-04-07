using System;

namespace Contas
{
    public class Conta
    {
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        // adicionando métodos a classe conta sem parametros.

        public void ExibirExtrato()
        {
            Console.WriteLine($" Conta nº:            {Numero} ");
            Console.WriteLine($"Data de Abertura:     {DataAbertura.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"  Saldo:              {Saldo.ToString("C")} ");
            Console.WriteLine("--------------------------------------");
        }

        // metodos com parametros
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        // metodos com retorno
        public string ExibirExtrato1()
        {
            return $" Conta nº:   {Numero}{Environment.NewLine} " +
            $"Data de Abertura:   {DataAbertura.ToString("dd/MM/yyyy")}{Environment.NewLine}" +
            $"  Saldo:            {Saldo.ToString("C")}{Environment.NewLine} " +
            "--------------------------------------";
        }

    }
}
