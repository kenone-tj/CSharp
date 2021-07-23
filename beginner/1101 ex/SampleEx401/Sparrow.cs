using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx401
{
    class Sparrow : Bird
    {
        // コンストラクタ
        public Sparrow() : base("すずめ")
        {
        }
        // すずめが鳴く
        public override void sing()
        {
            Console.WriteLine("チュンチュン");
        }
    }
}
