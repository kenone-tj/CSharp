using System;
using System.Collections.Generic;
using System.Text;

namespace Sample602
{
    class Calc
    {
        /*メソッドは同じ名前を定義できる
          ただし区別をつける(引数の数の違い)
        */

        // メソッド　2つの足し算
        public int Add(int a, int b) // メソッドの先頭は大文字
        {
            return a + b;
        }
        // メソッド　3つの足し算
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
