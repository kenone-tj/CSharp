using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx302
{
    // サブクラス Superクラスを継承
    class Sub : Super
    {
        // サブクラスのコンストラクタ Supurクラスのコンストラクタの後に呼び出される
        public Sub()
        {
            Console.WriteLine("Subクラスのコントラクタ(引数なし)");
        }
        // サブクラスのコンストラクタ Supurクラスのコンストラクタの後に呼び出される
        public Sub(int param)　: base(param) // 継承の場合はthisではなくbaseとなる
        {
            Console.WriteLine("Subクラスのコントラクタ(引数あり)　param:{0}",param);
            
        }
        //ディストラクタ
        ~Sub()
        {
            Console.WriteLine("Subクラスのデストラクタ");
        }
    }
}
