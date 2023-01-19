using System;

namespace Task_11._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int value1 = 1;
            int value2 = 1;
            int fibo = 0;
            
            for (int i = 3; i < number; i++)
            {
                fibo = value1 + value2;

                if (value1 > value2)
                {
                    value2 = fibo;
                }
                else
                {
                    value1 = fibo;
                }

            }

            Console.WriteLine(fibo);
        }
    }
}
