namespace Desafio_Biblioteca
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        } 
    }
}