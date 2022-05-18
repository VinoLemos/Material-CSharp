using PraticoLinq.Entities;

namespace PraticoLinq
{
    class Program
    {
        /* Fazer um programa para ler os dados (nome, email e salário) de funcionários
a partir de um arquivo em formato .csv.

Em seguida, mostrar em ordem alfabética, o email dos funcionários cujo salário 
seja superior a um ado valor fornecido pelo usuário.

Mostrar também a soma dos salários dos funcionários cujo nome começa com a
letra 'M'. */
        static void Main(string[] args)
        {
            System.Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            System.Console.Write("Enter salary: ");
            double sal = double.Parse(Console.ReadLine());

            List<Employee> emps = new List<Employee>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2]);
                    emps.Add(new Employee(name, email, salary));
                }
            }
            Console.WriteLine("Email of people whose salary is more than R$" + sal.ToString("F2") + ": ");
            var emails = emps.Where(obj => obj.Salary > sal).OrderBy(obj => obj.Email).Select(obj => obj.Email);
            foreach (string e in emails)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Sum of salary of people whose name starts with an 'M': ");
            var sum = emps.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);
            Console.WriteLine("R$" + sum.ToString("F2"));
        }
    }
}