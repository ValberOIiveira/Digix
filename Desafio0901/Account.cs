namespace Desafio0901
{


    public abstract class Account
    {
        public long Number { get; set; }
        public double Balance { get; set; }
        
        public List<ATMTransaction> Transactions { get; private set; } = new List<ATMTransaction>();


        public Account(long number, double balance)
        {
            Number = number;
            Balance = balance;
        }

        // Método para realizar o saque
        public virtual bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        // Método para realizar o depósito
        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }

        // Método para realizar uma transferência entre duas contas
        public void Transfer(Account destinationAccount, double amount)
        {
            if (Withdraw(amount))
            {
                destinationAccount.Deposit(amount);
                var transaction = new ATMTransaction(
                    new Random().Next(1000, 9999), DateTime.Now, TransactionType.Withdraw, amount, Balance);
                Transactions.Add(transaction);

                // Criando transação para a conta de destino
                var destinationTransaction = new ATMTransaction(
                    new Random().Next(1000, 9999), DateTime.Now, TransactionType.Deposit, amount, destinationAccount.Balance);
                destinationAccount.Transactions.Add(destinationTransaction);

                Console.WriteLine($"Transferência de {amount} realizada com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar a transferência.");
            }
        }

        // Exibe as transações da conta
        public void ShowTransactions()
        {
            foreach (var transaction in Transactions)
            {
                transaction.DisplayTransactionInfo();
            }
        }
    }

}