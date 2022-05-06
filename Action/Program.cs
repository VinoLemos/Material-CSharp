using System.Collections.Generic;
using Action.Entities;

namespace Action
{
    class Program
    {
        /* 
                Fazer um programa que, a partir de uma lista de produtos, aumente o preço dos produtos em 10%.
         */

        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.00));

            /*
            Utilizando Delegate
             Action<Product> act = UpdatePrice;
            list.ForEach(act); */

            //list.ForEach(UpdatePrice); Método só aceita uma função void como parâmetro

            // Expressão Lambda
            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }


        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
