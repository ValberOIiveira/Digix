namespace Aula_20_OO_UML
{
     public class Cozinha
    {
        private bool v1;
        private int v2;


        public PortaCozinha PortaCozinha { get; set; }
        public bool Americana { get; set; }
        public double MetragemQuadrada { get; set; }

        // Constructor updated to initialize PortaCozinha
        public Cozinha(PortaCozinha portaCozinha, bool americana, double metragemQuadrada)
        {
            Americana = americana; 
            MetragemQuadrada = metragemQuadrada;
            PortaCozinha = portaCozinha;
        }

        

        // Updated Entrar method to use PortaCozinha class property directly

        public void Entrar()
        {
            System.Console.WriteLine("Entrou pela porta da cozinha: " + PortaCozinha.Cor);
        }
    }
}