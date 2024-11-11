namespace biblioteca
{
    public class Livro
    {

        public string ?titulo;
        public string ?autor;
        public int isbn;

        public bool disponivel;

        public void Emprestar()
        {
            disponivel = false;
        }

        public void Devolver()
        {
            disponivel = true;
        }

        public override string ToString()
        {
            return $"Título: {titulo}, Autor: {autor}, ISBN: {isbn}, Disponível: {disponivel}";
        }


    }


}