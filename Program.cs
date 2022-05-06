using System;

namespace Course
{
            /*
            Checklist
                    - Ler um texto até a quebra de linha e armazenar em uma variável
                    - Ler três palavras, uma em cada linha, armazenando cada uma em uma variável
                    - Ler três palavara na mesma linha, separadas por espaço, armazenando cada 
                    uma em uma variável
            */
    class EntradaDeDados
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();// Lê até a quebra de linha

            string x = Console.ReadLine(); // Lê uma palavra por linha
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine(); // String recebe uma frase

            string[] vet = s.Split(' '); // Divide a string onde houverem espaços em branco
            string a = vet[0]; // Recebe a primeira posição do vetor
            string b = vet[1]; // Recebe a segunda posição do vetor
            string c = vet[2]; // Recebe a terceira posição do vetor
            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}

