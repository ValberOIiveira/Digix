namespace Aula_19_OO_Interface.Espaco
{
    public interface IForma
    {
        double CalcularArea();
        double CalcularPerimetro();

        void ExibirInformacoes()
        {
            System.Console.WriteLine("Area: " + CalcularArea());
            System.Console.WriteLine("Perimetro: " + CalcularPerimetro());
        }


    }
}