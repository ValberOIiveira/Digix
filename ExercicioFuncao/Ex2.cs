// using System.Security.Cryptography.X509Certificates;

// namespace exfunc2
// {
//     public class Ex2
//     {
//         public static void SomaLinhasMatriz(int[,] matriz)
//         {
//             int[] somaLinhas = new int[4];

//             for (int i = 0; i < 4; i++)
//             {
//                 somaLinhas[i] = 0;
//                 for (int j = 0; j < 4; j++)
//                 {
//                     somaLinhas[i] += matriz[i, j];
//                 }
//             }

//             Console.WriteLine("Soma dos elementos de cada linha:");
//             for (int i = 0; i < 4; i++)
//             {
//                 Console.WriteLine($"Linha {i + 1}: {somaLinhas[i]}");
//             }
//         }

//         public delegate void DelegateSomaLinhas(int[,] matriz);
//         public static void Main()
//         {
//             DelegateSomaLinhas d = new DelegateSomaLinhas(SomaLinhasMatriz);

//             int[,] matriz =
//             {
//                 { 1, 2, 3, 4 },
//                 { 5, 6, 7, 8 },
//                 { 9, 10, 11, 12 },
//                 { 13, 14, 15, 16 },
//             };

//             SomaLinhasMatriz(matriz);
//         }
//     }
// }
