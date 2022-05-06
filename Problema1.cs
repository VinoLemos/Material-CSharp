namespace InterfaceIComparable
{
    class Problema1
    {
        static void Main(string[] args)
        {
            /*
                Faça um programa para ler um arquivo contendo nomes de pessoas
                (um nome por linha), armazenando-os em uma lista. Depois, ordenar
                os dados dessa lista e mostra-los ordenadamente na tela.
                Nota: o caminho do arquivo pode ser informado "hardcode".
            */

            string path = @"/tmp/in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}