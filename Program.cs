using System;
using System.Globalization;

namespace Course
{
    class ClassesProdutos
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                vect[i] = new Produto(nome, preco);              
            }
            
            double sum = 0.0;
            for ( int i=  0; i < n; i++)
            {
                sum += vect[i].Preco;
            }

            double avg = sum / n;

            Console.WriteLine("Preço médio: R$" + avg.ToString("F2"));
        }
    }
}
