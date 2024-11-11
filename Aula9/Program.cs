namespace aula09
{
    public class Program
    {
        static int Somar(int x, int y)
        {
            return x + y;
        }

        static double Somar(double x, double y)
        {
            return x + y;
        }

        public static void Main()
        {
            Console.WriteLine(Somar(1,3));
            Console.WriteLine(Somar(1.5, 2.5));
        }
    }
}
