namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/tmp/File.txt";

            try
            {
                // Ao final do bloco, todos os recursos serão fechados automaticamente
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}