namespace Aula_20_OO_UML
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, DateTime nascimento, string cpf, Endereco enderecoFuncionario,double salario)
            : base(nome, nascimento, cpf, enderecoFuncionario, salario) 
        {
        }

        public double GetSalario()
        {
            return Salario * 1.5;
        }
    }
}