namespace ExercicioClasseAbstrata
{
    public class Horista : Empregado
    {
        public double precoHora;
        public double horasTrabalhadas;


        public Horista(string nome, string sobrenome, string cpf, double precoHora, double horasTrabalhadas) : base(nome, sobrenome, cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            this.precoHora = precoHora;
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public override double Vencimento()
        {
            return precoHora * horasTrabalhadas;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} {Sobrenome}, CPF: {Cpf}, Vencimento: {Vencimento()}";
        }
    }
}