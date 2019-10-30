using System;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            var name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}");
            Console.ReadLine();
        }
    }
}
