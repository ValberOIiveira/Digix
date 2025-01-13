namespace Aula_25_OO_Struct
{
    public struct ContaBancariaStruct
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }


        public ContaBancariaStruct(string numero, string titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Saque(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new System.Exception("Saldo insuficiente");
            }

            Saldo -= valor;
        }

        public void AlterarSaldo(decimal valor)
        {
            this = new ContaBancariaStruct(this.Numero, this.Titular, valor + Saldo)
        }
    }


    class Exe{
        static void Main(string[] args)
        {
            ContaBancariaStruct contaBancariaStruct = new ContaBancariaStruct("123", "Maria", 1000);
            contaBancariaStruct.AlterarSaldo(500);
        }
    }
}