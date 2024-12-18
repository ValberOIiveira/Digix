namespace Aula_20_OO_UML
{

    // Classe aluno vai ser fundamental para a Escola
    // Então vai ter relacionamento de Composicao
    public class Aluno
    {
        // Propriedades
        public string Nome { get; set; }

        // Construtor
        public Aluno(string nome)
        {
            Nome = nome;
        }

        //Funcao informar
        public void Informar()
        {
            Console.WriteLine($"Nome: {Nome}");
        }


    }
}