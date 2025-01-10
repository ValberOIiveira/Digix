namespace Desafio0901
{
    public class Bank
    {
        public long Code { get; set; }
        public string Adress { get; set; }

        private List<Customer> customers = new List<Customer>();
        private List<Account> accounts = new List<Account>();


        public Bank(long code, string adress)
        {
            this.Code = code;
            this.Adress = adress;
        }

        public void ManageCustomer(Customer customer)
        {
            customers.Add(customer);
            System.Console.WriteLine($"Cliente {customer.name} adicionado com suceso");
        }

        public void ManageAccount(Account account)
        {
            accounts.Add(account);
            System.Console.WriteLine($"Conta {account.GetType().Name} adicionada com sucesso");
        }

        public void MaintainAccount(Account account)
        {
            if (account.Balance < 0)
            {
                Console.WriteLine("Conta com saldo negativo, por favor verifique.");
            }
            else
            {
                Console.WriteLine($"Conta {account.GetType().Name} mantida. Saldo atual: {account.Balance}");
            }
        }
    }
}