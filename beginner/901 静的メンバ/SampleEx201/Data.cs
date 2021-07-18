using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx201
{
    class Data
    {
        // Dataのオブジェクト数 静的なフィールドstatic インスタンスをいくつ作成しても1つ
        private static int num = 0;
        // データの値
        private int id;
        // コンストラクタ(引数付)
        public Data(int id)
        {
            this.id = id;
            num++;
            Console.WriteLine("値：{0}　数:{1}", this.id, num);
        }
        //オブジェクトの数を取得 
        public static void ShowNumber()
        {
            Console.WriteLine("Dataオブジェクトの数:{0}", num);
        }
    }
}
