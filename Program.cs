using System.IO;
using System.Collections.Generic;

namespace Diretorios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listar as subpastas dentro de uma pasta
            string path = @"/home/vino/Pictures/";

            try
            {
                // A partir da pasta path, buscara como padrão de busca qualquer tipo de arquivo, buscando
                // também as subpastas do diretório
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                // Listando arquivos
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach(string f in files)
                {
                    Console.WriteLine(f);
                }

                // Criando uma nova pasta
                if (!Directory.Exists(path+@"newfolder"))
                {
                Directory.CreateDirectory(path + @"newfolder");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}