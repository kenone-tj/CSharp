using System;
using System.Collections.Generic;

namespace SampleEx603
{
    class Program
    {
        static void Main(string[] args)
        {
            // 連想クラスの生成
            Dictionary<String, string> capital = new Dictionary<string, string>(); // キーと値
            // データの追加
            Console.WriteLine("Hello World!");
            capital["日本"] = "東京";
            capital["イギリス"] = "ロンドン";
            capital["フランス"] = "パリ";
            capital["中国"] = "北京";
            Console.WriteLine("世界の首都");
            foreach (string a in capital.Keys)
            {
                Console.WriteLine("{0}の首都は{1}です", a, capital[a]);
            }
        }
    }
}
