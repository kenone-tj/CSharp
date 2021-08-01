using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx501
{
    interface IPhone //インターフェースは先頭にIをつける (抽象メソッドと同じように使える)
    {
        // 指定した番号に電話をかける
        void Call(string number);  // 大文字で始まらなければならない
    }
}
