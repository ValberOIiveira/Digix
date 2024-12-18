using System;

namespace Aula_20_OO_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Herança");
            // PortaCozinha portaCozinha = new PortaCozinha("Branca", 1.5f, 2.5f, 10);
            // portaCozinha.Abrir();
            // portaCozinha.Fechar();
            // Console.WriteLine($"portaCozinhaCozinha: Cor: {portaCozinha.Cor}, Largura: {portaCozinha.Largura}, Altura: {portaCozinha.Altura}, Peso: {portaCozinha.Peso}");

            // Console.WriteLine("Agregação");
            // Cozinha cozinha = new Cozinha(true, 20);
            // cozinha.Entrar(portaCozinha);

            // Console.WriteLine("Composição");
            // PortaQuarto portaQuarto = new PortaQuarto("Marrom", 1.5f, 2.5f, 10);
            // Quarto quarto = new Quarto(true, 20);
            // Console.WriteLine($"quarto: {quarto.PortaQuarto.Cor}");

            // Console.WriteLine("Associação simples");
            // PortaSala portaSala = new PortaSala("Azul", 1.5f, 2.5f, 10);
            // Sala sala = new Sala(portaSala, portaQuarto, 20);
            // sala.AbrirPortaAuxiliar();


           
            Estado estado = new Estado("São Paulo", "SP");
            Console.WriteLine($"Estado: {estado.Nome} ({estado.Sigla})");

            
            Cidade cidade = new Cidade("São Paulo", estado);
            Console.WriteLine($"Cidade: {cidade.Nome} - Estado: {cidade.Estado.Nome}");

            
            Endereco endereco = new Endereco("Av. Paulista", 1000, "Bela Vista", "01310-100", cidade);
            Console.WriteLine($"Endereço: {endereco.Rua}, {endereco.Numero}, {endereco.Bairro}, {endereco.Cep} - {endereco.Cidade.Nome}/{endereco.Cidade.Estado.Sigla}");

            Funcionario funcionario = new Funcionario("João Silva", new DateTime(1990, 5, 15), "123.456.789-00", endereco, 3000);
            Console.WriteLine($"\nFuncionario:\nNome: {funcionario.GetNome()}\nNascimento: {funcionario.GetNascimento().ToShortDateString()}\nCPF: {funcionario.GetCpf()}\nEndereço: {funcionario.GetEndereco().Rua}, {funcionario.GetEndereco().Numero}, {funcionario.GetEndereco().Bairro}, {funcionario.GetEndereco().Cep} - {funcionario.GetEndereco().Cidade.Nome}/{funcionario.GetEndereco().Cidade.Estado.Sigla}\nSalário: {funcionario.Salario}");

          
            Gerente gerente = new Gerente("Maria Oliveira", new DateTime(1985, 3, 20), "987.654.321-00", endereco, 5000);
            Console.WriteLine($"\nGerente:\nNome: {gerente.GetNome()}\nNascimento: {gerente.GetNascimento().ToShortDateString()}\nCPF: {gerente.GetCpf()}\nEndereço: {gerente.GetEndereco().Rua}, {gerente.GetEndereco().Numero}, {gerente.GetEndereco().Bairro}, {gerente.GetEndereco().Cep} - {gerente.GetEndereco().Cidade.Nome}/{gerente.GetEndereco().Cidade.Estado.Sigla}\nSalário: {gerente.GetSalario()}");

           
            EquipeVenda equipe = new EquipeVenda("Equipe A");

            Vendedor vendedor = new Vendedor("Carlos Pereira", new DateTime(1992, 8, 5), "321.654.987-00", endereco, equipe, 2000);
            Console.WriteLine($"\nVendedor:\nNome: {vendedor.GetNome()}\nNascimento: {vendedor.GetNascimento().ToShortDateString()}\nCPF: {vendedor.GetCpf()}\nEndereço: {vendedor.GetEndereco().Rua}, {vendedor.GetEndereco().Numero}, {vendedor.GetEndereco().Bairro}, {vendedor.GetEndereco().Cep} - {vendedor.GetEndereco().Cidade.Nome}/{vendedor.GetEndereco().Cidade.Estado.Sigla}\nSalário: {vendedor.GetSalario()}\nEquipe de Vendas: {vendedor.Equipe.Nome}");
        }
    }
}

