using System;

namespace Sample303
{
    class Program
    {
        static void Main(string[] args)
        {
            // キーボードから数値を入力
            Console.WriteLine("1から3の整数を入力");
            int num = int.Parse(Console.ReadLine());
            if (num == 1) // 等しい時==と書く
            {
                Console.WriteLine("one");
            }
            else if (num == 2)
            {
                Console.WriteLine("two");
            }
            else if (num == 3)
            {
                Console.WriteLine("three");
            }
            else
            {
                Console.WriteLine("不適切な数値です");
            }
        }
    }
}
