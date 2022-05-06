using System;

namespace Course
{
    class ClasseTimeSpan
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();//TimeSpan zerado
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(0, 1, 30);//Hora, minutos, segundos
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);//Dia, hora, minutos, segundos
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);//Dia, hora, minutos, segundos, milisegundos
            TimeSpan t6 = TimeSpan.FromDays(1.5);//Duração de um dia e meio
            TimeSpan t7 = TimeSpan.FromMinutes(1.5);
            TimeSpan t8 = TimeSpan.FromSeconds(1.5);
            TimeSpan t9 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t10 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Propriedades e operações com TimeSpan");

            TimeSpan tm1 = TimeSpan.MaxValue;
            TimeSpan tm2 = TimeSpan.MinValue;
            TimeSpan tm3 = TimeSpan.Zero;

            Console.WriteLine("Max Value: " + tm1);
            Console.WriteLine("Min Value: " + tm2);
            Console.WriteLine("Zero: " + tm3);

            Console.WriteLine();

            TimeSpan tm4 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(tm4);
            Console.WriteLine("Days: " + tm4.Days);
            Console.WriteLine("Hours: " + tm4.Hours);
            Console.WriteLine("Minutes: " + tm4.Minutes);
            Console.WriteLine("Milliseconds: " + tm4.Milliseconds);
            Console.WriteLine("Seconds: " + tm4.Seconds);
            Console.WriteLine("Ticks: " + tm4.Ticks);
            Console.WriteLine("Total days: " + tm4.TotalDays);
            Console.WriteLine("Total hours: " + tm4.TotalHours);
            Console.WriteLine("Total minutes: " + tm4.TotalMinutes);
            Console.WriteLine("Total seconds: " + tm4.TotalSeconds);
            Console.WriteLine("Total miliseconds: " + tm4.TotalMilliseconds);

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Operações");

            TimeSpan tm5 = new TimeSpan(1, 30, 10);
            TimeSpan tm6 = new TimeSpan(0, 10, 5);

            TimeSpan sum = tm5.Add(tm6);
            TimeSpan dif = tm5.Subtract(tm6);
            TimeSpan multi = tm5.Multiply(2.0);
            TimeSpan div = tm5.Divide(2.0);

            Console.WriteLine("Adding timespans: " + sum);
            Console.WriteLine("Difference: " + dif);
            Console.WriteLine("Multiply: " + multi);
            Console.WriteLine("Divide: " + div);
        }
    }
}