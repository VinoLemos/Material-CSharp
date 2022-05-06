using MetodoFunc.Entities;
using System.Collections;
using System.Linq;

namespace MetodoFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Func (System)
                Representa um método quoe recebe zero ou mais argumentos, e retorna um valor, diferente
                do Action que é um void

                Fazer um programa que, a partir de uma lista de produtos, gere uma nova lista
                contendo os nomes do produto em caixa alta
            */

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.00));

            // Delegate recebe um product, e retorna uma string
            // Referencia ao metodo NameUpper
            //Func<Product, string> func = NameUpper;



            // Recebe um delegate
            //List<string> result = list.Select(func).ToList();

            // Expressão Lambda
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}