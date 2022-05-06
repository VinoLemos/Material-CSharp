using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace Interfaces
{
    class Program
    {
        /*
            Uma locadora brasileira de carros cobra um valor por hora para locações de até
            12 horas. Porém, se a duração da locação ultrapassar 12 horas, a locação será
            cobrada com base em um valor diário. Além do valor da locação, é acrescido no
            preço o valor do imposto conforme regras do país que, no caso do Brasil, é 20%
            para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um programa
            que lê os dados da locação (modelo do carro, instante inicial e final da locação),
            bem como o valor por hora e o valor diário de locação. O programa deve então gerar
            a nota de pagamento (contendo valor da locação, valor do imposto e valor total do
            pagamento) e informar os dados na tela.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup date: (dd/MM/yyyy HH:mm)");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return date: (dd/MM/yyyy HH:mm)");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            Console.WriteLine();
            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}