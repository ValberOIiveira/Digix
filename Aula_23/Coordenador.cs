namespace Aula_23
{
    public class Coordenador : Funcionario 
    {
        public override void Salario(double salario)
        {
            System.Console.WriteLine("Salário base:" + salario *1.2);
        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Coordenando...");
        }
    }
}