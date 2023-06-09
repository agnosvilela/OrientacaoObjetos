using System;

namespace Contas
{
    public class Conta
    {
        public static double TaxaRendimento = 0.5f;
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        // adicionando o método construtor
        public Conta()
        {
            Numero = DateTime.Now.ToString("yyyyMMddhhmmss");
            DataAbertura = DateTime.Now;
            Saldo = 0;

            Console.WriteLine("Conta Ceriada");
        }


        // criando o metodo construtos com sobrecarga

        public Conta(string numero, DateTime dataAbertura, decimal saldo)
        {
            Numero = numero;
            DataAbertura = dataAbertura;
            Saldo = saldo;

        }





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
        /*sobrecarga de métodos- mesmo nome, porém, com assinaturas diferentes.*/
        public void RealizarEmprestimo(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"O valor {valor} será creditado e será debitado dentro de 30 dias");
        }
        // sobrecarga de metodos
        public void RealizarEmprestimo(decimal valor, int parcelas)
        {
            Saldo += valor;
            Console.WriteLine($" o valor {valor} foi creditado e será debitado em {parcelas} vezes.");
        }


        // método estático
        public static double CalcularRendimento(double capital, int meses)
        {
            return capital * Math.Pow(1 + TaxaRendimento, meses);
        }


    }
}
