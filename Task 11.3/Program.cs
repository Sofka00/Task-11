using System;

namespace Task_11._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int x;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    x = +i;
                    Console.WriteLine(x);
                }
            }
        }
    }
}
