// namespace exfunc4{
//     public class Ex4 {


//         public static void SomaDiagonais(int[,] matriz)
//         {

//             int somaDiagonalPrincipal = 0;
//             int somaDiagonalSecundaria = 0;

//             for (int i = 0; i < matriz.GetLength(0); i++) {
//                 somaDiagonalPrincipal += matriz[i, i];
//                 somaDiagonalSecundaria += matriz[i, matriz.GetLength(0) - 1 - i];
//             }

//             Console.WriteLine("Soma da diagonal principal: " + somaDiagonalPrincipal);
//             Console.WriteLine("Soma da diagonal secundaria: " + somaDiagonalSecundaria);


//         }
//         public static void Main() {
//              //Matriz 4x4
//              int[,] matriz = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
//              SomaDiagonais(matriz);
 
//         }
//     }
// }