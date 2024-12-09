namespace ExercicioClasseAbstrata
{
    public class Comissionado : Empregado
    {
        public double totalVenda;

        public double taxaComissao;

        public Comissionado(string nome, string sobrenome,string cpf, double totalVenda, double taxaComissao) : base(nome, sobrenome, cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            this.totalVenda = totalVenda;
            this.taxaComissao = taxaComissao;
            Cpf = cpf;
        }

        public override double Vencimento()
        {
            return totalVenda * taxaComissao;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} {Sobrenome}, CPF: {Cpf}, Total de Vendas: {totalVenda}, Taxa de Comissão: {taxaComissao}, Vencimento: {Vencimento()}";
        }
    }
}