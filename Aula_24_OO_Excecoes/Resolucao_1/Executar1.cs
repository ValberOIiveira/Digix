using System;

namespace Aula_24_OO_Excecoes.Resolucao_1
{
    class Executar1
    {
        static void Main(string[] args)
        {
            // Criando uma reserva com dados fixos
            Reservation reservation = new Reservation(101, DateTime.Parse("2025-01-10"), DateTime.Parse("2025-01-15"));

            // Exibindo a reserva inicial
            Console.WriteLine("Initial Reservation:");
            Console.WriteLine(reservation);

            // Atualizando as datas
            reservation.UpdateDates(DateTime.Parse("2025-01-12"), DateTime.Parse("2025-01-18"));

            // Exibindo a reserva atualizada
            Console.WriteLine("Updated Reservation:");
            Console.WriteLine(reservation);
        }
    }
}
