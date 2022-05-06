using System;
using System.Collections.Generic;

namespace DictionaryESortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /* É uma coleção de pares chave/valor
                - Não admite repetições do objeto chave
                - Os elementos são indexados pelo objeto chave (Não possuem posição)
                - Acesso, inserção e remoção de elementos são rápidos */

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "997712234";
            cookies["phone"] = "837373888";

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else 
            {
                Console.WriteLine("There is no email!");
            }

            Console.WriteLine("Size: " + cookies.Count());

            Console.WriteLine("All cookies: ");
            //foreach(KeyValuePair<string, string> item in cookies)
            foreach(var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}