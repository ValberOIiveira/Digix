namespace Aula_18_Encapsulamento
{
    public class Produto
    {
        //Colocar _ antes do atributo para dizer que ele é privado
        // private string _nome;
        //Propriedade autoimplementada
        public string Nome { get; set; }
        private double Preco { get; set; }
        private int Quantidade { get; set; }

        public Produto()
        {

        }

        //Construtor com 2 argumentos
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //Reutilizando construtor dentro de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        //Encapsulamento, Getters e Setters
        // public string GetNome()
        // {
        //     return _nome;
        // }
        // public void SetNome(string nome)
        // {

        //     if (nome != null && nome.Length > 1)
        //     {
        //         _nome = nome;

        //     }

        // }

        //Utilizando as propriedades do Getter e Setter
        // public string Nome{
        //     get{ return _nome; }
        //     set
        //     {
        //         if (value != null && value.Length > 1)
        //         {
        //             _nome = value;
        //         }
        //     }
        // }

        // public double GetPreco()
        // {
        //     return _preco;
        // }

        // public void SetPreco(double preco)
        // {
        //     if (preco > 0)
        //     {
        //         _preco = preco;
        //     }
            
        // }

        // public double Preco{
        //     get{ return _preco; }
        //     set
        //     {
        //         if (value > 0)
        //         {
        //             _preco = value;
        //         }
        //     }
        // }

        // public int GetQuantidade()
        // {
        //     return _quantidade;
        // }

        // public void SetQuantidade(int quantidade)
        // {
        //     if (quantidade >= 0)
        //     {
        //         _quantidade = quantidade;
        //     }
        // }

        // public int Quantidade{
        //     get{ return _quantidade;}
        //     set{
        //         if (value > 0)
        //         {
        //             _quantidade = value;
        //         }
        //     }
        // }

        public override string ToString()
        {
            return $"Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}";
        }

        // Funcao adicionar valor em estoque
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        //Funcao remover valor em estoque
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
    }
}