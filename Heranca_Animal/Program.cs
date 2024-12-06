namespace Heranca_Animal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cobra c = new Cobra(true, true);
            c.Alimenta("rato");
            c.SetVenenosa(false);
            System.Console.WriteLine($"A cobra está viva: {c.vivo}, é venenosa {c.Venenosa}");

        }
    }
}