using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Extension Methods são métodos que estendem a funcionalidade de um tipo, sem
            precisar alterar o código fonte deste tipo, nem herdar deste tipo.

            Como fazer um extension method?
                - Criar uma classe estática
                - Na classe, criar um método estático
                - O primeiro parâmetro do método deverá ter o prefixo this, seguido da 
                declaração de um parâmetro do tipo que se edseja estender. Esta será 
                uma referência para o próprio objeto. 
                
            Vamos criar um extension method chamado "ElapsedTime()" no struct DateTime para
            apresentar um objeto DateTime na forma de tempo decorrido, podendo ser em horas
            (se menor que 24h) ou em dias caso contrário. Por exemplo: 
            
                DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
                Console.WriteLine(dt.ElapsedTime());
                
                "4.5 hours"
                "3.2 days" */

            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine();

            string s1= "Good morning dear students";
            Console.WriteLine(s1.Cut(10));
        }
    }
}