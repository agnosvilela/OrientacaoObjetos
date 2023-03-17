using System;

namespace BlocoTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var nomes = new[] { "Agnos", "Vilela" };
                for (var indice = 0; indice <= nomes.Length; indice++)
                {
                    Console.WriteLine(nomes[indice]);
                }
            }
            catch (Exception excecao)
            {
                Console.WriteLine("Ocorreu um erro" + excecao.StackTrace);
                Console.WriteLine("Ocorreu um erro" + excecao.Message);

            }
            
            finally
            {

            }



        }
    }
}
