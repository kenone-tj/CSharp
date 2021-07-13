using System;

namespace Sample403
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // 6以上だと以下実行されない
            while (i <= 5)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
        }
    }
}
