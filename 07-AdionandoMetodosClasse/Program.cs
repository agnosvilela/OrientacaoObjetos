using System;
using Contas;
namespace AdicionandoMetodosClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.Numero = "002";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 100;
            conta.RealizarEmprestimo(200, 10);
            Console.WriteLine(conta.ExibirExtrato1());
            conta.Depositar(500);
            Console.WriteLine(conta.ExibirExtrato1());



        }

    }
}


