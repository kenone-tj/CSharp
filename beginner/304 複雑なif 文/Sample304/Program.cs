using System;

namespace Sample304
{
    class Program
    {
        static void Main(string[] args)
        {
            // サイコロの目を入力
            Console.WriteLine("サイコロの目(1~6)");
            int dise = int.Parse(Console.ReadLine());
            if (1 <= dise && dise <= 6)
            {
                //if分の中にif分　= ネスト
                //サイコロの目が偶数か奇数かで処理を分ける
                if (dise % 2 == 0) // % = 余り
                {
                    Console.WriteLine("丁です");
                }
                else
                {
                    Console.WriteLine("半です");
                }
            }
            else
            {
                Console.WriteLine("範囲外の数値です");
            }
        }
    }
}
