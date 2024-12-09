namespace ExercicioClasseAbstrata2
{
    public abstract class Produto
    {
        public int Codigo;
        public double Preco;

        public Produto(int codigo, double preco)
        {
            Codigo = codigo;
            Preco = preco;
        }

        public int GetCodigo()
        {
            return Codigo;
        }

        public void SetCodigo(int value)
        {
            Codigo = value;
        }

        public double GetPreco()
        {
            return Preco;
        }

        public void SetPreco(double value)
        {
            Preco = value;
        }

        public abstract double AtualizarPreco();

        public override string ToString()
        {
            return $"Código: {Codigo}, Preço: {Preco}";
        }
    }
}
