namespace Aula_19_OO_Interface.Zoo
{
    public class Cachorro : Animal, IAnimalDeEstimacao
    {
        public string? Nome { get; set; }

        public Cachorro(string nome, int pernas) : base( pernas)
        {
            Nome = nome;
            Pernas = pernas;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void Brinca()
        {
            System.Console.WriteLine("Au au!");
        }

        public override void Come()
        {
            base.Come();
        }






    }
}