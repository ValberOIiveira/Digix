namespace Aula_20_OO_UML
{
    public class PortaCozinha : Porta
    {
        // Constructor calling the base class constructor
        public PortaCozinha(string cor, double largura, double altura, double peso)
            : base(cor, largura, altura, peso)
        {
        }

        public override void Abrir()
        {
            System.Console.WriteLine("Abrindo porta da cozinha");
        }

        public override void Fechar()
        {
            System.Console.WriteLine("Fechando porta da cozinha");
        }
    }

}