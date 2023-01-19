using System;

namespace Task_11._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; Math.Sqrt(i) < a; i++)
                Console.WriteLine(i);
        }
    }
}