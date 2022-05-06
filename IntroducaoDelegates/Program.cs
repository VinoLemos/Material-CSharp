using System;
using System.Collections.Generic;
using ExpressoesLambda.Services;
using ExpressoesLambda.Entities;

namespace ExpressoesLambda
{
    /*
                É uma referência (com type safety) para um ou mais métodos

                Usos comuns:
                    - Comunicação entre objetos de forma flexível e extensível (eventos / callbacks)
                    - Parametrização de operações por métodos (programação funcional)

                Delegates pré-definidos:
                    - Action
                    - Function
                    - Predicate
    */




    // Referência para uma função que recebe 2 números como parâmetro
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate double NumericOperation(double n1);
    // Referência para um método void
    delegate void VoidBinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            // Objeto referenciando a função soma
            BinaryNumericOperation sum = CalculationService.Sum;
            // Sintaxe alternativa
            BinaryNumericOperation max = new BinaryNumericOperation(CalculationService.Max);
            NumericOperation square = CalculationService.Square;

            // Multicast Delegates
            // Um delegate pode receber mais de uma função utilizando os sinais +=
            VoidBinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            double a = 10, b = 12, result = sum(a, b);// Objeto é chamado e mostra o resultado da função
            Console.WriteLine("Sum: " + result);
            result = max.Invoke(a, b);// Sintaxe alternativa
            Console.WriteLine("Max number: " + result);
            result = square(a);
            Console.WriteLine("Square root: " + result);
            // A chamada do objeto retornará a saída das duas funções a ele atribuídas
            op.Invoke(a, b);


            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 89.90));

            // Remover da lista produtos cujo preço seja maior que 100
            // Predicate (System)
            // Representa um método que recebe um objeto do tipo T e retorna um valor booleano


            list.RemoveAll(p => p.Price>=100.0);//Utilizando expressão lambda
            list.RemoveAll(ProductTest);// Utilizando função estática;
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
