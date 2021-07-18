using System;

namespace Exercise203
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("実数値を入力");
            double n = double.Parse(Console.ReadLine());
            if (n > 0)
            {
                // 平方根
                double r = Math.Sqrt(n); //Mathクラス
                Console.WriteLine("平方根：{0}",r);
            }
            else
            {
                Console.WriteLine("正の数にしてください");
            }
        }
    }
}
