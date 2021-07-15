using System;

namespace Sample505
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4]; //カンマで二次元配列3行4列
            int m, n;
            // 二次元配列に値を代入
            for (m = 0;m < 3; m++)
            {
                for (n = 0; n < 4; n++)
                {
                    a[m, n] = m + n;
                　　Console.WriteLine("a[" + m + "," + n + "] = " + a[m,n]  );　//+の代わりに&は使えない
                }
            }
            Console.WriteLine();
            
        }
    }
}
