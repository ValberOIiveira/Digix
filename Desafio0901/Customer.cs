using System;
using System.Collections.Generic;

namespace Desafio0901
{
    // Definindo o record Customer
    public record Customer(string name, string address, DateTime dob, long cardNumber, long pin)
    {
        // Método para verificar o PIN fornecido pelo usuário
        public bool VerifyPassword(long enteredPin)
        {
            if (enteredPin.GetType() != typeof(long))
            {
                throw new System.FormatException("O pin inserido deve conter 4 números");
            }
            return enteredPin == pin;  // Compara o PIN fornecido com o PIN armazenado
        }

        // Método para realizar o login do usuário e exibir a mensagem de boas-vindas
         public static Customer Login(Customer customer)
        {
            Console.WriteLine("Digite o seu nome:");
            string enteredName = Console.ReadLine();

            Console.WriteLine("Digite o seu PIN:");
            long enteredPin;

            try
            {
                // Tenta fazer o parsing do PIN. Se falhar, lança uma exceção personalizada.
                enteredPin = long.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                // Lança a exceção personalizada com a mensagem desejada
                throw new FormatException("O PIN deve ser um número válido, por favor insira apenas dígitos.");
            }

            // Verifica se o nome e o PIN correspondem ao cliente
            if (customer.name == enteredName && customer.VerifyPassword(enteredPin))
            {
                // Mensagem de boas-vindas
                Console.WriteLine($"Login realizado com sucesso! Bem-vindo, {customer.name}.");
                Console.WriteLine($"Endereço: {customer.address}");
                Console.WriteLine($"Data de Nascimento: {customer.dob.ToShortDateString()}");
                return customer;  // Retorna o cliente autenticado
            }

            // Se o login falhar
            throw new UnauthorizedAccessException("Falha no login. Nome ou PIN inválido.");
        }
    }
}

    

