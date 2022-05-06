namespace Course
{
    class Params
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            int t1 = 3;
            int triple;
            Calculator.Triple(t1, out triple);
            Console.WriteLine(triple);
        }
    }
}