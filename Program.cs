using System;
using System.Collections.Generic;

namespace Course
{
    class Lists
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();


            //Adiciona no final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            //Insere um elemento em um índice específico
            list.Insert(2, "Marco");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            //Mostrar tamanho da lista
            Console.WriteLine("List count: " + list.Count);

            //Encontra a primeira ou última ocorrẽncia de um elemento que satisfaça um predicado

            //Primeiro nome que comece com a letra A
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            //Último nome que comece com a letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //Encontra o índice de um elemento que satisfaça um predicado
            //Posição do primeiro nome que comece com a letra A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Position of first 'A': " + pos1);

            //Posição do último nome que comece com a letra A
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Position of first 'A': " + pos2);

            Console.WriteLine("-------------------------------------------");

            //Filtra a lista com base em um predicado
            //Cria uma nova lista contendo apenas strings de 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string name in list2)
            {
                Console.WriteLine(name);
            }

            //Removendo elementos
            list.Remove("Alex");
            Console.WriteLine("-------------------------------------------");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            //Remove todos os elementos que comecem com a letra M
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------------------------------");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            //Remover elemento pela posição
            list.RemoveAt(1);

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------------------------------");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Ana");

            Console.WriteLine("-------------------------------------------");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            //Remove a partir de uma faixa
            //A partir da posição X, remover N elementos
            list.RemoveRange(1, 2);

            Console.WriteLine("-------------------------------------------");
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}