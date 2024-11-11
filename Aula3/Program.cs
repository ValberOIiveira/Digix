using System.Data;
using System.Net.NetworkInformation;

namespace AreaTriangulo
{
     public class Program
 {
     public static void Main()
     {
         Console.Write("Digite o primeiro lado do triângulo: ");
         int lado1 = Convert.ToInt32(Console.ReadLine());

         Console.Write("Digite o segundo lado do triângulo: ");
         int lado2 = Convert.ToInt32(Console.ReadLine());
   
         Console.Write("Digite o terceiro lado do triângulo: ");
         int lado3 = Convert.ToInt32(Console.ReadLine());

         if (ETrianguloValido(lado1, lado2, lado3))
         {
             double semiperimetro = (lado1 + lado2 + lado3) / 2.0;
             double area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));

             Console.WriteLine($"Área do triângulo: {area:F2} cm²");
         }
         else
         {
             Console.WriteLine("Os lados fornecidos não podem formar um triângulo válido.");
         }

        //área do círculo 
        int raio = 5;
        const double pi = 3.14159;

        double areaCirculo = pi * Math.Pow(raio, 2);

        Console.WriteLine($"Área do círculo: {areaCirculo:F2} cm²");


        //área do quadrado
        int ladoQuadrado = 10;
        double areaQuadrado = Math.Pow(ladoQuadrado, 2);
        Console.WriteLine($"Área do quadrado: {areaQuadrado:F2} cm²");
     }

     public static bool ETrianguloValido(int a, int b, int c)
     {
         return (a + b > c) && (a + c > b) && (b + c > a);
     }
 }
}