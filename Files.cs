using System.IO;

namespace Arquivos
{
    class Files
    {
        static void Main(string[] args)
        {
            // Caminho do arquivo a ser lido
            string sourcePath = @"/tmp/File.txt";
            string targetPath = @"/tmp/File2.txt";

            // FileStream e StreamReader

            //FileStream fs = null;
            StreamReader sr = null;
            // Vetor recebe todas as linhas do arquivo de texto
            string[] lines = File.ReadAllLines(sourcePath);

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                /*
                // Copia o conteúdo do arquivo para um novo arquivo
                if (targetPath == null)
                {
                    fileInfo.CopyTo(targetPath);
                }
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }
                */

                Console.WriteLine();

                // Abre o arquivo
                // fs = new FileStream(sourcePath, FileMode.Open);
                // Recebe o arquivo
                // A função OpenText implicitamente instancia o FileStream
                sr = File.OpenText(sourcePath);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }


                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string s in lines)
                    {
                        sw.WriteLine(s.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}