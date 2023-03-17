using System;
namespace TrbalhandoComClasses
{
    // criando uma classe Aluno
    class Aluno
    {
        public string Nome;
        public int Idade;
    }
    class Program
    {
        static void Main(string[] arggs)
        {
            // criando uma instancia da classe - obrjeto é o nome que damos 
            var aluno1 = new Aluno();
            aluno1.Nome = "Agnos Vilela";
            aluno1.Idade = 30;

            // lendo os valores
            Console.WriteLine(aluno1.Nome);
            Console.WriteLine(aluno1.Idade);
        }
    }
}

