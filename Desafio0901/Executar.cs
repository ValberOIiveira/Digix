namespace Desafio0901
{
    public class Executar
    {
        public static void Main()
        {
            // Criando um banco
            Bank bank = new Bank(123, "Rua Principal, 100");

            // Criando clientes
            Customer customer1 = new Customer("João Silva", "Rua X, 123", new DateTime(1990, 5, 10), 1234567890, 1234);
            Customer customer2 = new Customer("Maria Oliveira", "Rua Y, 456", new DateTime(1985, 8, 20), 9876543210, 5678);

            // Gerenciando clientes no banco
            bank.ManageCustomer(customer1);
            bank.ManageCustomer(customer2);

            // Criando contas
            Account savingAccount = new SavingAccount(1, 1000.0);
            Account currentAccount = new CurrentAccount(2, 500.0);

            // Gerenciando contas no banco
            bank.ManageAccount(savingAccount);
            bank.ManageAccount(currentAccount);

            // Realizando login de cliente
            try
            {
                Console.WriteLine("Tentando login para João Silva...");
                Customer.Login(customer1);  // Alterar conforme o nome e PIN do cliente

                // Realizando transações entre contas
                Console.WriteLine("\nRealizando transferência de R$ 200 da Conta Poupança para a Conta Corrente...");
                savingAccount.Transfer(currentAccount, 200.0);
                
                // Exibindo as transações realizadas
                Console.WriteLine("\nTransações da Conta Poupança:");
                savingAccount.ShowTransactions();

                Console.WriteLine("\nTransações da Conta Corrente:");
                currentAccount.ShowTransactions();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            // Criando uma ATM e mostrando transações
            ATM atm = new ATM("Agência Centro", "Banco XYZ");
            atm.AddTransaction(new ATMTransaction(1, DateTime.Now, TransactionType.Deposit, 1000.0, 1000.0));
            atm.AddTransaction(new ATMTransaction(2, DateTime.Now, TransactionType.Withdraw, 500.0, 500.0));

            // Exibindo transações da ATM
            atm.ShowTransactions();
        }
    }
}
