namespace Aula_23
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public virtual void Salario(double salario)
        {
            System.Console.WriteLine("Salário Base" + salario);
        }

        public virtual void Trabalhar()
        {
            System.Console.WriteLine("Trabalhando...");
        }
    }
}