using System;

namespace SampleEx703
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    int a = getNum(i);
                    int b = 5;
                    Console.Write(a + "/" + b + "=");
                    Console.WriteLine(calc(a, b));
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine();
                Console.WriteLine("0による割り算発生");
                // Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine();
                Console.WriteLine("配列の範囲外にアクセスしました");
                // Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("終了");
            }
        }
        // 計算処理 (例外を発生させる)
        private static int calc(int a, int b)
        {
            return a / b;
        }
        // 範囲外に出た時の処理
        public static int getNum(int index)
        {
            int[] num = { 1, 2, 3, 4 };
            return num[index];
        }
           
    }
}
