namespace Desafio_Biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoDePublicacao { get; set; }
        public int NumeroDeExemplares { get; set; }

         public Livro(string titulo, string autor, int anoDePublicacao, int numeroDeExemplares)
        {
            Titulo = titulo;
            Autor = autor;
            AnoDePublicacao = anoDePublicacao;
            NumeroDeExemplares = numeroDeExemplares;
        }

        public bool Disponivel()
        {
            return NumeroDeExemplares > 0;
        }

        public void Emprestar()
        {
            if (Disponivel())
            {
                NumeroDeExemplares--;
            }
        }

        public void Devolver()
        {
            NumeroDeExemplares++;
        }
    }
}