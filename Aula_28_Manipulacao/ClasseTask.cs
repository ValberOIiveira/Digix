// namespace Aula_28_Manipulacao
// {
//     public class ClasseTask
//     {
//         static async Task Main(string[] args)
//         {
//             System.Console.WriteLine("Inicio do programa");
//             int resultado = await Soma(10, 20);
//             System.Console.WriteLine("Resultado: " + resultado);
//         }


//         static Task<int> Soma(int a, int b)
//         {
//             return Task.Run(() => {
//                 //Espera 2 segundos antes de retornar
//                 Task.Delay(2000).Wait();
//                 return a + b;
//             });
//         }
//     }
// }