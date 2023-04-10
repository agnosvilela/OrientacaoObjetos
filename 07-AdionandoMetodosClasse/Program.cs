using System;
using Contas;
namespace AdicionandoMetodosClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            //Console.WriteLine("Informe o número da conta: ");
            //conta.Numero = Console.ReadLine();
            //conta.DataAbertura = DateTime.Today;
            //conta.Saldo = 100;
            //conta.RealizarEmprestimo(200, 10);
            //Console.WriteLine(conta.ExibirExtrato1());
            // conta.Depositar(500);
            Console.WriteLine(conta.ExibirExtrato1());

            // propriedades estáticas
            // Console.WriteLine(Conta.TaxaRendimento);

            // métodos estaticos.
            //Console.WriteLine(Conta.CalcularRendimento(100, 12));

            var conta2 = new Conta("002", DateTime.Now, 500);
            Console.WriteLine(conta2.ExibirExtrato1());
        }

    }
}


