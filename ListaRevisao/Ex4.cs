// TODO 4. Escreva um algoritmo que dado uma quantidade indeterminada de números inteiros e positivos, informe o menor e o maior. Utilize o número -1 como finalizador, ou seja, servirá como recurso de saída do laço de repetição.



// using System;

// namespace ex4 {
//     public class Ex4 {
//         public static void Main() {
//             int menor = int.MaxValue; 
//             int maior = int.MinValue; 
//             Console.WriteLine("Digite números inteiros positivos (digite -1 para finalizar):");

//             while (true) { 
//                 int numero = Convert.ToInt32(Console.ReadLine());

//                 if (numero == -1) {
//                     break; 
//                 }

//                 if (numero < 0) {
//                     Console.WriteLine("Por favor, insira apenas números positivos.");
//                     continue; 
//                 }

                
//                 if (numero < menor) {
//                     menor = numero;
//                 }

//                 if (numero > maior) {
//                     maior = numero;
//                 }
//             }

            
//             if (menor != int.MaxValue && maior != int.MinValue) {
//                 Console.WriteLine($"O menor número é: {menor}");
//                 Console.WriteLine($"O maior número é: {maior}");
//             } else {
//                 Console.WriteLine("Nenhum número válido foi digitado.");
//             }
//         }
//     }
// }

