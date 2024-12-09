namespace Aula_18_OO
{
    public class Circulo : Forma
    {
       public double Raio;

       public Circulo(string nome, double raio) : base(nome)
       {
        Raio = raio;
       }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Área: {CalcularArea():F2}, Perímetro: {CalcularPerimetro():F2}";
        }
    }
}