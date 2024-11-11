

namespace divisao{
    public class Divisao {
        
        public static void Dividir(int num1, int num2) {
            double resultado;
            string message = "Não é possível dividir por zero.";

            if (num2 == 0) {
                 Console.WriteLine(message);
            }
            else {
                resultado = num1 / num2;
                Console.WriteLine($"Resultado da divisão: {resultado:F2}");
            }
        }
    }
}