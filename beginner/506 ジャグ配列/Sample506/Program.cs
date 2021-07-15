using System;

namespace Sample506
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * ジャグ配列の定義
             * 配列の中にサイズ違いの配列を宣言
            */
            int[][] a = new int[][] { new int[] { 0, 1 }, new int[] { 2 }, new int[] { 3, 4, 5, 6 } };
            // 成分の表示
            for (int m = 0; m < a.Length; m++)　//a[m]の長さ
            {
                for (int n = 0; n < a[m].Length; n++) //a[n]の長さ
                {
                    Console.Write(a[m][n] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
