namespace Aula_18_OO_ModificadoresdeAcesso
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, double salario, string cargo) : base(nome, salario, cargo) { }

        // Método para aumentar o salário, acessível apenas para o gerente
        public void AumentarSalarioGerente(double porcentagem)
        {
            // Acessa o método protegido da classe Funcionario
            AumentarSalario(porcentagem);
            System.Console.WriteLine($"Novo Salário do {Nome}: {Salario}");
        }

        // Método público para exibir o cargo (mesmo que seja protegido na classe base)
        public void ExibirCargoGerente()
        {
            // Acessa o atributo protegido da classe base
            System.Console.WriteLine($"Cargo do Gerente: {Cargo}");
        }
    }
}