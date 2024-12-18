namespace Aula_20_OO_UML
{
    public class Estado
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Estado(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
    }
}