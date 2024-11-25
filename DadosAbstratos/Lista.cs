// namespace DadosAbstratos
// {
//     public class Program
//     {
//         public class Lista
//         {
//             static int[] vetor = new int[10];

//              static void Inserir(int valor)
//             {
//                 for (int i = 0; i < vetor.Length; i++)
//                 {
//                     // Verifica se a posição está vazia (0 é considerado vazio no início)
//                     if (vetor[i] == 0)
//                     {
//                         vetor[i] = valor;  // Insere o valor na primeira posição vazia
//                         break;  // Sai do loop após inserir o valor
//                     }
//                 }
//             }

//             static void ListarInverso()
//             {
//                 // Loop de trás para frente
//                 for (int i = vetor.Length - 1; i >= 0; i--)
//                 {
//                     if (vetor[i] != 0) // Imprime apenas valores diferentes de 0 (não vazios)
//                     {
//                         System.Console.WriteLine(vetor[i]);
//                     }
//                 }
//             }

//              static void Listar()
//             {
//                 // Loop que percorre o vetor do início até o fim
//                 for (int i = 0; i < vetor.Length; i++)
//                 {
//                     if (vetor[i] != 0) // Imprime apenas valores diferentes de 0 (não vazios)
//                     {
//                         System.Console.WriteLine(vetor[i]);
//                     }
//                 }
//             }

//             public static void Main()
//             {
//                 Inserir(5);
//                 Inserir(3);
//                 Inserir(7);
//                 Inserir(1);
//                 Inserir(2);
//                 Inserir(3);
//                 Inserir(4);
//                 Inserir(5);
//                 Inserir(6);
//                 Inserir(11);
//                 ListarInverso();
//             }
//         }
//     }
// }
