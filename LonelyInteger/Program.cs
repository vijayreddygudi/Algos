using System;
using static System.Console;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lonelyIteger = 0;
            string lineOfInts = Console.ReadLine();
            string[] numArray = lineOfInts.Split(' ');
            for (int i = 0; i < n; i++)
            {
                lonelyIteger ^= int.Parse(numArray[i]);
            }
            WriteLine("lonely integer is: " + lonelyIteger);
            ReadLine();
        }
    }
}
