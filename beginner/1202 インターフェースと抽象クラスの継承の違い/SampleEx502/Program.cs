using System;

namespace SampleEx502
{
    class Program
    {
        static void Main(string[] args)
        {
            Dummy d = new Dummy();
            IFunc1 f1 = (IFunc1)d;
            IFunc2 f2 = (IFunc2)d;
            // f1のメソッドを利用
            f1.Func1();
            f1.Func2();
            // f2のメソッドを利用
            f2.Func2();
            f2.Func3();
            // インターフェースでは抽象クラスと違い重複したメソッドを使用できる
        }
    }
}
