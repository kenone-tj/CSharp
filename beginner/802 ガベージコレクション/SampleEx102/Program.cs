using System;

namespace SampleEx102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("メモリ使用量(初期値　　　)" + GC.GetTotalMemory(false));
            string[] s = new string[10000];
            for (int i = 0; i < 10000; i++)
            {
                s[i] = new string('M', 10000); //Charは'' Stringは"" Mを10000文字追加
            }
            Console.WriteLine("メモリ使用量(GC発動前　　)" + GC.GetTotalMemory(false));
            // sの参照を解放
            s = null;
            Console.WriteLine("メモリ使用量(参照解放後　)" + GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("メモリ使用量(GC発動後　　)" + GC.GetTotalMemory(false));
        }
    }
}
