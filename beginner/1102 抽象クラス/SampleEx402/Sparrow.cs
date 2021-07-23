using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx402
{
    class Sparrow : Bird
    {
        // コンストラクタ
        public Sparrow() : base("すずめ")
        {
        }
        // すずめが鳴く
        public override void Sing()
        {
            Console.WriteLine("チュンチュン");
        }

    }
}
