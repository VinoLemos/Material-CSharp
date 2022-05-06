using System.Collections.Generic;

namespace HashSetSortedSet
{
    class Program
    {
        /*
            Representa um conjunto de elementos (similar ao da Álgebra)
                - Não admite repetições
                - Elementos não possuem posição
                - Acesso, inserção e remoção de elementos são rápidos
                - Oferece operações eficientes de conjunto, inserção, união, diferença.

            HashSet
                - Armazenamento em tabela hash
                - Extremamente rápido
                - A ordem dos elementos não é garantida

            SortedSet
                - Armazenamento em árvore
                - Rápido
                - Os elementos são armazenados ordenadamente conforme implementação ICompare<T>
        */
        static void Main(string[] args)
        {
// --------------------------- HashSet
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook")); // retorna true
            Console.WriteLine(set.Contains("Computer")); // retorna false

            // Os elementos do set não possuem índice numerado
            // É necessário utilizar foreach para percorrer todos os elementos do conjunto
            foreach(string s in set)
            {
                Console.WriteLine(s);
            }

// --------------------------- SortedSet            
            SortedSet<int> a = new SortedSet<int>() {0, 2, 4, 5, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() {5, 6, 7, 8, 9, 10};

            // Union 
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);// Insere dentro do conjunto c todos os elementos do conjunto b que ainda não existem
            // sem repetições

            PrintCollection(c);

            // Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);// Elementos que existem nos dois conjuntos
            PrintCollection(d);

            // Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);// Elementos que existem no conjunto a, porém não existem no conjunto b
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}