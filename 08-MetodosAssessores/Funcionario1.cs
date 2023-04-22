namespace RH
{
    public class Funcionario1
    {
        public string Nome;
        private string cpf;


        public string CPF
        {
            get
            {
                return cpf.Replace(".", "").Replace("-", "");
            }

            set
            {
                if (value.Length == 0)
                    return;
                cpf = value;
            }
        }

        public Funcionario1(string _nome, string _cpf)
        {
            Nome = _nome;
            cpf = _cpf;
        }

    }

}