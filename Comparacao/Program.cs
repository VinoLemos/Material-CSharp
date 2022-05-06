using System;
using Comparacao.Entites;

namespace Comparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Suponha uma classe Product com os atributos name e price.
            Suponha que precisamos ordenar uma lista de objetos Product.

            Podemos implementar a comparação de produtos por meio da implementação da interface IComparable<Product>
            Entretanto, desta forma nossa classe não fica fechada para alteração: se o critério de comparação mudar, 
            precisaremos alterar a classe Product.

            Podemos então usar outra sobrecarga do método "Sort" da classe List:
                public void Sort(Comparison<T> comparison) */

        
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // list>.Sort() organiza a lista utilizando o método comparativo da classe
            // Só funciona em classes que implementam o IComparable

            // Organizando a lista utilizando expressão lambda
            list.Sort((p1, p2) => p1.GetName().ToUpper().CompareTo(p2.GetName().ToUpper()));// Tipagem dos objetos é inferida

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}