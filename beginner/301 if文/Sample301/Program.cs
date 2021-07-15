using System;

namespace Sample301
{
    class Program
    {
        static void Main(string[] args)
        {
            // キーワードから数値を入力
            Console.Write("整数値を入力");
            int a = int.Parse(Console.ReadLine()); //入力した数値を整数に変換
            Console.WriteLine("a = " + a);
            //入力した値が正の数かどうか調べる
            if(a > 0) 
            {
                Console.WriteLine("aは正の数です"); // 正の数だった場合に実行
            }
        }
    }
}
