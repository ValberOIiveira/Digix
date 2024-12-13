namespace Desafio_OO_Banco
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Criando cliente
            Cliente c = new Cliente("Maria Souza");
            Console.WriteLine($"Cliente: {c.GetNome()}");

            // Perguntando se o usuário deseja fazer um depósito inicial
            Console.WriteLine("Você deseja realizar um depósito inicial? (sim/não)");

            // Lê a resposta
            string resposta = Console.ReadLine().ToLower();

            double depositoInicial = 1000.0; // Valor padrão de depósito inicial

            if (resposta == "sim")
            {
                // Se a resposta for "sim", solicitar o valor do depósito
                Console.WriteLine("Informe o valor do depósito inicial:");
                depositoInicial = Convert.ToDouble(Console.ReadLine());
            }

            // Criando conta bancária com o valor de depósito inicial
            ContaBancaria cb = new ContaBancaria(987654, c.GetNome(), depositoInicial);
            Console.WriteLine($"Conta criada para {cb.NomeTitular}, Número: {cb.NumeroDaConta}, Saldo: R${depositoInicial}");

            // Testando Depósito
            Console.WriteLine("\nDepositando R$200...");
            cb.Depositar(200.0);
            Console.WriteLine($"Saldo após depósito: R${cb.GetSaldo()}");

            // Testando Saque bem-sucedido
            Console.WriteLine("\nSacando R$300...");
            cb.Sacar(300.0);
            Console.WriteLine($"Saldo após saque: R${cb.GetSaldo()}");

            // Alterando o nome do titular
            cb.SetNome("Maria Pereira");
            Console.WriteLine($"Nome do titular atualizado: {cb.NomeTitular}");
        }
    }
}