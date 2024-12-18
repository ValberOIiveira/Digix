namespace Aula_20_OO_UML
{

    public class Porta
    {
        public string Cor { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        public Porta(string cor, double largura, double altura, double peso)
        {
            Cor = cor;
            Largura = largura;
            Altura = altura;
            Peso = peso;
        }

        public virtual void Abrir()
        {
            System.Console.WriteLine("Abrindo...");
        }

        public virtual void Fechar()
        {
            System.Console.WriteLine("Fechando...");
        }
    }
}