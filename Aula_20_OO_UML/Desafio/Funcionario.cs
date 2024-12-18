namespace Aula_20_OO_UML
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public Endereco EnderecoFuncionario { get; set; }

        public double Salario { get; set; }

         public Funcionario(string nome, DateTime nascimento, string cpf, Endereco enderecoFuncionario, double salario)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
            EnderecoFuncionario = enderecoFuncionario; 
            Salario = salario;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Nascimento: {Nascimento.ToShortDateString()}, CPF: {Cpf}, Endereço: {EnderecoFuncionario}";
        }

        public string GetNome()
        {
            return Nome;
        }

        public DateTime GetNascimento()
        {
            return Nascimento;
        }

        public string GetCpf()
        {
            return Cpf;
        }

        public Endereco GetEndereco()
        {
            return EnderecoFuncionario;
        }


    }
}