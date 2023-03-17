using System;
namespace TrabalhandoComMetodos
{
    // criando uma classe com suas propriedades
    class ContaCorrente
    {
        public string Numero;
        public decimal Saldo;
        // criando o metodo - 1 modificador de acesso / tipo de retorno do metodo
        // nome do metodo - maiuscula 
        // metodo sem retorno
        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Numero: {Numero} Saldo: {Saldo}");
        }

        // metodo que tem retorno 

        public string ListarInformacoes()
        {
            return $"Numero: {Numero} | Saldo: {Saldo}";
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe e criando objetos.
            var conta1 = new ContaCorrente();
            conta1.Numero = "0025";
            conta1.Saldo = 500m;
            // imprindo as propriedades
            //Console.WriteLine($"Numero: {conta1.Numero} Saldo: {conta1.Saldo}");
            // conta1.ImprimirInformacoes();
            conta1.ListarInformacoes();// o metodo por si so nao imprime.
            var informacoes = conta1.ListarInformacoes();
            Console.WriteLine(informacoes);

            conta1.Depositar(500);
            Console.WriteLine(conta1.ListarInformacoes());
        }
    }

}






