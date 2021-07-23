using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx401
{
    class Crow : Bird
    {
            // コンストラクタ
            public Crow() : base("カラス")
            {
            }
            // すずめが鳴く
            public override void sing()
            {
                Console.WriteLine("カーカー");
            }
        }
    }
