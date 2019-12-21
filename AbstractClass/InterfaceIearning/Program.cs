using System;
using System.Collections;

namespace InterfaceIearning
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 1, 2, 3, 4, 5, 6 };
            ArrayList array = new ArrayList { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(Sum(num1));
            Console.WriteLine(Avg(array));
        }

        static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += (int)item;
            }
            return sum;
        }

        static double Avg(IEnumerable nums)
        {
            int sum = 0; double count = 0;
            foreach (var item in nums)
            {
                sum += (int)item; count++;
            }
            return sum / count;
        }
    }
}

