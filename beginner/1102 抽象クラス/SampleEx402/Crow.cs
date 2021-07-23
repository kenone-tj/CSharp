using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx402
{
    class Crow : Bird
    {
        // コンストラクタ
        public Crow() : base("カラス")
        {
        }
        // カラスが鳴く
        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }
}
