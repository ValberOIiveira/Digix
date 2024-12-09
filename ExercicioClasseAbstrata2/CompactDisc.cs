namespace ExercicioClasseAbstrata2
{
    public class CompactDisc : Produto
    {
        public string Artista;

        public string Gravadora;

        public CompactDisc(int codigo, double preco, string artista, string gravadora)
            : base(codigo, preco)
        {
            Codigo = codigo;
            Preco = preco;
            Artista = artista;
            Gravadora = gravadora;
        }

        public string GetArtista()
        {
            return Artista;
        }

        public void SetArtista(string value)
        {
            Artista = value;
        }

        public string GetGravadora()
        {
            return Gravadora;
        }

        public void SetGravadora(string value)
        {
            Gravadora = value;
        }


        public override double AtualizarPreco()
        {
            return Preco * 1.1;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Artista: {Artista}, Gravadora: {Gravadora}, Preço: {Preco}, Novo Preço: {AtualizarPreco()}";
        }
    }
}
