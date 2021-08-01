using System;
using System.Collections.Generic;

namespace SampleEx602
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>();
            // データを追加
            s.Add("Taro");
            s.Add("Hanako");
            s.Add("Jiro");
            s.Add("Kaoru");
            s.Remove("Taro"); // Taroを削除
            s.RemoveAt(1); // 1番目のデータを削除
            foreach (string a in s) //collectionでも同じように使える
            {
                Console.WriteLine(a);
            }
        }
    }
}
