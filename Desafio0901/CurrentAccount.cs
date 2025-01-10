namespace Desafio0901
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(long number, double balance) : base(number, balance)
        {
            Number = number;
            Balance = balance;
        }


        public override bool Withdraw(double amount)
        {
            // Chama o método Withdraw da classe base e retorna o resultado
            return base.Withdraw(amount);
        }

        public override void Deposit(double amount)
        {
            // Chama o método Deposit da classe base e retorna o resultado
            base.Deposit(amount);
            
        }

    }
}