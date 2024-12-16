namespace Aula_19_OO_Interface.Zoo
{
    public class Peixe : Animal, IAnimalDeEstimacao
    {
        public string Nome { get; set; }

        public Peixe(string nome, int pernas) : base(pernas)
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
            System.Console.WriteLine($"{Nome} está brincando!");
        }

        public override void Come()
        {
            base.Come();
        }



    }
}