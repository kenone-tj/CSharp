using System;

namespace Sample504
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 2, 3, 4 }; //配列サイズは指定不要
            foreach (int i in n) // nの要素がiに順番に入る
            {
                Console.WriteLine("{0} ", i); //iはnの要素
            }
            Console.WriteLine();
        }
    }
}
