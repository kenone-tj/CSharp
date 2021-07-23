using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx403
{
    // スーパークラス　（抽象プロパティを持つ）
     class Vector : VectorBase
    {
        private double x = 0.0;
        private double y = 0.0;
        // プロパティの実装
        public override double X
        {
            set { x = value;  }
            get { return x; }
        }
        public override double Y
        {
            set { y = value; }
            get { return y; }
        }

    }
}
