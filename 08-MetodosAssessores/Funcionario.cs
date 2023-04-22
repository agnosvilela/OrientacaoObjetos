namespace RH
{
    public class Funcionario
    {
        public string name;
        private string CPF;

        public Funcionario(string nome, string cpf)
        {
            nome = nome;
            CPF = cpf;
        }


        // usamos o conceito de get para retornar informaçoes
        public string GetCPF()
        {
            return CPF;
        }
        // metodo para escrever/ modificar a informação 
        public void SetCPF(string cpf)
        {
            if (cpf.Length == 0)
                return;
            CPF = cpf;
        }
    }

}