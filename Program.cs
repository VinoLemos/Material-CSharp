namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divison by 0 not allowed!");
            }
            catch (FormatException p)
            {
                Console.WriteLine("Error! " + p.Message);
            }
            finally
            {
                
            }
        }
    }
}