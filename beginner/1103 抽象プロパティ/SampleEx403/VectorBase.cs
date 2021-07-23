using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx403
{
    // スーパークラス　（抽象プロパティを持つ）
    abstract class VectorBase
    {
        // 抽象プロパティ 実装が必要
        public abstract double X
        {
            get; set;
        }
        public abstract double Y
        {
            get; set;
        }
    }
}
