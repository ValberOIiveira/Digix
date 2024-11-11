using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores aritméticos

            int a = 2; int b = 3;

            Console.WriteLine($"Soma: {a + b}");
            Console.WriteLine($"Subtração: {a - b}");
            Console.WriteLine($"Multiplicação: {a * b}");
            Console.WriteLine($"Divisão: {Math.Round((double)a / b, 2)}");
            Console.WriteLine($"Resto da divisão: {a % b}");
            Console.WriteLine($"Potência: {Math.Pow(a, b)}");
            Console.WriteLine($"Raiz quadrada: {Math.Sqrt(a):F2}");
            Console.WriteLine($"Logaritmo natural: {Math.Log(a)}");

            //Calculadora simples usando switch case

            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um operador (+, -, *, /): ");
            char op = Console.ReadLine()[0];
            Console.Write("Digite um número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            double resultado;
            switch (op)
            {
                case '+':
                    resultado = num + num2;
                    break;
                case '-':
                    resultado = num - num2;
                    break;
                case '*':
                    resultado = num * num2;
                    break;
                case '/':
                    resultado = num / num2;
                    break;
                default:
                    Console.WriteLine("Operador inválido!");
                    return;
            }
            Console.WriteLine($"Resultado: {resultado}");

            

            
        }
    }
}

