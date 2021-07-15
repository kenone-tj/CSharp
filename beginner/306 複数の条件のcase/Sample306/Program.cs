using System;

namespace Sample306
{
    class Program
    {
        static void Main(string[] args)
        {
            // サイコロの目を入力
            Console.WriteLine("サイコロの目(1~6)");
            int dise = int.Parse(Console.ReadLine());
            switch (dise)
            {
                case 1: //case 数値1つしか記述できない
                case 3:
                case 5:
                    Console.WriteLine("丁です");
                    break;
                case 2: //case 数値1つしか記述できない
                case 4:
                case 6:
                    Console.WriteLine("半です");
                    break;
                default:
                    Console .WriteLine ("不適切な数値です");
                    break;
            }
        }
    }
}
