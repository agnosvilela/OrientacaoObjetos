using System;
using Contas;
namespace _05_AprendendoMaisOrientacaoObjetos
{
    class Program
    {
        public static void Main(string[] args)
        {
            // classes e objetos.
            // como instanciar a classe na classe program? veja:

            var conta1 = new Conta();
            conta1.Numero = "001";
            conta1.DataAbertura = DateTime.Today;
            conta1.Saldo = 0;

            Console.WriteLine(conta1.Numero);
            Console.WriteLine(conta1.DataAbertura);
            Console.WriteLine(conta1.Saldo);
        }
    }

}



