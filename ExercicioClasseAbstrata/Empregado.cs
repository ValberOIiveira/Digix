namespace ExercicioClasseAbstrata
{
    public abstract class Empregado
    {
        public string Nome;
        public string Sobrenome;
        public string Cpf;

        public Empregado(string nome, string sobrenome, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
        }

        public abstract double Vencimento();

        public override string ToString()
        {
            return $"Nome: {Nome} {Sobrenome}, CPF: {Cpf}, " + Vencimento();
        }


    }
}