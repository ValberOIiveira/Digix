namespace Aula_24_OO_Excecoes
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Solicita o primeiro número ao usuário
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                // Solicita o segundo número ao usuário
                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                // Solicita a operação
                Console.Write("Escolha uma operação (+, -, *, /): ");
                char operacao = Console.ReadLine()[0];

                double resultado;

                // Realiza a operação escolhida
                switch (operacao)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("Não é possível dividir por zero.");
                        }
                        resultado = num1 / num2;
                        break;
                    default:
                        throw new InvalidOperationException("Operação inválida.");
                }

                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operação concluída.");
            }
        }
    }
}