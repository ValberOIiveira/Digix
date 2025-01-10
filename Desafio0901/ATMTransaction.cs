namespace Desafio0901
{
    public class ATMTransaction
    {
       public long transactionId { get; set; } 

       public DateTime date { get; set; }
       public Enum TransactionType { get; set; }
       public double Amount { get; set; }

       public double postBalance { get; set; }


       public ATMTransaction(long transactionId, DateTime date, Enum transactionType, double amount, double postBalance)
       {
         this.transactionId = transactionId;
         this.date = date;
         this.TransactionType = transactionType;
         this.Amount = amount;
         this.postBalance = postBalance;  // Saldo após a transação
       }

       public void DisplayTransactionInfo()
       {
         Console.WriteLine($"Data: {date.ToShortDateString()}, Tipo: {TransactionType}, Valor: {Amount}, Saldo Após: {postBalance}");
       }
    }
}