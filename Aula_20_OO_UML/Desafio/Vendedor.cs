namespace Aula_20_OO_UML
{
    public class Vendedor : Funcionario
    {
        public EquipeVenda Equipe { get; set; }

        public Vendedor(string nome, DateTime nascimento, string cpf, Endereco enderecoFuncionario, EquipeVenda equipeVenda, double salario)
            : base(nome, nascimento, cpf, enderecoFuncionario, salario) 
        {
            Equipe = equipeVenda; 
        }

        public double GetSalario()
        {
            return Salario + (Salario * 0.10); 
        }
    }
}