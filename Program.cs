using System.Globalization;
using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Exceptions;

namespace ExcecoesPersonalizadas
{
    class Program
    {

        /*
            Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data
            de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração
            em dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
            novamente a reserva com os dados atualizados. O programa não deve aceitar dados inválidos
            para a reserva, conforme as seguintes regras:
            -Alterações de reserva só podem ocorrer para datas futuras
            -A data de saída deve ser maior que a data de entrada
        */
        static void Main(string[] args)
        {
            try {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date: (dd/mm/yyyy)");
            DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Check-out date: (dd/mm/yyyy)");
            DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);


            Console.WriteLine();
            Console.WriteLine("Enter data to update reservation: ");

            Console.Write("Room number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date: (dd/mm/yyyy)");
            checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Check-out date: (dd/mm/yyyy)");
            checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}