// namespace recursao{
//     public class Recursao {

//         // public static int Fatorial(int n)
//         // {
//         //     // Caso base: fatorial de 0 ou 1 é 1
//         //     if (n <= 1)
//         //         return 1;

//         //     // Chamada recursiva: n * fatorial(n-1)
//         //     return n * Fatorial(n - 1);
//         // }


//         //Criando funcao recursvia de fibonacci
//         public static int Fibonacci(int n)
//         {
//             // Caso base: Fibonacci(0) = 0 e Fibonacci(1) = 1
//             if (n <= 1)
//                 return n;

//             // Chamada recursiva: Fibonacci(n-1) + Fibonacci(n-2)
//             return Fibonacci(n - 1) + Fibonacci(n - 2);
//         }

        

//         public static void Main()
//         {
//             // int numero = 5;
//             // int resultado = Fatorial(numero);
//             // Console.WriteLine($"Fatorial de {numero} é {resultado}");  // Saída: 120

//             int numero = 6; // Exemplo: calcular o 6º número de Fibonacci
//             int resultado = Fibonacci(numero);
//             Console.WriteLine($"Fibonacci de {numero} é {resultado}");  // Saída: 8
//         }
//     }
// }