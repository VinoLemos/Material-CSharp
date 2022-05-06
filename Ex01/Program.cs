using System;
using System.Globalization;

namespace Course
{
    class Ex01
    {
        /*
            Checklist:
                        -   Ler um número inteiro
                        -   Ler um caractere
                        -   Ler um número double
                        -   Ler um nome (única palavra), sexo (caractere F ou M), idade (inteiro)
                            e altura (double) na mesma linha, armazenando-os em quatro variáveis
                            com os devidos tipos
        */
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());// Recebe uma string e converte para int
            char ch = char.Parse(Console.ReadLine());// Recebe uma string e converte para char
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// Recebe uma string e converte para double
            
            string dados = Console.ReadLine();
            string[] vet = dados.Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);


            Console.WriteLine("Você digitou: ");

            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);

            Console.WriteLine("Dados: ");
            Console.WriteLine("{0}, sexo {1}, {2} anos de idade, {3:F2} m de altura", nome, sexo, idade, altura);
        }
    }
}
