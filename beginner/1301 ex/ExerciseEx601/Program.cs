using System;
using System.Collections.Generic;

namespace ExerciseEx601
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = new List<int>();
            int a = 0;
            int max = 1;
            int min = 10;
           
            while(true)
            {
                a = int.Parse(Console.ReadLine());
                n.Add(a);
                if (a < 1 || a > 10)
                {
                    break;
                }
            } 

            foreach(int b in n)
            {
                if (b < min)
                {
                    min = b;
                }
                if (b > max)
                {
                    max = b;
                }
                Console.Write("[" + b + "]");
            }
            Console.WriteLine();
            Console.WriteLine("最大値：{0}", max);
            Console.WriteLine("最小値：{0}", min);
        }
    }
}
