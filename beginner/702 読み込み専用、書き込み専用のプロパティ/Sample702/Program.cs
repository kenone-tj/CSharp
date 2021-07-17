using System;

namespace Sample702
{
    class Program
    {
        static void Main(string[] args)
        {
            Access a = new Access();
            //a.Data1 = 1;  Data1は読み取り専用のため書き込みできない
            a.Data2 = 2;
            a.ShowData();
            Console.WriteLine("a.Data1 = {0}", a.Data1);
            // Console.WriteLine("a.Data2 = {0}", a.Data2); Data2は書き込み専用のため読み込みできない
        }
    }
}
