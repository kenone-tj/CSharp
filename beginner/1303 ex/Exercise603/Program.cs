using System;
using System.Collections.Generic;

namespace Exercise603
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            Dictionary<String, int> d = new Dictionary<string, int>();

            for(int i = 0; i < months.Length; i++)
            {
                d[months[i]] = i + 1;
            }

            Console.Write("英語3文字で月の名前を入力してください");
            string name = Console.ReadLine();
            Console.WriteLine("{0}は{1}月です", name, d[name]);
        }
    }
}
