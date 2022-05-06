using System;

namespace Course
{
    class Matrizes
    {
        /*
            Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números
            inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos
            da matriz.
        */
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            Console.WriteLine("Digite os valores da matriz: ");
            for (int i = 0; i < n; i++)
            {
                //Faz a leitura dos valores da linha
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    //Preenche os valores da coluna
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();

            int count = 0;
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         if (mat[i, j] < 0)
            //         {
            //             count++;
            //         }
            //     }
            // }

            foreach(int number in mat)
            {
                if (number < 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Números negativos: " + count);
        }
    }
}