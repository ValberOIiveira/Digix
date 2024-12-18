namespace Aula_20_OO_UML
{
    public class PortaSala : Porta
    {
        public PortaSala(string cor,  double altura, double largura, double peso) : base(cor, altura, largura, peso)
        {
        }

        public override void Abrir()
        {
            System.Console.WriteLine("Abrindo a porta da sala");
        }

        public override void Fechar()
        {
            System.Console.WriteLine("Fechando a porta da sala");
        }
    }
}