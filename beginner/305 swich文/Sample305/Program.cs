using System;

namespace Sample305
{
    class Program
    {
        static void Main(string[] args)
        {
            // キーボードから数値を入力
            Console.WriteLine("1から3の整数を入力");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break; //breakでcaseから抜ける
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default: //デフォルト、その他
                    Console.WriteLine("不適切な数値です");
                    break;
            }
        }
    }
}
