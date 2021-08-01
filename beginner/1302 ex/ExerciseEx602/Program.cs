using System;
using System.Collections.Generic;

namespace ExerciseEx602
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();

            while (true)
            {
                Console.Write("1～10の値を入力");
                int a = int.Parse(Console.ReadLine());
                l.Add(a);
                if(a < 1 || a > 10)
                {
                    break; 
                } 
            }
            l.Sort();
            //  l.Reverse(); 逆転もできる
            foreach (int n in l)
            {
                Console.Write("[" + n + "]");
            }
        }
    }
}
