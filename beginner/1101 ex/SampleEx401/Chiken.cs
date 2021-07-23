using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx401
{
    class Chiken : Bird
    {
        // コンストラクタ
        public Chiken() : base("にわとり")
        {
        }
        // にわとりが鳴く
        public override void sing()
        {
            Console.WriteLine("コケコッコー");
        }
    }
}
