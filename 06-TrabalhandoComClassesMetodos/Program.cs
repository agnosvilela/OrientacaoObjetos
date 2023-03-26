
using Cadastro;
namespace TrabalhandoComClassesMetodos
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cliente1 = new Clientes();
            cliente1.Nome = "Agnos Vilela";
            cliente1.Profissao = "Professor";
            cliente1.CPF = "000.002.003.00";
            cliente1.Email = "agnos.nl@gmail.com";
            cliente1.DataNascimento = new DateTime(2023, 04, 22);

            Console.WriteLine(cliente1.Nome);
        }
    }

}
