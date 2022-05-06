using System;
using Polimorfismo.Entities;

namespace Course
{
    /*
        Uma empresa possui funcionários próprios e terceirizados. Para cada funcionário, deseja-se
        registrar nome, horas trabalhadas e valor por hora. Funcionários terceirizados possuem
        ainda uma despeza adicional.
        
        O pagamento dos funcionários corresponde ao valor da hora multiplicado pelas horas trabalhadas,
        sendo que os funcionários terceirizados ainda recebem um bônus correspondente a 110% de sua
        despesa adicional.

        Fazer um programa para ler os dados de N funcionários (N fornecido pelo usuário) e armazená-los 
        em uma lista. Depois de ler todos os dados, mostrar nome e pagamento de cada funcionário na
        mesma ordem em que foram digitados.
    */
    class Polimorfismo
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data: ");
                Console.Write("Outsorced? (y/n): ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (op == 'y' || op == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

                Console.WriteLine();

                Console.WriteLine("PAYMENTS: ");
            }

                foreach(Employee emp in list)
                {
                    Console.WriteLine(emp);
                }
        }
    }
}