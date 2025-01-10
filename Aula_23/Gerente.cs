namespace Aula_23
{
    public sealed class Gerente : Funcionario
    {
        public override void Salario(double salario)
        {
            System.Console.WriteLine("Salario base:" + salario * 1.5);

        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Gerenciando...");
        }


    }
}