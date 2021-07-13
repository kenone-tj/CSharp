using System;

namespace Sample405
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            num = 1;
            // whilrループで実行
            Console.WriteLine("whileで実行");
            i = 1;
            while (i < num) // iはnumと同じため実行しない
            {
                Console.Write("*");
                i++;
            }
            Console.WriteLine();
            // do~whilrループで実行
            Console.WriteLine("do~whileで実行");
            i = 1;
            do // 実行してからdo~whileを抜ける
            {
                Console.Write("*");
                i++;
            } while (i < num);
        }
    }
}
