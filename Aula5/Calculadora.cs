using System.Reflection.PortableExecutable;

namespace calculadora
{
    public class Calculadora
    {
        public int num1;
        public int num2;

        public double resultado;

        public void Soma(int num1, int num2)
        {
            resultado = num1 + num2;
            Console.WriteLine($"Resultado da soma: {resultado}");
        }

        public void Subtracao(int num1, int num2)
        {
            resultado = num1 - num2;
            Console.WriteLine($"Resultado da subtracao: {resultado}");
        }

        public void Multiplicacao(int num1, int num2)
        {
            resultado = num1 * num2;
            Console.WriteLine($"Resultado da multiplicacao: {resultado}");
        }

        public void Divisao(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Divisao por zero não é permitida.");
            }
            else
            {
                resultado = (double)num1 / num2;
                Console.WriteLine($"Resultado da divisao: {resultado:F2}");
            }
        }
    }
}
