using System;

namespace Sample502
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = new double[3]; // 配列クラス
            for (int i = 0; i<=2; i++)
            {
                d[i] = 5.5;
            }
            double sum = 0.0, avg = 0.0;
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(d[i] + " ");
                sum += d[i] ;
            }
            Console.WriteLine();
            avg = sum / d.Length;
            Console.WriteLine("合計値" + sum);
            Console.WriteLine("平均値" + avg);
        }
    }
}
