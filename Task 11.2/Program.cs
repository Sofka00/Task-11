using System;

namespace Task_11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int namber = Convert.ToInt32(Console.ReadLine());
            for (int i = namber; i < 1000; i += namber)
            {
                Console.WriteLine(i);
            }
        }
    }
}
