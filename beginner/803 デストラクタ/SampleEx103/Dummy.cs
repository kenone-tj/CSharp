using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx103
{
    class Dummy
    {
        // コンストラクタ
        public Dummy()
        {
            Console.WriteLine("コンストラクタ");
        }
        // デストラクタ 後処理を行う(GC発動後などに実行される) 先頭にチルダ~をつける
        ~Dummy()
        {
            Console.WriteLine("デストラクタ");
        }
    }
}
