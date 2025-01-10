namespace Aula_23
{
    public class Instrutor : Coordenador
    {
        public override void Salario(double salario)
        {
            System.Console.WriteLine("Salario base:" + salario * 1.5);
        }


        //Tentando sobrescrever um método sealed da classe Coordenador 
        public override void Trabalhar()
        {
            base.Trabalhar();
        }
    }
}