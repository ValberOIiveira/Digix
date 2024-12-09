namespace ExercicioClasseAbstrata
{
    public class Assalariado : Empregado
    {
        public double Salario;

        public Assalariado(string nome, string sobrenome, string cpf, double salario) : base(nome, sobrenome, cpf)
        {
            Nome = nome;
            Salario = salario;
            Sobrenome = sobrenome;
            Cpf = cpf;

        }

        public override double Vencimento()
        {
            return Salario;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} {Sobrenome}, CPF: {Cpf}, Salário: {Salario}";
        }
    }
}