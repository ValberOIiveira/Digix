namespace Desafio0901
{
    
     public class ATM
    {
        public string Location { get; set; }
        public string ManagedBy { get; set; }

        // Lista de transações realizadas na máquina
        private List<ATMTransaction> transactions = new List<ATMTransaction>();

        // Construtor para inicializar a localização e o banco responsável
        public ATM(string location, string managedBy)
        {
            Location = location;
            ManagedBy = managedBy;
        }

        // Método para adicionar transações à lista
        public void AddTransaction(ATMTransaction transaction)
        {
            transactions.Add(transaction); // Adiciona a transação à lista
        }

        // Método para mostrar todas as transações realizadas na máquina
        public void ShowTransactions()
        {
            Console.WriteLine($"Transações realizadas na ATM localizada em: {Location}");
            if (transactions.Count == 0)
            {
                Console.WriteLine("Nenhuma transação realizada ainda.");
            }
            else
            {
                foreach (var transaction in transactions)
                {
                    // Chamando o método DisplayTransactionInfo de cada transação
                    transaction.DisplayTransactionInfo();
                }
            }
        }
    }
}