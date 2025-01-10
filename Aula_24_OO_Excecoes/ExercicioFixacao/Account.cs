namespace Aula_24_OO_Excecoes.ExercicioFixacao
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double withDrawLimit { get; set; }


        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            this.withDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("O valor do depósito deve ser maior que zero.");
            }
            Balance += amount;
        }

        public void withDraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("O valor do saque deve ser maior que zero.");
            }

            if (amount > withDrawLimit)
            {
                throw new InvalidOperationException("O valor excede o limite de saque.");
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }

            Balance -= amount;
        }
    }
}