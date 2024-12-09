namespace ExercicioClasseAbstrata2
{
    public class Livro : Produto
    {
        public string Autor;
        public long ISBN;

        public Livro(int codigo, double preco, string autor, long isbn) : base(codigo, preco)
        {
            Codigo = codigo;
            Preco = preco;
            Autor = autor;
            ISBN = isbn;

        }

        public string GetAutor()
        {
            return Autor;
        }

        // Método Set para Autor
        public void SetAutor(string value)
        {
            Autor = value;
        }

        // Método Get para ISBN
        public long GetISBN()
        {
            return ISBN;
        }

        // Método Set para ISBN
        public void SetISBN(long value)
        {
            ISBN = value;
        }

        public override double AtualizarPreco()
        {
            return Preco * 1.05;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Autor: {Autor}, ISBN: {ISBN}, Preço: {Preco}";
        }


    }
}