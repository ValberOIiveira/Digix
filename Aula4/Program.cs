using System;

namespace Name
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Digite a cerveja que você está tomando: ");
            string? cerveja = Console.ReadLine();

            if (cerveja == "Original")
            {
                Console.WriteLine("Você está bebendo uma cervea ruim");
            }
            else if (cerveja == "Moema")
            {
                Console.WriteLine("Você está bebendo uma cerveja boa");
            }
            else
            {
                Console.WriteLine("Você está bebendo uma cerveja horrível");
            }


        
        }
    }
}
