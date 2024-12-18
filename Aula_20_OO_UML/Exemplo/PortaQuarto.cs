namespace Aula_20_OO_UML
{
    public class PortaQuarto : Porta
    {
        // Constructor calling the base class constructor
        public PortaQuarto(string cor, double largura, double altura, double peso)
            : base(cor, largura, altura, peso)
        {
        }

        public override void Abrir()
        {
            System.Console.WriteLine("Porta do quarto aberta");
        }

        public override void Fechar()
        {
            System.Console.WriteLine("Porta do quarto fechada");
        }
    }
}