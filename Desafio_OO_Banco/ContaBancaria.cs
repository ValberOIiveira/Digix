using System.Data.SqlTypes;
using System.Xml.Serialization;

namespace Desafio_OO_Banco
{
    public class ContaBancaria
    {
        public long NumeroDaConta { get; set; }
        public string NomeTitular { get; set; }
        public double ValorDepositoInicial { get; set; }

        private double Saldo { get; set; }


        public ContaBancaria(long numeroDaConta, string nomeTitular, double valorDepositoInicial, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            NomeTitular = nomeTitular;
            ValorDepositoInicial = valorDepositoInicial;
            Saldo = valorDepositoInicial;
        }

        public ContaBancaria(long numeroDaConta, string nomeTitular, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }

        public double GetSaldo()
        {
            return Saldo;
        }


        //Criar fun;ão de realizar deposito
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do depósito deve ser maior que zero.");
            }
            Saldo += valor;
        }

        //Criar funcao de realizar saque 
        public void Sacar(double valor)
        {
            const double taxa = 5.0;
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do saque deve ser maior que zero.");
            }
            if ((valor + taxa) > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente para realizar o saque.");
            }

            Saldo -= (valor + taxa);
        }

        public void SetNome(string nome)
        {
            NomeTitular = nome;
        }

    }
}