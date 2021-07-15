using System;

namespace Sample302
{
    class Program
    {
        static void Main(string[] args)
        {
            //キーワードから数値を入力
            Console.Write("数値を入力");
            int a = int.Parse(Console.ReadLine());
            // 入力した値が正の数かを調べる
            if (a > 0)
            {
                Console.WriteLine("aは正の数です");
            }
            else 
            {
                Console.WriteLine("aは正の数ではありません");
            }

        }
    }
}
