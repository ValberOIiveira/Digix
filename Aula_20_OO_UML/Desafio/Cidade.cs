namespace Aula_20_OO_UML
{
    public class Cidade
    {
        public string Nome { get; set; }
        public Estado Estado { get; set; }

        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            Estado = estado;
        } 
    }
}