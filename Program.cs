using System;
using System.Globalization;

namespace Course
{
    class ClasseDateTimes
    {
        static void Main(string[] args)
        {

            //DateTime com data e horário atual
            DateTime d1 = DateTime.Now;
            //Especificando a data
            DateTime d2 = new DateTime(2018, 11, 25);
            //Especificando data e horário
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            //DateTime com data atual, porém horário zerado
            DateTime d4 = DateTime.Today;
            //Horário de Greenwich
            DateTime d5 = DateTime.UtcNow;
            //Convertendo string para DateTime
            DateTime d6 = DateTime.Parse("2000-08-15");
            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d8 = DateTime.Parse("08/15/2000");
            DateTime d9 = DateTime.Parse("08/15/2000 13:05:58");
            //Determinando o formato da data manualmente
            DateTime d10 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine("DateTime com data e horário atual: " + d1);
            Console.WriteLine("Especificando a data: " + d2);
            Console.WriteLine("Especificando data e horário: " + d3);
            Console.WriteLine("DateTime com data atual, porém horário zerado: " + d4);
            Console.WriteLine("DateTime com data e horário atual: " + d1);
            Console.WriteLine("Horário de Greenwich: " + d5);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine("Determinando o formato da data manualmente: " + d10);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Propriedades do DateTime");
            Console.WriteLine("1) Date: " + d3.Date);
            Console.WriteLine("2) Day: " + d3.Day);
            Console.WriteLine("3) Day of the week: " + d3.DayOfWeek);
            Console.WriteLine("4) Day of year: " + d3.DayOfYear);
            Console.WriteLine("5) Hour: " + d3.Hour);
            Console.WriteLine("6) Kind: " + d3.Kind);
            Console.WriteLine("7) Millisecond: " + d3.Millisecond);
            Console.WriteLine("8) Minute: " + d3.Minute);
            Console.WriteLine("9) Month: " + d3.Month);
            Console.WriteLine("10) Second: " + d3.Second);
            Console.WriteLine("11) Ticks: " + d3.Ticks);
            Console.WriteLine("12) Time of day: " + d3.TimeOfDay);
            Console.WriteLine("13) Year: " + d3.Year);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Funções ToString");
            Console.WriteLine("1) To Long Date String: " + d3.ToLongDateString());
            Console.WriteLine("2) To Long Time String: " + d3.ToLongTimeString());
            Console.WriteLine("3) To Short Date String: " + d3.ToShortDateString());
            Console.WriteLine("4) To Short Time String; " + d3.ToShortTimeString());
            Console.WriteLine("5) To String: " + d3.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("6) Add hours: " + d3.AddHours(2));
            Console.WriteLine("7) Add days: " + d3.AddDays(7));
        }
    }
}