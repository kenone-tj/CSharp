using System;

namespace Sample404
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do //while範囲外でも1度は実行される
            {
                Console.Write(i + "");
                i++;
            } while (i < 5);
            Console.WriteLine();
        }
    }
}
