using System.Data;

namespace Aula_18_OO
{
    public class Executar
    {
        static void Main(string[] args){
            Circulo c = new Circulo("Circulo", 5);
            c.CalcularArea();
            c.CalcularPerimetro();
            System.Console.WriteLine(c.ToString());

            Retangulo r = new Retangulo("Retangulo", 5, 10);
            r.CalcularArea();
            r.CalcularPerimetro();
            c.ToString();
            System.Console.WriteLine(r.ToString());
        }
    }
}