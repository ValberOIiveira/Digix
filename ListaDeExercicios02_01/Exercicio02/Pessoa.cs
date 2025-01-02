namespace ListaDeExercicios02_01.Exercicio02
{
    public class Pessoa
    {
        public string nome;
        public string cpf;

        public Pessoa(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
            }
        }

        public string Cpf
        {
            get => cpf;
            set
            {
                cpf = value;
            }
        }


    }


}