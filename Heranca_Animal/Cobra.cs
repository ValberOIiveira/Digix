namespace Heranca_Animal
{
    public class Cobra : Animal
    {
        public bool Venenosa { get; private set; }

        public Cobra(bool vivo, bool venenosa) : base(vivo)
        {
            Venenosa = venenosa;
        }

        public void Alimenta(string alimento)
        {
            Console.WriteLine($"A cobra foi alimentada com {alimento}.");
        }

        public void SetVenenosa(bool venenosa)
        {
            Venenosa = venenosa;
        }
    }
}