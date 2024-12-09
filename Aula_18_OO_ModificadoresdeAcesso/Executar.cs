namespace Aula_18_OO_ModificadoresdeAcesso
{
    public class Executar
    {
        public static void Main()
        {
            // Criando um funcionário
            Funcionario funcionario = new Funcionario("Carlos", 2000, "Assistente");

            // Exibindo dados do funcionário
            funcionario.ExibirDados();

            // Tentando acessar a função privada (não permitido)
            // funcionario.ExibirCargo(); // Erro: Método privado não pode ser acessado

            // Criando um gerente
            Gerente gerente = new Gerente("Ana", 5000, "Gerente de TI");

            // Exibindo dados do gerente
            gerente.ExibirDados();

            // O gerente pode acessar o método para aumentar salário
            gerente.AumentarSalarioGerente(10);

            // O gerente pode acessar o método para exibir cargo, mesmo sendo protegido
            gerente.ExibirCargoGerente();

            // Tentando acessar o método privado do funcionário através do gerente
            // gerente.ExibirCargo(); // Erro: Método privado não pode ser acessado     


        }
    }
}