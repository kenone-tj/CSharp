﻿using System;

namespace SampleEx201
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dataクラスを3つ作る
            Data[] d = new Data[2];
            // Dataのインスタンスの数を表示
            Data.ShowNumber();
            // 1つ目のインスタンスを生成
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = new Data(i + 100);
                //Dataのインスタンスを生成
                Data.ShowNumber();
            }
        }
    }
}
