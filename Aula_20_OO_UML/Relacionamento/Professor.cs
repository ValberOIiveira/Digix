namespace Aula_20_OO_UML
{
    //Classe Professor, vai ser agregada com a Escola
    public class Professor
    {
        public string Nome { get; set; }

        public Professor(string nome)
        {
            Nome = nome;
        }

        public void Ensinar()
        {
            Console.WriteLine($"{Nome} está ensinando");
        }
        
    }
}