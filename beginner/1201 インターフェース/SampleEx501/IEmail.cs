using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEx501
{
    interface IEmail //インターフェースは先頭にIをつける (抽象メソッドと同じように使える)
    {
        // 指定した番号に電話をかける
        void Mail(string address);  // 大文字で始まらなければならない
    }
}
