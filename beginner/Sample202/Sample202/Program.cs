using System;

namespace Sample202
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;  //変数の宣言
            int b = 3;  //初期化と代入
            int add, sub;  //複数の宣言
            double avg;  //int以外の変数
            a = 6;  //代入
            add = a + b;  //a,bの和
            sub = a - b;  //a,bの差
            avg = (a + b) / 2.0;  //a,bの平均
            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0} と {1} の平均 {2}", a, b, avg);

        }
    }
}
