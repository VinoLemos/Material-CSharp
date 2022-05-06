using System.Globalization;
using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos
{
    class Program
    {

        /*
            Fazer um programa para ler os dados de N figuras, e depois mostrar as áreas destas
            figuras na mesma ordem em que foram digitadas.
        */
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data: ");
                Console.Write("Rectangle or Circle? (r/c): ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (op == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(width, height, color));
                }
                else 
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("SHAPE AREAS: ");

            foreach (Shape sh in list)
            {
                Console.WriteLine(sh.Area().ToString("F2"));
            }
        }
    }
}