namespace Heranca_Animal
{
    public class Javali : Animal
    {
        public bool Selvagem { get; private set; }

        public Javali(bool vivo, bool selvagem) : base(vivo)
        {
            Selvagem = selvagem;
        }

        public int GetVelocidadeMaxima()
        {
            // Retorna uma velocidade máxima fictícia
            return 40; // km/h
        }

        public void SetSelvagem(bool selvagem)
        {
            Selvagem = selvagem;
        }
    }
}