// namespace exfunc3{
//     public class Ex3 {



//         public static string EhPalidromo(int[] vetor)
//         {
//             bool ehPalindromo = true;

//             for (int i = 0; i < vetor.Length / 2; i++)
//             {
//                 if (vetor[i] != vetor[vetor.Length - 1 - i])
//                 {
//                     ehPalindromo = false;
//                     break;
//                 }
//             }

//             string resultado = ehPalindromo ? "sim" : "não";


//             return $"O vetor {string.Join(", ", vetor)} é um palíndromo? {resultado}";
//         }

//         public static void Main() {

//             int[] vetor = {1, 2, 3, 3, 2, 1};

//             Console.WriteLine(EhPalidromo(vetor));
//         }
//     }
// }