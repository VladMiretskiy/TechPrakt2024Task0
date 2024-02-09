using System;

namespace PracticaTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число а:");
            var a = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Введiть число b:");
            var b = float.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма дорiвнює: {a + b}");
        }
    }
}
