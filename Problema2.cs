using InterfaceIComparable.Entities;

namespace InterfaceIComparable
{
    public class Problema2
    {
        static void Principal(string[] args)
        {
            /*
                Faça um programa para ler um arquivo contendo funcionários (nome e salário)
                no formato .csv, armazenando-os em uma lista. Depois, ordenar a lista por
                nome e mostrar o resultado na tela. Nota: o caminho do arquivo pode ser
                informado "hardcode".
            */

            string path = @"/tmp/in.csv";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while(!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }  
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}