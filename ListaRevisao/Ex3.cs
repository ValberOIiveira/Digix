// /*Reescreva o programa que identifica o DDD dos estados, utilizando a estrutura Caso, de acordo com os seguintes critérios de DDDs e seus respectivos Estados brasileiros.
// • Paraná: 41, 42, 43, 44, 45 e 46
// • Rio Grande do Sul: 51, 53, 54 e 55 • Brasília: 61
// •Goiás:62 e 64
// • Mato Grosso: 65 e 66
// • Mato Grosso do Sul: 67

// */

// namespace ex3
// {
//     public class Ex3
//     {
//         public static void Main()
//         {


//             Console.Write("Digite o DDD: ");
//             int DDD = Convert.ToInt32(Console.ReadLine());

//             switch (DDD)
//             {
//                 case 41:
//                 case 42:
//                 case 43:
//                 case 44:
//                 case 45:
//                 case 46:
//                     Console.WriteLine("Paraná");
//                     break;
//                 case 51:
//                 case 53:
//                 case 54:
//                 case 55:
//                     Console.WriteLine("Rio Grande do Sul");
//                     break;
//                 case 61:
//                     Console.WriteLine("Brasília");
//                     break;
//                 case 62:
//                 case 64:
//                     Console.WriteLine("Goiás");
//                     break;
//                 case 65:
//                 case 66:
//                     Console.WriteLine("Mato Grosso");
//                     break;
//                 case 67:
//                     Console.WriteLine("Mato Grosso do Sul");
//                     break;
//                 default:
//                     Console.WriteLine("DDD inválido");
//                     break;

//             }
//         }

//     }
// }