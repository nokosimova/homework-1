/*Чтобы раскомментировать коды, 
по отдельности доваляйте '/' перед 
каждым из "/*", в строках 7, 28, 51 и т д:
*/

//Problem 1
/*
using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            double result = Math.Sqrt(a*b);
            Console.WriteLine($"result = {result}");
        }
    }
}
//*/

//Problem 2
/*
using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Write("A = ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("B = ");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.Write("C = ");
            decimal c = decimal.Parse(Console.ReadLine());
            Console.Write('\n');
            Console.WriteLine($"AB = {Math.Abs(c-a)}");
            Console.WriteLine($"BC = {Math.Abs(c-b)}");
            Console.WriteLine($"AB + BC = {Math.Abs(c-a) + Math.Abs(c-b)}");
        }
    }
}
//*/
//Problem 3
/*
using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("x1, x2: ");
            String[] point1 = Console.ReadLine().Split();
            double x1 = double.Parse(point1[0]);
            double y1 = double.Parse(point1[1]);

            Console.Write("y1, y2: ");
            String[] point2 = Console.ReadLine().Split();
            double x2 = double.Parse(point2[0]);
            double y2 = double.Parse(point2[1]);

            double result =  Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1,2));
            Console.WriteLine($"result = {result}");
        }
    }
}
//*/
 
//Problem 4
/*
using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int res_num = 10 * (num % 10) + num / 10;
            Console.WriteLine($"result number: {res_num}");
        }
    }
}
//*/
 
//Problem 5
/*
using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int result = n / 3600;
            Console.WriteLine($"result: {result}");
        }
    }
}
//*/
 
//Problem 6
/*
using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("K = ");
            int n = int.Parse(Console.ReadLine());
            int week_num = n % 7;
            Console.WriteLine($"result number: {week_num}");
        }
    }
}
//*/