//Вариант 13 Радзивиловский УТС-21
using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A:");
            double A = double.Parse(Console.ReadLine());
            double A2;//A^2
            double A4;//A^4
            double A8;//A^8
            A2 = Math.Pow(A, 2);
            Console.Write("A в степени 2:\n");
            Console.WriteLine($"A2:{A2:0.00}");
            A4 = Math.Pow(A, 4);
            Console.Write("A в степени 4:\n");
            Console.WriteLine($"A4:{A4:0.00}");
            A8 = A * A * A2 * A4;//А^8 через 3 операции умножения
            Console.Write("A в степени 8:\n");
            Console.WriteLine($"A8:{A8:0.00}");
            A8=Math.Pow(A, 8);//A^8 через Math.Pow
            Console.WriteLine($"A8:{A8:0.00}");
        }
    }
}
