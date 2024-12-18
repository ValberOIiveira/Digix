namespace Aula_20_OO_UML
{
    public class Quarto
    {
        // Propriedades
        public PortaQuarto PortaQuarto { get; set; }
        public bool Banheiro { get; set; }
        public double MetragemQuadrada { get; set; }

        // Constructor updated to properly initialize PortaQuarto
        public Quarto(bool banheiro, double metragemQuadrada)
        {
            Banheiro = banheiro;
            MetragemQuadrada = metragemQuadrada;
            PortaQuarto = new PortaQuarto("Branca", 0.80, 2.10, 10.0);
        }
    }

}