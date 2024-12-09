namespace Aula_18_OO
{
    public class Retangulo : Forma
    {
        public double Largura;
        public double Altura;

        public Retangulo(string nome, double largura, double altura) : base(nome)
        {
            Largura = largura;
            Altura = altura;
        }    

        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Área: {CalcularArea()}, Perímetro: {CalcularPerimetro()}";
        }
    }
}